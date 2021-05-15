using FamilyLoan2020.DAL.Repository;
using FamilyLoan2020.Models.Entity;
using FamilyLoan2020.UI.BaseForms;
using Sadr_Tools.ExtensionMethods;
using Sadr_Tools.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FamilyLoan2020.UI.UIForms
{
    public partial class PersonFrm : BaseFrm, IBaseFormMethod
    {

        UnitOfWork uow = null;
        bool IsNew = false;
        Person MainObject = null;
        byte[] ImageBinary;
        byte[] SelectedImageBinary;
        public PersonFrm()
        {
            InitializeComponent();
        }


        private void PersonFrm_Load(object sender, EventArgs e)
        {
            uow = new UnitOfWork();
            MainObject = new Person();
            PicBoxProfileImage.SizeMode = PictureBoxSizeMode.StretchImage;
            EnableControlStatus(false);
            LoadGrid();
        }

        #region [ Event Handlers ]
        private void BtnInsert_ButtonClick(object sender, EventArgs e)
        {
            IsNew = true;
            ClearControlContent();
            EnableControlStatus();
        }

        private void BtnUpdate_ButtonClick(object sender, EventArgs e)
        {
            IsNew = false;
            EnableControlStatus();
            NumTxtID.Enabled = false;

        }

        private void BtnDelete_ButtonClick(object sender, EventArgs e)
        {
            if (!MainObject.IsValid())
            {
                FarsiBox.ShowInformation("رکوردی انتخاب نشده است");
                return;
            }

            uow.PersonRepository.Delete(MainObject);
            uow.Save();
            LoadGrid();
        }

        private void BtnSave_ButtonClick(object sender, EventArgs e)
        {
            if (!CheckInputData())
                return;


            if (IsNew)
            {
                var obj = new Person()
                {
                    Name = ParsiTxtName.Text,
                    Family = ParsiTxtFamily.Text,
                    Gender = RbMale.Checked,
                    Birthdate = DSBirthdate.Value ?? DateTime.Now,
                    Mobile = MaskTxtMobile.Text,
                    AccountNo = parsiTextAccountNO.Text,
                    ProfileImage = ImageBinary
                };
                uow.PersonRepository.Insert(obj);
            }
            else
            {
                var obj2Update = uow.PersonRepository.GetByID(MainObject.ID);
                obj2Update.Birthdate = DSBirthdate.Value ?? DateTime.Now;
                obj2Update.Family = ParsiTxtFamily.Text;
                obj2Update.Name = ParsiTxtName.Text;
                obj2Update.Mobile = MaskTxtMobile.Text;
                obj2Update.Gender = RbMale.Checked;
                obj2Update.AccountNo = parsiTextAccountNO.Text;
                obj2Update.ProfileImage = ImageBinary ?? SelectedImageBinary;

                uow.PersonRepository.Update(obj2Update);
            }

            uow.Save();
            LoadGrid();
            EnableControlStatus(false);
        }

        private void BtnCancel_ButtonClick(object sender, EventArgs e)
        {
            EnableControlStatus(false);
            ClearControlContent();
            MainObject = null;
            IsNew = true;
        }

        #endregion

        private void LoadGrid()
        {
            List<Person> list = uow.PersonRepository.Get().ToList();
            GGridPerson.FillGrid<Person>(list);
            if (list.Count > 0)
                GGridPerson.Rows[0].Selected = true;
        }

        public bool CheckInputData()
        {
            if (ParsiTxtName.Text.Length < 3 ||
                ParsiTxtFamily.Text.Length < 3 ||
                MaskTxtMobile.Text.Length != 11
                )
            {
                FarsiBox.ShowInformation("اطلاعات را کامل وارد نمایید", "خطا", true);
                return false;
            }

            return true;
        }

        public void ClearControlContent()
        {
            foreach (Control item in GrpBoxInputs.Controls)
            {
                if (item is TextBoxBase)
                    item.Text = "";

                if (item is Atf.UI.DateTimeSelector)
                {
                    item.Text = "";
                }
                if (item is PictureBox)
                {
                    (item as PictureBox).Image = null;
                }
            }
        }

        public void EnableControlStatus(bool isEnabled = true)
        {
            foreach (Control item in this.GrpBoxInputs.Controls)
            {
                item.Enabled = isEnabled;
            }
        }

        private void GGridPerson_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MainObject = (GGridPerson.SelectedRow as Person);
            if (MainObject == null)
                return;

            NumTxtID.Text = MainObject.ID.ToString();
            DSBirthdate.Value = MainObject.Birthdate;
            ParsiTxtFamily.Text = MainObject.Family;
            ParsiTxtName.Text = MainObject.Name;
            MaskTxtMobile.Text = MainObject.Mobile;
            RbMale.Checked = MainObject.Gender;
            RbFemale.Checked = !MainObject.Gender;
            parsiTextAccountNO.Text = MainObject.AccountNo;
            ImageBinary = null; // تصویر قبلی حذف شود
            SelectedImageBinary = MainObject.ProfileImage;

            if (SelectedImageBinary == null)
            {
                PicBoxProfileImage.Image = MainObject.Gender ?
                    Properties.Resources.Avatar_Male :
                    Properties.Resources.Avatar_Female;
            }
            else
            {
                PicBoxProfileImage.Image = SelectedImageBinary?.ToImage();
            }
        }

        private void BtnPicSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (OpenImageDialog.ShowDialog() == DialogResult.OK)
                {
                    ImageBinary = OpenImageDialog.FileName.GetFile();
                    PicBoxProfileImage.Image = ImageBinary.ToImage();
                }
            }
            catch (Exception ex)
            {
                FarsiBox.ShowInformation("وقوع مشکل در سیستم" + "\n" + ex.Message, "خطای سیستمی", true);
            }
        }
    }
}

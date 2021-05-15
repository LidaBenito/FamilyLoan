using FamilyLoan2020.DAL.Repository;
using FamilyLoan2020.Models.Entity;
using FamilyLoan2020.UI.BaseForms;
using Sadr_Tools.CommonConsts;
using Sadr_Tools.ExtensionMethods;
using Sadr_Tools.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilyLoan2020.UI.UIForms
{
    public partial class UserFrm : BaseFrm
    {
        UnitOfWork uow = null;
        User MainObject = null;
        bool IsNew = false;
        public UserFrm()
        {
            InitializeComponent();
        }

        private void UserFrm_Load(object sender, EventArgs e)
        {
            uow = new UnitOfWork();
            MainObject = new User();
            LoadGrid();
            LoadCmbPerson();
            EnableControlStatus(false);
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
            TxtPassword.Enabled = TxtPassword2.Enabled = false;
            CmbPerson.Enabled = false;
        }



        private void BtnSave_ButtonClick(object sender, EventArgs e)
        {
            if (!CheckInputData())
                return;

            if (IsNew)
            {
                var userObj = new User()
                {
                    ID = CmbPerson.SelectedValue.ToInt(),
                    IsActive = ChbIsActive.Checked,
                    UserName = StrTxtUsername.Text.Trim()
                };

                var salt = StringMethods.GenerateSaltString();
                var hashedPass = TxtPassword.Text.MakeSaltedHashPassword(salt);

                var passObj = new PasswordHistory()
                {
                    UserID = userObj.ID,
                    Salt = salt,
                    HashPassword = hashedPass
                };

                uow.UserRepository.Insert(userObj);
                uow.PasswordHistoryRepository.Insert(passObj);
            }
            else
            {
                var obj2Update = uow.UserRepository.GetByID(MainObject.ID);
                obj2Update.IsActive = ChbIsActive.Checked;
                obj2Update.UserName = StrTxtUsername.Text.Trim();
                uow.UserRepository.Update(obj2Update);
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


        private void GGridLoanRequest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MainObject = (GGridUser.SelectedRow as User);
            if (MainObject == null)
                return;

            NumTxtID.Text = MainObject.ID.ToString();
            CmbPerson.SelectedValue = MainObject.ID;
            StrTxtUsername.Text = MainObject.UserName;
            ChbIsActive.Checked = MainObject.IsActive;
        }

        #endregion

        private void LoadGrid()
        {
            List<User> list = uow.UserRepository.Get().ToList();
            GGridUser.FillGrid<User>(list);
            if (list.Count > 0)
                GGridUser.Rows[0].Selected = true;
        }

        private void LoadCmbPerson()
        {
            List<Person> list = uow.PersonRepository.Get().ToList();
            list.Insert(0, new Person() { ID = 0, Name = "لطفا یک شخص انتخاب کنید" });
            CmbPerson.DataSource = list;
            CmbPerson.DisplayMember = "FullName";
            CmbPerson.ValueMember = "ID";
        }

        public bool CheckInputData()
        {
            if (StrTxtUsername.Text.IsNullOrEmpty() || CmbPerson.SelectedIndex < 1)
            {
                FarsiBox.ShowInformation(Messages.Information.PlzChoose);
                return false;
            }

            if (TxtPassword.Text != TxtPassword2.Text)
            {
                FarsiBox.ShowInformation(Messages.Information.PasswordsNotEqual);
                return false;
            }

            if (uow.UserRepository.IsUsernameExist(StrTxtUsername.Text))
            {
                FarsiBox.ShowInformation(Messages.Information.DuplicateUsername);
                return false;
            }

            if (uow.UserRepository.DoesPersonHaveUserName(NumTxtID.Text.ToInt()))
            {
                FarsiBox.ShowInformation(Messages.Information.PersonHasUsername);
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

                if (item is ComboBox)
                {
                    (item as ComboBox).SelectedIndex = 0;
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

        private void CmbPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            NumTxtID.Text = CmbPerson.SelectedIndex.Equals(0) ? "" : CmbPerson.SelectedValue.ToString();
        }
    }
}

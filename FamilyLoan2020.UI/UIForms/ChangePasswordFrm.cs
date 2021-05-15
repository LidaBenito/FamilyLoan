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
    public partial class ChangePasswordFrm : BaseFrm
    {
        public ChangePasswordFrm()
        {
            InitializeComponent();
        }
        UnitOfWork uow = null;
        private void ChangePasswordFrm_Load(object sender, EventArgs e)
        {
            uow = new UnitOfWork();
            LoadCmbPerson();
            EnableControlStatus(false);

        }

        private void LoadCmbPerson()
        {
            List<Person> list = uow.PersonRepository.GetPeopleWithUserInfo();
            list.Insert(0, new Person() { ID = 0, Name = "لطفا یک شخص انتخاب کنید" });
            CmbPerson.DataSource = list;
            CmbPerson.DisplayMember = "FullName";
            CmbPerson.ValueMember = "ID";
        }

        private void CmbPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            StrTxtUsername.Text = CmbPerson.SelectedIndex.Equals(0) ? "" : uow.UserRepository.GetByID(CmbPerson.SelectedValue.ToInt()).UserName;
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

        public bool CheckInputData()
        {
            if (StrTxtUsername.Text.IsNullOrEmpty() || CmbPerson.SelectedIndex < 1)
            {
                FarsiBox.ShowInformation(Messages.Information.PlzChoose);
                return false;
            }

            if (TxtNewPassword.Text != TxtNewPassword2.Text)
            {
                FarsiBox.ShowInformation(Messages.Information.PasswordsNotEqual);
                return false;
            }

            if (!uow.PasswordHistoryRepository.DoesCurrentPasswordCorrect(CmbPerson.SelectedValue.ToInt(), TxtCurrentPassword.Text))
            {
                FarsiBox.ShowInformation(Messages.Information.InvalidCurrentPassword);
                return false;
            }

            return true;
        }

        private void BtnInsert_ButtonClick_1(object sender, EventArgs e)
        {
            ClearControlContent();
            EnableControlStatus();
            StrTxtUsername.Enabled = false;
        }

        private void BtnSave_ButtonClick_1(object sender, EventArgs e)
        {
            if (!CheckInputData())
                return;

            var salt = StringMethods.GenerateSaltString();
            var hashedPass = TxtNewPassword.Text.MakeSaltedHashPassword(salt);

            var passObj = new PasswordHistory()
            {
                UserID = CmbPerson.SelectedValue.ToInt(),
                Salt = salt,
                HashPassword = hashedPass
            };

            uow.PasswordHistoryRepository.Insert(passObj);

            uow.Save();

            EnableControlStatus(false);
        }

        private void BtnCancel_ButtonClick_1(object sender, EventArgs e)
        {

            EnableControlStatus(false);
            ClearControlContent();
        }
    }
}

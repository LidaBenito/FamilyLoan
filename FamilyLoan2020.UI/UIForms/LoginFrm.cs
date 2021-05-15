using FamilyLoan2020.DAL.Repository;
using Sadr_Tools.CommonConsts;
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
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }
        UnitOfWork uow = null;

        private void Login_Click(object sender, EventArgs e)
        {
            var username = TxtUsername.Text.Trim();
            var password = TxtPassword.Text;

            Models.Entity.User user = null;

            try
            {
                user = uow.PasswordHistoryRepository.DoesLoginSuccessful(username, password);
                if (user == null)
                {
                    FarsiBox.ShowInformation(Messages.Information.WrongUsernamePassword, Messages.Information.UnSuccessfulLogin, true);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception {ex.Message}, Inner Exception {ex.InnerException?.Message}");
            }

            Sadr_Tools.CommonConsts.Application.LoginName = user.UserName;
            Sadr_Tools.CommonConsts.Application.PersonName = user.Person.FormalFullName;
            MainFrm frm = new MainFrm();
            frm.Show();
            this.Hide();
        }
        //var username = TxtUsername.Text.Trim();
        //    var password = TxtPassword.Text;

        //    var user = uow.PasswordHistoryRepository.DoesLoginSuccessful(username, password);
        //    if (user == null)
        //    {
        //        FarsiBox.ShowInformation(Messages.Information.WrongUsernamePassword, Messages.Information.UnSuccessfulLogin, true);
        //        return;
        //    }

        //    Sadr_Tools.CommonConsts.Application.LoginName = user.UserName;
        //    Sadr_Tools.CommonConsts.Application.PersonName = user.Person.FormalFullName;
        //    MainFrm frm = new MainFrm();
        //    frm.Show();
        //    this.Hide();
        //}

        private void LoginFrm_Load_1(object sender, EventArgs e)
        {
            WelcomeFrm frm = new WelcomeFrm();
            frm.Show();
            frm.Refresh();
            GeneralMethod.Sleep(5000);
            frm.Close();

            uow = new UnitOfWork();

        }
    }
}

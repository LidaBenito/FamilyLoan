using FamilyLoan2020.UI.BaseForms;
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
    public partial class UserAccountHomeFrm : BaseFrm
    {
        public UserAccountHomeFrm()
        {
            InitializeComponent();
        }

        private void ToolStripBtnChangePassword_Click(object sender, EventArgs e)
        {
            FormTools.DisplayForm(sender, new ChangePasswordFrm(), Color.CornflowerBlue, Properties.Resources.ChangePassvvord_64x);

        }

        private void ToolStripBtnUser_Click(object sender, EventArgs e)
        {
            FormTools.DisplayForm(sender, new UserFrm(), Color.CornflowerBlue, Properties.Resources.User_64x);

        }
    }
}

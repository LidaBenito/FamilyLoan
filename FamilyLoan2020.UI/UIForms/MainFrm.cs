using FamilyLoan2020.UI.BaseForms;
using System;
using System.Drawing;

namespace FamilyLoan2020.UI.UIForms
{
    public partial class MainFrm : BaseFrm
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void ToolStripBtnPeople_Click(object sender, EventArgs e)
        {
            var frm = new PersonFrm();
            FormTools.DisplayForm(sender, frm, Color.PowderBlue, Properties.Resources.Person_64x);
        }

        private void ToolStripBtnPayment_Click(object sender, EventArgs e)
        {
            var frm = new PaymentHomeFrm();
            FormTools.DisplayForm(sender, frm, Color.PowderBlue, Properties.Resources.Payment_64x);
        }

        private void ToolStripBtnLoan_Click(object sender, EventArgs e)
        {
            var frm = new LoanHomeFrm();
            FormTools.DisplayForm(sender, frm, Color.PowderBlue, Properties.Resources.Loan_64x);
        }

        private void ToolStripBtnSetting_Click_1(object sender, EventArgs e)
        {
            var frm = new SettingFrm();
            FormTools.DisplayForm(sender, frm, Color.PowderBlue, Properties.Resources.Settings_64x);
        }

        private void ToolStripBtnLottary_Click(object sender, EventArgs e)
        {
            var frm = new LottaryFrm();
            FormTools.DisplayForm(sender, frm, Color.PowderBlue, Properties.Resources.Search_64x);

        }

        private void ToolStripBtnBank_Click(object sender, EventArgs e)
        {
            var frm = new BankFrm();
            FormTools.DisplayForm(sender, frm, Color.PowderBlue, Properties.Resources.PaymentBill_64x);

        }

        private void ToolStripBtnUserAccount_Click(object sender, EventArgs e)
        {
            var frm = new UserAccountHomeFrm();
            FormTools.DisplayForm(sender, frm, Color.PowderBlue, Properties.Resources.Loan_64x);
        }

      

        private void toolStripReport_Click(object sender, EventArgs e)
        {
            var frm = new ReportHomeFrm();
            FormTools.DisplayForm(sender, frm, Color.PowderBlue, Properties.Resources.ToDoList_64x);

        }
    }
}

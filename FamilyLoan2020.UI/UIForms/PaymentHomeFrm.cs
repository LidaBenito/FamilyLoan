using FamilyLoan2020.UI.BaseForms;
using System;
using System.Drawing;

namespace FamilyLoan2020.UI.UIForms
{
    public partial class PaymentHomeFrm : BaseFrm
    {
        public PaymentHomeFrm()
        {
            InitializeComponent();
        }

        private void ToolStripBtnPaymentType_Click(object sender, EventArgs e)
        {
            FormTools.DisplayForm(sender, new PaymentTypeFrm(), Color.CornflowerBlue, Properties.Resources.Payment_64x);
        }

        private void ToolStripBtnPaymentSearch_Click(object sender, EventArgs e)
        {
            FormTools.DisplayForm(sender, new PaymentSearchFrm(), Color.CornflowerBlue, Properties.Resources.Search_64x);
        }

        private void ToolStripBtnPayment_Click(object sender, EventArgs e)
        {
            FormTools.DisplayForm(sender, new PaymentFrm(), Color.CornflowerBlue, Properties.Resources.PaymentBill_64x);
        }
    }
}

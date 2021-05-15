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
    public partial class LoanHomeFrm : BaseFrm, IBaseFormMethod
    {
        public LoanHomeFrm()
        {
            InitializeComponent();
        }

        public bool CheckInputData()
        {
            throw new NotImplementedException();
        }

        public  void ClearControlContent()
        {
            throw new NotImplementedException();
        }

        public  void EnableControlStatus(bool isEnabled = true)
        {
            throw new NotImplementedException();
        }

        private void ToolStripBtnLoanRequest_Click(object sender, EventArgs e)
        {
            var frm = new LoanRequestFrm();
            FormTools.DisplayForm(sender, frm, Color.PowderBlue, Properties.Resources.LoanRequest_64x);
        }

        private void ToolStripBtnLoanRequestList_Click(object sender, EventArgs e)
        {
            var frm = new LoanRequestListFrm();
            FormTools.DisplayForm(sender, frm, Color.PowderBlue, Properties.Resources.ToDoList_64x);
        }

        private void ToolStripBtnLoan_Click(object sender, EventArgs e)
        {
            var frm = new LoanFrm();
            FormTools.DisplayForm(sender, frm, Color.PowderBlue, Properties.Resources.Loan);
        }

        private void LoanHomeFrm_Load(object sender, EventArgs e)
        {

        }
    }
}

using FamilyLoan2020.DAL.Repository;
using FamilyLoan2020.Models.Entity;
using FamilyLoan2020.UI.BaseForms;
using Sadr_Tools.CommonConsts;
using Sadr_Tools.ExtensionMethods;
using Sadr_Tools.Utility;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FamilyLoan2020.UI.UIForms
{
    public partial class LoanFrm : BaseFrm
    {
        UnitOfWork uow = null;
        Loan MainObject = null;
        LoanRequest LoanRequestObject = null;

        public LoanFrm()
        {
            InitializeComponent();
        }

        private void GiveLoanFrm_Load(object sender, EventArgs e)
        {
            uow = new UnitOfWork();
            MainObject = new Loan();
            LoanRequestObject = new LoanRequest();
            EnableControlStatus(false);
            LoadGridLoanRequest();
            LoadGridLoan();
            DSLoanDate.Value = DateTime.Now.Date;

        }


        #region [ Event Handlers ]
        private void BtnInsert_ButtonClick(object sender, EventArgs e)
        {
            ClearControlContent();
            EnableControlStatus();
        }

        private void BtnSave_ButtonClick(object sender, EventArgs e)
        {
            if (!CheckInputData())
                return;

            var setting = uow.SettingRepository.GetLastOne();
            var loanDate = DSLoanDate.Value.Value;
            var obj = new Loan()
            {

                LoanRequestID = LoanRequestObject.ID,
                SettingCode = setting.Code,
                PersonLoanNo = uow.LoanRepository.GetPersonLoanNo(LoanRequestObject.PersonID),
                LoanNo = uow.LoanRepository.GetSettingLoanNo(setting.Code),
                Amount = NumTxtAmount.Text.ExtractNumber().ToInt(),
                LoanDate = loanDate,
                FirstInstallmentDate = loanDate.AddMonths(1),
                LastInstallmentDate = loanDate.AddMonths((setting.InstallmentQty)),
                PersonID = LoanRequestObject.PersonID
            };
            

            // -------- در قالب یک تراکنش ----------

            uow.LoanRepository.Insert(obj);
            uow.LoanItemRepository.InsertRange(obj);
            uow.PaymentRepository.InsertByLoan(obj);
            uow.Save();

            //---------------------------------------

            LoadGridLoanRequest();
            LoadGridLoan();
            EnableControlStatus(false);
        }

        private void BtnCancel_ButtonClick(object sender, EventArgs e)
        {
            EnableControlStatus(false);
            ClearControlContent();
            MainObject = null;
            LoanRequestObject = null;
        }

        private void GGridApprovedLoanRequest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoanRequestObject = (GGridApprovedLoanRequest.SelectedRow as LoanRequest);
            if (LoanRequestObject == null)
                return;
            NumTxtAmount.Text = LoanRequestObject.RequestAmount.ToString();

        }

        private void GGridLoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MainObject = (GGridLoan.SelectedRow as Loan);
            if (MainObject == null)
                return;
            NumTxtAmount.Text = MainObject.Amount.ToString();
            NumTxtCode.Text = MainObject.PersonLoanNo.ToString();
            NumTxtID.Text = MainObject.ID.ToString();
            DSLoanDate.Value = MainObject.LoanDate;
            LblFirstInstallmentDate.Text = MainObject.PersianFirstInstallmentDate;
            LblLastInstallmentDate.Text = MainObject.PersianLastInstallmentDate;
        }

        #endregion


        private void LoadGridLoanRequest()
        {
            List<LoanRequest> list = uow.LoanRequestRepository.Get(x => x.IsApproved.Value && x.Loans.Count == 0).ToList();
            GGridApprovedLoanRequest.FillGrid<LoanRequest>(list);
            if (list.Count > 0)
                GGridApprovedLoanRequest.Rows[0].Selected = true;
        }


        private void LoadGridLoan()
        {
            List<Loan> list = uow.LoanRepository.Get(/*x => x.LoanDate == DateTime.Today.Date*/).ToList();
            GGridLoan.FillGrid<Loan>(list);
            if (list.Count > 0)
                GGridLoan.Rows[0].Selected = true;
         

        }


        public bool CheckInputData()
        {
            if (NumTxtAmount.Text.IsNullOrEmpty())
            {
                FarsiBox.ShowInformation(Messages.Information.NoAmount);
                return false;
            }

            if (!DSLoanDate.Value.HasValue)
            {
                FarsiBox.ShowInformation(Messages.Information.PlzChoose);
                return false;
            }

            return true;

        }

        public void ClearControlContent()
        {

        }

        public void EnableControlStatus(bool isEnabled = true)
        {
            foreach (Control item in this.GrpBoxInputs.Controls)
            {
                if (item.Name.In("NumTxtCode", "NumTxtID"))
                    continue;

                item.Enabled = isEnabled;
            }
        }

        private void deleteButtonUC1_ButtonClick(object sender, EventArgs e)
        {
            if (!MainObject.IsValid())
            {
                FarsiBox.ShowInformation("رکوردی انتخاب نشده است");
                return;
            }
            uow.LoanRepository.Delete(MainObject);
            uow.Save();
            LoadGrid();
        }

        private void LoadGrid()
        {
            List<Loan> list = uow.LoanRepository.Get().ToList();
            GGridLoan.FillGrid<Loan>(list);
            if (list.Count > 0)
                GGridLoan.Rows[0].Selected = true;
        }
    }
}

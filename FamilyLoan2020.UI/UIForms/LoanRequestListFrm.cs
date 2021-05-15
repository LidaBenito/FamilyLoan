using FamilyLoan2020.DAL.Repository;
using FamilyLoan2020.Models.Entity;
using FamilyLoan2020.UI.BaseForms;
using Sadr_Tools.Utility;
using System;
using System.Collections.Generic;

namespace FamilyLoan2020.UI.UIForms
{
    public partial class LoanRequestListFrm : BaseFrm
    {
        UnitOfWork uow = null;
        LoanRequest MainObject = null;

        public LoanRequestListFrm()
        {
            InitializeComponent();
        }

        private void LoanRequestListFrm_Load(object sender, EventArgs e)
        {
            uow = new UnitOfWork();
            MainObject = new LoanRequest();
            LoadGrid();
        }

        private void LoadGrid()
        {
            List<LoanRequest> list = uow.LoanRequestRepository.GetUncertainList();
            GGridLoanRequestList.FillGrid<LoanRequest>(list);
            if (list.Count > 0)
                GGridLoanRequestList.Rows[0].Selected = true;
        }

        private void BtnApprove_ButtonClick(object sender, EventArgs e)
        {
            if (MainObject == null || !MainObject.IsValid())
            {
                FarsiBox.ShowInformation("هیچ رکوردی انتخاب نشده است");
                return;
            }
            uow.LoanRequestRepository.SetLoanRequestStatus(MainObject.ID);
            uow.Save();
            LoadGrid();
        }

        private void BtnDisapprove_ButtonClick(object sender, EventArgs e)
        {
            if (MainObject == null || !MainObject.IsValid())
            {
                FarsiBox.ShowInformation("هیچ رکوردی انتخاب نشده است");
                return;
            }
            uow.LoanRequestRepository.SetLoanRequestStatus(MainObject.ID, false);
            uow.Save();
            LoadGrid();
        }

        private void GGridLoanRequestList_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            MainObject = (GGridLoanRequestList.SelectedRow as LoanRequest);
        }

        private void BtnCancel_ButtonClick(object sender, EventArgs e)
        {
            MainObject = null;
        }

        private void BtnCancel_Load(object sender, EventArgs e)
        {

        }
    }
}

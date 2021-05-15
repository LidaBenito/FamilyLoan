using FamilyLoan2020.DAL.Repository;
using FamilyLoan2020.Models.Entity;
using FamilyLoan2020.UI.BaseForms;
using Sadr_Tools.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Sadr_Tools.ExtensionMethods;
using Sadr_Tools.CommonConsts;


namespace FamilyLoan2020.UI.UIForms
{
    public partial class LoanRequestFrm : BaseFrm, IBaseFormMethod
    {
        UnitOfWork uow = null;
        bool IsNew = false;
        LoanRequest MainObject = null;

        public LoanRequestFrm()
        {
            InitializeComponent();
        }

        private void LoanRequestFrm_Load(object sender, EventArgs e)
        {
            uow = new UnitOfWork();
            MainObject = new LoanRequest();
            EnableControlStatus(false);
            LoadGrid();
            LoadCmbPerson();
           
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

            uow.LoanRequestRepository.Delete(MainObject);
            uow.Save();
            LoadGrid();
        }

        private void BtnSave_ButtonClick(object sender, EventArgs e)
        {
            if (!CheckInputData())
                return;

            if (IsNew)
            {
                var obj = new LoanRequest()
                {
                    Note = ParsiTxtNote.Text,
                    PersonID = CmbPerson.SelectedValue.ToInt(),
                    RequestAmount = NumTxtRequestAmount.Text.ExtractNumber().ToInt(),
                    RequestDate = DSRequestDate.Value ?? DateTime.Now,
                    IsApproved = null
                };
                uow.LoanRequestRepository.Insert(obj);
            }
            else
            {
                var obj2Update = uow.LoanRequestRepository.GetByID(MainObject.ID);
                obj2Update.Note = ParsiTxtNote.Text;
                obj2Update.PersonID = CmbPerson.SelectedValue.ToInt();
                obj2Update.RequestAmount = NumTxtRequestAmount.Text.ExtractNumber().ToInt();
                obj2Update.RequestDate = DSRequestDate.Value ?? DateTime.Now;
                obj2Update.IsApproved = null;
                uow.LoanRequestRepository.Update(obj2Update);
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
            MainObject = (GGridLoanRequest.SelectedRow as LoanRequest);
            if (MainObject == null)
                return;

            NumTxtID.Text = MainObject.ID.ToString();
            DSRequestDate.Value = MainObject.RequestDate;
            NumTxtRequestAmount.Text = MainObject.RequestAmount.ToString();
            CmbPerson.SelectedValue = MainObject.PersonID;
            ParsiTxtNote.Text = MainObject.Note;
        }

        #endregion



        private void LoadGrid()
        {
            List<LoanRequest> list = uow.LoanRequestRepository.Get().ToList();
            GGridLoanRequest.FillGrid<LoanRequest>(list);
            if (list.Count > 0)
                GGridLoanRequest.Rows[0].Selected = true;
        }

        private void LoadCmbPerson()
        {
            List<Person> list = uow.PersonRepository.Get().ToList();
            CmbPerson.DataSource = list;
            CmbPerson.DisplayMember = "FullName";
            CmbPerson.ValueMember = "ID";

        }

        public bool CheckInputData()
        {
            if (NumTxtRequestAmount.Text.IsNullOrEmpty() || CmbPerson.SelectedIndex == -1)
            {
                FarsiBox.ShowInformation(Messages.Information.NoAmount);
                return false;
            }

            if (!uow.LoanRequestRepository.IsRequestAmountValid(NumTxtRequestAmount.Text.ExtractNumber().ToInt()))
            {
                FarsiBox.ShowInformation(Messages.Information.NotInRangeAmount);
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

    }
}

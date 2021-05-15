using FamilyLoan2020.UI.BaseForms;
using System;
using System.Collections.Generic;
using Sadr_Tools.ExtensionMethods;
using FamilyLoan2020.DAL.Repository;
using FamilyLoan2020.Models.Entity;
using System.Linq;
using System.Windows.Forms;
using Sadr_Tools.Utility;
using Sadr_Tools.CommonConsts;

namespace FamilyLoan2020.UI.UIForms
{
    public partial class PaymentFrm : BaseFrm
    {
        UnitOfWork uow = null;
        bool IsNew = false;
        Payment MainObject = null;
        LoanItem LoanItem = null;
        Loan Loan = null;

        public PaymentFrm()
        {
            InitializeComponent();
        }

        private void PaymentSearchFrm_Load(object sender, EventArgs e)
        {
            uow = new UnitOfWork();
            LoanItem = new LoanItem();
            Loan = new Loan();
            LoadCmbPerson();
            ECmbPaymentType.EnumObject = EnPaymentType.حق_عضویت;
            EnableControlStatus(false);
            LoadGrid();
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
            NumTxtPaymentID.Enabled = false;

        }

        private void BtnDelete_ButtonClick(object sender, EventArgs e)
        {
            if (!MainObject.IsValid())
            {
                FarsiBox.ShowInformation("رکوردی انتخاب نشده است");
                return;
            }

            uow.PaymentRepository.Delete(MainObject);
            uow.Save();
            LoadGrid();
        }

        private void BtnSave_ButtonClick(object sender, EventArgs e)
        {
            if (!CheckInputData())
                return;


            if (IsNew)
            {
                var obj = new Payment()
                {
                    PersonID = CmbPerson.SelectedValue.ToInt() > 0 ? (int?)CmbPerson.SelectedValue.ToInt() : null,
                    PaymentDateTime = DSPaymentDate.Value ?? DateTime.Now,
                    LoanItemID = CmbLoanItem.SelectedValue.ToInt() > 0 ? (int?)CmbLoanItem.SelectedValue.ToInt() : null,
                    PaymentTypeCode = ECmbPaymentType.SelectedIndex.ToByte(),
                    Amount = NumTxtAmount.Text.ExtractNumber().ToInt(),

                };

                if (CmbLoanItem.SelectedIndex < 0 && obj.PaymentTypeCode == (byte)EnPaymentType.قسط ||
                    obj.PaymentTypeCode == (byte)EnPaymentType.وام)
                {
                    obj.PaymentTypeCode = (byte)EnPaymentType.حق_عضویت;
                }
                else
                 if (obj.PaymentTypeCode == (byte)EnPaymentType.قسط)
                {

                    var Remaining = 0;
                    var outOfPlace = 0;
                    List<LoanItem> list = uow.LoanItemRepository.Get().ToList();
                    foreach (var item in list)
                    {
                        if (item.ID == obj.LoanItemID)
                        {
                            obj.LoanID = item.LoanID;
                            if (obj.Amount == item.InstallmentAmount)
                            {
                                item.InstallmentAmount -= obj.Amount;

                                break;
                            }
                            else
                            if (obj.Amount < item.InstallmentAmount)
                            {
                                item.InstallmentAmount -= obj.Amount;
                                LoanItem loanItem = uow.LoanItemRepository.Get(c => c.ID == item.ID + 1).SingleOrDefault();
                                loanItem.InstallmentAmount += item.InstallmentAmount;

                                break;

                            }
                            else
                             if (obj.Amount > item.InstallmentAmount)
                            {
                                Remaining = obj.Amount % item.InstallmentAmount;
                                outOfPlace = obj.Amount / item.InstallmentAmount;
                                var count = 0;
                                count += outOfPlace + item.ID;
                                for (int i = item.ID; i < count; i++)
                                {
                                    LoanItem currectLoanItem = uow.LoanItemRepository.Get(c => c.ID == i).SingleOrDefault();

                                    currectLoanItem.InstallmentAmount -= currectLoanItem.InstallmentAmount;

                                }
                                LoanItem LoanItemNew = uow.LoanItemRepository.Get(c => c.ID == count).SingleOrDefault();
                                if (LoanItemNew!=null)
                                {
                                LoanItemNew.InstallmentAmount -= Remaining;

                                }


                                break;
                            }
                        }

                    }



                    Payment paymentLoan = uow.PaymentRepository
                        .Get(c => c.LoanID == obj.LoanID &&c.PaymentTypeCode==(byte)EnPaymentType.وام)
                        .SingleOrDefault();
                    paymentLoan.Amount -= obj.Amount;

                }

                uow.PaymentRepository.Insert(obj);

            }
            else
            {
                var obj2Update = uow.PaymentRepository.GetByID(MainObject.ID);
                obj2Update.PersonID = CmbPerson.SelectedValue.ToInt() > 0 ? (int?)CmbPerson.SelectedValue.ToInt() : null;
                obj2Update.Amount = NumTxtAmount.Text.ExtractNumber().ToInt();
                obj2Update.PaymentDateTime = DSPaymentDate.Value ?? DateTime.Now;
                obj2Update.LoanItemID = CmbLoanItem.SelectedValue.ToInt() > 0 ? (int?)CmbLoanItem.SelectedValue.ToInt() : null;
                obj2Update.PaymentTypeCode = ECmbPaymentType.SelectedIndex.ToByte();
                uow.PaymentRepository.Update(obj2Update);
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


        private void GGridPayments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MainObject = (GGridPayments.SelectedRow as Payment);
            if (MainObject == null)
                return;

            NumTxtPaymentID.Text = MainObject.ID.ToString();
            DSPaymentDate.Value = MainObject.PaymentDateTime;
            NumTxtAmount.Text = MainObject.Amount.ToString();
            ECmbPaymentType.SelectedIndex = MainObject.PaymentTypeCode;

            CmbPerson.SelectedIndex = MainObject.PersonID.ToInt() /*> 0 ?Convert.ToInt32(MainObject.PersonID) : null*/;
        }

        private void CmbPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbPerson.SelectedIndex <= 0)
            {
                CmbLoanItem.DataSource = null;
                CmbLoanItem.Enabled = false;
                return;
            }
            CmbLoanItem.Enabled = true;
            CmbLoanItem.SelectedIndexChanged -= CmbLoanItem_SelectedIndexChanged;
            LoadCmbLoanItem(CmbPerson.SelectedValue.ToInt());
            CmbLoanItem.SelectedIndexChanged += CmbLoanItem_SelectedIndexChanged;
            CmbLoanItem_SelectedIndexChanged(null, null);

        }

        private void CmbLoanItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbLoanItem.SelectedIndex >= 0)
            {

                NumTxtAmount.Text = uow.LoanItemRepository.GetAmount(CmbLoanItem.SelectedValue.ToInt()).ToString();
            }
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            uow.Dispose();
            base.OnFormClosing(e);
        }

        #endregion

        #region [ Methods ]

        private void LoadCmbPerson()
        {
            List<Person> list = uow.PersonRepository.Get().ToList();
            list.Insert(0, new Person() { ID = 0, Name = "لطفا یک شخص انتخاب کنید" });
            CmbPerson.DataSource = list;
            CmbPerson.DisplayMember = "FullName";
            CmbPerson.ValueMember = "ID";
        }

        private void LoadCmbLoanItem(int personID)
        {
            List<LoanItem> list = uow.LoanItemRepository.GetUnpaidList(personID);
            CmbLoanItem.DataSource = list;
            CmbLoanItem.DisplayMember = "PersianInstallmentDate";
            CmbLoanItem.ValueMember = "ID";
        }

        private void LoadGrid()
        {
            List<Payment> list = uow.PaymentRepository.GetPayments(DateTime.Today).ToList();
            GGridPayments.FillGrid<Payment>(list);
            if (list.Count > 0)
                GGridPayments.Rows[0].Selected = true;



        }

        public bool CheckInputData()
        {
            if (NumTxtAmount.Text.IsNullOrEmpty() || CmbPerson.SelectedIndex == -1)
            {
                FarsiBox.ShowInformation(Messages.Information.NoAmount);
                return false;
            }

            return true;

        }

        public void ClearControlContent()
        {
            CmbLoanItem.SelectedIndexChanged -= CmbLoanItem_SelectedIndexChanged;
            CmbPerson.SelectedIndexChanged -= CmbPerson_SelectedIndexChanged;

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
                    (item as ComboBox).SelectedIndex = -1;
                }
            }

            CmbLoanItem.SelectedIndexChanged += CmbLoanItem_SelectedIndexChanged;
            CmbPerson.SelectedIndexChanged += CmbPerson_SelectedIndexChanged;
        }

        public void EnableControlStatus(bool isEnabled = true)
        {
            foreach (Control item in this.GrpBoxInputs.Controls)
            {
                item.Enabled = isEnabled;
            }

        }



        #endregion

        private void GrpBoxGrid_Enter(object sender, EventArgs e)
        {

        }
    }
}

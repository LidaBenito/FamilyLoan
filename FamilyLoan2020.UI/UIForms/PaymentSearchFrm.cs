using FamilyLoan2020.UI.BaseForms;
using System;
using System.Collections.Generic;
using Sadr_Tools.ExtensionMethods;
using FamilyLoan2020.DAL.Repository;
using FamilyLoan2020.Models.DTO;
using FamilyLoan2020.Models.Entity;
using System.Linq;
using System.Windows.Forms;

namespace FamilyLoan2020.UI.UIForms
{
    public partial class PaymentSearchFrm : BaseFrm
    {

        UnitOfWork uow = null;

        public PaymentSearchFrm()
        {
            InitializeComponent();
        }

        private void PaymentSearchFrm_Load(object sender, EventArgs e)
        {
            uow = new UnitOfWork();
            LoadCmbPerson();
            ECmbPaymentType.EnumObject = EnPaymentType.حق_عضویت;
        }

        private void BtnSearch_ButtonClick(object sender, EventArgs e)
        {
            var dto = new PaymentSearchDTO()
            {
                PaymentID = NumTxtPaymentID.Text.IsNullOrEmpty() ? null : (int?)NumTxtPaymentID.Text.ToInt(),
                SettingCode = NumTxtSettingCode.Text.IsNullOrEmpty() ? null : (byte?)NumTxtSettingCode.Text.ToByte(),
                PersonID = CmbPerson.SelectedValue.ToInt() == 0 ? null : (int?)CmbPerson.SelectedValue.ToInt(),
                PaymentTypeCode = ECmbPaymentType.SelectedIndex == 0 ? null : (byte?)ECmbPaymentType.SelectedIndex,
                FromAmount = NumTxtAmountFrom.Text.IsNullOrEmpty() ? null : (int?)NumTxtAmountFrom.Text.ExtractNumber().ToInt(),
                ToAmount = NumTxtAmountTo.Text.IsNullOrEmpty() ? null : (int?)NumTxtAmountTo.Text.ExtractNumber().ToInt(),
                FromDate = DSPaymentDateFrom.Value.HasValue ? (DateTime?)DSPaymentDateFrom.Value.Value : null,
                ToDate = DSPaymentDateTo.Value.HasValue ? (DateTime?)DSPaymentDateTo.Value.Value : null
            };

            List<Payment> payments = uow.PaymentRepository.GetPayments(dto);

            GGridPayments.FillGrid<Payment>(payments);
            var result = uow.PaymentRepository.GetSumByPaymentType(payments);
            LblSumFee.Text = result.SumFee.ToString().ThousandSeprator();
            LblSumLoan.Text = result.SumLoan.ToString().ThousandSeprator();
            LblSumInstallment.Text = result.SumInstallment.ToString().ThousandSeprator();
        }

        private void LoadCmbPerson()
        {
            List<Person> list = uow.PersonRepository.Get().ToList();
            list.Insert(0, new Person() { ID = 0, Name = "لطفا یک شخص انتخاب کنید" });
            CmbPerson.DataSource = list;
            CmbPerson.DisplayMember = "FullName";
            CmbPerson.ValueMember = "ID";
        }

        private void BtnCancel_ButtonClick(object sender, EventArgs e)
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

        private void NumTxtAmountFrom_TextChanged(object sender, EventArgs e)
        {
            NumTxtAmountTo.Text = NumTxtAmountFrom.Text;
        }

        private void DSPaymentDateFrom_ValueChanged(object sender, EventArgs e)
        {
            DSPaymentDateTo.Value = DSPaymentDateFrom.Value;
        }

      
    }
}

using FamilyLoan2020.DAL.Repository;
using FamilyLoan2020.Models.DTO;
using FamilyLoan2020.Models.Entity;
using FamilyLoan2020.UI.BaseForms;
using Sadr_Tools.CommonConsts;
using Sadr_Tools.ExtensionMethods;
using Sadr_Tools.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FamilyLoan2020.UI.UIForms
{
    public partial class BankFrm : BaseFrm, IBaseFormMethod
    {
        UnitOfWork uow = null;
        Bank MainObject = null;
        bool IsNew = false;


        public BankFrm()
        {
            InitializeComponent();
        }

        private void BankFrm_Load(object sender, EventArgs e)
        {
            uow = new UnitOfWork();
            MainObject = new Bank();
            ECmbPaymentType.EnumObject = EnPaymentType.بانک;
            EnableControlStatus(false);
            LoadGrid();

        }
        #region [ Event Handlers ]
        private void insertButtonUC1_ButtonClick(object sender, EventArgs e)
        {
            IsNew = true;
            ClearControlContent();
            EnableControlStatus();
        }

        private void updateButtonUC1_ButtonClick(object sender, EventArgs e)
        {
            IsNew = false;
            EnableControlStatus();

        }
        private void deleteButtonUC1_ButtonClick(object sender, EventArgs e)
        {
            if (!MainObject.IsValid())
            {
                FarsiBox.ShowInformation("رکوردی انتخاب نشده است");
                return;
            }
            uow.BankRepository.Delete(MainObject);
            uow.Save();
            LoadGrid();
        }
        private void saveButtonUC1_ButtonClick(object sender, EventArgs e)
        {
            if (!CheckInputData())
                return;
            if (IsNew)
            {
                var obj = new Bank()
                {
                    AccountNO = numericTextAccountNO.Text,
                    Description = StringTxtDescription.Text,
                    AmountDate = DSTransaction.Value ?? DateTime.Now,
                    Amount = NumericTxtAmount.Text.ThousandSeprator().ToInt(),
                    PaymentTypeCode = ECmbPaymentType.SelectedIndex.ToByte(),
                };

                uow.BankRepository.Insert(obj);

            }
            else
            {
                var obj2Update = uow.BankRepository.GetByID(MainObject.ID);
                obj2Update.AccountNO = numericTextAccountNO.Text;
                obj2Update.Amount = NumericTxtAmount.Text.ThousandSeprator().ToInt();
                obj2Update.Description = StringTxtDescription.Text;
                obj2Update.AmountDate = DSTransaction.Value ?? DateTime.Now;
                obj2Update.PaymentTypeCode = ECmbPaymentType.SelectedIndex.ToByte();
                uow.BankRepository.Update(obj2Update);
            }
            uow.Save();
            LoadGrid();
            EnableControlStatus(false);

        }

        private void cancelButtonUC1_ButtonClick(object sender, EventArgs e)
        {
            EnableControlStatus(false);
            ClearControlContent();
            MainObject = null;
            IsNew = true;
        }

        #endregion
        #region [ Methods ]
        private void LoadGrid()
        {
            int sumBank= 0;
            int sumWage = 0;
            List<Bank> list = uow.BankRepository.Get().ToList();
            GGridBank.FillGrid<Bank>(list);
            if (list.Count > 0)
                GGridBank.Rows[0].Selected = true;

            foreach (var item in list)
            {
                if (item.PaymentTypeCode ==(byte)EnPaymentType.بانک)
                {
                    sumBank += item.Amount;
                    LblSumBank.Text = sumBank.ToString().ThousandSeprator();
                }
                else if (item.PaymentTypeCode == (byte)EnPaymentType.کارمزد)
                {
                    sumWage+= item.Amount;
                    LblSumWage.Text = sumWage.ToString().ThousandSeprator();
                }
                LblTotalSum.Text = (sumWage + sumBank).ToString().ThousandSeprator();
            }

            

        }

        public void EnableControlStatus(bool isEnabled = true)
        {
            foreach (Control item in this.GrpBoxInputs.Controls)
            {
                item.Enabled = isEnabled;
            }
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
            }
        }

        public bool CheckInputData()
        {
            if (NumericTxtAmount.Text.IsNullOrEmpty())
            {
                FarsiBox.ShowInformation(Messages.Information.NoAmount);
                return false;
            }

            return true;
        }

        private void GGridBank_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MainObject = (GGridBank.SelectedRow as Bank);
            if (MainObject == null)
                return;
            NumTxtBankID.Text = MainObject.ID.ToString();
            DSTransaction.Value = MainObject.AmountDate;
            StringTxtDescription.Text = MainObject.Description;
            NumericTxtAmount.Text = MainObject.Amount.ToString();
            ECmbPaymentType.SelectedIndex = MainObject.PaymentTypeCode;
            numericTextAccountNO.Text = MainObject.AccountNO.ToString();

        }



        #endregion

    }
}

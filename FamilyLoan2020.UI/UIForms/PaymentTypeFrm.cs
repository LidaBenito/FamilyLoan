using FamilyLoan2020.UI.BaseForms;
using System;
using System.Windows.Forms;
using FamilyLoan2020.DAL.Repository;
using System.Linq;
using FamilyLoan2020.Models.Entity;
using System.Collections.Generic;
using Sadr_Tools.ExtensionMethods;
using Sadr_Tools.Utility;

namespace FamilyLoan2020.UI.UIForms
{
    public partial class PaymentTypeFrm : BaseFrm , IBaseFormMethod
    {
        UnitOfWork uow = null;
        bool IsNew = false;
        PaymentType MainObject = null;

        public PaymentTypeFrm()
        {
            InitializeComponent();
        }

        private void PaymentTypeFrm_Load(object sender, EventArgs e)
        {
            uow = new UnitOfWork();
            MainObject = new PaymentType();
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
            NumTxtCode.Enabled = false;

        }

        private void BtnDelete_ButtonClick(object sender, EventArgs e)
        {
            if (!MainObject.IsValid())
            {
                FarsiBox.ShowInformation("رکوردی انتخاب نشده است");
                return;
            }

            uow.PaymentTypeRepository.Delete(MainObject);
            uow.Save();
            LoadGrid();
        }

        private void BtnSave_ButtonClick(object sender, EventArgs e)
        {
            if (IsNew)
            {
                var obj = new PaymentType()
                {
                    Code = NumTxtCode.Text.ToByte(),
                    Title = ParsiTxtTitle.Text
                };
                uow.PaymentTypeRepository.Insert(obj);
            }
            else
            {
                var obj2Update = uow.PaymentTypeRepository.GetByCode(MainObject.Code);
                obj2Update.Title = ParsiTxtTitle.Text;
                uow.PaymentTypeRepository.Update(obj2Update);
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

        private void GenericGridPaymentType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MainObject = (GenericGridPaymentType.SelectedRow as PaymentType);
            if (MainObject == null)
                return;

            NumTxtCode.Text = MainObject.Code.ToString();
            ParsiTxtTitle.Text = MainObject.Title;
        }
        #endregion

        #region [ methods ]

        public void EnableControlStatus(bool isEnabled = true)
        {
            foreach (Control item in this.GrpBoxInputs.Controls)
            {
                if (item is DataGridView)
                    continue;
                item.Enabled = isEnabled;
            }
        }
        public void ClearControlContent()
        {
            foreach (Control item in GrpBoxInputs.Controls)
            {
                if (item is TextBox)
                    item.Text = "";
            }
        }
        private void LoadGrid()
        {
            List<PaymentType> list = uow.PaymentTypeRepository.Get().ToList();
            GenericGridPaymentType.FillGrid<PaymentType>(list);
            if (list.Count > 0)
                GenericGridPaymentType.Rows[0].Selected = true;
        }
        public bool CheckInputData()
        {
            throw new NotImplementedException();
        } 
        #endregion
    }
}

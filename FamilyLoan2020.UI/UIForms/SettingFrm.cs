using FamilyLoan2020.DAL.Repository;
using FamilyLoan2020.Models.Entity;
using FamilyLoan2020.UI.BaseForms;
using Sadr_Tools.ExtensionMethods;
using Sadr_Tools.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FamilyLoan2020.UI.UIForms
{
    public partial class SettingFrm : BaseFrm, IBaseFormMethod
    {

        UnitOfWork uow = null;
        bool IsNew = false;
        Setting MainObject = null;

        public SettingFrm()
        {
            InitializeComponent(); 
            this.MinimumSize = this.Size;
        }

        private void SettingFrm_Load(object sender, EventArgs e)
        {
            uow = new UnitOfWork();
            MainObject = new Setting();
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

            uow.SettingRepository.Delete(MainObject);
            uow.Save();
            LoadGrid();
        }

        private void BtnSave_ButtonClick(object sender, EventArgs e)
        {
            if (!CheckInputData())
                return;

            if (IsNew)
            {
                var obj = new Setting()
                {
                    Code = NumTxtCode.Text.ToByte(),
                    InstallmentQty = NumTxtInstallmentQty.Text.ExtractNumber().ToByte(),
                    MaxLoanAmount = NumTxtMaxLoanAmount.Text.ExtractNumber().ToInt(),
                    MembershipFee = NumTxtMembershipFee.Text.ExtractNumber().ToInt(),
                    MinLoanAmount = NumTxtMinLoanAmount.Text.ExtractNumber().ToInt()
                };
                uow.SettingRepository.Insert(obj);
            }
            else
            {
                var obj2Update = uow.SettingRepository.GetByCode(MainObject.Code);
                obj2Update.InstallmentQty = NumTxtInstallmentQty.Text.ExtractNumber().ToByte();
                obj2Update.MaxLoanAmount = NumTxtMaxLoanAmount.Text.ExtractNumber().ToInt();
                obj2Update.MembershipFee = NumTxtMembershipFee.Text.ExtractNumber().ToInt();
                obj2Update.MinLoanAmount = NumTxtMinLoanAmount.Text.ExtractNumber().ToInt();

                uow.SettingRepository.Update(obj2Update);
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


        #endregion


        private void LoadGrid()
        {
            List<Setting> list = uow.SettingRepository.Get().ToList();
            GGridSetting.FillGrid<Setting>(list);
            if (list.Count > 0)
                GGridSetting.Rows[0].Selected = true;
        }

        public bool CheckInputData()
        {
            foreach (Control item in GrpBoxInputs.Controls)
            {
                if (item is NumericTextBox.NumericTextBox && (item as NumericTextBox.NumericTextBox).ApplyThousandSeprator)
                {
                    if (!item.Text.ExtractNumber().ToInt().IsDivisibleByThousand())
                    {
                        FarsiBox.ShowInformation("مبالغ باید به 000 ختم شوند");
                        return false;
                    }
                }       
            }

            return true;
        }

        public void ClearControlContent()
        {
            foreach (Control item in GrpBoxInputs.Controls)
            {
                if (item is TextBoxBase)
                    item.Text = "";
            }
        }

        public void EnableControlStatus(bool isEnabled = true)
        {
            foreach (Control item in this.GrpBoxInputs.Controls)
            {
                item.Enabled = isEnabled;
            }
        }

        private void GGridSetting_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MainObject = (GGridSetting.SelectedRow as Setting);
            if (MainObject == null)
                return;

            NumTxtCode.Text = MainObject.Code.ToString();
            NumTxtInstallmentQty.Text = MainObject.InstallmentQty.ToString();
            NumTxtMaxLoanAmount.Text = MainObject.MaxLoanAmount.ToString();
            NumTxtMembershipFee.Text = MainObject.MembershipFee.ToString();
            NumTxtMinLoanAmount.Text = MainObject.MinLoanAmount.ToString();
        }
    }
}

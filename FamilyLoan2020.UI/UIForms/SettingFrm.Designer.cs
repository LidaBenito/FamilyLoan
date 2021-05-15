namespace FamilyLoan2020.UI.UIForms
{
    partial class SettingFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GrpBoxInputs = new System.Windows.Forms.GroupBox();
            this.NumTxtInstallmentQty = new NumericTextBox.NumericTextBox();
            this.NumTxtMaxLoanAmount = new NumericTextBox.NumericTextBox();
            this.NumTxtMembershipFee = new NumericTextBox.NumericTextBox();
            this.NumTxtMinLoanAmount = new NumericTextBox.NumericTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NumTxtCode = new NumericTextBox.NumericTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GrpBoxBtns = new System.Windows.Forms.GroupBox();
            this.BtnSave = new CRUD_Buttons.SaveButtonUC();
            this.BtnUpdate = new CRUD_Buttons.UpdateButtonUC();
            this.BtnDelete = new CRUD_Buttons.DeleteButtonUC();
            this.BtnCancel = new CRUD_Buttons.CancelButtonUC();
            this.BtnInsert = new CRUD_Buttons.InsertButtonUC();
            this.GrpBoxGrid = new System.Windows.Forms.GroupBox();
            this.GGridSetting = new GenericDataGrid.GenericDataGrid();
            this.GrpBoxInputs.SuspendLayout();
            this.GrpBoxBtns.SuspendLayout();
            this.GrpBoxGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GGridSetting)).BeginInit();
            this.SuspendLayout();
            // 
            // GrpBoxInputs
            // 
            this.GrpBoxInputs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpBoxInputs.Controls.Add(this.NumTxtInstallmentQty);
            this.GrpBoxInputs.Controls.Add(this.NumTxtMaxLoanAmount);
            this.GrpBoxInputs.Controls.Add(this.NumTxtMembershipFee);
            this.GrpBoxInputs.Controls.Add(this.NumTxtMinLoanAmount);
            this.GrpBoxInputs.Controls.Add(this.label6);
            this.GrpBoxInputs.Controls.Add(this.label5);
            this.GrpBoxInputs.Controls.Add(this.label4);
            this.GrpBoxInputs.Controls.Add(this.NumTxtCode);
            this.GrpBoxInputs.Controls.Add(this.label2);
            this.GrpBoxInputs.Controls.Add(this.label1);
            this.GrpBoxInputs.Location = new System.Drawing.Point(16, 112);
            this.GrpBoxInputs.Margin = new System.Windows.Forms.Padding(4);
            this.GrpBoxInputs.Name = "GrpBoxInputs";
            this.GrpBoxInputs.Padding = new System.Windows.Forms.Padding(4);
            this.GrpBoxInputs.Size = new System.Drawing.Size(951, 183);
            this.GrpBoxInputs.TabIndex = 0;
            this.GrpBoxInputs.TabStop = false;
            // 
            // NumTxtInstallmentQty
            // 
            this.NumTxtInstallmentQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumTxtInstallmentQty.ApplyThousandSeprator = false;
            this.NumTxtInstallmentQty.Location = new System.Drawing.Point(542, 134);
            this.NumTxtInstallmentQty.Margin = new System.Windows.Forms.Padding(4);
            this.NumTxtInstallmentQty.MaxLength = 2;
            this.NumTxtInstallmentQty.Name = "NumTxtInstallmentQty";
            this.NumTxtInstallmentQty.Size = new System.Drawing.Size(258, 26);
            this.NumTxtInstallmentQty.TabIndex = 5;
            // 
            // NumTxtMaxLoanAmount
            // 
            this.NumTxtMaxLoanAmount.ApplyThousandSeprator = true;
            this.NumTxtMaxLoanAmount.Location = new System.Drawing.Point(8, 73);
            this.NumTxtMaxLoanAmount.Margin = new System.Windows.Forms.Padding(4);
            this.NumTxtMaxLoanAmount.MaxLength = 10;
            this.NumTxtMaxLoanAmount.Name = "NumTxtMaxLoanAmount";
            this.NumTxtMaxLoanAmount.Size = new System.Drawing.Size(258, 26);
            this.NumTxtMaxLoanAmount.TabIndex = 3;
            // 
            // NumTxtMembershipFee
            // 
            this.NumTxtMembershipFee.ApplyThousandSeprator = true;
            this.NumTxtMembershipFee.Location = new System.Drawing.Point(8, 25);
            this.NumTxtMembershipFee.Margin = new System.Windows.Forms.Padding(4);
            this.NumTxtMembershipFee.MaxLength = 7;
            this.NumTxtMembershipFee.Name = "NumTxtMembershipFee";
            this.NumTxtMembershipFee.Size = new System.Drawing.Size(258, 26);
            this.NumTxtMembershipFee.TabIndex = 4;
            // 
            // NumTxtMinLoanAmount
            // 
            this.NumTxtMinLoanAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumTxtMinLoanAmount.ApplyThousandSeprator = true;
            this.NumTxtMinLoanAmount.Location = new System.Drawing.Point(542, 82);
            this.NumTxtMinLoanAmount.Margin = new System.Windows.Forms.Padding(4);
            this.NumTxtMinLoanAmount.MaxLength = 9;
            this.NumTxtMinLoanAmount.Name = "NumTxtMinLoanAmount";
            this.NumTxtMinLoanAmount.Size = new System.Drawing.Size(258, 26);
            this.NumTxtMinLoanAmount.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(406, 90);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "حداکثر مبلغ وام";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(831, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "حداقل مبلغ وام";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(851, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "تعداد اقساط";
            // 
            // NumTxtCode
            // 
            this.NumTxtCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumTxtCode.ApplyThousandSeprator = false;
            this.NumTxtCode.Location = new System.Drawing.Point(542, 25);
            this.NumTxtCode.Margin = new System.Windows.Forms.Padding(4);
            this.NumTxtCode.MaxLength = 2;
            this.NumTxtCode.Name = "NumTxtCode";
            this.NumTxtCode.Size = new System.Drawing.Size(258, 26);
            this.NumTxtCode.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(429, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "حق عضویت";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(919, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "کد";
            // 
            // GrpBoxBtns
            // 
            this.GrpBoxBtns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpBoxBtns.Controls.Add(this.BtnSave);
            this.GrpBoxBtns.Controls.Add(this.BtnUpdate);
            this.GrpBoxBtns.Controls.Add(this.BtnDelete);
            this.GrpBoxBtns.Controls.Add(this.BtnCancel);
            this.GrpBoxBtns.Controls.Add(this.BtnInsert);
            this.GrpBoxBtns.Location = new System.Drawing.Point(14, 496);
            this.GrpBoxBtns.Margin = new System.Windows.Forms.Padding(4);
            this.GrpBoxBtns.Name = "GrpBoxBtns";
            this.GrpBoxBtns.Padding = new System.Windows.Forms.Padding(4);
            this.GrpBoxBtns.Size = new System.Drawing.Size(953, 80);
            this.GrpBoxBtns.TabIndex = 0;
            this.GrpBoxBtns.TabStop = false;
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnSave.Location = new System.Drawing.Point(192, 13);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnSave.Size = new System.Drawing.Size(178, 53);
            this.BtnSave.TabIndex = 9;
            this.BtnSave.ButtonClick += new System.EventHandler(this.BtnSave_ButtonClick);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUpdate.Location = new System.Drawing.Point(567, 13);
            this.BtnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnUpdate.Size = new System.Drawing.Size(187, 53);
            this.BtnUpdate.TabIndex = 7;
            this.BtnUpdate.ButtonClick += new System.EventHandler(this.BtnUpdate_ButtonClick);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnDelete.Location = new System.Drawing.Point(378, 13);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnDelete.Size = new System.Drawing.Size(181, 53);
            this.BtnDelete.TabIndex = 8;
            this.BtnDelete.ButtonClick += new System.EventHandler(this.BtnDelete_ButtonClick);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCancel.Location = new System.Drawing.Point(5, 13);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnCancel.Size = new System.Drawing.Size(179, 53);
            this.BtnCancel.TabIndex = 10;
            this.BtnCancel.ButtonClick += new System.EventHandler(this.BtnCancel_ButtonClick);
            // 
            // BtnInsert
            // 
            this.BtnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnInsert.Location = new System.Drawing.Point(762, 10);
            this.BtnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnInsert.Size = new System.Drawing.Size(179, 59);
            this.BtnInsert.TabIndex = 6;
            this.BtnInsert.ButtonClick += new System.EventHandler(this.BtnInsert_ButtonClick);
            // 
            // GrpBoxGrid
            // 
            this.GrpBoxGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpBoxGrid.Controls.Add(this.GGridSetting);
            this.GrpBoxGrid.Location = new System.Drawing.Point(14, 303);
            this.GrpBoxGrid.Margin = new System.Windows.Forms.Padding(4);
            this.GrpBoxGrid.Name = "GrpBoxGrid";
            this.GrpBoxGrid.Padding = new System.Windows.Forms.Padding(4);
            this.GrpBoxGrid.Size = new System.Drawing.Size(953, 195);
            this.GrpBoxGrid.TabIndex = 0;
            this.GrpBoxGrid.TabStop = false;
            // 
            // GGridSetting
            // 
            this.GGridSetting.AllowUserToAddRows = false;
            this.GGridSetting.AllowUserToDeleteRows = false;
            this.GGridSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GGridSetting.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GGridSetting.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.GGridSetting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GGridSetting.Location = new System.Drawing.Point(9, 22);
            this.GGridSetting.Margin = new System.Windows.Forms.Padding(4);
            this.GGridSetting.Name = "GGridSetting";
            this.GGridSetting.ReadOnly = true;
            this.GGridSetting.Size = new System.Drawing.Size(930, 163);
            this.GGridSetting.TabIndex = 0;
            this.GGridSetting.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GGridSetting_CellClick);
            this.GGridSetting.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GGridSetting_CellClick);
            // 
            // SettingFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 637);
            this.Controls.Add(this.GrpBoxGrid);
            this.Controls.Add(this.GrpBoxBtns);
            this.Controls.Add(this.GrpBoxInputs);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SettingFrm";
            this.Text = "SettingFrm";
            this.Load += new System.EventHandler(this.SettingFrm_Load);
            this.Controls.SetChildIndex(this.GrpBoxInputs, 0);
            this.Controls.SetChildIndex(this.GrpBoxBtns, 0);
            this.Controls.SetChildIndex(this.GrpBoxGrid, 0);
            this.GrpBoxInputs.ResumeLayout(false);
            this.GrpBoxInputs.PerformLayout();
            this.GrpBoxBtns.ResumeLayout(false);
            this.GrpBoxGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GGridSetting)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpBoxInputs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private NumericTextBox.NumericTextBox NumTxtCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GrpBoxBtns;
        private CRUD_Buttons.SaveButtonUC BtnSave;
        private CRUD_Buttons.UpdateButtonUC BtnUpdate;
        private CRUD_Buttons.DeleteButtonUC BtnDelete;
        private CRUD_Buttons.CancelButtonUC BtnCancel;
        private CRUD_Buttons.InsertButtonUC BtnInsert;
        private System.Windows.Forms.GroupBox GrpBoxGrid;
        private GenericDataGrid.GenericDataGrid GGridSetting;
        private NumericTextBox.NumericTextBox NumTxtInstallmentQty;
        private NumericTextBox.NumericTextBox NumTxtMaxLoanAmount;
        private NumericTextBox.NumericTextBox NumTxtMembershipFee;
        private NumericTextBox.NumericTextBox NumTxtMinLoanAmount;
    }
}
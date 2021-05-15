namespace FamilyLoan2020.UI.UIForms
{
    partial class PaymentSearchFrm
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
            this.GrpBoxGrid = new System.Windows.Forms.GroupBox();
            this.GGridPayments = new GenericDataGrid.GenericDataGrid();
            this.GrpBoxInputs = new System.Windows.Forms.GroupBox();
            this.ECmbPaymentType = new EnumComboBox.EnumComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DSPaymentDateFrom = new Atf.UI.DateTimeSelector();
            this.label7 = new System.Windows.Forms.Label();
            this.DSPaymentDateTo = new Atf.UI.DateTimeSelector();
            this.NumTxtSettingCode = new NumericTextBox.NumericTextBox();
            this.NumTxtAmountTo = new NumericTextBox.NumericTextBox();
            this.NumTxtAmountFrom = new NumericTextBox.NumericTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbPerson = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NumTxtPaymentID = new NumericTextBox.NumericTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GrpBoxBtns = new System.Windows.Forms.GroupBox();
            this.BtnSearch = new CRUD_Buttons.SearchButtonUC();
            this.BtnCancel = new CRUD_Buttons.CancelButtonUC();
            this.LblSumFee = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.LblSumInstallment = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LblSumLoan = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.GrpBoxResult = new System.Windows.Forms.GroupBox();
            this.GrpBoxGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GGridPayments)).BeginInit();
            this.GrpBoxInputs.SuspendLayout();
            this.GrpBoxBtns.SuspendLayout();
            this.GrpBoxResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpBoxGrid
            // 
            this.GrpBoxGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpBoxGrid.Controls.Add(this.GGridPayments);
            this.GrpBoxGrid.Location = new System.Drawing.Point(15, 315);
            this.GrpBoxGrid.Margin = new System.Windows.Forms.Padding(4);
            this.GrpBoxGrid.Name = "GrpBoxGrid";
            this.GrpBoxGrid.Padding = new System.Windows.Forms.Padding(4);
            this.GrpBoxGrid.Size = new System.Drawing.Size(933, 123);
            this.GrpBoxGrid.TabIndex = 0;
            this.GrpBoxGrid.TabStop = false;
            // 
            // GGridPayments
            // 
            this.GGridPayments.AllowUserToAddRows = false;
            this.GGridPayments.AllowUserToDeleteRows = false;
            this.GGridPayments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GGridPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GGridPayments.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.GGridPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GGridPayments.Location = new System.Drawing.Point(8, 14);
            this.GGridPayments.Margin = new System.Windows.Forms.Padding(4);
            this.GGridPayments.Name = "GGridPayments";
            this.GGridPayments.ReadOnly = true;
            this.GGridPayments.Size = new System.Drawing.Size(917, 101);
            this.GGridPayments.TabIndex = 0;
            // 
            // GrpBoxInputs
            // 
            this.GrpBoxInputs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpBoxInputs.Controls.Add(this.ECmbPaymentType);
            this.GrpBoxInputs.Controls.Add(this.label8);
            this.GrpBoxInputs.Controls.Add(this.DSPaymentDateFrom);
            this.GrpBoxInputs.Controls.Add(this.label7);
            this.GrpBoxInputs.Controls.Add(this.DSPaymentDateTo);
            this.GrpBoxInputs.Controls.Add(this.NumTxtSettingCode);
            this.GrpBoxInputs.Controls.Add(this.NumTxtAmountTo);
            this.GrpBoxInputs.Controls.Add(this.NumTxtAmountFrom);
            this.GrpBoxInputs.Controls.Add(this.label5);
            this.GrpBoxInputs.Controls.Add(this.label6);
            this.GrpBoxInputs.Controls.Add(this.label2);
            this.GrpBoxInputs.Controls.Add(this.label4);
            this.GrpBoxInputs.Controls.Add(this.CmbPerson);
            this.GrpBoxInputs.Controls.Add(this.label3);
            this.GrpBoxInputs.Controls.Add(this.NumTxtPaymentID);
            this.GrpBoxInputs.Controls.Add(this.label1);
            this.GrpBoxInputs.Location = new System.Drawing.Point(13, 104);
            this.GrpBoxInputs.Margin = new System.Windows.Forms.Padding(4);
            this.GrpBoxInputs.Name = "GrpBoxInputs";
            this.GrpBoxInputs.Padding = new System.Windows.Forms.Padding(4);
            this.GrpBoxInputs.Size = new System.Drawing.Size(935, 149);
            this.GrpBoxInputs.TabIndex = 0;
            this.GrpBoxInputs.TabStop = false;
            // 
            // ECmbPaymentType
            // 
            this.ECmbPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ECmbPaymentType.EnumObject = null;
            this.ECmbPaymentType.FormattingEnabled = true;
            this.ECmbPaymentType.Location = new System.Drawing.Point(23, 50);
            this.ECmbPaymentType.Margin = new System.Windows.Forms.Padding(4);
            this.ECmbPaymentType.Name = "ECmbPaymentType";
            this.ECmbPaymentType.Size = new System.Drawing.Size(258, 26);
            this.ECmbPaymentType.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(853, 125);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "تاریخ از";
            // 
            // DSPaymentDateFrom
            // 
            this.DSPaymentDateFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DSPaymentDateFrom.CustomFormat = "YYYY/MM/DD";
            this.DSPaymentDateFrom.Location = new System.Drawing.Point(554, 119);
            this.DSPaymentDateFrom.Margin = new System.Windows.Forms.Padding(4);
            this.DSPaymentDateFrom.Name = "DSPaymentDateFrom";
            this.DSPaymentDateFrom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DSPaymentDateFrom.Size = new System.Drawing.Size(260, 27);
            this.DSPaymentDateFrom.TabIndex = 5;
            this.DSPaymentDateFrom.UsePersianFormat = true;
            this.DSPaymentDateFrom.ValueChanged += new System.EventHandler(this.DSPaymentDateFrom_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(358, 124);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 18);
            this.label7.TabIndex = 26;
            this.label7.Text = "تا";
            // 
            // DSPaymentDateTo
            // 
            this.DSPaymentDateTo.CustomFormat = "YYYY/MM/DD";
            this.DSPaymentDateTo.Location = new System.Drawing.Point(23, 116);
            this.DSPaymentDateTo.Margin = new System.Windows.Forms.Padding(4);
            this.DSPaymentDateTo.Name = "DSPaymentDateTo";
            this.DSPaymentDateTo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DSPaymentDateTo.Size = new System.Drawing.Size(260, 27);
            this.DSPaymentDateTo.TabIndex = 6;
            this.DSPaymentDateTo.UsePersianFormat = true;
            // 
            // NumTxtSettingCode
            // 
            this.NumTxtSettingCode.ApplyThousandSeprator = false;
            this.NumTxtSettingCode.Location = new System.Drawing.Point(23, 17);
            this.NumTxtSettingCode.Margin = new System.Windows.Forms.Padding(4);
            this.NumTxtSettingCode.MaxLength = 2;
            this.NumTxtSettingCode.Name = "NumTxtSettingCode";
            this.NumTxtSettingCode.Size = new System.Drawing.Size(258, 26);
            this.NumTxtSettingCode.TabIndex = 8;
            // 
            // NumTxtAmountTo
            // 
            this.NumTxtAmountTo.ApplyThousandSeprator = true;
            this.NumTxtAmountTo.Location = new System.Drawing.Point(23, 85);
            this.NumTxtAmountTo.Margin = new System.Windows.Forms.Padding(4);
            this.NumTxtAmountTo.Name = "NumTxtAmountTo";
            this.NumTxtAmountTo.Size = new System.Drawing.Size(258, 26);
            this.NumTxtAmountTo.TabIndex = 4;
            // 
            // NumTxtAmountFrom
            // 
            this.NumTxtAmountFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumTxtAmountFrom.ApplyThousandSeprator = true;
            this.NumTxtAmountFrom.Location = new System.Drawing.Point(554, 85);
            this.NumTxtAmountFrom.Margin = new System.Windows.Forms.Padding(4);
            this.NumTxtAmountFrom.Name = "NumTxtAmountFrom";
            this.NumTxtAmountFrom.Size = new System.Drawing.Size(258, 26);
            this.NumTxtAmountFrom.TabIndex = 3;
            this.NumTxtAmountFrom.TextChanged += new System.EventHandler(this.NumTxtAmountFrom_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "کد";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(856, 89);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "مبلغ از";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "تا";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "نوع پرداخت";
            // 
            // CmbPerson
            // 
            this.CmbPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbPerson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPerson.FormattingEnabled = true;
            this.CmbPerson.Location = new System.Drawing.Point(554, 50);
            this.CmbPerson.Margin = new System.Windows.Forms.Padding(4);
            this.CmbPerson.Name = "CmbPerson";
            this.CmbPerson.Size = new System.Drawing.Size(258, 26);
            this.CmbPerson.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(829, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "نام شخص";
            // 
            // NumTxtPaymentID
            // 
            this.NumTxtPaymentID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumTxtPaymentID.ApplyThousandSeprator = false;
            this.NumTxtPaymentID.Location = new System.Drawing.Point(554, 17);
            this.NumTxtPaymentID.Margin = new System.Windows.Forms.Padding(4);
            this.NumTxtPaymentID.MaxLength = 2;
            this.NumTxtPaymentID.Name = "NumTxtPaymentID";
            this.NumTxtPaymentID.Size = new System.Drawing.Size(258, 26);
            this.NumTxtPaymentID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(849, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "شناسه";
            // 
            // GrpBoxBtns
            // 
            this.GrpBoxBtns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpBoxBtns.Controls.Add(this.BtnSearch);
            this.GrpBoxBtns.Controls.Add(this.BtnCancel);
            this.GrpBoxBtns.Location = new System.Drawing.Point(14, 251);
            this.GrpBoxBtns.Margin = new System.Windows.Forms.Padding(4);
            this.GrpBoxBtns.Name = "GrpBoxBtns";
            this.GrpBoxBtns.Padding = new System.Windows.Forms.Padding(4);
            this.GrpBoxBtns.Size = new System.Drawing.Size(934, 69);
            this.GrpBoxBtns.TabIndex = 12;
            this.GrpBoxBtns.TabStop = false;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSearch.Location = new System.Drawing.Point(537, 10);
            this.BtnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnSearch.Size = new System.Drawing.Size(188, 54);
            this.BtnSearch.TabIndex = 9;
            this.BtnSearch.ButtonClick += new System.EventHandler(this.BtnSearch_ButtonClick);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(342, 10);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnCancel.Size = new System.Drawing.Size(188, 54);
            this.BtnCancel.TabIndex = 10;
            this.BtnCancel.ButtonClick += new System.EventHandler(this.BtnCancel_ButtonClick);
            // 
            // LblSumFee
            // 
            this.LblSumFee.BackColor = System.Drawing.Color.PaleTurquoise;
            this.LblSumFee.Location = new System.Drawing.Point(137, 22);
            this.LblSumFee.Name = "LblSumFee";
            this.LblSumFee.Size = new System.Drawing.Size(145, 23);
            this.LblSumFee.TabIndex = 0;
            this.LblSumFee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(297, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 18);
            this.label13.TabIndex = 0;
            this.label13.Text = "حق عضویت";
            // 
            // LblSumInstallment
            // 
            this.LblSumInstallment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblSumInstallment.BackColor = System.Drawing.Color.PaleTurquoise;
            this.LblSumInstallment.Location = new System.Drawing.Point(404, 22);
            this.LblSumInstallment.Name = "LblSumInstallment";
            this.LblSumInstallment.Size = new System.Drawing.Size(133, 23);
            this.LblSumInstallment.TabIndex = 0;
            this.LblSumInstallment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(552, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "اقساط";
            // 
            // LblSumLoan
            // 
            this.LblSumLoan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblSumLoan.BackColor = System.Drawing.Color.PaleTurquoise;
            this.LblSumLoan.Location = new System.Drawing.Point(621, 22);
            this.LblSumLoan.Name = "LblSumLoan";
            this.LblSumLoan.Size = new System.Drawing.Size(137, 23);
            this.LblSumLoan.TabIndex = 0;
            this.LblSumLoan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(773, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 18);
            this.label12.TabIndex = 0;
            this.label12.Text = "وام";
            // 
            // GrpBoxResult
            // 
            this.GrpBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpBoxResult.Controls.Add(this.LblSumFee);
            this.GrpBoxResult.Controls.Add(this.label13);
            this.GrpBoxResult.Controls.Add(this.LblSumInstallment);
            this.GrpBoxResult.Controls.Add(this.label9);
            this.GrpBoxResult.Controls.Add(this.LblSumLoan);
            this.GrpBoxResult.Controls.Add(this.label12);
            this.GrpBoxResult.Location = new System.Drawing.Point(15, 437);
            this.GrpBoxResult.Name = "GrpBoxResult";
            this.GrpBoxResult.Size = new System.Drawing.Size(933, 57);
            this.GrpBoxResult.TabIndex = 0;
            this.GrpBoxResult.TabStop = false;
            this.GrpBoxResult.Text = "جمع کل";
            // 
            // PaymentSearchFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 548);
            this.Controls.Add(this.GrpBoxResult);
            this.Controls.Add(this.GrpBoxBtns);
            this.Controls.Add(this.GrpBoxGrid);
            this.Controls.Add(this.GrpBoxInputs);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "PaymentSearchFrm";
            this.Text = "PaymentSearchFrm";
            this.Load += new System.EventHandler(this.PaymentSearchFrm_Load);
            this.Controls.SetChildIndex(this.GrpBoxInputs, 0);
            this.Controls.SetChildIndex(this.GrpBoxGrid, 0);
            this.Controls.SetChildIndex(this.GrpBoxBtns, 0);
            this.Controls.SetChildIndex(this.GrpBoxResult, 0);
            this.GrpBoxGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GGridPayments)).EndInit();
            this.GrpBoxInputs.ResumeLayout(false);
            this.GrpBoxInputs.PerformLayout();
            this.GrpBoxBtns.ResumeLayout(false);
            this.GrpBoxResult.ResumeLayout(false);
            this.GrpBoxResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpBoxGrid;
        private GenericDataGrid.GenericDataGrid GGridPayments;
        private System.Windows.Forms.GroupBox GrpBoxInputs;
        private NumericTextBox.NumericTextBox NumTxtPaymentID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private NumericTextBox.NumericTextBox NumTxtAmountTo;
        private System.Windows.Forms.Label label6;
        private NumericTextBox.NumericTextBox NumTxtAmountFrom;
        private System.Windows.Forms.ComboBox CmbPerson;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private NumericTextBox.NumericTextBox NumTxtSettingCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private Atf.UI.DateTimeSelector DSPaymentDateFrom;
        private System.Windows.Forms.Label label7;
        private Atf.UI.DateTimeSelector DSPaymentDateTo;
        private System.Windows.Forms.GroupBox GrpBoxBtns;
        private CRUD_Buttons.SearchButtonUC BtnSearch;
        private CRUD_Buttons.CancelButtonUC BtnCancel;
        private EnumComboBox.EnumComboBox ECmbPaymentType;
        private System.Windows.Forms.Label LblSumFee;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label LblSumInstallment;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LblSumLoan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox GrpBoxResult;
    }
}
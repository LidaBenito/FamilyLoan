namespace FamilyLoan2020.UI.UIForms
{
    partial class PaymentFrm
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
            this.CmbLoanItem = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ECmbPaymentType = new EnumComboBox.EnumComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DSPaymentDate = new Atf.UI.DateTimeSelector();
            this.NumTxtAmount = new NumericTextBox.NumericTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbPerson = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NumTxtPaymentID = new NumericTextBox.NumericTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GrpBoxBtns = new System.Windows.Forms.GroupBox();
            this.BtnSave = new CRUD_Buttons.SaveButtonUC();
            this.BtnUpdate = new CRUD_Buttons.UpdateButtonUC();
            this.BtnDelete = new CRUD_Buttons.DeleteButtonUC();
            this.BtnCancel = new CRUD_Buttons.CancelButtonUC();
            this.BtnInsert = new CRUD_Buttons.InsertButtonUC();
            this.GrpBoxGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GGridPayments)).BeginInit();
            this.GrpBoxInputs.SuspendLayout();
            this.GrpBoxBtns.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpBoxGrid
            // 
            this.GrpBoxGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpBoxGrid.Controls.Add(this.GGridPayments);
            this.GrpBoxGrid.Location = new System.Drawing.Point(27, 260);
            this.GrpBoxGrid.Margin = new System.Windows.Forms.Padding(4);
            this.GrpBoxGrid.Name = "GrpBoxGrid";
            this.GrpBoxGrid.Padding = new System.Windows.Forms.Padding(4);
            this.GrpBoxGrid.Size = new System.Drawing.Size(934, 234);
            this.GrpBoxGrid.TabIndex = 0;
            this.GrpBoxGrid.TabStop = false;
            this.GrpBoxGrid.Enter += new System.EventHandler(this.GrpBoxGrid_Enter);
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
            this.GGridPayments.Location = new System.Drawing.Point(8, 18);
            this.GGridPayments.Margin = new System.Windows.Forms.Padding(4);
            this.GGridPayments.Name = "GGridPayments";
            this.GGridPayments.ReadOnly = true;
            this.GGridPayments.Size = new System.Drawing.Size(912, 204);
            this.GGridPayments.TabIndex = 0;
            this.GGridPayments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GGridPayments_CellClick);
            this.GGridPayments.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GGridPayments_CellClick);
            // 
            // GrpBoxInputs
            // 
            this.GrpBoxInputs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpBoxInputs.Controls.Add(this.CmbLoanItem);
            this.GrpBoxInputs.Controls.Add(this.label2);
            this.GrpBoxInputs.Controls.Add(this.ECmbPaymentType);
            this.GrpBoxInputs.Controls.Add(this.label8);
            this.GrpBoxInputs.Controls.Add(this.DSPaymentDate);
            this.GrpBoxInputs.Controls.Add(this.NumTxtAmount);
            this.GrpBoxInputs.Controls.Add(this.label6);
            this.GrpBoxInputs.Controls.Add(this.label4);
            this.GrpBoxInputs.Controls.Add(this.CmbPerson);
            this.GrpBoxInputs.Controls.Add(this.label3);
            this.GrpBoxInputs.Controls.Add(this.NumTxtPaymentID);
            this.GrpBoxInputs.Controls.Add(this.label1);
            this.GrpBoxInputs.Location = new System.Drawing.Point(24, 108);
            this.GrpBoxInputs.Margin = new System.Windows.Forms.Padding(4);
            this.GrpBoxInputs.Name = "GrpBoxInputs";
            this.GrpBoxInputs.Padding = new System.Windows.Forms.Padding(4);
            this.GrpBoxInputs.Size = new System.Drawing.Size(937, 144);
            this.GrpBoxInputs.TabIndex = 0;
            this.GrpBoxInputs.TabStop = false;
            // 
            // CmbLoanItem
            // 
            this.CmbLoanItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbLoanItem.FormattingEnabled = true;
            this.CmbLoanItem.Location = new System.Drawing.Point(34, 99);
            this.CmbLoanItem.Margin = new System.Windows.Forms.Padding(4);
            this.CmbLoanItem.Name = "CmbLoanItem";
            this.CmbLoanItem.Size = new System.Drawing.Size(258, 26);
            this.CmbLoanItem.TabIndex = 6;
            this.CmbLoanItem.SelectedIndexChanged += new System.EventHandler(this.CmbLoanItem_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "اقلام وام جاری";
            // 
            // ECmbPaymentType
            // 
            this.ECmbPaymentType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ECmbPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ECmbPaymentType.EnumObject = null;
            this.ECmbPaymentType.FormattingEnabled = true;
            this.ECmbPaymentType.Location = new System.Drawing.Point(534, 69);
            this.ECmbPaymentType.Margin = new System.Windows.Forms.Padding(4);
            this.ECmbPaymentType.Name = "ECmbPaymentType";
            this.ECmbPaymentType.Size = new System.Drawing.Size(258, 26);
            this.ECmbPaymentType.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(363, 72);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "تاریخ ";
            // 
            // DSPaymentDate
            // 
            this.DSPaymentDate.CustomFormat = "YYYY/MM/DD";
            this.DSPaymentDate.Location = new System.Drawing.Point(34, 63);
            this.DSPaymentDate.Margin = new System.Windows.Forms.Padding(4);
            this.DSPaymentDate.Name = "DSPaymentDate";
            this.DSPaymentDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DSPaymentDate.Size = new System.Drawing.Size(260, 27);
            this.DSPaymentDate.TabIndex = 5;
            this.DSPaymentDate.UsePersianFormat = true;
            // 
            // NumTxtAmount
            // 
            this.NumTxtAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumTxtAmount.ApplyThousandSeprator = true;
            this.NumTxtAmount.Location = new System.Drawing.Point(533, 102);
            this.NumTxtAmount.Margin = new System.Windows.Forms.Padding(4);
            this.NumTxtAmount.Name = "NumTxtAmount";
            this.NumTxtAmount.Size = new System.Drawing.Size(258, 26);
            this.NumTxtAmount.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(887, 107);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "مبلغ";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(840, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "نوع پرداخت";
            // 
            // CmbPerson
            // 
            this.CmbPerson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPerson.FormattingEnabled = true;
            this.CmbPerson.Location = new System.Drawing.Point(34, 28);
            this.CmbPerson.Margin = new System.Windows.Forms.Padding(4);
            this.CmbPerson.Name = "CmbPerson";
            this.CmbPerson.Size = new System.Drawing.Size(258, 26);
            this.CmbPerson.TabIndex = 4;
            this.CmbPerson.SelectedIndexChanged += new System.EventHandler(this.CmbPerson_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 33);
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
            this.NumTxtPaymentID.Location = new System.Drawing.Point(535, 33);
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
            this.label1.Location = new System.Drawing.Point(865, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "شناسه";
            // 
            // GrpBoxBtns
            // 
            this.GrpBoxBtns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpBoxBtns.Controls.Add(this.BtnSave);
            this.GrpBoxBtns.Controls.Add(this.BtnUpdate);
            this.GrpBoxBtns.Controls.Add(this.BtnDelete);
            this.GrpBoxBtns.Controls.Add(this.BtnCancel);
            this.GrpBoxBtns.Controls.Add(this.BtnInsert);
            this.GrpBoxBtns.Location = new System.Drawing.Point(27, 501);
            this.GrpBoxBtns.Margin = new System.Windows.Forms.Padding(4);
            this.GrpBoxBtns.Name = "GrpBoxBtns";
            this.GrpBoxBtns.Padding = new System.Windows.Forms.Padding(4);
            this.GrpBoxBtns.Size = new System.Drawing.Size(934, 77);
            this.GrpBoxBtns.TabIndex = 0;
            this.GrpBoxBtns.TabStop = false;
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnSave.Location = new System.Drawing.Point(190, 12);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnSave.Size = new System.Drawing.Size(188, 60);
            this.BtnSave.TabIndex = 10;
            this.BtnSave.ButtonClick += new System.EventHandler(this.BtnSave_ButtonClick);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUpdate.Location = new System.Drawing.Point(553, 12);
            this.BtnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnUpdate.Size = new System.Drawing.Size(188, 60);
            this.BtnUpdate.TabIndex = 8;
            this.BtnUpdate.ButtonClick += new System.EventHandler(this.BtnUpdate_ButtonClick);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnDelete.Location = new System.Drawing.Point(377, 12);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnDelete.Size = new System.Drawing.Size(188, 60);
            this.BtnDelete.TabIndex = 9;
            this.BtnDelete.ButtonClick += new System.EventHandler(this.BtnDelete_ButtonClick);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCancel.Location = new System.Drawing.Point(12, 12);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnCancel.Size = new System.Drawing.Size(188, 60);
            this.BtnCancel.TabIndex = 11;
            this.BtnCancel.ButtonClick += new System.EventHandler(this.BtnCancel_ButtonClick);
            // 
            // BtnInsert
            // 
            this.BtnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnInsert.Location = new System.Drawing.Point(735, 12);
            this.BtnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnInsert.Size = new System.Drawing.Size(198, 57);
            this.BtnInsert.TabIndex = 7;
            this.BtnInsert.ButtonClick += new System.EventHandler(this.BtnInsert_ButtonClick);
            // 
            // PaymentFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 632);
            this.Controls.Add(this.GrpBoxBtns);
            this.Controls.Add(this.GrpBoxGrid);
            this.Controls.Add(this.GrpBoxInputs);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "PaymentFrm";
            this.Text = "PaymentSearchFrm";
            this.Load += new System.EventHandler(this.PaymentSearchFrm_Load);
            this.Controls.SetChildIndex(this.GrpBoxInputs, 0);
            this.Controls.SetChildIndex(this.GrpBoxGrid, 0);
            this.Controls.SetChildIndex(this.GrpBoxBtns, 0);
            this.GrpBoxGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GGridPayments)).EndInit();
            this.GrpBoxInputs.ResumeLayout(false);
            this.GrpBoxInputs.PerformLayout();
            this.GrpBoxBtns.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpBoxGrid;
        private GenericDataGrid.GenericDataGrid GGridPayments;
        private System.Windows.Forms.GroupBox GrpBoxInputs;
        private NumericTextBox.NumericTextBox NumTxtPaymentID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private NumericTextBox.NumericTextBox NumTxtAmount;
        private System.Windows.Forms.ComboBox CmbPerson;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private Atf.UI.DateTimeSelector DSPaymentDate;
        private EnumComboBox.EnumComboBox ECmbPaymentType;
        private System.Windows.Forms.ComboBox CmbLoanItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GrpBoxBtns;
        private CRUD_Buttons.SaveButtonUC BtnSave;
        private CRUD_Buttons.UpdateButtonUC BtnUpdate;
        private CRUD_Buttons.DeleteButtonUC BtnDelete;
        private CRUD_Buttons.CancelButtonUC BtnCancel;
        private CRUD_Buttons.InsertButtonUC BtnInsert;
    }
}
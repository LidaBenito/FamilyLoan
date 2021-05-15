namespace FamilyLoan2020.UI.UIForms
{
    partial class LoanFrm
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
            this.GGridApprovedLoanRequest = new GenericDataGrid.GenericDataGrid();
            this.GrpBoxBtns = new System.Windows.Forms.GroupBox();
            this.deleteButtonUC1 = new CRUD_Buttons.DeleteButtonUC();
            this.BtnSave = new CRUD_Buttons.SaveButtonUC();
            this.BtnCancel = new CRUD_Buttons.CancelButtonUC();
            this.BtnInsert = new CRUD_Buttons.InsertButtonUC();
            this.GrpBoxInputs = new System.Windows.Forms.GroupBox();
            this.LblLastInstallmentDate = new System.Windows.Forms.Label();
            this.LblFirstInstallmentDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DSLoanDate = new Atf.UI.DateTimeSelector();
            this.NumTxtCode = new NumericTextBox.NumericTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NumTxtAmount = new NumericTextBox.NumericTextBox();
            this.NumTxtID = new NumericTextBox.NumericTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GrpBoxGrid2 = new System.Windows.Forms.GroupBox();
            this.GGridLoan = new GenericDataGrid.GenericDataGrid();
            this.GrpBoxGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GGridApprovedLoanRequest)).BeginInit();
            this.GrpBoxBtns.SuspendLayout();
            this.GrpBoxInputs.SuspendLayout();
            this.GrpBoxGrid2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GGridLoan)).BeginInit();
            this.SuspendLayout();
            // 
            // GrpBoxGrid
            // 
            this.GrpBoxGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpBoxGrid.Controls.Add(this.GGridApprovedLoanRequest);
            this.GrpBoxGrid.Location = new System.Drawing.Point(11, 224);
            this.GrpBoxGrid.Margin = new System.Windows.Forms.Padding(4);
            this.GrpBoxGrid.Name = "GrpBoxGrid";
            this.GrpBoxGrid.Padding = new System.Windows.Forms.Padding(4);
            this.GrpBoxGrid.Size = new System.Drawing.Size(947, 130);
            this.GrpBoxGrid.TabIndex = 0;
            this.GrpBoxGrid.TabStop = false;
            // 
            // GGridApprovedLoanRequest
            // 
            this.GGridApprovedLoanRequest.AllowUserToAddRows = false;
            this.GGridApprovedLoanRequest.AllowUserToDeleteRows = false;
            this.GGridApprovedLoanRequest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GGridApprovedLoanRequest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GGridApprovedLoanRequest.BackgroundColor = System.Drawing.Color.Firebrick;
            this.GGridApprovedLoanRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GGridApprovedLoanRequest.Location = new System.Drawing.Point(8, 25);
            this.GGridApprovedLoanRequest.Margin = new System.Windows.Forms.Padding(4);
            this.GGridApprovedLoanRequest.Name = "GGridApprovedLoanRequest";
            this.GGridApprovedLoanRequest.ReadOnly = true;
            this.GGridApprovedLoanRequest.Size = new System.Drawing.Size(931, 95);
            this.GGridApprovedLoanRequest.TabIndex = 0;
            this.GGridApprovedLoanRequest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GGridApprovedLoanRequest_CellClick);
            this.GGridApprovedLoanRequest.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GGridApprovedLoanRequest_CellClick);
            // 
            // GrpBoxBtns
            // 
            this.GrpBoxBtns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpBoxBtns.Controls.Add(this.deleteButtonUC1);
            this.GrpBoxBtns.Controls.Add(this.BtnSave);
            this.GrpBoxBtns.Controls.Add(this.BtnCancel);
            this.GrpBoxBtns.Controls.Add(this.BtnInsert);
            this.GrpBoxBtns.Location = new System.Drawing.Point(11, 483);
            this.GrpBoxBtns.Margin = new System.Windows.Forms.Padding(4);
            this.GrpBoxBtns.Name = "GrpBoxBtns";
            this.GrpBoxBtns.Padding = new System.Windows.Forms.Padding(4);
            this.GrpBoxBtns.Size = new System.Drawing.Size(947, 76);
            this.GrpBoxBtns.TabIndex = 0;
            this.GrpBoxBtns.TabStop = false;
            // 
            // deleteButtonUC1
            // 
            this.deleteButtonUC1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteButtonUC1.Location = new System.Drawing.Point(42, 14);
            this.deleteButtonUC1.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButtonUC1.Name = "deleteButtonUC1";
            this.deleteButtonUC1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.deleteButtonUC1.Size = new System.Drawing.Size(183, 54);
            this.deleteButtonUC1.TabIndex = 8;
            this.deleteButtonUC1.ButtonClick += new System.EventHandler(this.deleteButtonUC1_ButtonClick);
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.Location = new System.Drawing.Point(517, 14);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnSave.Size = new System.Drawing.Size(188, 54);
            this.BtnSave.TabIndex = 6;
            this.BtnSave.ButtonClick += new System.EventHandler(this.BtnSave_ButtonClick);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCancel.Location = new System.Drawing.Point(277, 14);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnCancel.Size = new System.Drawing.Size(188, 54);
            this.BtnCancel.TabIndex = 7;
            this.BtnCancel.ButtonClick += new System.EventHandler(this.BtnCancel_ButtonClick);
            // 
            // BtnInsert
            // 
            this.BtnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnInsert.Location = new System.Drawing.Point(757, 11);
            this.BtnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnInsert.Size = new System.Drawing.Size(178, 61);
            this.BtnInsert.TabIndex = 5;
            this.BtnInsert.ButtonClick += new System.EventHandler(this.BtnInsert_ButtonClick);
            // 
            // GrpBoxInputs
            // 
            this.GrpBoxInputs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpBoxInputs.Controls.Add(this.LblLastInstallmentDate);
            this.GrpBoxInputs.Controls.Add(this.LblFirstInstallmentDate);
            this.GrpBoxInputs.Controls.Add(this.label5);
            this.GrpBoxInputs.Controls.Add(this.DSLoanDate);
            this.GrpBoxInputs.Controls.Add(this.NumTxtCode);
            this.GrpBoxInputs.Controls.Add(this.label6);
            this.GrpBoxInputs.Controls.Add(this.NumTxtAmount);
            this.GrpBoxInputs.Controls.Add(this.NumTxtID);
            this.GrpBoxInputs.Controls.Add(this.label2);
            this.GrpBoxInputs.Controls.Add(this.label1);
            this.GrpBoxInputs.Location = new System.Drawing.Point(11, 112);
            this.GrpBoxInputs.Margin = new System.Windows.Forms.Padding(4);
            this.GrpBoxInputs.Name = "GrpBoxInputs";
            this.GrpBoxInputs.Padding = new System.Windows.Forms.Padding(4);
            this.GrpBoxInputs.Size = new System.Drawing.Size(947, 104);
            this.GrpBoxInputs.TabIndex = 0;
            this.GrpBoxInputs.TabStop = false;
            // 
            // LblLastInstallmentDate
            // 
            this.LblLastInstallmentDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblLastInstallmentDate.Location = new System.Drawing.Point(8, 54);
            this.LblLastInstallmentDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblLastInstallmentDate.Name = "LblLastInstallmentDate";
            this.LblLastInstallmentDate.Size = new System.Drawing.Size(231, 26);
            this.LblLastInstallmentDate.TabIndex = 0;
            // 
            // LblFirstInstallmentDate
            // 
            this.LblFirstInstallmentDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblFirstInstallmentDate.Location = new System.Drawing.Point(8, 16);
            this.LblFirstInstallmentDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFirstInstallmentDate.Name = "LblFirstInstallmentDate";
            this.LblFirstInstallmentDate.Size = new System.Drawing.Size(231, 26);
            this.LblFirstInstallmentDate.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(547, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "تاریخ وام";
            // 
            // DSLoanDate
            // 
            this.DSLoanDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DSLoanDate.CustomFormat = "YYYY/MM/DD";
            this.DSLoanDate.Location = new System.Drawing.Point(303, 55);
            this.DSLoanDate.Margin = new System.Windows.Forms.Padding(4);
            this.DSLoanDate.Name = "DSLoanDate";
            this.DSLoanDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DSLoanDate.Size = new System.Drawing.Size(202, 27);
            this.DSLoanDate.TabIndex = 4;
            this.DSLoanDate.UsePersianFormat = true;
            // 
            // NumTxtCode
            // 
            this.NumTxtCode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NumTxtCode.ApplyThousandSeprator = false;
            this.NumTxtCode.Enabled = false;
            this.NumTxtCode.Location = new System.Drawing.Point(304, 18);
            this.NumTxtCode.Margin = new System.Windows.Forms.Padding(4);
            this.NumTxtCode.Name = "NumTxtCode";
            this.NumTxtCode.Size = new System.Drawing.Size(201, 26);
            this.NumTxtCode.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(900, 60);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "مبلغ";
            // 
            // NumTxtAmount
            // 
            this.NumTxtAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumTxtAmount.ApplyThousandSeprator = true;
            this.NumTxtAmount.Location = new System.Drawing.Point(655, 60);
            this.NumTxtAmount.Margin = new System.Windows.Forms.Padding(4);
            this.NumTxtAmount.Name = "NumTxtAmount";
            this.NumTxtAmount.Size = new System.Drawing.Size(203, 26);
            this.NumTxtAmount.TabIndex = 2;
            // 
            // NumTxtID
            // 
            this.NumTxtID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumTxtID.ApplyThousandSeprator = false;
            this.NumTxtID.Enabled = false;
            this.NumTxtID.Location = new System.Drawing.Point(657, 18);
            this.NumTxtID.Margin = new System.Windows.Forms.Padding(4);
            this.NumTxtID.Name = "NumTxtID";
            this.NumTxtID.Size = new System.Drawing.Size(201, 26);
            this.NumTxtID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(590, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "کد";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(878, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "شناسه";
            // 
            // GrpBoxGrid2
            // 
            this.GrpBoxGrid2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpBoxGrid2.Controls.Add(this.GGridLoan);
            this.GrpBoxGrid2.Location = new System.Drawing.Point(11, 357);
            this.GrpBoxGrid2.Margin = new System.Windows.Forms.Padding(4);
            this.GrpBoxGrid2.Name = "GrpBoxGrid2";
            this.GrpBoxGrid2.Padding = new System.Windows.Forms.Padding(4);
            this.GrpBoxGrid2.Size = new System.Drawing.Size(947, 132);
            this.GrpBoxGrid2.TabIndex = 0;
            this.GrpBoxGrid2.TabStop = false;
            // 
            // GGridLoan
            // 
            this.GGridLoan.AllowUserToAddRows = false;
            this.GGridLoan.AllowUserToDeleteRows = false;
            this.GGridLoan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GGridLoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GGridLoan.BackgroundColor = System.Drawing.Color.SpringGreen;
            this.GGridLoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GGridLoan.Location = new System.Drawing.Point(8, 14);
            this.GGridLoan.Margin = new System.Windows.Forms.Padding(4);
            this.GGridLoan.Name = "GGridLoan";
            this.GGridLoan.ReadOnly = true;
            this.GGridLoan.Size = new System.Drawing.Size(931, 110);
            this.GGridLoan.TabIndex = 0;
            this.GGridLoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GGridLoan_CellClick);
            this.GGridLoan.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GGridLoan_CellClick);
            // 
            // LoanFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 613);
            this.Controls.Add(this.GrpBoxGrid2);
            this.Controls.Add(this.GrpBoxGrid);
            this.Controls.Add(this.GrpBoxBtns);
            this.Controls.Add(this.GrpBoxInputs);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "LoanFrm";
            this.Text = "GiveLoanFrm";
            this.Load += new System.EventHandler(this.GiveLoanFrm_Load);
            this.Controls.SetChildIndex(this.GrpBoxInputs, 0);
            this.Controls.SetChildIndex(this.GrpBoxBtns, 0);
            this.Controls.SetChildIndex(this.GrpBoxGrid, 0);
            this.Controls.SetChildIndex(this.GrpBoxGrid2, 0);
            this.GrpBoxGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GGridApprovedLoanRequest)).EndInit();
            this.GrpBoxBtns.ResumeLayout(false);
            this.GrpBoxInputs.ResumeLayout(false);
            this.GrpBoxInputs.PerformLayout();
            this.GrpBoxGrid2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GGridLoan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpBoxGrid;
        private GenericDataGrid.GenericDataGrid GGridApprovedLoanRequest;
        private System.Windows.Forms.GroupBox GrpBoxBtns;
        private CRUD_Buttons.SaveButtonUC BtnSave;
        private CRUD_Buttons.CancelButtonUC BtnCancel;
        private CRUD_Buttons.InsertButtonUC BtnInsert;
        private System.Windows.Forms.GroupBox GrpBoxInputs;
        private System.Windows.Forms.Label label6;
        private NumericTextBox.NumericTextBox NumTxtAmount;
        private NumericTextBox.NumericTextBox NumTxtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private NumericTextBox.NumericTextBox NumTxtCode;
        private System.Windows.Forms.GroupBox GrpBoxGrid2;
        private GenericDataGrid.GenericDataGrid GGridLoan;
        private System.Windows.Forms.Label label5;
        private Atf.UI.DateTimeSelector DSLoanDate;
        private System.Windows.Forms.Label LblLastInstallmentDate;
        private System.Windows.Forms.Label LblFirstInstallmentDate;
        private CRUD_Buttons.DeleteButtonUC deleteButtonUC1;
    }
}
namespace FamilyLoan2020.UI.UIForms
{
    partial class LoanRequestFrm
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
            this.ParsiTxtNote = new ParsiTextBox_Control.ParsiTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NumTxtRequestAmount = new NumericTextBox.NumericTextBox();
            this.CmbPerson = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DSRequestDate = new Atf.UI.DateTimeSelector();
            this.label3 = new System.Windows.Forms.Label();
            this.NumTxtID = new NumericTextBox.NumericTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GrpBoxBtns = new System.Windows.Forms.GroupBox();
            this.BtnSave = new CRUD_Buttons.SaveButtonUC();
            this.BtnUpdate = new CRUD_Buttons.UpdateButtonUC();
            this.BtnDelete = new CRUD_Buttons.DeleteButtonUC();
            this.BtnCancel = new CRUD_Buttons.CancelButtonUC();
            this.BtnInsert = new CRUD_Buttons.InsertButtonUC();
            this.GrpBoxGrid = new System.Windows.Forms.GroupBox();
            this.GGridLoanRequest = new GenericDataGrid.GenericDataGrid();
            this.GrpBoxInputs.SuspendLayout();
            this.GrpBoxBtns.SuspendLayout();
            this.GrpBoxGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GGridLoanRequest)).BeginInit();
            this.SuspendLayout();
            // 
            // GrpBoxInputs
            // 
            this.GrpBoxInputs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpBoxInputs.Controls.Add(this.ParsiTxtNote);
            this.GrpBoxInputs.Controls.Add(this.label6);
            this.GrpBoxInputs.Controls.Add(this.NumTxtRequestAmount);
            this.GrpBoxInputs.Controls.Add(this.CmbPerson);
            this.GrpBoxInputs.Controls.Add(this.label5);
            this.GrpBoxInputs.Controls.Add(this.DSRequestDate);
            this.GrpBoxInputs.Controls.Add(this.label3);
            this.GrpBoxInputs.Controls.Add(this.NumTxtID);
            this.GrpBoxInputs.Controls.Add(this.label2);
            this.GrpBoxInputs.Controls.Add(this.label1);
            this.GrpBoxInputs.Location = new System.Drawing.Point(13, 111);
            this.GrpBoxInputs.Margin = new System.Windows.Forms.Padding(4);
            this.GrpBoxInputs.Name = "GrpBoxInputs";
            this.GrpBoxInputs.Padding = new System.Windows.Forms.Padding(4);
            this.GrpBoxInputs.Size = new System.Drawing.Size(974, 202);
            this.GrpBoxInputs.TabIndex = 0;
            this.GrpBoxInputs.TabStop = false;
            // 
            // ParsiTxtNote
            // 
            this.ParsiTxtNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ParsiTxtNote.ExtraChar = '0';
            this.ParsiTxtNote.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ParsiTxtNote.KeyBoardLanguage = ParsiTextBox_Control.EnKeyBoardLanguage.Persian;
            this.ParsiTxtNote.Location = new System.Drawing.Point(42, 109);
            this.ParsiTxtNote.Margin = new System.Windows.Forms.Padding(4);
            this.ParsiTxtNote.MinimumLength = 0;
            this.ParsiTxtNote.Multiline = true;
            this.ParsiTxtNote.Name = "ParsiTxtNote";
            this.ParsiTxtNote.Size = new System.Drawing.Size(790, 65);
            this.ParsiTxtNote.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(322, 71);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "مبلغ درخواست";
            // 
            // NumTxtRequestAmount
            // 
            this.NumTxtRequestAmount.ApplyThousandSeprator = true;
            this.NumTxtRequestAmount.Location = new System.Drawing.Point(9, 65);
            this.NumTxtRequestAmount.Margin = new System.Windows.Forms.Padding(4);
            this.NumTxtRequestAmount.Name = "NumTxtRequestAmount";
            this.NumTxtRequestAmount.Size = new System.Drawing.Size(310, 26);
            this.NumTxtRequestAmount.TabIndex = 4;
            // 
            // CmbPerson
            // 
            this.CmbPerson.FormattingEnabled = true;
            this.CmbPerson.Location = new System.Drawing.Point(9, 28);
            this.CmbPerson.Margin = new System.Windows.Forms.Padding(4);
            this.CmbPerson.Name = "CmbPerson";
            this.CmbPerson.Size = new System.Drawing.Size(310, 26);
            this.CmbPerson.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(841, 72);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "تاریخ درخواست";
            // 
            // DSRequestDate
            // 
            this.DSRequestDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DSRequestDate.CustomFormat = "YYYY/MM/DD";
            this.DSRequestDate.Location = new System.Drawing.Point(575, 65);
            this.DSRequestDate.Margin = new System.Windows.Forms.Padding(4);
            this.DSRequestDate.Name = "DSRequestDate";
            this.DSRequestDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DSRequestDate.Size = new System.Drawing.Size(254, 27);
            this.DSRequestDate.TabIndex = 3;
            this.DSRequestDate.UsePersianFormat = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(885, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "توضیحات";
            // 
            // NumTxtID
            // 
            this.NumTxtID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumTxtID.ApplyThousandSeprator = false;
            this.NumTxtID.Location = new System.Drawing.Point(575, 28);
            this.NumTxtID.Margin = new System.Windows.Forms.Padding(4);
            this.NumTxtID.Name = "NumTxtID";
            this.NumTxtID.Size = new System.Drawing.Size(254, 26);
            this.NumTxtID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "نام شخص";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(895, 32);
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
            this.GrpBoxBtns.Location = new System.Drawing.Point(13, 550);
            this.GrpBoxBtns.Margin = new System.Windows.Forms.Padding(4);
            this.GrpBoxBtns.Name = "GrpBoxBtns";
            this.GrpBoxBtns.Padding = new System.Windows.Forms.Padding(4);
            this.GrpBoxBtns.Size = new System.Drawing.Size(974, 79);
            this.GrpBoxBtns.TabIndex = 0;
            this.GrpBoxBtns.TabStop = false;
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnSave.Location = new System.Drawing.Point(190, 16);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnSave.Size = new System.Drawing.Size(188, 60);
            this.BtnSave.TabIndex = 9;
            this.BtnSave.ButtonClick += new System.EventHandler(this.BtnSave_ButtonClick);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUpdate.Location = new System.Drawing.Point(579, 16);
            this.BtnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnUpdate.Size = new System.Drawing.Size(188, 60);
            this.BtnUpdate.TabIndex = 7;
            this.BtnUpdate.ButtonClick += new System.EventHandler(this.BtnUpdate_ButtonClick);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnDelete.Location = new System.Drawing.Point(370, 16);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnDelete.Size = new System.Drawing.Size(188, 60);
            this.BtnDelete.TabIndex = 8;
            this.BtnDelete.ButtonClick += new System.EventHandler(this.BtnDelete_ButtonClick);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCancel.Location = new System.Drawing.Point(12, 16);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnCancel.Size = new System.Drawing.Size(188, 60);
            this.BtnCancel.TabIndex = 10;
            this.BtnCancel.ButtonClick += new System.EventHandler(this.BtnCancel_ButtonClick);
            // 
            // BtnInsert
            // 
            this.BtnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnInsert.Location = new System.Drawing.Point(761, 16);
            this.BtnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnInsert.Size = new System.Drawing.Size(198, 66);
            this.BtnInsert.TabIndex = 6;
            this.BtnInsert.ButtonClick += new System.EventHandler(this.BtnInsert_ButtonClick);
            // 
            // GrpBoxGrid
            // 
            this.GrpBoxGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpBoxGrid.Controls.Add(this.GGridLoanRequest);
            this.GrpBoxGrid.Location = new System.Drawing.Point(13, 321);
            this.GrpBoxGrid.Margin = new System.Windows.Forms.Padding(4);
            this.GrpBoxGrid.Name = "GrpBoxGrid";
            this.GrpBoxGrid.Padding = new System.Windows.Forms.Padding(4);
            this.GrpBoxGrid.Size = new System.Drawing.Size(974, 221);
            this.GrpBoxGrid.TabIndex = 0;
            this.GrpBoxGrid.TabStop = false;
            // 
            // GGridLoanRequest
            // 
            this.GGridLoanRequest.AllowUserToAddRows = false;
            this.GGridLoanRequest.AllowUserToDeleteRows = false;
            this.GGridLoanRequest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GGridLoanRequest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GGridLoanRequest.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.GGridLoanRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GGridLoanRequest.Location = new System.Drawing.Point(9, 17);
            this.GGridLoanRequest.Margin = new System.Windows.Forms.Padding(4);
            this.GGridLoanRequest.Name = "GGridLoanRequest";
            this.GGridLoanRequest.ReadOnly = true;
            this.GGridLoanRequest.Size = new System.Drawing.Size(937, 196);
            this.GGridLoanRequest.TabIndex = 0;
            this.GGridLoanRequest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GGridLoanRequest_CellClick);
            this.GGridLoanRequest.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GGridLoanRequest_CellClick);
            // 
            // LoanRequestFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 696);
            this.Controls.Add(this.GrpBoxGrid);
            this.Controls.Add(this.GrpBoxBtns);
            this.Controls.Add(this.GrpBoxInputs);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "LoanRequestFrm";
            this.Text = "LoanRequestFrm";
            this.Load += new System.EventHandler(this.LoanRequestFrm_Load);
            this.Controls.SetChildIndex(this.GrpBoxInputs, 0);
            this.Controls.SetChildIndex(this.GrpBoxBtns, 0);
            this.Controls.SetChildIndex(this.GrpBoxGrid, 0);
            this.GrpBoxInputs.ResumeLayout(false);
            this.GrpBoxInputs.PerformLayout();
            this.GrpBoxBtns.ResumeLayout(false);
            this.GrpBoxGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GGridLoanRequest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpBoxInputs;
        private System.Windows.Forms.Label label5;
        private Atf.UI.DateTimeSelector DSRequestDate;
        private System.Windows.Forms.Label label3;
        private NumericTextBox.NumericTextBox NumTxtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GrpBoxBtns;
        private CRUD_Buttons.SaveButtonUC BtnSave;
        private CRUD_Buttons.UpdateButtonUC BtnUpdate;
        private CRUD_Buttons.DeleteButtonUC BtnDelete;
        private CRUD_Buttons.CancelButtonUC BtnCancel;
        private CRUD_Buttons.InsertButtonUC BtnInsert;
        private System.Windows.Forms.ComboBox CmbPerson;
        private NumericTextBox.NumericTextBox NumTxtRequestAmount;
        private System.Windows.Forms.Label label6;
        private ParsiTextBox_Control.ParsiTextBox ParsiTxtNote;
        private System.Windows.Forms.GroupBox GrpBoxGrid;
        private GenericDataGrid.GenericDataGrid GGridLoanRequest;
    }
}
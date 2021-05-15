namespace FamilyLoan2020.UI.UIForms
{
    partial class PaymentTypeFrm
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
            this.GenericGridPaymentType = new GenericDataGrid.GenericDataGrid();
            this.ParsiTxtTitle = new ParsiTextBox_Control.ParsiTextBox();
            this.NumTxtCode = new NumericTextBox.NumericTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GrpBoxBtns = new System.Windows.Forms.GroupBox();
            this.BtnSave = new CRUD_Buttons.SaveButtonUC();
            this.BtnUpdate = new CRUD_Buttons.UpdateButtonUC();
            this.BtnDelete = new CRUD_Buttons.DeleteButtonUC();
            this.BtnCancel = new CRUD_Buttons.CancelButtonUC();
            this.BtnInsert = new CRUD_Buttons.InsertButtonUC();
            this.GrpBoxInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GenericGridPaymentType)).BeginInit();
            this.GrpBoxBtns.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpBoxInputs
            // 
            this.GrpBoxInputs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpBoxInputs.Controls.Add(this.GenericGridPaymentType);
            this.GrpBoxInputs.Controls.Add(this.ParsiTxtTitle);
            this.GrpBoxInputs.Controls.Add(this.NumTxtCode);
            this.GrpBoxInputs.Controls.Add(this.label2);
            this.GrpBoxInputs.Controls.Add(this.label1);
            this.GrpBoxInputs.Location = new System.Drawing.Point(14, 111);
            this.GrpBoxInputs.Margin = new System.Windows.Forms.Padding(4);
            this.GrpBoxInputs.Name = "GrpBoxInputs";
            this.GrpBoxInputs.Padding = new System.Windows.Forms.Padding(4);
            this.GrpBoxInputs.Size = new System.Drawing.Size(927, 222);
            this.GrpBoxInputs.TabIndex = 4;
            this.GrpBoxInputs.TabStop = false;
            // 
            // GenericGridPaymentType
            // 
            this.GenericGridPaymentType.AllowUserToAddRows = false;
            this.GenericGridPaymentType.AllowUserToDeleteRows = false;
            this.GenericGridPaymentType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GenericGridPaymentType.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.GenericGridPaymentType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GenericGridPaymentType.Location = new System.Drawing.Point(32, 29);
            this.GenericGridPaymentType.Margin = new System.Windows.Forms.Padding(4);
            this.GenericGridPaymentType.Name = "GenericGridPaymentType";
            this.GenericGridPaymentType.ReadOnly = true;
            this.GenericGridPaymentType.Size = new System.Drawing.Size(525, 169);
            this.GenericGridPaymentType.TabIndex = 4;
            this.GenericGridPaymentType.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GenericGridPaymentType_CellClick);
            // 
            // ParsiTxtTitle
            // 
            this.ParsiTxtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ParsiTxtTitle.ExtraChar = '0';
            this.ParsiTxtTitle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ParsiTxtTitle.KeyBoardLanguage = ParsiTextBox_Control.EnKeyBoardLanguage.Persian;
            this.ParsiTxtTitle.Location = new System.Drawing.Point(586, 78);
            this.ParsiTxtTitle.Margin = new System.Windows.Forms.Padding(4);
            this.ParsiTxtTitle.MinimumLength = 0;
            this.ParsiTxtTitle.Name = "ParsiTxtTitle";
            this.ParsiTxtTitle.Size = new System.Drawing.Size(258, 23);
            this.ParsiTxtTitle.TabIndex = 2;
            // 
            // NumTxtCode
            // 
            this.NumTxtCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumTxtCode.ApplyThousandSeprator = false;
            this.NumTxtCode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NumTxtCode.Location = new System.Drawing.Point(586, 40);
            this.NumTxtCode.Margin = new System.Windows.Forms.Padding(4);
            this.NumTxtCode.Name = "NumTxtCode";
            this.NumTxtCode.Size = new System.Drawing.Size(258, 23);
            this.NumTxtCode.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(855, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "عنوان";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(855, 44);
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
            this.GrpBoxBtns.Location = new System.Drawing.Point(14, 332);
            this.GrpBoxBtns.Margin = new System.Windows.Forms.Padding(4);
            this.GrpBoxBtns.Name = "GrpBoxBtns";
            this.GrpBoxBtns.Padding = new System.Windows.Forms.Padding(4);
            this.GrpBoxBtns.Size = new System.Drawing.Size(927, 102);
            this.GrpBoxBtns.TabIndex = 5;
            this.GrpBoxBtns.TabStop = false;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(190, 28);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnSave.Size = new System.Drawing.Size(188, 60);
            this.BtnSave.TabIndex = 5;
            this.BtnSave.ButtonClick += new System.EventHandler(this.BtnSave_ButtonClick);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUpdate.Location = new System.Drawing.Point(546, 28);
            this.BtnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnUpdate.Size = new System.Drawing.Size(188, 60);
            this.BtnUpdate.TabIndex = 3;
            this.BtnUpdate.ButtonClick += new System.EventHandler(this.BtnUpdate_ButtonClick);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(370, 28);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnDelete.Size = new System.Drawing.Size(188, 60);
            this.BtnDelete.TabIndex = 4;
            this.BtnDelete.ButtonClick += new System.EventHandler(this.BtnDelete_ButtonClick);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(12, 28);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnCancel.Size = new System.Drawing.Size(188, 60);
            this.BtnCancel.TabIndex = 6;
            this.BtnCancel.ButtonClick += new System.EventHandler(this.BtnCancel_ButtonClick);
            // 
            // BtnInsert
            // 
            this.BtnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnInsert.Location = new System.Drawing.Point(726, 28);
            this.BtnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnInsert.Size = new System.Drawing.Size(198, 66);
            this.BtnInsert.TabIndex = 0;
            this.BtnInsert.ButtonClick += new System.EventHandler(this.BtnInsert_ButtonClick);
            // 
            // PaymentTypeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 497);
            this.Controls.Add(this.GrpBoxBtns);
            this.Controls.Add(this.GrpBoxInputs);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "PaymentTypeFrm";
            this.Text = "PaymentTypeFrm";
            this.Load += new System.EventHandler(this.PaymentTypeFrm_Load);
            this.Controls.SetChildIndex(this.GrpBoxInputs, 0);
            this.Controls.SetChildIndex(this.GrpBoxBtns, 0);
            this.GrpBoxInputs.ResumeLayout(false);
            this.GrpBoxInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GenericGridPaymentType)).EndInit();
            this.GrpBoxBtns.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpBoxInputs;
        private System.Windows.Forms.GroupBox GrpBoxBtns;
        private NumericTextBox.NumericTextBox NumTxtCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private GenericDataGrid.GenericDataGrid GenericGridPaymentType;
        private ParsiTextBox_Control.ParsiTextBox ParsiTxtTitle;
        private CRUD_Buttons.InsertButtonUC BtnInsert;
        private CRUD_Buttons.DeleteButtonUC BtnDelete;
        private CRUD_Buttons.CancelButtonUC BtnCancel;
        private CRUD_Buttons.SaveButtonUC BtnSave;
        private CRUD_Buttons.UpdateButtonUC BtnUpdate;
    }
}
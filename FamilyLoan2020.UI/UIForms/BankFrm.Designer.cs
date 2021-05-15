
namespace FamilyLoan2020.UI.UIForms
{
    partial class BankFrm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.GGridBank = new GenericDataGrid.GenericDataGrid();
            this.panel3 = new System.Windows.Forms.Panel();
            this.updateButtonUC1 = new CRUD_Buttons.UpdateButtonUC();
            this.saveButtonUC1 = new CRUD_Buttons.SaveButtonUC();
            this.insertButtonUC1 = new CRUD_Buttons.InsertButtonUC();
            this.deleteButtonUC1 = new CRUD_Buttons.DeleteButtonUC();
            this.cancelButtonUC1 = new CRUD_Buttons.CancelButtonUC();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LblBank = new System.Windows.Forms.Label();
            this.LblKarmozd = new System.Windows.Forms.Label();
            this.DSTransaction = new Atf.UI.DateTimeSelector();
            this.label2 = new System.Windows.Forms.Label();
            this.StringTxtDescription = new StringTextBox.StringTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GrpBoxInputs = new System.Windows.Forms.Panel();
            this.NumericTxtAmount = new System.Windows.Forms.TextBox();
            this.numericTextAccountNO = new System.Windows.Forms.TextBox();
            this.NumTxtBankID = new NumericTextBox.NumericTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ECmbPaymentType = new EnumComboBox.EnumComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblTotalSum = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblSumWage = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.LblSumBank = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GGridBank)).BeginInit();
            this.panel3.SuspendLayout();
            this.GrpBoxInputs.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.GGridBank);
            this.panel2.Location = new System.Drawing.Point(15, 320);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(941, 120);
            this.panel2.TabIndex = 0;
            // 
            // GGridBank
            // 
            this.GGridBank.AllowUserToAddRows = false;
            this.GGridBank.AllowUserToDeleteRows = false;
            this.GGridBank.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GGridBank.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GGridBank.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.GGridBank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GGridBank.Location = new System.Drawing.Point(12, 10);
            this.GGridBank.Name = "GGridBank";
            this.GGridBank.ReadOnly = true;
            this.GGridBank.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GGridBank.Size = new System.Drawing.Size(917, 105);
            this.GGridBank.TabIndex = 0;
            this.GGridBank.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GGridBank_CellClick);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.updateButtonUC1);
            this.panel3.Controls.Add(this.saveButtonUC1);
            this.panel3.Controls.Add(this.insertButtonUC1);
            this.panel3.Controls.Add(this.deleteButtonUC1);
            this.panel3.Controls.Add(this.cancelButtonUC1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(12, 515);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(941, 59);
            this.panel3.TabIndex = 0;
            // 
            // updateButtonUC1
            // 
            this.updateButtonUC1.Location = new System.Drawing.Point(378, 1);
            this.updateButtonUC1.Margin = new System.Windows.Forms.Padding(4);
            this.updateButtonUC1.Name = "updateButtonUC1";
            this.updateButtonUC1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.updateButtonUC1.Size = new System.Drawing.Size(180, 55);
            this.updateButtonUC1.TabIndex = 9;
            this.updateButtonUC1.ButtonClick += new System.EventHandler(this.updateButtonUC1_ButtonClick);
            // 
            // saveButtonUC1
            // 
            this.saveButtonUC1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButtonUC1.Location = new System.Drawing.Point(560, 3);
            this.saveButtonUC1.Margin = new System.Windows.Forms.Padding(4);
            this.saveButtonUC1.Name = "saveButtonUC1";
            this.saveButtonUC1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.saveButtonUC1.Size = new System.Drawing.Size(181, 55);
            this.saveButtonUC1.TabIndex = 8;
            this.saveButtonUC1.ButtonClick += new System.EventHandler(this.saveButtonUC1_ButtonClick);
            // 
            // insertButtonUC1
            // 
            this.insertButtonUC1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.insertButtonUC1.Location = new System.Drawing.Point(749, 1);
            this.insertButtonUC1.Margin = new System.Windows.Forms.Padding(4);
            this.insertButtonUC1.Name = "insertButtonUC1";
            this.insertButtonUC1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.insertButtonUC1.Size = new System.Drawing.Size(185, 57);
            this.insertButtonUC1.TabIndex = 7;
            this.insertButtonUC1.ButtonClick += new System.EventHandler(this.insertButtonUC1_ButtonClick);
            // 
            // deleteButtonUC1
            // 
            this.deleteButtonUC1.Location = new System.Drawing.Point(196, 2);
            this.deleteButtonUC1.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButtonUC1.Name = "deleteButtonUC1";
            this.deleteButtonUC1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.deleteButtonUC1.Size = new System.Drawing.Size(184, 55);
            this.deleteButtonUC1.TabIndex = 10;
            this.deleteButtonUC1.ButtonClick += new System.EventHandler(this.deleteButtonUC1_ButtonClick);
            // 
            // cancelButtonUC1
            // 
            this.cancelButtonUC1.Location = new System.Drawing.Point(4, 2);
            this.cancelButtonUC1.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButtonUC1.Name = "cancelButtonUC1";
            this.cancelButtonUC1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cancelButtonUC1.Size = new System.Drawing.Size(184, 56);
            this.cancelButtonUC1.TabIndex = 11;
            this.cancelButtonUC1.ButtonClick += new System.EventHandler(this.cancelButtonUC1_ButtonClick);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(8, 350);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(941, 158);
            this.panel4.TabIndex = 4;
            // 
            // LblBank
            // 
            this.LblBank.AutoSize = true;
            this.LblBank.Location = new System.Drawing.Point(309, 137);
            this.LblBank.Name = "LblBank";
            this.LblBank.Size = new System.Drawing.Size(105, 18);
            this.LblBank.TabIndex = 0;
            this.LblBank.Text = "شماره حساب";
            // 
            // LblKarmozd
            // 
            this.LblKarmozd.AutoSize = true;
            this.LblKarmozd.Location = new System.Drawing.Point(369, 26);
            this.LblKarmozd.Name = "LblKarmozd";
            this.LblKarmozd.Size = new System.Drawing.Size(39, 18);
            this.LblKarmozd.TabIndex = 0;
            this.LblKarmozd.Text = "مبلغ";
            // 
            // DSTransaction
            // 
            this.DSTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DSTransaction.CustomFormat = "YYYY/MM/DD";
            this.DSTransaction.Location = new System.Drawing.Point(515, 68);
            this.DSTransaction.Margin = new System.Windows.Forms.Padding(4);
            this.DSTransaction.Name = "DSTransaction";
            this.DSTransaction.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DSTransaction.Size = new System.Drawing.Size(258, 27);
            this.DSTransaction.TabIndex = 3;
            this.DSTransaction.UsePersianFormat = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(817, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "تاریخ تراکنش";
            // 
            // StringTxtDescription
            // 
            this.StringTxtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StringTxtDescription.Location = new System.Drawing.Point(439, 115);
            this.StringTxtDescription.Multiline = true;
            this.StringTxtDescription.Name = "StringTxtDescription";
            this.StringTxtDescription.Size = new System.Drawing.Size(334, 64);
            this.StringTxtDescription.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(845, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "توضیحات";
            // 
            // GrpBoxInputs
            // 
            this.GrpBoxInputs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpBoxInputs.Controls.Add(this.NumericTxtAmount);
            this.GrpBoxInputs.Controls.Add(this.numericTextAccountNO);
            this.GrpBoxInputs.Controls.Add(this.NumTxtBankID);
            this.GrpBoxInputs.Controls.Add(this.label1);
            this.GrpBoxInputs.Controls.Add(this.label3);
            this.GrpBoxInputs.Controls.Add(this.ECmbPaymentType);
            this.GrpBoxInputs.Controls.Add(this.label4);
            this.GrpBoxInputs.Controls.Add(this.StringTxtDescription);
            this.GrpBoxInputs.Controls.Add(this.label2);
            this.GrpBoxInputs.Controls.Add(this.DSTransaction);
            this.GrpBoxInputs.Controls.Add(this.LblKarmozd);
            this.GrpBoxInputs.Controls.Add(this.LblBank);
            this.GrpBoxInputs.Location = new System.Drawing.Point(14, 120);
            this.GrpBoxInputs.Name = "GrpBoxInputs";
            this.GrpBoxInputs.Size = new System.Drawing.Size(947, 188);
            this.GrpBoxInputs.TabIndex = 0;
            // 
            // NumericTxtAmount
            // 
            this.NumericTxtAmount.Location = new System.Drawing.Point(17, 22);
            this.NumericTxtAmount.Name = "NumericTxtAmount";
            this.NumericTxtAmount.Size = new System.Drawing.Size(251, 26);
            this.NumericTxtAmount.TabIndex = 2;
            // 
            // numericTextAccountNO
            // 
            this.numericTextAccountNO.Location = new System.Drawing.Point(21, 134);
            this.numericTextAccountNO.Name = "numericTextAccountNO";
            this.numericTextAccountNO.Size = new System.Drawing.Size(247, 26);
            this.numericTextAccountNO.TabIndex = 6;
            // 
            // NumTxtBankID
            // 
            this.NumTxtBankID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumTxtBankID.ApplyThousandSeprator = false;
            this.NumTxtBankID.Location = new System.Drawing.Point(515, 21);
            this.NumTxtBankID.Margin = new System.Windows.Forms.Padding(4);
            this.NumTxtBankID.MaxLength = 2;
            this.NumTxtBankID.Name = "NumTxtBankID";
            this.NumTxtBankID.Size = new System.Drawing.Size(258, 26);
            this.NumTxtBankID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(855, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "شناسه";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "نوع پرداخت";
            // 
            // ECmbPaymentType
            // 
            this.ECmbPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ECmbPaymentType.EnumObject = null;
            this.ECmbPaymentType.FormattingEnabled = true;
            this.ECmbPaymentType.Location = new System.Drawing.Point(21, 78);
            this.ECmbPaymentType.Margin = new System.Windows.Forms.Padding(4);
            this.ECmbPaymentType.Name = "ECmbPaymentType";
            this.ECmbPaymentType.Size = new System.Drawing.Size(247, 26);
            this.ECmbPaymentType.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.LblTotalSum);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.LblSumWage);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.LblSumBank);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(16, 441);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(939, 55);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جمع کل";
            // 
            // LblTotalSum
            // 
            this.LblTotalSum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LblTotalSum.BackColor = System.Drawing.Color.PaleTurquoise;
            this.LblTotalSum.Location = new System.Drawing.Point(20, 15);
            this.LblTotalSum.Name = "LblTotalSum";
            this.LblTotalSum.Size = new System.Drawing.Size(167, 35);
            this.LblTotalSum.TabIndex = 0;
            this.LblTotalSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(217, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "جمع کل";
            // 
            // LblSumWage
            // 
            this.LblSumWage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LblSumWage.BackColor = System.Drawing.Color.PaleTurquoise;
            this.LblSumWage.Location = new System.Drawing.Point(301, 14);
            this.LblSumWage.Name = "LblSumWage";
            this.LblSumWage.Size = new System.Drawing.Size(167, 35);
            this.LblSumWage.TabIndex = 0;
            this.LblSumWage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(498, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 18);
            this.label13.TabIndex = 0;
            this.label13.Text = "کارمزد";
            // 
            // LblSumBank
            // 
            this.LblSumBank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblSumBank.BackColor = System.Drawing.Color.PaleTurquoise;
            this.LblSumBank.Location = new System.Drawing.Point(631, 15);
            this.LblSumBank.Name = "LblSumBank";
            this.LblSumBank.Size = new System.Drawing.Size(164, 35);
            this.LblSumBank.TabIndex = 0;
            this.LblSumBank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(826, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 18);
            this.label12.TabIndex = 0;
            this.label12.Text = "بانک";
            // 
            // BankFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 638);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.GrpBoxInputs);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "BankFrm";
            this.Text = "BankFrm";
            this.Load += new System.EventHandler(this.BankFrm_Load);
            this.Controls.SetChildIndex(this.GrpBoxInputs, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GGridBank)).EndInit();
            this.panel3.ResumeLayout(false);
            this.GrpBoxInputs.ResumeLayout(false);
            this.GrpBoxInputs.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private CRUD_Buttons.SaveButtonUC saveButtonUC1;
        private CRUD_Buttons.InsertButtonUC insertButtonUC1;
        private CRUD_Buttons.DeleteButtonUC deleteButtonUC1;
        private CRUD_Buttons.CancelButtonUC cancelButtonUC1;
        private CRUD_Buttons.UpdateButtonUC updateButtonUC1;
        private GenericDataGrid.GenericDataGrid GGridBank;
        private System.Windows.Forms.Label LblBank;
        private System.Windows.Forms.Label LblKarmozd;
        private Atf.UI.DateTimeSelector DSTransaction;
        private System.Windows.Forms.Label label2;
        private StringTextBox.StringTextBox StringTxtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel GrpBoxInputs;
        private System.Windows.Forms.Label label3;
        private EnumComboBox.EnumComboBox ECmbPaymentType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblSumWage;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label LblSumBank;
        private System.Windows.Forms.Label label12;
        private NumericTextBox.NumericTextBox NumTxtBankID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numericTextAccountNO;
        private System.Windows.Forms.Label LblTotalSum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NumericTxtAmount;
    }
}
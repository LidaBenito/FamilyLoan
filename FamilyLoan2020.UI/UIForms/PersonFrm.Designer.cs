namespace FamilyLoan2020.UI.UIForms
{
    partial class PersonFrm
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
            this.DSBirthdate = new Atf.UI.DateTimeSelector();
            this.GrpBoxBtns = new System.Windows.Forms.GroupBox();
            this.BtnSave = new CRUD_Buttons.SaveButtonUC();
            this.BtnUpdate = new CRUD_Buttons.UpdateButtonUC();
            this.BtnDelete = new CRUD_Buttons.DeleteButtonUC();
            this.BtnCancel = new CRUD_Buttons.CancelButtonUC();
            this.BtnInsert = new CRUD_Buttons.InsertButtonUC();
            this.GrpBoxInputs = new System.Windows.Forms.GroupBox();
            this.BtnPicSearch = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.parsiTextAccountNO = new ParsiTextBox_Control.ParsiTextBox();
            this.MaskTxtMobile = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RbFemale = new System.Windows.Forms.RadioButton();
            this.RbMale = new System.Windows.Forms.RadioButton();
            this.ParsiTxtFamily = new ParsiTextBox_Control.ParsiTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ParsiTxtName = new ParsiTextBox_Control.ParsiTextBox();
            this.NumTxtID = new NumericTextBox.NumericTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GrpBoxGrid = new System.Windows.Forms.GroupBox();
            this.GGridPerson = new GenericDataGrid.GenericDataGrid();
            this.PicBoxProfileImage = new System.Windows.Forms.PictureBox();
            this.OpenImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.GrpBoxBtns.SuspendLayout();
            this.GrpBoxInputs.SuspendLayout();
            this.GrpBoxGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GGridPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxProfileImage)).BeginInit();
            this.SuspendLayout();
            // 
            // DSBirthdate
            // 
            this.DSBirthdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DSBirthdate.CustomFormat = "YYYY/MM/DD";
            this.DSBirthdate.Location = new System.Drawing.Point(552, 90);
            this.DSBirthdate.Margin = new System.Windows.Forms.Padding(4);
            this.DSBirthdate.Name = "DSBirthdate";
            this.DSBirthdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DSBirthdate.Size = new System.Drawing.Size(260, 27);
            this.DSBirthdate.TabIndex = 5;
            this.DSBirthdate.UsePersianFormat = true;
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
            this.GrpBoxBtns.Location = new System.Drawing.Point(10, 595);
            this.GrpBoxBtns.Margin = new System.Windows.Forms.Padding(4);
            this.GrpBoxBtns.Name = "GrpBoxBtns";
            this.GrpBoxBtns.Padding = new System.Windows.Forms.Padding(4);
            this.GrpBoxBtns.Size = new System.Drawing.Size(927, 98);
            this.GrpBoxBtns.TabIndex = 0;
            this.GrpBoxBtns.TabStop = false;
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnSave.Location = new System.Drawing.Point(190, 28);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnSave.Size = new System.Drawing.Size(188, 60);
            this.BtnSave.TabIndex = 12;
            this.BtnSave.ButtonClick += new System.EventHandler(this.BtnSave_ButtonClick);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUpdate.Location = new System.Drawing.Point(546, 28);
            this.BtnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnUpdate.Size = new System.Drawing.Size(188, 60);
            this.BtnUpdate.TabIndex = 10;
            this.BtnUpdate.ButtonClick += new System.EventHandler(this.BtnUpdate_ButtonClick);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnDelete.Location = new System.Drawing.Point(370, 28);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnDelete.Size = new System.Drawing.Size(188, 60);
            this.BtnDelete.TabIndex = 11;
            this.BtnDelete.ButtonClick += new System.EventHandler(this.BtnDelete_ButtonClick);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCancel.Location = new System.Drawing.Point(12, 28);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnCancel.Size = new System.Drawing.Size(188, 60);
            this.BtnCancel.TabIndex = 13;
            this.BtnCancel.ButtonClick += new System.EventHandler(this.BtnCancel_ButtonClick);
            // 
            // BtnInsert
            // 
            this.BtnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnInsert.Location = new System.Drawing.Point(728, 28);
            this.BtnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnInsert.Size = new System.Drawing.Size(198, 66);
            this.BtnInsert.TabIndex = 9;
            this.BtnInsert.ButtonClick += new System.EventHandler(this.BtnInsert_ButtonClick);
            // 
            // GrpBoxInputs
            // 
            this.GrpBoxInputs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpBoxInputs.Controls.Add(this.PicBoxProfileImage);
            this.GrpBoxInputs.Controls.Add(this.BtnPicSearch);
            this.GrpBoxInputs.Controls.Add(this.label8);
            this.GrpBoxInputs.Controls.Add(this.label7);
            this.GrpBoxInputs.Controls.Add(this.parsiTextAccountNO);
            this.GrpBoxInputs.Controls.Add(this.MaskTxtMobile);
            this.GrpBoxInputs.Controls.Add(this.label6);
            this.GrpBoxInputs.Controls.Add(this.label5);
            this.GrpBoxInputs.Controls.Add(this.label4);
            this.GrpBoxInputs.Controls.Add(this.DSBirthdate);
            this.GrpBoxInputs.Controls.Add(this.RbFemale);
            this.GrpBoxInputs.Controls.Add(this.RbMale);
            this.GrpBoxInputs.Controls.Add(this.ParsiTxtFamily);
            this.GrpBoxInputs.Controls.Add(this.label3);
            this.GrpBoxInputs.Controls.Add(this.ParsiTxtName);
            this.GrpBoxInputs.Controls.Add(this.NumTxtID);
            this.GrpBoxInputs.Controls.Add(this.label2);
            this.GrpBoxInputs.Controls.Add(this.label1);
            this.GrpBoxInputs.Location = new System.Drawing.Point(18, 116);
            this.GrpBoxInputs.Margin = new System.Windows.Forms.Padding(4);
            this.GrpBoxInputs.Name = "GrpBoxInputs";
            this.GrpBoxInputs.Padding = new System.Windows.Forms.Padding(4);
            this.GrpBoxInputs.Size = new System.Drawing.Size(927, 189);
            this.GrpBoxInputs.TabIndex = 0;
            this.GrpBoxInputs.TabStop = false;
            // 
            // BtnPicSearch
            // 
            this.BtnPicSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnPicSearch.Location = new System.Drawing.Point(239, 117);
            this.BtnPicSearch.Name = "BtnPicSearch";
            this.BtnPicSearch.Size = new System.Drawing.Size(145, 35);
            this.BtnPicSearch.TabIndex = 11;
            this.BtnPicSearch.Text = "انتخاب تصویر";
            this.BtnPicSearch.UseVisualStyleBackColor = false;
            this.BtnPicSearch.Click += new System.EventHandler(this.BtnPicSearch_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(465, 113);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "تصویر";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(365, 30);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "شماره حساب بانکی";
            // 
            // parsiTextAccountNO
            // 
            this.parsiTextAccountNO.ExtraChar = '0';
            this.parsiTextAccountNO.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.parsiTextAccountNO.KeyBoardLanguage = ParsiTextBox_Control.EnKeyBoardLanguage.Persian;
            this.parsiTextAccountNO.Location = new System.Drawing.Point(99, 30);
            this.parsiTextAccountNO.Margin = new System.Windows.Forms.Padding(4);
            this.parsiTextAccountNO.MinimumLength = 0;
            this.parsiTextAccountNO.Name = "parsiTextAccountNO";
            this.parsiTextAccountNO.Size = new System.Drawing.Size(258, 23);
            this.parsiTextAccountNO.TabIndex = 2;
            // 
            // MaskTxtMobile
            // 
            this.MaskTxtMobile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaskTxtMobile.Location = new System.Drawing.Point(554, 125);
            this.MaskTxtMobile.Margin = new System.Windows.Forms.Padding(4);
            this.MaskTxtMobile.Mask = "00000000000";
            this.MaskTxtMobile.Name = "MaskTxtMobile";
            this.MaskTxtMobile.Size = new System.Drawing.Size(258, 26);
            this.MaskTxtMobile.TabIndex = 8;
            this.MaskTxtMobile.ValidatingType = typeof(int);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(858, 125);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "موبایل";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(837, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "تاریخ تولد";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(847, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "جنسیت";
            // 
            // RbFemale
            // 
            this.RbFemale.AutoSize = true;
            this.RbFemale.Location = new System.Drawing.Point(654, 156);
            this.RbFemale.Margin = new System.Windows.Forms.Padding(4);
            this.RbFemale.Name = "RbFemale";
            this.RbFemale.Size = new System.Drawing.Size(45, 22);
            this.RbFemale.TabIndex = 7;
            this.RbFemale.Text = "زن";
            this.RbFemale.UseVisualStyleBackColor = true;
            // 
            // RbMale
            // 
            this.RbMale.AutoSize = true;
            this.RbMale.Checked = true;
            this.RbMale.Location = new System.Drawing.Point(720, 156);
            this.RbMale.Margin = new System.Windows.Forms.Padding(4);
            this.RbMale.Name = "RbMale";
            this.RbMale.Size = new System.Drawing.Size(51, 22);
            this.RbMale.TabIndex = 6;
            this.RbMale.TabStop = true;
            this.RbMale.Text = "مرد";
            this.RbMale.UseVisualStyleBackColor = true;
            // 
            // ParsiTxtFamily
            // 
            this.ParsiTxtFamily.ExtraChar = '0';
            this.ParsiTxtFamily.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ParsiTxtFamily.KeyBoardLanguage = ParsiTextBox_Control.EnKeyBoardLanguage.Persian;
            this.ParsiTxtFamily.Location = new System.Drawing.Point(99, 61);
            this.ParsiTxtFamily.Margin = new System.Windows.Forms.Padding(4);
            this.ParsiTxtFamily.MinimumLength = 0;
            this.ParsiTxtFamily.Name = "ParsiTxtFamily";
            this.ParsiTxtFamily.Size = new System.Drawing.Size(258, 23);
            this.ParsiTxtFamily.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "نام خانوادگی";
            // 
            // ParsiTxtName
            // 
            this.ParsiTxtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ParsiTxtName.ExtraChar = '0';
            this.ParsiTxtName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ParsiTxtName.KeyBoardLanguage = ParsiTextBox_Control.EnKeyBoardLanguage.Persian;
            this.ParsiTxtName.Location = new System.Drawing.Point(554, 59);
            this.ParsiTxtName.Margin = new System.Windows.Forms.Padding(4);
            this.ParsiTxtName.MinimumLength = 0;
            this.ParsiTxtName.Name = "ParsiTxtName";
            this.ParsiTxtName.Size = new System.Drawing.Size(258, 23);
            this.ParsiTxtName.TabIndex = 3;
            // 
            // NumTxtID
            // 
            this.NumTxtID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumTxtID.ApplyThousandSeprator = false;
            this.NumTxtID.Location = new System.Drawing.Point(554, 25);
            this.NumTxtID.Margin = new System.Windows.Forms.Padding(4);
            this.NumTxtID.Name = "NumTxtID";
            this.NumTxtID.Size = new System.Drawing.Size(258, 26);
            this.NumTxtID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(882, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "نام";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(849, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "شناسه";
            // 
            // GrpBoxGrid
            // 
            this.GrpBoxGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpBoxGrid.Controls.Add(this.GGridPerson);
            this.GrpBoxGrid.Location = new System.Drawing.Point(16, 305);
            this.GrpBoxGrid.Margin = new System.Windows.Forms.Padding(4);
            this.GrpBoxGrid.Name = "GrpBoxGrid";
            this.GrpBoxGrid.Padding = new System.Windows.Forms.Padding(4);
            this.GrpBoxGrid.Size = new System.Drawing.Size(927, 285);
            this.GrpBoxGrid.TabIndex = 0;
            this.GrpBoxGrid.TabStop = false;
            // 
            // GGridPerson
            // 
            this.GGridPerson.AllowUserToAddRows = false;
            this.GGridPerson.AllowUserToDeleteRows = false;
            this.GGridPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GGridPerson.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GGridPerson.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.GGridPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GGridPerson.Location = new System.Drawing.Point(9, 24);
            this.GGridPerson.Margin = new System.Windows.Forms.Padding(4);
            this.GGridPerson.Name = "GGridPerson";
            this.GGridPerson.ReadOnly = true;
            this.GGridPerson.Size = new System.Drawing.Size(909, 249);
            this.GGridPerson.StandardTab = true;
            this.GGridPerson.TabIndex = 0;
            this.GGridPerson.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GGridPerson_CellClick);
            this.GGridPerson.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GGridPerson_CellClick);
            // 
            // PicBoxProfileImage
            // 
            this.PicBoxProfileImage.Location = new System.Drawing.Point(66, 91);
            this.PicBoxProfileImage.Name = "PicBoxProfileImage";
            this.PicBoxProfileImage.Size = new System.Drawing.Size(140, 91);
            this.PicBoxProfileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxProfileImage.TabIndex = 12;
            this.PicBoxProfileImage.TabStop = false;
            // 
            // OpenImageDialog
            // 
            this.OpenImageDialog.FileName = "openFileDialog1";
            // 
            // PersonFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 749);
            this.Controls.Add(this.GrpBoxGrid);
            this.Controls.Add(this.GrpBoxBtns);
            this.Controls.Add(this.GrpBoxInputs);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "PersonFrm";
            this.Text = "PersonFrm";
            this.Load += new System.EventHandler(this.PersonFrm_Load);
            this.Controls.SetChildIndex(this.GrpBoxInputs, 0);
            this.Controls.SetChildIndex(this.GrpBoxBtns, 0);
            this.Controls.SetChildIndex(this.GrpBoxGrid, 0);
            this.GrpBoxBtns.ResumeLayout(false);
            this.GrpBoxInputs.ResumeLayout(false);
            this.GrpBoxInputs.PerformLayout();
            this.GrpBoxGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GGridPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxProfileImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GrpBoxBtns;
        private CRUD_Buttons.SaveButtonUC BtnSave;
        private CRUD_Buttons.UpdateButtonUC BtnUpdate;
        private CRUD_Buttons.DeleteButtonUC BtnDelete;
        private CRUD_Buttons.CancelButtonUC BtnCancel;
        private CRUD_Buttons.InsertButtonUC BtnInsert;
        private System.Windows.Forms.GroupBox GrpBoxInputs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton RbFemale;
        private System.Windows.Forms.RadioButton RbMale;
        private ParsiTextBox_Control.ParsiTextBox ParsiTxtFamily;
        private System.Windows.Forms.Label label3;
        private ParsiTextBox_Control.ParsiTextBox ParsiTxtName;
        private NumericTextBox.NumericTextBox NumTxtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GrpBoxGrid;
        private GenericDataGrid.GenericDataGrid GGridPerson;
        private System.Windows.Forms.MaskedTextBox MaskTxtMobile;
        private System.Windows.Forms.Label label6;
        private Atf.UI.DateTimeSelector DSBirthdate;
        private System.Windows.Forms.Label label7;
        private ParsiTextBox_Control.ParsiTextBox parsiTextAccountNO;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnPicSearch;
        private System.Windows.Forms.PictureBox PicBoxProfileImage;
        private System.Windows.Forms.OpenFileDialog OpenImageDialog;
    }
}
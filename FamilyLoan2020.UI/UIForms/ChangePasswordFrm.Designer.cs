
namespace FamilyLoan2020.UI.UIForms
{
    partial class ChangePasswordFrm
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
            this.TxtNewPassword = new ParsiTextBox_Control.ParsiTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNewPassword2 = new ParsiTextBox_Control.ParsiTextBox();
            this.TxtCurrentPassword = new ParsiTextBox_Control.ParsiTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StrTxtUsername = new StringTextBox.StringTextBox();
            this.CmbPerson = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GrpBoxBtns = new System.Windows.Forms.GroupBox();
            this.BtnSave = new CRUD_Buttons.SaveButtonUC();
            this.BtnCancel = new CRUD_Buttons.CancelButtonUC();
            this.BtnInsert = new CRUD_Buttons.InsertButtonUC();
            this.GrpBoxInputs = new System.Windows.Forms.GroupBox();
            this.GrpBoxBtns.SuspendLayout();
            this.GrpBoxInputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtNewPassword
            // 
            this.TxtNewPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNewPassword.ExtraChar = '0';
            this.TxtNewPassword.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtNewPassword.KeyBoardLanguage = ParsiTextBox_Control.EnKeyBoardLanguage.English;
            this.TxtNewPassword.Location = new System.Drawing.Point(525, 107);
            this.TxtNewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNewPassword.MinimumLength = 0;
            this.TxtNewPassword.Name = "TxtNewPassword";
            this.TxtNewPassword.PasswordChar = '$';
            this.TxtNewPassword.Size = new System.Drawing.Size(250, 21);
            this.TxtNewPassword.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(797, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "کلمه عبور جدید";
            // 
            // TxtNewPassword2
            // 
            this.TxtNewPassword2.ExtraChar = '0';
            this.TxtNewPassword2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtNewPassword2.KeyBoardLanguage = ParsiTextBox_Control.EnKeyBoardLanguage.English;
            this.TxtNewPassword2.Location = new System.Drawing.Point(48, 108);
            this.TxtNewPassword2.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNewPassword2.MinimumLength = 0;
            this.TxtNewPassword2.Name = "TxtNewPassword2";
            this.TxtNewPassword2.PasswordChar = '$';
            this.TxtNewPassword2.Size = new System.Drawing.Size(250, 21);
            this.TxtNewPassword2.TabIndex = 5;
            // 
            // TxtCurrentPassword
            // 
            this.TxtCurrentPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCurrentPassword.ExtraChar = '0';
            this.TxtCurrentPassword.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtCurrentPassword.KeyBoardLanguage = ParsiTextBox_Control.EnKeyBoardLanguage.English;
            this.TxtCurrentPassword.Location = new System.Drawing.Point(525, 64);
            this.TxtCurrentPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCurrentPassword.MinimumLength = 0;
            this.TxtCurrentPassword.Name = "TxtCurrentPassword";
            this.TxtCurrentPassword.PasswordChar = '$';
            this.TxtCurrentPassword.Size = new System.Drawing.Size(250, 21);
            this.TxtCurrentPassword.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "تکرار کلمه عبور";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(791, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "کلمه عبور فعلی";
            // 
            // StrTxtUsername
            // 
            this.StrTxtUsername.Enabled = false;
            this.StrTxtUsername.Location = new System.Drawing.Point(44, 54);
            this.StrTxtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.StrTxtUsername.Name = "StrTxtUsername";
            this.StrTxtUsername.Size = new System.Drawing.Size(254, 26);
            this.StrTxtUsername.TabIndex = 4;
            // 
            // CmbPerson
            // 
            this.CmbPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbPerson.FormattingEnabled = true;
            this.CmbPerson.Location = new System.Drawing.Point(525, 21);
            this.CmbPerson.Margin = new System.Windows.Forms.Padding(4);
            this.CmbPerson.Name = "CmbPerson";
            this.CmbPerson.Size = new System.Drawing.Size(250, 26);
            this.CmbPerson.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 60);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "نام کاربری";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(837, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "نام شخص";
            // 
            // GrpBoxBtns
            // 
            this.GrpBoxBtns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpBoxBtns.Controls.Add(this.BtnSave);
            this.GrpBoxBtns.Controls.Add(this.BtnCancel);
            this.GrpBoxBtns.Controls.Add(this.BtnInsert);
            this.GrpBoxBtns.Location = new System.Drawing.Point(18, 282);
            this.GrpBoxBtns.Margin = new System.Windows.Forms.Padding(4);
            this.GrpBoxBtns.Name = "GrpBoxBtns";
            this.GrpBoxBtns.Padding = new System.Windows.Forms.Padding(4);
            this.GrpBoxBtns.Size = new System.Drawing.Size(930, 100);
            this.GrpBoxBtns.TabIndex = 0;
            this.GrpBoxBtns.TabStop = false;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(380, 26);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnSave.Size = new System.Drawing.Size(188, 60);
            this.BtnSave.TabIndex = 7;
            this.BtnSave.ButtonClick += new System.EventHandler(this.BtnSave_ButtonClick_1);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(44, 26);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnCancel.Size = new System.Drawing.Size(188, 60);
            this.BtnCancel.TabIndex = 8;
            this.BtnCancel.ButtonClick += new System.EventHandler(this.BtnCancel_ButtonClick_1);
            // 
            // BtnInsert
            // 
            this.BtnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnInsert.Location = new System.Drawing.Point(716, 20);
            this.BtnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnInsert.Size = new System.Drawing.Size(198, 66);
            this.BtnInsert.TabIndex = 6;
            this.BtnInsert.ButtonClick += new System.EventHandler(this.BtnInsert_ButtonClick_1);
            // 
            // GrpBoxInputs
            // 
            this.GrpBoxInputs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpBoxInputs.Controls.Add(this.TxtNewPassword);
            this.GrpBoxInputs.Controls.Add(this.label1);
            this.GrpBoxInputs.Controls.Add(this.TxtNewPassword2);
            this.GrpBoxInputs.Controls.Add(this.TxtCurrentPassword);
            this.GrpBoxInputs.Controls.Add(this.label4);
            this.GrpBoxInputs.Controls.Add(this.label3);
            this.GrpBoxInputs.Controls.Add(this.StrTxtUsername);
            this.GrpBoxInputs.Controls.Add(this.CmbPerson);
            this.GrpBoxInputs.Controls.Add(this.label5);
            this.GrpBoxInputs.Controls.Add(this.label2);
            this.GrpBoxInputs.Location = new System.Drawing.Point(18, 122);
            this.GrpBoxInputs.Margin = new System.Windows.Forms.Padding(4);
            this.GrpBoxInputs.Name = "GrpBoxInputs";
            this.GrpBoxInputs.Padding = new System.Windows.Forms.Padding(4);
            this.GrpBoxInputs.Size = new System.Drawing.Size(930, 152);
            this.GrpBoxInputs.TabIndex = 0;
            this.GrpBoxInputs.TabStop = false;
            // 
            // ChangePasswordFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 456);
            this.Controls.Add(this.GrpBoxBtns);
            this.Controls.Add(this.GrpBoxInputs);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ChangePasswordFrm";
            this.Text = "ChangePasswordFrm";
            this.Load += new System.EventHandler(this.ChangePasswordFrm_Load);
            this.Controls.SetChildIndex(this.GrpBoxInputs, 0);
            this.Controls.SetChildIndex(this.GrpBoxBtns, 0);
            this.GrpBoxBtns.ResumeLayout(false);
            this.GrpBoxInputs.ResumeLayout(false);
            this.GrpBoxInputs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ParsiTextBox_Control.ParsiTextBox TxtNewPassword;
        private System.Windows.Forms.Label label1;
        private ParsiTextBox_Control.ParsiTextBox TxtNewPassword2;
        private ParsiTextBox_Control.ParsiTextBox TxtCurrentPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private StringTextBox.StringTextBox StrTxtUsername;
        private System.Windows.Forms.ComboBox CmbPerson;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GrpBoxBtns;
        private CRUD_Buttons.SaveButtonUC BtnSave;
        private CRUD_Buttons.CancelButtonUC BtnCancel;
        private CRUD_Buttons.InsertButtonUC BtnInsert;
        private System.Windows.Forms.GroupBox GrpBoxInputs;
    }
}
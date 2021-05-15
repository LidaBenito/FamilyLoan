namespace FamilyLoan2020.UI.UIForms
{
    partial class MainFrm
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
            this.ToolStripMain = new System.Windows.Forms.ToolStrip();
            this.ToolStripBtnPeople = new System.Windows.Forms.ToolStripButton();
            this.ToolStripBtnPayment = new System.Windows.Forms.ToolStripButton();
            this.ToolStripBtnLoan = new System.Windows.Forms.ToolStripButton();
            this.ToolStripBtnSetting = new System.Windows.Forms.ToolStripButton();
            this.ToolStripBtnBank = new System.Windows.Forms.ToolStripButton();
            this.ToolStripBtnUserAccount = new System.Windows.Forms.ToolStripButton();
            this.ToolStripBtnLottary = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ToolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolStripMain
            // 
            this.ToolStripMain.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripBtnPeople,
            this.ToolStripBtnPayment,
            this.ToolStripBtnLoan,
            this.ToolStripBtnSetting,
            this.ToolStripBtnBank,
            this.ToolStripBtnLottary,
            this.ToolStripBtnUserAccount});
            this.ToolStripMain.Location = new System.Drawing.Point(0, 104);
            this.ToolStripMain.Name = "ToolStripMain";
            this.ToolStripMain.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.ToolStripMain.Size = new System.Drawing.Size(967, 93);
            this.ToolStripMain.TabIndex = 3;
            this.ToolStripMain.Text = "toolStrip1";
            // 
            // ToolStripBtnPeople
            // 
            this.ToolStripBtnPeople.Image = global::FamilyLoan2020.UI.Properties.Resources.Person_64x;
            this.ToolStripBtnPeople.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripBtnPeople.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripBtnPeople.Name = "ToolStripBtnPeople";
            this.ToolStripBtnPeople.Size = new System.Drawing.Size(114, 90);
            this.ToolStripBtnPeople.Text = "مدیریت اشخاص";
            this.ToolStripBtnPeople.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolStripBtnPeople.Click += new System.EventHandler(this.ToolStripBtnPeople_Click);
            // 
            // ToolStripBtnPayment
            // 
            this.ToolStripBtnPayment.Image = global::FamilyLoan2020.UI.Properties.Resources.Payment_64x;
            this.ToolStripBtnPayment.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripBtnPayment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripBtnPayment.Name = "ToolStripBtnPayment";
            this.ToolStripBtnPayment.Size = new System.Drawing.Size(68, 90);
            this.ToolStripBtnPayment.Text = "پرداخت";
            this.ToolStripBtnPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolStripBtnPayment.Click += new System.EventHandler(this.ToolStripBtnPayment_Click);
            // 
            // ToolStripBtnLoan
            // 
            this.ToolStripBtnLoan.Image = global::FamilyLoan2020.UI.Properties.Resources.Loan_64x;
            this.ToolStripBtnLoan.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripBtnLoan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripBtnLoan.Name = "ToolStripBtnLoan";
            this.ToolStripBtnLoan.Size = new System.Drawing.Size(68, 90);
            this.ToolStripBtnLoan.Text = "وام";
            this.ToolStripBtnLoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolStripBtnLoan.Click += new System.EventHandler(this.ToolStripBtnLoan_Click);
            // 
            // ToolStripBtnSetting
            // 
            this.ToolStripBtnSetting.Image = global::FamilyLoan2020.UI.Properties.Resources.Settings_64x;
            this.ToolStripBtnSetting.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripBtnSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripBtnSetting.Name = "ToolStripBtnSetting";
            this.ToolStripBtnSetting.Size = new System.Drawing.Size(123, 90);
            this.ToolStripBtnSetting.Text = "تنظیمات نرم افزار";
            this.ToolStripBtnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolStripBtnSetting.Click += new System.EventHandler(this.ToolStripBtnSetting_Click_1);
            // 
            // ToolStripBtnBank
            // 
            this.ToolStripBtnBank.Image = global::FamilyLoan2020.UI.Properties.Resources.PaymentBill_64x;
            this.ToolStripBtnBank.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripBtnBank.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripBtnBank.Name = "ToolStripBtnBank";
            this.ToolStripBtnBank.Size = new System.Drawing.Size(106, 90);
            this.ToolStripBtnBank.Text = "بانک و کارمزد";
            this.ToolStripBtnBank.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolStripBtnBank.Click += new System.EventHandler(this.ToolStripBtnBank_Click);
            // 
            // ToolStripBtnUserAccount
            // 
            this.ToolStripBtnUserAccount.Image = global::FamilyLoan2020.UI.Properties.Resources.UserAccount_64x;
            this.ToolStripBtnUserAccount.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripBtnUserAccount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripBtnUserAccount.Name = "ToolStripBtnUserAccount";
            this.ToolStripBtnUserAccount.Size = new System.Drawing.Size(101, 90);
            this.ToolStripBtnUserAccount.Text = "حساب کاربری";
            this.ToolStripBtnUserAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolStripBtnUserAccount.Click += new System.EventHandler(this.ToolStripBtnUserAccount_Click);
            // 
            // ToolStripBtnLottary
            // 
            this.ToolStripBtnLottary.Image = global::FamilyLoan2020.UI.Properties.Resources.Search_64x;
            this.ToolStripBtnLottary.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripBtnLottary.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripBtnLottary.Name = "ToolStripBtnLottary";
            this.ToolStripBtnLottary.Size = new System.Drawing.Size(81, 90);
            this.ToolStripBtnLottary.Text = "قرعه کشی";
            this.ToolStripBtnLottary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolStripBtnLottary.Click += new System.EventHandler(this.ToolStripBtnLottary_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::FamilyLoan2020.UI.Properties.Resources.bg;
            this.pictureBox1.Location = new System.Drawing.Point(0, 197);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(967, 245);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 492);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ToolStripMain);
            this.HeaderText = " صندوق قرض الحسنه امداد";
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimizeBox = false;
            this.Name = "MainFrm";
            this.Text = "MainFrm";
            this.Controls.SetChildIndex(this.ToolStripMain, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.ToolStripMain.ResumeLayout(false);
            this.ToolStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ToolStripMain;
        private System.Windows.Forms.ToolStripButton ToolStripBtnPeople;
        private System.Windows.Forms.ToolStripButton ToolStripBtnPayment;
        private System.Windows.Forms.ToolStripButton ToolStripBtnLoan;
        private System.Windows.Forms.ToolStripButton ToolStripBtnLottary;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripButton ToolStripBtnSetting;
        private System.Windows.Forms.ToolStripButton ToolStripBtnBank;
        private System.Windows.Forms.ToolStripButton ToolStripBtnUserAccount;
    }
}
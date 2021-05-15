namespace FamilyLoan2020.UI.UIForms
{
    partial class PaymentHomeFrm
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
            this.ToolStripBtnPaymentType = new System.Windows.Forms.ToolStripButton();
            this.ToolStripBtnPayment = new System.Windows.Forms.ToolStripButton();
            this.ToolStripBtnPaymentSearch = new System.Windows.Forms.ToolStripButton();
            this.ToolStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolStripMain
            // 
            this.ToolStripMain.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripBtnPaymentType,
            this.ToolStripBtnPayment,
            this.ToolStripBtnPaymentSearch});
            this.ToolStripMain.Location = new System.Drawing.Point(0, 104);
            this.ToolStripMain.Name = "ToolStripMain";
            this.ToolStripMain.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.ToolStripMain.Size = new System.Drawing.Size(967, 93);
            this.ToolStripMain.TabIndex = 4;
            this.ToolStripMain.Text = "toolStrip1";
            // 
            // ToolStripBtnPaymentType
            // 
            this.ToolStripBtnPaymentType.Image = global::FamilyLoan2020.UI.Properties.Resources.Payment_64x;
            this.ToolStripBtnPaymentType.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripBtnPaymentType.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripBtnPaymentType.Name = "ToolStripBtnPaymentType";
            this.ToolStripBtnPaymentType.Size = new System.Drawing.Size(89, 90);
            this.ToolStripBtnPaymentType.Text = "نوع پرداخت";
            this.ToolStripBtnPaymentType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolStripBtnPaymentType.Click += new System.EventHandler(this.ToolStripBtnPaymentType_Click);
            // 
            // ToolStripBtnPayment
            // 
            this.ToolStripBtnPayment.Image = global::FamilyLoan2020.UI.Properties.Resources.PaymentBill_64x;
            this.ToolStripBtnPayment.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripBtnPayment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripBtnPayment.Name = "ToolStripBtnPayment";
            this.ToolStripBtnPayment.Size = new System.Drawing.Size(105, 90);
            this.ToolStripBtnPayment.Text = "ثبت پرداخت ها";
            this.ToolStripBtnPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolStripBtnPayment.Click += new System.EventHandler(this.ToolStripBtnPayment_Click);
            // 
            // ToolStripBtnPaymentSearch
            // 
            this.ToolStripBtnPaymentSearch.Image = global::FamilyLoan2020.UI.Properties.Resources.Search_64x;
            this.ToolStripBtnPaymentSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripBtnPaymentSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripBtnPaymentSearch.Name = "ToolStripBtnPaymentSearch";
            this.ToolStripBtnPaymentSearch.Size = new System.Drawing.Size(141, 90);
            this.ToolStripBtnPaymentSearch.Text = "جستجوی پرداخت ها";
            this.ToolStripBtnPaymentSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolStripBtnPaymentSearch.Click += new System.EventHandler(this.ToolStripBtnPaymentSearch_Click);
            // 
            // PaymentHomeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 456);
            this.Controls.Add(this.ToolStripMain);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "PaymentHomeFrm";
            this.Text = "PaymentHomeFrm";
            this.Controls.SetChildIndex(this.ToolStripMain, 0);
            this.ToolStripMain.ResumeLayout(false);
            this.ToolStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ToolStripMain;
        private System.Windows.Forms.ToolStripButton ToolStripBtnPaymentType;
        private System.Windows.Forms.ToolStripButton ToolStripBtnPaymentSearch;
        private System.Windows.Forms.ToolStripButton ToolStripBtnPayment;
    }
}
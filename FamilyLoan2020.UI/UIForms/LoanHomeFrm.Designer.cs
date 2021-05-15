namespace FamilyLoan2020.UI.UIForms
{
    partial class LoanHomeFrm
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
            this.ToolStripBtnLoanRequest = new System.Windows.Forms.ToolStripButton();
            this.ToolStripBtnLoanRequestList = new System.Windows.Forms.ToolStripButton();
            this.ToolStripBtnLoan = new System.Windows.Forms.ToolStripButton();
            this.ToolStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolStripMain
            // 
            this.ToolStripMain.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripBtnLoanRequest,
            this.ToolStripBtnLoanRequestList,
            this.ToolStripBtnLoan});
            this.ToolStripMain.Location = new System.Drawing.Point(0, 104);
            this.ToolStripMain.Name = "ToolStripMain";
            this.ToolStripMain.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.ToolStripMain.Size = new System.Drawing.Size(967, 90);
            this.ToolStripMain.TabIndex = 4;
            this.ToolStripMain.Text = "toolStrip1";
            // 
            // ToolStripBtnLoanRequest
            // 
            this.ToolStripBtnLoanRequest.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripBtnLoanRequest.Image = global::FamilyLoan2020.UI.Properties.Resources.LoanRequest_64x;
            this.ToolStripBtnLoanRequest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripBtnLoanRequest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripBtnLoanRequest.Name = "ToolStripBtnLoanRequest";
            this.ToolStripBtnLoanRequest.Size = new System.Drawing.Size(85, 87);
            this.ToolStripBtnLoanRequest.Text = "درخواست وام";
            this.ToolStripBtnLoanRequest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolStripBtnLoanRequest.Click += new System.EventHandler(this.ToolStripBtnLoanRequest_Click);
            // 
            // ToolStripBtnLoanRequestList
            // 
            this.ToolStripBtnLoanRequestList.Image = global::FamilyLoan2020.UI.Properties.Resources.ToDoList_64x;
            this.ToolStripBtnLoanRequestList.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripBtnLoanRequestList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripBtnLoanRequestList.Name = "ToolStripBtnLoanRequestList";
            this.ToolStripBtnLoanRequestList.Size = new System.Drawing.Size(105, 83);
            this.ToolStripBtnLoanRequestList.Text = "لیست درخواست ها";
            this.ToolStripBtnLoanRequestList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolStripBtnLoanRequestList.Click += new System.EventHandler(this.ToolStripBtnLoanRequestList_Click);
            // 
            // ToolStripBtnLoan
            // 
            this.ToolStripBtnLoan.Image = global::FamilyLoan2020.UI.Properties.Resources.Loan_64x;
            this.ToolStripBtnLoan.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripBtnLoan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripBtnLoan.Name = "ToolStripBtnLoan";
            this.ToolStripBtnLoan.Size = new System.Drawing.Size(68, 83);
            this.ToolStripBtnLoan.Text = "وام";
            this.ToolStripBtnLoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolStripBtnLoan.Click += new System.EventHandler(this.ToolStripBtnLoan_Click);
            // 
            // LoanHomeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 456);
            this.Controls.Add(this.ToolStripMain);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "LoanHomeFrm";
            this.Text = "LoanFrm";
            this.Load += new System.EventHandler(this.LoanHomeFrm_Load);
            this.Controls.SetChildIndex(this.ToolStripMain, 0);
            this.ToolStripMain.ResumeLayout(false);
            this.ToolStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ToolStripMain;
        private System.Windows.Forms.ToolStripButton ToolStripBtnLoanRequest;
        private System.Windows.Forms.ToolStripButton ToolStripBtnLoanRequestList;
        private System.Windows.Forms.ToolStripButton ToolStripBtnLoan;
    }
}
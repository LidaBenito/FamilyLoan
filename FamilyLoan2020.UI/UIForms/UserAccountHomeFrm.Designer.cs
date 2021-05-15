
namespace FamilyLoan2020.UI.UIForms
{
    partial class UserAccountHomeFrm
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
            this.ToolStripBtnUser = new System.Windows.Forms.ToolStripButton();
            this.ToolStripBtnChangePassword = new System.Windows.Forms.ToolStripButton();
            this.ToolStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolStripMain
            // 
            this.ToolStripMain.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripBtnUser,
            this.ToolStripBtnChangePassword});
            this.ToolStripMain.Location = new System.Drawing.Point(0, 104);
            this.ToolStripMain.Name = "ToolStripMain";
            this.ToolStripMain.Size = new System.Drawing.Size(967, 93);
            this.ToolStripMain.TabIndex = 6;
            this.ToolStripMain.Text = "toolStrip1";
            // 
            // ToolStripBtnUser
            // 
            this.ToolStripBtnUser.Image = global::FamilyLoan2020.UI.Properties.Resources.User_64x;
            this.ToolStripBtnUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripBtnUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripBtnUser.Name = "ToolStripBtnUser";
            this.ToolStripBtnUser.Size = new System.Drawing.Size(90, 90);
            this.ToolStripBtnUser.Text = "تعریف کاربر";
            this.ToolStripBtnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolStripBtnUser.Click += new System.EventHandler(this.ToolStripBtnUser_Click);
            // 
            // ToolStripBtnChangePassword
            // 
            this.ToolStripBtnChangePassword.Image = global::FamilyLoan2020.UI.Properties.Resources.ChangePassvvord_64x;
            this.ToolStripBtnChangePassword.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripBtnChangePassword.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripBtnChangePassword.Name = "ToolStripBtnChangePassword";
            this.ToolStripBtnChangePassword.Size = new System.Drawing.Size(129, 90);
            this.ToolStripBtnChangePassword.Text = "تعویض کلمه عبور";
            this.ToolStripBtnChangePassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolStripBtnChangePassword.Click += new System.EventHandler(this.ToolStripBtnChangePassword_Click);
            // 
            // UserAccountHomeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 631);
            this.Controls.Add(this.ToolStripMain);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UserAccountHomeFrm";
            this.Text = "UserAccountHomeFrm";
            this.Controls.SetChildIndex(this.ToolStripMain, 0);
            this.ToolStripMain.ResumeLayout(false);
            this.ToolStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ToolStripMain;
        private System.Windows.Forms.ToolStripButton ToolStripBtnUser;
        private System.Windows.Forms.ToolStripButton ToolStripBtnChangePassword;
    }
}
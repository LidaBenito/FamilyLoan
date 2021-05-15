
namespace FamilyLoan2020.UI.UIForms
{
    partial class LottaryFrm
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
            this.components = new System.ComponentModel.Container();
            this.lblName = new System.Windows.Forms.Label();
            this.StopWatch = new System.Windows.Forms.Timer(this.components);
            this.LblTimer = new System.Windows.Forms.Label();
            this.BtnLottary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(494, 219);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 18);
            this.lblName.TabIndex = 1;
            // 
            // LblTimer
            // 
            this.LblTimer.AutoSize = true;
            this.LblTimer.Location = new System.Drawing.Point(494, 173);
            this.LblTimer.Name = "LblTimer";
            this.LblTimer.Size = new System.Drawing.Size(0, 18);
            this.LblTimer.TabIndex = 3;
            // 
            // BtnLottary
            // 
            this.BtnLottary.BackColor = System.Drawing.Color.DeepPink;
            this.BtnLottary.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLottary.Image = global::FamilyLoan2020.UI.Properties.Resources.favicon_32x32;
            this.BtnLottary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLottary.Location = new System.Drawing.Point(395, 317);
            this.BtnLottary.Name = "BtnLottary";
            this.BtnLottary.Size = new System.Drawing.Size(182, 47);
            this.BtnLottary.TabIndex = 4;
            this.BtnLottary.Text = "قرعه کشی";
            this.BtnLottary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLottary.UseVisualStyleBackColor = false;
            this.BtnLottary.Click += new System.EventHandler(this.BtnLottary_Click);
            // 
            // LottaryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 456);
            this.Controls.Add(this.BtnLottary);
            this.Controls.Add(this.LblTimer);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "LottaryFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LottaryFrm";
            this.Load += new System.EventHandler(this.LottaryFrm_Load);
            this.Controls.SetChildIndex(this.lblName, 0);
            this.Controls.SetChildIndex(this.LblTimer, 0);
            this.Controls.SetChildIndex(this.BtnLottary, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Timer StopWatch;
        private System.Windows.Forms.Label LblTimer;
        private System.Windows.Forms.Button BtnLottary;
    }
}
namespace CRUD_Buttons
{
    partial class ApproveButtonUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnApprove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnApprove
            // 
            this.BtnApprove.BackColor = System.Drawing.Color.Orange;
            this.BtnApprove.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnApprove.Image = global::CRUD_Buttons.Properties.Resources.Approved_32x;
            this.BtnApprove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnApprove.Location = new System.Drawing.Point(3, 3);
            this.BtnApprove.Name = "BtnApprove";
            this.BtnApprove.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnApprove.Size = new System.Drawing.Size(119, 38);
            this.BtnApprove.TabIndex = 0;
            this.BtnApprove.Text = "تایید";
            this.BtnApprove.UseVisualStyleBackColor = false;
            this.BtnApprove.Click += new System.EventHandler(this.BtnApprove_Click);
            // 
            // ApproveButtonUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnApprove);
            this.Name = "ApproveButtonUC";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(125, 43);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnApprove;
    }
}

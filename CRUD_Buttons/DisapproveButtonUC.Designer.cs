namespace CRUD_Buttons
{
    partial class DisapproveButtonUC
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
            this.BtnDisapprove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnDisapprove
            // 
            this.BtnDisapprove.BackColor = System.Drawing.Color.Orange;
            this.BtnDisapprove.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDisapprove.Image = global::CRUD_Buttons.Properties.Resources.DisApprove_32x;
            this.BtnDisapprove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDisapprove.Location = new System.Drawing.Point(3, 3);
            this.BtnDisapprove.Name = "BtnDisapprove";
            this.BtnDisapprove.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnDisapprove.Size = new System.Drawing.Size(119, 38);
            this.BtnDisapprove.TabIndex = 0;
            this.BtnDisapprove.Text = "عدم تایید";
            this.BtnDisapprove.UseVisualStyleBackColor = false;
            this.BtnDisapprove.Click += new System.EventHandler(this.BtnDisapprove_Click);
            // 
            // DisapproveButtonUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnDisapprove);
            this.Name = "DisapproveButtonUC";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(125, 43);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnDisapprove;
    }
}

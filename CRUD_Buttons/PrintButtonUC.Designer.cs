namespace CRUD_Buttons
{
    partial class PrintButtonUC
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
            this.BtnPrint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnPrint
            // 
            this.BtnPrint.BackColor = System.Drawing.Color.Orange;
            this.BtnPrint.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrint.Image = global::CRUD_Buttons.Properties.Resources.Print_32x;
            this.BtnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPrint.Location = new System.Drawing.Point(3, 3);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnPrint.Size = new System.Drawing.Size(119, 38);
            this.BtnPrint.TabIndex = 0;
            this.BtnPrint.Text = "چاپ";
            this.BtnPrint.UseVisualStyleBackColor = false;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // PrintButtonUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnPrint);
            this.Name = "PrintButtonUC";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(125, 43);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnPrint;
    }
}

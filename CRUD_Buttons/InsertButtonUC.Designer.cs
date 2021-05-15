namespace CRUD_Buttons
{
    partial class InsertButtonUC
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
            this.BtnInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnInsert
            // 
            this.BtnInsert.BackColor = System.Drawing.Color.Orange;
            this.BtnInsert.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInsert.Image = global::CRUD_Buttons.Properties.Resources.Insert_32x;
            this.BtnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInsert.Location = new System.Drawing.Point(3, 3);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnInsert.Size = new System.Drawing.Size(119, 38);
            this.BtnInsert.TabIndex = 0;
            this.BtnInsert.Text = "افزودن";
            this.BtnInsert.UseVisualStyleBackColor = false;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // InsertButtonUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnInsert);
            this.Name = "InsertButtonUC";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(125, 43);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnInsert;
    }
}

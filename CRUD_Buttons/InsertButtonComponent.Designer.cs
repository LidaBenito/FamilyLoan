namespace CRUD_Buttons
{
    partial class InsertButtonComponent
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
            // 
            // BtnInsert
            // 
            this.BtnInsert.Image = global::CRUD_Buttons.Properties.Resources.Insert_32x;
            this.BtnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnInsert.Location = new System.Drawing.Point(0, 0);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnInsert.Size = new System.Drawing.Size(75, 23);
            this.BtnInsert.TabIndex = 0;
            this.BtnInsert.Text = "افزودن";
            this.BtnInsert.UseVisualStyleBackColor = true;

        }

        #endregion

        private System.Windows.Forms.Button BtnInsert;
    }
}

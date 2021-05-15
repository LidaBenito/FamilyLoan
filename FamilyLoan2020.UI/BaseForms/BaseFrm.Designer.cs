namespace FamilyLoan2020.UI.BaseForms
{
    partial class BaseFrm
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
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.StatusStripBottom = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLblUsername = new System.Windows.Forms.ToolStripStatusLabel();
            this.TimerDisplayTime = new System.Windows.Forms.Timer(this.components);
            this.ToolStripStatusLblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnExit = new System.Windows.Forms.Button();
            this.HeaderPicBox = new System.Windows.Forms.PictureBox();
            this.HeaderPanel.SuspendLayout();
            this.StatusStripBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.HeaderPanel.Controls.Add(this.btnExit);
            this.HeaderPanel.Controls.Add(this.HeaderPicBox);
            this.HeaderPanel.Controls.Add(this.HeaderLabel);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Margin = new System.Windows.Forms.Padding(4);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(967, 104);
            this.HeaderPanel.TabIndex = 0;
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeaderLabel.Location = new System.Drawing.Point(117, 12);
            this.HeaderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(834, 78);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "فرم پایه";
            this.HeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StatusStripBottom
            // 
            this.StatusStripBottom.AutoSize = false;
            this.StatusStripBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.StatusStripBottom.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.StatusStripBottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLblDate,
            this.ToolStripStatusLblTime,
            this.ToolStripStatusLblUsername});
            this.StatusStripBottom.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.StatusStripBottom.Location = new System.Drawing.Point(0, 406);
            this.StatusStripBottom.Name = "StatusStripBottom";
            this.StatusStripBottom.Padding = new System.Windows.Forms.Padding(21, 0, 2, 0);
            this.StatusStripBottom.Size = new System.Drawing.Size(967, 50);
            this.StatusStripBottom.TabIndex = 2;
            // 
            // ToolStripStatusLblTime
            // 
            this.ToolStripStatusLblTime.AutoSize = false;
            this.ToolStripStatusLblTime.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.ToolStripStatusLblTime.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStripStatusLblTime.Name = "ToolStripStatusLblTime";
            this.ToolStripStatusLblTime.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.ToolStripStatusLblTime.Size = new System.Drawing.Size(32, 32);
            this.ToolStripStatusLblTime.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // ToolStripStatusLblUsername
            // 
            this.ToolStripStatusLblUsername.AutoSize = false;
            this.ToolStripStatusLblUsername.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.ToolStripStatusLblUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripStatusLblUsername.Name = "ToolStripStatusLblUsername";
            this.ToolStripStatusLblUsername.Size = new System.Drawing.Size(200, 32);
            this.ToolStripStatusLblUsername.Text = "toolStripStatusLabel1";
            // 
            // TimerDisplayTime
            // 
            this.TimerDisplayTime.Enabled = true;
            this.TimerDisplayTime.Interval = 60000;
            this.TimerDisplayTime.Tick += new System.EventHandler(this.TimerDisplayTime_Tick);
            // 
            // ToolStripStatusLblDate
            // 
            this.ToolStripStatusLblDate.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.ToolStripStatusLblDate.Image = global::FamilyLoan2020.UI.Properties.Resources.Date;
            this.ToolStripStatusLblDate.Name = "ToolStripStatusLblDate";
            this.ToolStripStatusLblDate.Size = new System.Drawing.Size(36, 36);
            this.ToolStripStatusLblDate.ToolTipText = "تاریخ امروز";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Image = global::FamilyLoan2020.UI.Properties.Resources.Error_32x;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.Location = new System.Drawing.Point(905, 31);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(43, 40);
            this.btnExit.TabIndex = 2;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // HeaderPicBox
            // 
            this.HeaderPicBox.Image = global::FamilyLoan2020.UI.Properties.Resources.bg;
            this.HeaderPicBox.Location = new System.Drawing.Point(14, 12);
            this.HeaderPicBox.Margin = new System.Windows.Forms.Padding(4);
            this.HeaderPicBox.Name = "HeaderPicBox";
            this.HeaderPicBox.Size = new System.Drawing.Size(88, 78);
            this.HeaderPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HeaderPicBox.TabIndex = 1;
            this.HeaderPicBox.TabStop = false;
            // 
            // BaseFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(967, 456);
            this.Controls.Add(this.StatusStripBottom);
            this.Controls.Add(this.HeaderPanel);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(983, 495);
            this.Name = "BaseFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم پایه";
            this.Load += new System.EventHandler(this.BaseFrm_Load);
            this.HeaderPanel.ResumeLayout(false);
            this.StatusStripBottom.ResumeLayout(false);
            this.StatusStripBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.PictureBox HeaderPicBox;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.StatusStrip StatusStripBottom;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLblDate;
        private System.Windows.Forms.Timer TimerDisplayTime;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLblTime;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLblUsername;
        private System.Windows.Forms.Button btnExit;
    }
}
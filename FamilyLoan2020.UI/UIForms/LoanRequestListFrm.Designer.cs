namespace FamilyLoan2020.UI.UIForms
{
    partial class LoanRequestListFrm
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
            this.GrpBoxGrid = new System.Windows.Forms.GroupBox();
            this.GGridLoanRequestList = new GenericDataGrid.GenericDataGrid();
            this.GrpBoxBtns = new System.Windows.Forms.GroupBox();
            this.BtnDisapprove = new CRUD_Buttons.DisapproveButtonUC();
            this.BtnApprove = new CRUD_Buttons.ApproveButtonUC();
            this.BtnCancel = new CRUD_Buttons.CancelButtonUC();
            this.GrpBoxGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GGridLoanRequestList)).BeginInit();
            this.GrpBoxBtns.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpBoxGrid
            // 
            this.GrpBoxGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpBoxGrid.Controls.Add(this.GGridLoanRequestList);
            this.GrpBoxGrid.Location = new System.Drawing.Point(13, 110);
            this.GrpBoxGrid.Margin = new System.Windows.Forms.Padding(4);
            this.GrpBoxGrid.Name = "GrpBoxGrid";
            this.GrpBoxGrid.Padding = new System.Windows.Forms.Padding(4);
            this.GrpBoxGrid.Size = new System.Drawing.Size(935, 385);
            this.GrpBoxGrid.TabIndex = 0;
            this.GrpBoxGrid.TabStop = false;
            // 
            // GGridLoanRequestList
            // 
            this.GGridLoanRequestList.AllowUserToAddRows = false;
            this.GGridLoanRequestList.AllowUserToDeleteRows = false;
            this.GGridLoanRequestList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GGridLoanRequestList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GGridLoanRequestList.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.GGridLoanRequestList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GGridLoanRequestList.Location = new System.Drawing.Point(8, 14);
            this.GGridLoanRequestList.Margin = new System.Windows.Forms.Padding(4);
            this.GGridLoanRequestList.Name = "GGridLoanRequestList";
            this.GGridLoanRequestList.ReadOnly = true;
            this.GGridLoanRequestList.Size = new System.Drawing.Size(919, 353);
            this.GGridLoanRequestList.TabIndex = 0;
            this.GGridLoanRequestList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GGridLoanRequestList_CellClick);
            this.GGridLoanRequestList.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GGridLoanRequestList_CellClick);
            // 
            // GrpBoxBtns
            // 
            this.GrpBoxBtns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpBoxBtns.Controls.Add(this.BtnDisapprove);
            this.GrpBoxBtns.Controls.Add(this.BtnApprove);
            this.GrpBoxBtns.Controls.Add(this.BtnCancel);
            this.GrpBoxBtns.Location = new System.Drawing.Point(13, 503);
            this.GrpBoxBtns.Margin = new System.Windows.Forms.Padding(4);
            this.GrpBoxBtns.Name = "GrpBoxBtns";
            this.GrpBoxBtns.Padding = new System.Windows.Forms.Padding(4);
            this.GrpBoxBtns.Size = new System.Drawing.Size(935, 102);
            this.GrpBoxBtns.TabIndex = 0;
            this.GrpBoxBtns.TabStop = false;
            // 
            // BtnDisapprove
            // 
            this.BtnDisapprove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDisapprove.Location = new System.Drawing.Point(431, 27);
            this.BtnDisapprove.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDisapprove.Name = "BtnDisapprove";
            this.BtnDisapprove.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnDisapprove.Size = new System.Drawing.Size(188, 60);
            this.BtnDisapprove.TabIndex = 2;
            this.BtnDisapprove.ButtonClick += new System.EventHandler(this.BtnDisapprove_ButtonClick);
            // 
            // BtnApprove
            // 
            this.BtnApprove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnApprove.Location = new System.Drawing.Point(739, 28);
            this.BtnApprove.Margin = new System.Windows.Forms.Padding(4);
            this.BtnApprove.Name = "BtnApprove";
            this.BtnApprove.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnApprove.Size = new System.Drawing.Size(188, 60);
            this.BtnApprove.TabIndex = 1;
            this.BtnApprove.ButtonClick += new System.EventHandler(this.BtnApprove_ButtonClick);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCancel.Location = new System.Drawing.Point(104, 28);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnCancel.Size = new System.Drawing.Size(188, 60);
            this.BtnCancel.TabIndex = 3;
            this.BtnCancel.ButtonClick += new System.EventHandler(this.BtnCancel_ButtonClick);
            this.BtnCancel.Load += new System.EventHandler(this.BtnCancel_Load);
            // 
            // LoanRequestListFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 684);
            this.Controls.Add(this.GrpBoxBtns);
            this.Controls.Add(this.GrpBoxGrid);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "LoanRequestListFrm";
            this.Text = "LoanRequestListFrm";
            this.Load += new System.EventHandler(this.LoanRequestListFrm_Load);
            this.Controls.SetChildIndex(this.GrpBoxGrid, 0);
            this.Controls.SetChildIndex(this.GrpBoxBtns, 0);
            this.GrpBoxGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GGridLoanRequestList)).EndInit();
            this.GrpBoxBtns.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpBoxGrid;
        private GenericDataGrid.GenericDataGrid GGridLoanRequestList;
        private System.Windows.Forms.GroupBox GrpBoxBtns;
        private CRUD_Buttons.CancelButtonUC BtnCancel;
        private CRUD_Buttons.DisapproveButtonUC BtnDisapprove;
        private CRUD_Buttons.ApproveButtonUC BtnApprove;
    }
}
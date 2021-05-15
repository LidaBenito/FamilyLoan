using System;
using System.Windows.Forms;

namespace CRUD_Buttons
{
    public partial class ApproveButtonUC : UserControl
    {
        /// <summary>
        /// رویداد کلیک
        /// </summary>
        public event EventHandler ButtonClick;
        public ApproveButtonUC()
        {
            InitializeComponent();
            BtnApprove.MouseHover += BtnApprove_MouseHover;
            BtnApprove.MouseLeave += BtnApprove_MouseLeave;
            BtnApprove.MouseEnter += BtnApprove_MouseHover;
        }

        private void BtnApprove_MouseLeave(object sender, EventArgs e)
        {
            BtnApprove.Cursor = Cursors.Default;

        }

        private void BtnApprove_MouseHover(object sender, EventArgs e)
        {
            BtnApprove.Cursor = Cursors.Hand;
        }

        private void BtnApprove_Click(object sender, EventArgs e)
        {
            this.ButtonClick?.Invoke(this, e);  
        }
    }
}

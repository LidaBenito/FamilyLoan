using System;
using System.Windows.Forms;

namespace CRUD_Buttons
{
    public partial class DisapproveButtonUC : UserControl
    {
        /// <summary>
        /// رویداد کلیک
        /// </summary>
        public event EventHandler ButtonClick;
        public DisapproveButtonUC()
        {
            InitializeComponent();
            BtnDisapprove.MouseHover += BtnDisapprove_MouseHover;
            BtnDisapprove.MouseLeave += BtnDisapprove_MouseLeave;
            BtnDisapprove.MouseEnter += BtnDisapprove_MouseHover;
        }

        private void BtnDisapprove_MouseLeave(object sender, EventArgs e)
        {
            BtnDisapprove.Cursor = Cursors.Default;

        }

        private void BtnDisapprove_MouseHover(object sender, EventArgs e)
        {
            BtnDisapprove.Cursor = Cursors.Hand;
        }

        private void BtnDisapprove_Click(object sender, EventArgs e)
        {
            this.ButtonClick?.Invoke(this, e);  
        }
    }
}

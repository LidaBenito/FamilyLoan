using System;
using System.Windows.Forms;

namespace CRUD_Buttons
{
    public partial class CancelButtonUC : UserControl
    {
        /// <summary>
        /// رویداد کلیک
        /// </summary>
        public event EventHandler ButtonClick;
        public CancelButtonUC()
        {
            InitializeComponent();
            BtnCancel.MouseHover += Btn_MouseHover;
            BtnCancel.MouseLeave += Btn_MouseLeave;
            BtnCancel.MouseEnter += Btn_MouseHover;
        }

        private void Btn_MouseLeave(object sender, EventArgs e)
        {
            BtnCancel.Cursor = Cursors.Default;
        }

        private void Btn_MouseHover(object sender, EventArgs e)
        {
            BtnCancel.Cursor = Cursors.Hand;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.ButtonClick?.Invoke(this, e);
        }
    }
}

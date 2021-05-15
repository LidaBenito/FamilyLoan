using System;
using System.Windows.Forms;

namespace CRUD_Buttons
{
    public partial class UpdateButtonUC : UserControl
    {
        /// <summary>
        /// رویداد کلیک
        /// </summary>
        public event EventHandler ButtonClick;
        public UpdateButtonUC()
        {
            InitializeComponent();
            BtnUpdate.MouseHover += Btn_MouseHover;
            BtnUpdate.MouseLeave += Btn_MouseLeave;
            BtnUpdate.MouseEnter += Btn_MouseHover;
        }

        private void Btn_MouseLeave(object sender, EventArgs e)
        {
            BtnUpdate.Cursor = Cursors.Default;

        }

        private void Btn_MouseHover(object sender, EventArgs e)
        {
            BtnUpdate.Cursor = Cursors.Hand;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            this.ButtonClick?.Invoke(this, e);

        }
    }
}

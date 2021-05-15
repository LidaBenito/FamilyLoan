using System;
using System.Windows.Forms;

namespace CRUD_Buttons
{
    public partial class PrintButtonUC : UserControl
    {
        /// <summary>
        /// رویداد کلیک
        /// </summary>
        public event EventHandler ButtonClick;
        public PrintButtonUC()
        {
            InitializeComponent();
            BtnPrint.MouseHover += Btn_MouseHover;
            BtnPrint.MouseLeave += Btn_MouseLeave;
            BtnPrint.MouseEnter += Btn_MouseHover;
        }

        private void Btn_MouseLeave(object sender, EventArgs e)
        {
            BtnPrint.Cursor = Cursors.Default;

        }

        private void Btn_MouseHover(object sender, EventArgs e)
        {
            BtnPrint.Cursor = Cursors.Hand;
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            this.ButtonClick?.Invoke(this, e);

        }
    }
}

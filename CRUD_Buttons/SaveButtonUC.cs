using System;
using System.Windows.Forms;

namespace CRUD_Buttons
{
    public partial class SaveButtonUC : UserControl
    {
        /// <summary>
        /// رویداد کلیک
        /// </summary>
        public event EventHandler ButtonClick;
        public SaveButtonUC()
        {
            InitializeComponent();
            BtnSave.MouseHover += Btn_MouseHover;
            BtnSave.MouseLeave += Btn_MouseLeave;
            BtnSave.MouseEnter += Btn_MouseHover;
        }

        private void Btn_MouseLeave(object sender, EventArgs e)
        {
            BtnSave.Cursor = Cursors.Default;

        }

        private void Btn_MouseHover(object sender, EventArgs e)
        {
            BtnSave.Cursor = Cursors.Hand;
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            this.ButtonClick?.Invoke(this, e);

        }
    }
}

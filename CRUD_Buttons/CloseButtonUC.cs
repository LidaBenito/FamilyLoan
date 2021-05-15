using Sadr_Tools.Utility;
using System;
using System.Windows.Forms;

namespace CRUD_Buttons
{
    public partial class CloseButtonUC : UserControl
    {
        /// <summary>
        /// رویداد کلیک
        /// </summary>
        public event EventHandler ButtonClick;
        public CloseButtonUC()
        {
            InitializeComponent();
            BtnClose.MouseHover += Btn_MouseHover;
            BtnClose.MouseLeave += Btn_MouseLeave;
            BtnClose.MouseEnter += Btn_MouseHover;
        }

        private void Btn_MouseLeave(object sender, EventArgs e)
        {
            BtnClose.Cursor = Cursors.Default;
        }

        private void Btn_MouseHover(object sender, EventArgs e)
        {
            BtnClose.Cursor = Cursors.Hand;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            if (FarsiBox.AskQuestion("آیا از بسته شدن فرم مطمئن هستید؟", "بستن فرم") == DialogResult.Yes)
                this.ButtonClick?.Invoke(this, e);
        }
    }
}

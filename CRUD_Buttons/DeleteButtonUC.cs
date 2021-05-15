using System;
using System.Windows.Forms;
using Sadr_Tools.Utility;

namespace CRUD_Buttons
{
    public partial class DeleteButtonUC : UserControl
    {
        /// <summary>
        /// رویداد کلیک
        /// </summary>
        public event EventHandler ButtonClick;
        public DeleteButtonUC()
        {
            InitializeComponent();
            BtnDelete.MouseHover += Btn_MouseHover;
            BtnDelete.MouseLeave += Btn_MouseLeave;
            BtnDelete.MouseEnter += Btn_MouseHover;
        }

        private void Btn_MouseLeave(object sender, EventArgs e)
        {
            BtnDelete.Cursor = Cursors.Default;

        }

        private void Btn_MouseHover(object sender, EventArgs e)
        {
            BtnDelete.Cursor = Cursors.Hand;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (FarsiBox.AskQuestion("آیا از حذف رکورد جاری مطمئن هستید؟", "حذف رکورد") == DialogResult.Yes)
                this.ButtonClick?.Invoke(this, e);
        }
    }
}

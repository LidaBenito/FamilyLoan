using System;
using System.Windows.Forms;

namespace CRUD_Buttons
{
    public partial class InsertButtonUC : UserControl
    {
        /// <summary>
        /// رویداد کلیک
        /// </summary>
        public event EventHandler ButtonClick;
        public InsertButtonUC()
        {
            InitializeComponent();
            BtnInsert.MouseHover += BtnInsert_MouseHover;
            BtnInsert.MouseLeave += BtnInsert_MouseLeave;
            BtnInsert.MouseEnter += BtnInsert_MouseHover;


        }

        private void BtnInsert_MouseLeave(object sender, EventArgs e)
        {
            BtnInsert.Cursor = Cursors.Default;

        }

        private void BtnInsert_MouseHover(object sender, EventArgs e)
        {
            BtnInsert.Cursor = Cursors.Hand;
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            this.ButtonClick?.Invoke(this, e);
        }
    }
}

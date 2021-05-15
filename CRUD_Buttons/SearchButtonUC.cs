using System;
using System.Windows.Forms;

namespace CRUD_Buttons
{
    public partial class SearchButtonUC : UserControl
    {
        /// <summary>
        /// رویداد کلیک
        /// </summary>
        public event EventHandler ButtonClick;
        public SearchButtonUC()
        {
            InitializeComponent();
            BtnSearch.MouseHover += Btn_MouseHover;
            BtnSearch.MouseLeave += Btn_MouseLeave;
            BtnSearch.MouseEnter += Btn_MouseHover;
        }

        private void Btn_MouseLeave(object sender, EventArgs e)
        {
            BtnSearch.Cursor = Cursors.Default;
        }

        private void Btn_MouseHover(object sender, EventArgs e)
        {
            BtnSearch.Cursor = Cursors.Hand;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            this.ButtonClick?.Invoke(this, e);
        }
    }
}

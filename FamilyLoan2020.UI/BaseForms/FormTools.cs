using System.Drawing;
using System.Windows.Forms;

namespace FamilyLoan2020.UI.BaseForms
{
    public static class FormTools
    {
        /// <summary>
        /// نمایش فرم
        /// </summary>
        /// <param name="sender">فرستنده</param>
        /// <param name="frm">آبجتی از فرم پایه</param>
        /// <param name="color">رنگ</param>
        /// <param name="bitmap">تصویر</param>
        public static void DisplayForm(object sender, BaseFrm frm, Color color, Bitmap bitmap)
        {
            frm.Text = (sender as ToolStripButton).Text;
            frm.HeaderText = (sender as ToolStripButton).Text;
            frm.HeaderColor = color;
            frm.HeaderImage = bitmap;
            frm.Show();

        }
        public static string ExeDirectory 
        {
            get 
            {
                return System.IO.Directory.GetCurrentDirectory();

            }
        }
    }
}

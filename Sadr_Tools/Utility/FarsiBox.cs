using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sadr_Tools.Utility
{
    /// <summary>
    /// باکس فارسی
    /// </summary>
    public class FarsiBox
    {
        private static Font AFont { get; set; }
        private static Form AForm { get; set; }
        private static Label ALabel { get; set; }
        private static Button BtnOK { get; set; }
        private static Button BtnCancel { get; set; }
        private static PictureBox PicBox { get; set; }

        static FarsiBox()
        {
            AFont = new Font("Tahoma", 8F);
        }

     
        /// <summary>
        /// نمایش جمله خبری
        /// </summary>
        /// <param name="title">جمله</param>
        /// <param name="caption">تیتر</param>
        /// <param name="isError">آیا خطا است؟</param>
        public static void ShowInformation(string title, string caption = "اطلاعات" , bool isError=false)
        {
            AForm = new Form();
            ALabel = new Label();
            BtnOK = new Button();
            PicBox = new PictureBox();

            Bitmap bitmap = isError ? Sadr_Tools.Properties.Resources.Error_32x : Sadr_Tools.Properties.Resources.Information_32x;

            BtnOK.MouseHover += (s, e) =>
            {
                BtnOK.Cursor = Cursors.Hand;
            };

            AForm.Font = AFont;
            AForm.RightToLeft = RightToLeft.Yes;
            AForm.RightToLeftLayout = true;
            AForm.Text = caption;
            AForm.TopMost = true;

            ALabel.Text = title;

            BtnOK.Text = "تایید";

            BtnOK.TextAlign = ContentAlignment.MiddleCenter;
            BtnOK.DialogResult = DialogResult.OK;

            BtnOK.Image = Sadr_Tools.Properties.Resources.OK;
            BtnOK.ImageAlign = ContentAlignment.MiddleLeft;

            ALabel.SetBounds(45, 20, 372, 13);
            PicBox.SetBounds(12, 10, 32, 32);
            BtnOK.SetBounds(100, 55, 100, 25);

            PicBox.Image = bitmap;

            ALabel.AutoSize = true;

            BtnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AForm.ClientSize = new Size(396, 90);
            AForm.Controls.AddRange(new Control[] { ALabel, BtnOK, PicBox });
            AForm.ClientSize = new Size(Math.Max(300, ALabel.Right + 10), AForm.ClientSize.Height);
            AForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            AForm.StartPosition = FormStartPosition.CenterScreen;
            AForm.MinimizeBox = false;
            AForm.MaximizeBox = false;
            AForm.AcceptButton = BtnOK;

            DialogResult dialogResult = AForm.ShowDialog();

        }

        /// <summary>
        /// نمایش جمله سوالی
        /// </summary>
        /// <param name="title">جمله</param>
        /// <param name="caption">تیتر</param>
        public static DialogResult AskQuestion(string title, string caption = "سوال")
        {
            AForm = new Form();
            ALabel = new Label();
            BtnOK = new Button();
            BtnCancel = new Button();
            PicBox = new PictureBox();

            BtnOK.MouseHover += (s, e) =>
            {
                BtnOK.Cursor = Cursors.Hand;
            };

            BtnOK.Click += (s, e) =>
            {
                AForm.DialogResult = DialogResult.Yes;
            };

            BtnCancel.MouseHover += (s, e) =>
            {
                BtnCancel.Cursor = Cursors.Hand;
            };


            BtnCancel.Click += (s, e) =>
            {
                AForm.DialogResult = DialogResult.No;
            };

            AForm.Font = AFont;
            AForm.RightToLeft = RightToLeft.Yes;
            AForm.RightToLeftLayout = true;
            AForm.Text = caption;
            AForm.TopMost = true;

            ALabel.Text = title;


            BtnOK.Text = "بلی";
            BtnCancel.Text = "خیر";


            BtnOK.TextAlign = BtnCancel.TextAlign = ContentAlignment.MiddleCenter;
          

            BtnOK.Image = Sadr_Tools.Properties.Resources.OK;
            BtnCancel.Image = Sadr_Tools.Properties.Resources.Cancel;

            BtnOK.ImageAlign = BtnCancel.ImageAlign = ContentAlignment.MiddleLeft;



            ALabel.SetBounds(45, 20, 372, 13);
            PicBox.SetBounds(12, 10, 32, 32);
            BtnOK.SetBounds(150, 55, 80, 25);
            BtnCancel.SetBounds(150, 55, 80, 25);

            PicBox.Image = Sadr_Tools.Properties.Resources.Question_32x;

            ALabel.AutoSize = true;

            BtnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AForm.ClientSize = new Size(396, 90);
            AForm.Controls.AddRange(new Control[] { ALabel, BtnOK, BtnCancel, PicBox });
            AForm.ClientSize = new Size(Math.Max(300, ALabel.Right + 10), AForm.ClientSize.Height);
            AForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            AForm.StartPosition = FormStartPosition.CenterScreen;
            AForm.MinimizeBox = false;
            AForm.MaximizeBox = false;
            AForm.AcceptButton = BtnOK;

            DialogResult dialogResult = AForm.ShowDialog();

            return dialogResult;
        }
    }
}
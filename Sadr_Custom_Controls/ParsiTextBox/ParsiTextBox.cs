using Sadr_Tools.ExtensionMethods;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ParsiTextBox_Control
{
    public class ParsiTextBox : TextBox
    {
        public EnKeyBoardLanguage KeyBoardLanguage { get; set; }
        public char ExtraChar { get; set; } = '0';

        private int _minimumLength = 0;
        public int MinimumLength
        {
            get
            {
                return this._minimumLength;
            }
            set
            {
                if (value < 0)
                    value = 0;
                this._minimumLength = value;
            }
        }

        public ParsiTextBox()
        {
            this.KeyBoardLanguage = EnKeyBoardLanguage.Persian;
            this.Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 178);
        }



        private string ArabicToParsi(string str)
        {
            if (!str.IsNullOrEmpty())
                str = str.Replace('ي', 'ی').Replace('ك', 'ک');

            return str;
        }

        #region [ Overrided Properties/Methods ]
        public override string Text
        {
            get
            {
                return this.ArabicToParsi(base.Text);
            }
            set
            {
                base.Text = this.ArabicToParsi(value);
            }
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {

            if (!DesignMode)
            {
                if (e.KeyChar == 'A')
                {
                    SendKeys.Send("1");
                    e.Handled = true;
                }

                if (e.KeyChar == 'B')
                {
                    e.Handled = true;
                    SendKeys.Send("2");
                }

                if (e.KeyChar == 'C')
                {
                    e.Handled = true;
                    SendKeys.Send("3");
                    base.OnKeyPress(e);
                }

                if (e.KeyChar == 'D')
                {
                    base.OnKeyPress(e);
                    e.Handled = true;
                    SendKeys.Send("4");
                }

                if (e.KeyChar == 'ي' || e.KeyChar == 1610)
                {
                    e.Handled = true;
                    string s = Convert.ToChar(1740).ToString();
                    SendKeys.Send(s);
                }
                if (e.KeyChar == 'ك' || e.KeyChar == 1603)
                {
                    SendKeys.Send(Convert.ToChar(1705).ToString());
                    e.Handled = true;
                }
            }
        }

        public static string ToPersianText(string str)
        {
            string result = null;

            foreach (char c in str)
            {
                int ascii = c;
                switch (ascii)
                {
                    case 1577:
                        result = $"{result}{((char)1578)}";
                        break;

                    case 1610:
                        result = $"{result}{((char)1740)}";
                        break;

                    case 1603:
                        result = $"{result}{((char)1705)}";
                        break;

                    default:
                        result = $"{result}{((char)ascii)}";
                        break;
                }
            }

            return result;
        }



        protected override void OnEnter(EventArgs e)
        {
            if (!DesignMode)
            {
                base.OnEnter(e);
                if (KeyBoardLanguage == EnKeyBoardLanguage.Persian)
                    ParsiTextBox_Control.KeyBoardLanguageSetting.SetParsi();

                if (KeyBoardLanguage == EnKeyBoardLanguage.English)
                    ParsiTextBox_Control.KeyBoardLanguageSetting.SetEnglish();
            }
        }

        protected override void OnLeave(EventArgs e)
        {
            if (this._minimumLength > 0)
                for (int i = 0; i < _minimumLength; i++)
                    if (base.Text.Length > 0 && base.Text.Length < _minimumLength)
                        base.Text = $"{ExtraChar}{base.Text}";
                    else
                        break;
            base.OnLeave(e);
        }
        #endregion
    }
}

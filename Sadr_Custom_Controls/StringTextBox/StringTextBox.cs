using System;
using System.Windows.Forms;

namespace StringTextBox
{
    public class StringTextBox : TextBox
    {
        public StringTextBox()
        {
            this.KeyPress += StringTextBox_KeyPress;
        }

        private void StringTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}

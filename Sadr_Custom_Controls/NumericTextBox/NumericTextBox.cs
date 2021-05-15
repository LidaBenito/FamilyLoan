using System;
using System.Windows.Forms;
using Sadr_Tools.ExtensionMethods;

namespace NumericTextBox
{
    public class NumericTextBox : TextBox
    {

        public bool ApplyThousandSeprator { get; set; } = false;

        public NumericTextBox()
        {
            this.KeyPress += NumericTextBox_KeyPress;

        }

        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);

            if (ApplyThousandSeprator && !this.Text.IsNullOrEmpty())
            {
                this.Text = this.Text.ExtractNumber().ThousandSeprator();
                this.Select(this.Text.Length, 0);
            }
        }
    }
}

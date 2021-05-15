using Sadr_Tools.ExtensionMethods;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sadr_Tools.Utility
{
    public static class FormMethods
    {
        public static SizeF StringWidth(Form form, string str, Font font)
        {
            System.IntPtr T;
            if (form == null)
                T = (System.IntPtr)null;
            else
                T = form.Handle;

            System.Drawing.Graphics graphics = System.Drawing.Graphics.FromHwnd(T);
            return graphics.MeasureString(str, font);
        }

        public static void CheckFloatValue(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (((TextBox)sender).Text.IndexOf('.') > -1 && e.KeyChar == '.')
                return;

            char[] arr = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '.', (char)8 };
            foreach (char c in arr)
            {
                if (e.KeyChar == c)
                {
                    e.Handled = false;
                    return;
                }
            }
        }

        public static void CheckIntValue(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            char[] arr = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', (char)8 };
            foreach (char c in arr)
            {
                if (e.KeyChar == c)
                {
                    e.Handled = false;
                    return;
                }
            }
        }

        public static void DateValidation(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)(int)Keys.Space) && (!((TextBox)sender).ReadOnly))
            {
                e.Handled = true;
                if (sender is TextBox)
                    ((TextBox)sender).Text = (DateTime.Now.ToPersianDate());
            }
            e.Handled = true;
            char[] arr = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '/', (char)8 };
            foreach (char c in arr)
            {
                if (e.KeyChar == c)
                {
                    e.Handled = false;
                    return;
                }
            }
        }

        public static Control FindComponents(Control control, string controlName)
        {
            Control result = null;
            for (int i = 0; i < control.Controls.Count; i++)
                if (control.Controls[i].Name == controlName)
                {
                    result = control.Controls[i];
                    break;
                }
                else
                {
                    if (control.Controls[i].Controls.Count > 0)
                    {
                        result = FindComponents(control.Controls[i], controlName);
                        if (result != null)
                            break;
                    }
                }
            return result;
        }

        public static void SetControlEnabledAll(Control AParent, bool Writable)
        {
            for (int i = 0; i <= AParent.Controls.Count - 1; i++)
            {
                if (AParent.Controls[i].Controls.Count != 0)
                    SetControlEnabledAll(AParent.Controls[i], Writable);
                if (AParent.Controls[i] is TextBox)
                    ((TextBox)(AParent.Controls[i])).ReadOnly = !Writable;
                else
                    if (AParent.Controls[i] is CheckBox)
                    ((CheckBox)(AParent.Controls[i])).Enabled = Writable;
                else
                        if (AParent.Controls[i] is ComboBox)
                    ((ComboBox)(AParent.Controls[i])).Enabled = Writable;
                else
                            if (AParent.Controls[i] is Button)
                    ((Button)(AParent.Controls[i])).Enabled = Writable;
                else
                                if (AParent.Controls[i] is DataGrid)
                    ((DataGrid)(AParent.Controls[i])).ReadOnly = !Writable;
            }
        }

        public static void SetControlEnabled(Control AParent, bool Writable)
        {
            for (int i = 0; i <= AParent.Controls.Count - 1; i++)
            {
                if (AParent.Controls[i] is TextBox)
                    ((TextBox)(AParent.Controls[i])).ReadOnly = !Writable;
                else
                    if (AParent.Controls[i] is CheckBox)
                    ((CheckBox)(AParent.Controls[i])).Enabled = Writable;
                else
                        if (AParent.Controls[i] is ComboBox)
                    ((ComboBox)(AParent.Controls[i])).Enabled = Writable;
                else
                            if (AParent.Controls[i] is Button)
                    ((Button)(AParent.Controls[i])).Enabled = Writable;
                else
                                if (AParent.Controls[i] is DataGrid)
                    ((DataGrid)(AParent.Controls[i])).ReadOnly = !Writable;
            }
        }

        public static Form ControlFindForm(Control AControl)
        {
            Control MyControl = AControl.Parent;
            Form Result = null;
            while (MyControl != null && !(MyControl is Form))
            {
                MyControl = MyControl.Parent;
            }
            if (MyControl != null && MyControl is Form)
                Result = MyControl as Form;
            return Result;
        }

        public static SizeF StringWidth(Form form, Font font, string str)
        {
            System.IntPtr T;
            if (form == null)
                T = (System.IntPtr)null;
            else
                T = form.Handle;

            System.Drawing.Graphics graphics = System.Drawing.Graphics.FromHwnd(T);
            return graphics.MeasureString(str, font);
        }

        public static void SetFontForm(Control AParent, FontFamily AFontFamoly)
        {

            AParent.Font = new Font(AFontFamoly, AParent.Font.Size);
            foreach (Control AControl in AParent.Controls)
            {
                SetFontForm(AControl, AFontFamoly);
            }


        }

    }
}

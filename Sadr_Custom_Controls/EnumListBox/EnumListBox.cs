using System;
using System.Collections;
using System.Windows.Forms;


namespace EnumListBox
{
    public class EnumListBox : ListBox
    {
        private System.ComponentModel.IContainer _components;
        private Enum _enumObject;
        private ArrayList _selectedObjects;

        public EnumListBox()
        {
            this._selectedObjects = new ArrayList();
            this.InitializeComponent();
        }

        public Enum EnumObject
        {
            get
            {
                return this._enumObject;
            }
            set
            {
                if (value != null)
                {
                    this._enumObject = value;
                    this.FillCombo();
                }
            }
        }

        private void FillCombo()
        {
            Type TT = this._enumObject.GetType();
            object EnumObj = Activator.CreateInstance(TT);
            this.Items.Clear();
            object o = new object();
            foreach (int i in Enum.GetValues(EnumObj.GetType()))
            {
                o = Enum.ToObject(EnumObj.GetType(), i);
                this.Items.Add(o);
            }
        }

        /// <summary>
        /// موارد انتخاب شده با حذف _
        /// </summary>
        public ArrayList SelectedObjects
        {
            get
            {
                this._selectedObjects = new ArrayList();
                foreach (var item in this.SelectedItems)
                {
                    this._selectedObjects.Add(item.ToString().Replace("_", " "));
                }

                return _selectedObjects;
            }
        }

        private void InitializeComponent()
        {
            this._components = new System.ComponentModel.Container();
            this.SuspendLayout();

            // 
            // EnumListBox
            // 
            this.Size = new System.Drawing.Size(120, 95);
            this.ResumeLayout(false);

        }
    }
}

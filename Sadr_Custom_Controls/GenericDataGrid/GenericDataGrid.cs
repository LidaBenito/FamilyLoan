using FamilyLoan2020.Models.Abstract;
using Sadr_Tools.ExtensionMethods;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GenericDataGrid
{
    /// <summary>
    /// شخصی سازی شده برای پروژه صندوق وام
    /// </summary>
    public class GenericDataGrid : DataGridView
    {
        public GenericDataGrid()
        {
            if (!DesignMode)
            {
                this.CellClick += GenericDataGrid_CellClick;
                this.CellEnter += GenericDataGrid_CellClick;
                this.AllowUserToAddRows = false;
                this.AllowUserToDeleteRows = false;
            }
        }

        private object TempObj { get; set; }

        public object SelectedRow { get; private set; }


        /// <summary>
        /// موجودیت انتخاب شده
        /// </summary>
        public Type SelectedType { get; private set; }

        /// <summary>
        /// دیتاسورس گرید در قالب آی لیست
        /// </summary>
        public IList DataSourceList
        {
            get
            {
                return this.DataSource as IList;
            }
        }

        private void GenericDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var x = (TempObj as BaseEntityCode);

            if (x != null)
            {
                SelectedType = TempObj.GetType();
                SelectedRow = DataSourceList[e.RowIndex];
                return;
            }

            var x2 = (TempObj as BaseEntityIdentity);
            if (x2 != null)
            {
                SelectedType = TempObj.GetType();
                SelectedRow = DataSourceList[e.RowIndex];
                return;
            }
        }

        public void FillGrid<T>(IList<T> lst)
        {
            this.AutoGenerateColumns = false;
            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.Columns.Clear();

            var obj = (((T)Activator.CreateInstance(typeof(T))) as BaseEntity);

            var PropertyHeaderList = obj.PropertyHeaderList;
            DataGridViewColumn col;
            foreach (PropertyHeader item in PropertyHeaderList)
            {
                if (item.IsImage)
                {
                    col = new DataGridViewImageColumn();
                    (col as DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Zoom;
                }
                else
                {
                    col = new DataGridViewTextBoxColumn();
                }

                col.Name = item.Name;
                col.HeaderText = item.HeaderText;
                col.DataPropertyName = item.Name;
                col.Width = item.ColWidth;


                if (item.ApplyThousandSeprator)
                    col.DefaultCellStyle.Format = "N0";

                this.Columns.Add(col);
            }

            IEnumerable<T> result = lst.Cast<T>();
            List<T> list = result.ToList();
            this.DataSource = list;
            if (list.Count > 0)
                TempObj = list[0];
        }
    }
}

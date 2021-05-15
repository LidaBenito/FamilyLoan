using Sadr_Tools.ExtensionMethods;
using System.Collections;
using System.Data;
using System.Reflection;
using System.Windows.Forms;

namespace Sadr_Tools.Utility
{
    public static class GridMethods
    {

        #region [ Base Object ]
        /*
        public static object GetCell(Form AForm, DataGrid Grid)
        {
            return GetCell(AForm, Grid, false);
        }

        public static object GetCell(System.Windows.Forms.Form AForm, System.Windows.Forms.DataGrid Grid, bool ForceSysID)
        {
            DataGridCell myDataGridCell = Grid.CurrentCell;
            BindingManagerBase bm = AForm.BindingContext[Grid.DataSource, Grid.DataMember];
            IBaseObject AObject;
            object Result = null;
            try
            {
                AObject = (IBaseObject)bm.Current;
                if (AObject is INaturalBaseObject && !ForceSysID)
                {
                    Result = (AObject as INaturalBaseObject).NaturalCodeProperty.GetValue(AObject, null);
                }
                else
                    Result = AObject.ID;
            }
            catch
            {
                Result = CommonConst.InvalidObject;
            }

            return Result;
        }

        public static IBaseObject GetCellBaseObject(System.Windows.Forms.Form AForm, System.Windows.Forms.DataGrid Grid)
        {
            DataGridCell myDataGridCell = Grid.CurrentCell;
            BindingManagerBase bm = AForm.BindingContext[Grid.DataSource, Grid.DataMember];
            IBaseObject Result = null;
            try
            {
                Result = (IBaseObject)bm.Current;
            }
            catch
            {
                Result = null;
            }

            return Result;
        }

        public static object GetCellObject(System.Windows.Forms.Form AForm, System.Windows.Forms.DataGrid Grid, string MapName)
        {
            BindingManagerBase bm = AForm.BindingContext[Grid.DataSource, Grid.DataMember];
            IBaseObject drv;
            object Result = null;
            try
            {
                drv = (IBaseObject)bm.Current;
                foreach (PropertyInfo item in drv.PropertyInfos)
                {
                    if (item.Name == MapName)
                    {
                        Result = item.GetValue(drv, null);
                    }
                }
            }
            catch
            {
                return null;
            }

            return Result;
        }
        */
        #endregion

        public static string GetCell(Form form, DataGrid grid, string keyNames)
        {
            // DataGridCell myDataGridCell = grid.CurrentCell;
            BindingManagerBase bm = form.BindingContext[grid.DataSource, grid.DataMember];
            DataRowView drv;
            try
            {
                drv = (DataRowView)bm.Current;
            }
            catch
            {
                return null;
            }
            int ColNo = 0;
            ArrayList KeyList = keyNames.Split(';').ToArrayList();

            string Result = "";
            for (int K = 0; K < KeyList.Count; K++)
            {
                string KeyName = KeyList[K].ToString();
                for (int i = 0; i < grid.TableStyles[0].GridColumnStyles.Count; i++)
                {
                    if (grid.TableStyles[0].GridColumnStyles[i].MappingName == KeyName)
                    {
                        ColNo = i;
                        break;
                    }
                }
                Result += ";" + drv[ColNo].ToString();
            }
            if (Result.Length != 0)
                Result = Result.Remove(0, 1);
            return Result;
        }

        public static object GetCellObjectProperty(Form AForm, DataGrid Grid, string PropertyName)
        {
            // DataGridCell myDataGridCell = Grid.CurrentCell;
            BindingManagerBase bm = AForm.BindingContext[Grid.DataSource, Grid.DataMember];
            object AObject;
            object Result = null;
            try
            {
                AObject = bm.Current;
                System.Type myTypeA = AObject.GetType();
                PropertyInfo[] myPropertyInfo = myTypeA.GetProperties();
                foreach (PropertyInfo PropI in myPropertyInfo)
                {
                    if (PropI.Name == PropertyName)
                    {
                        Result = PropI.GetValue(AObject, null);
                        break;
                    }
                }
            }
            catch
            {
                Result = CommonConsts.Messages.Exception.InvalidObject;
            }

            return Result;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Data.Filtering;

namespace DXSample {
    public class MyGridControl : GridControl
    {
        protected override BaseView CreateDefaultView()
        {
            return CreateView("MyGridView");
        }
        protected override void RegisterAvailableViewsCore(InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new MyGridViewInfoRegistrator());
        }
    }
    public class MyGridViewInfoRegistrator : GridInfoRegistrator
    {
        public override string ViewName { get { return "MyGridView"; } }
        public override BaseView CreateView(GridControl grid) { return new MyGridView(grid as GridControl); }
    }
    public class MyGridView : GridView
    {
        public MyGridView() : this(null) { }
        public MyGridView(DevExpress.XtraGrid.GridControl grid) : base(grid) { }

        protected override string ViewName { get { return "MyGridView"; } }

        protected override DevExpress.Data.Filtering.CriteriaOperator CreateAutoFilterCriterion(DevExpress.XtraGrid.Columns.GridColumn column, DevExpress.XtraGrid.Columns.AutoFilterCondition condition, object _value, string strVal)
        {
            if (column.ColumnType == typeof(DateTime) && strVal.Length > 0)
            {
                BinaryOperatorType type = BinaryOperatorType.Equal;
                string operand = string.Empty;
                if (strVal.Length > 1)
                {
                    operand = strVal.Substring(0, 2);
                    if (operand.Equals(">="))
                        type = BinaryOperatorType.GreaterOrEqual;
                    else if (operand.Equals("<="))
                        type = BinaryOperatorType.LessOrEqual;
                }
                if (type == BinaryOperatorType.Equal)
                {
                    operand = strVal.Substring(0, 1);
                    if (operand.Equals(">"))
                        type = BinaryOperatorType.Greater;
                    else if (operand.Equals("<"))
                        type = BinaryOperatorType.Less;
                }
                if (type != BinaryOperatorType.Equal)
                {

                    string val = strVal.Replace(operand, string.Empty);
                    try
                    {
                        DateTime dt = DateTime.ParseExact(val, "d", column.RealColumnEdit.EditFormat.Format);
                        return new BinaryOperator(column.FieldName, dt, type);
                    }
                    catch
                    {
                        return null;
                    }
                }
            }
            return base.CreateAutoFilterCriterion(column, condition, _value, strVal);
        }
    }
}
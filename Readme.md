<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128624310/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3148)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WinForms Data Grid - Implement new filter options in the Auto Filter Row

This example creates a custom grid control (`MyGridControl`) to introduce new filter options. Users can use the following operands to filter DateTime values in columns using the Auto Filter Row: "<", ">", ">=", "<=".

See the implementation of the `GridView.CreateAutoFilterCriterion` method:

```csharp
protected override DevExpress.Data.Filtering.CriteriaOperator CreateAutoFilterCriterion(DevExpress.XtraGrid.Columns.GridColumn column, DevExpress.XtraGrid.Columns.AutoFilterCondition condition, object _value, string strVal) {
    if (column.ColumnType == typeof(DateTime) && strVal.Length > 0) {
        BinaryOperatorType type = BinaryOperatorType.Equal;
        string operand = string.Empty;
        if (strVal.Length > 1) {
            operand = strVal.Substring(0, 2);
            if (operand.Equals(">="))
                type = BinaryOperatorType.GreaterOrEqual;
            else if (operand.Equals("<="))
                type = BinaryOperatorType.LessOrEqual;
        }
        if (type == BinaryOperatorType.Equal) {
            operand = strVal.Substring(0, 1);
            if (operand.Equals(">"))
                type = BinaryOperatorType.Greater;
            else if (operand.Equals("<"))
                type = BinaryOperatorType.Less;
        }
        if (type != BinaryOperatorType.Equal) {
            string val = strVal.Replace(operand, string.Empty);
            try {
                DateTime dt = DateTime.ParseExact(val, "d", column.RealColumnEdit.EditFormat.Format);
                return new BinaryOperator(column.FieldName, dt, type);
            }
            catch {
                return null;
            }
        }
    }
    return base.CreateAutoFilterCriterion(column, condition, _value, strVal);
}
```


## Files to Review

* [CustomGrid.cs](./CS/WindowsApplication3/CustomGrid.cs) (VB: [CustomGrid.vb](./VB/WindowsApplication3/CustomGrid.vb))


## Documentation

* [Filter and Search](https://docs.devexpress.com/WindowsForms/114635/controls-and-libraries/data-grid/filter-and-search)


## See Also

* [Examples: Filtering Records](https://docs.devexpress.com/WindowsForms/3014/controls-and-libraries/data-grid/examples/filtering/examples-filtering-records)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-introduce-custom-options-in-auto-filter-row&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-introduce-custom-options-in-auto-filter-row&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->

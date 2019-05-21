Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.Skins
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Registrator
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Data.Filtering

Namespace DXSample
	Public Class MyGridControl
		Inherits GridControl

		Protected Overrides Function CreateDefaultView() As BaseView
			Return CreateView("MyGridView")
		End Function
		Protected Overrides Sub RegisterAvailableViewsCore(ByVal collection As InfoCollection)
			MyBase.RegisterAvailableViewsCore(collection)
			collection.Add(New MyGridViewInfoRegistrator())
		End Sub
	End Class
	Public Class MyGridViewInfoRegistrator
		Inherits GridInfoRegistrator

		Public Overrides ReadOnly Property ViewName() As String
			Get
				Return "MyGridView"
			End Get
		End Property
		Public Overrides Function CreateView(ByVal grid As GridControl) As BaseView
			Return New MyGridView(TryCast(grid, GridControl))
		End Function
	End Class
	Public Class MyGridView
		Inherits GridView

		Public Sub New()
			Me.New(Nothing)
		End Sub
		Public Sub New(ByVal grid As DevExpress.XtraGrid.GridControl)
			MyBase.New(grid)
		End Sub

		Protected Overrides ReadOnly Property ViewName() As String
			Get
				Return "MyGridView"
			End Get
		End Property

		Protected Overrides Function CreateAutoFilterCriterion(ByVal column As DevExpress.XtraGrid.Columns.GridColumn, ByVal condition As DevExpress.XtraGrid.Columns.AutoFilterCondition, ByVal _value As Object, ByVal strVal As String) As DevExpress.Data.Filtering.CriteriaOperator
			If column.ColumnType Is GetType(Date) AndAlso strVal.Length > 0 Then
				Dim type As BinaryOperatorType = BinaryOperatorType.Equal
				Dim operand As String = String.Empty
				If strVal.Length > 1 Then
					operand = strVal.Substring(0, 2)
					If operand.Equals(">=") Then
						type = BinaryOperatorType.GreaterOrEqual
					ElseIf operand.Equals("<=") Then
						type = BinaryOperatorType.LessOrEqual
					End If
				End If
				If type = BinaryOperatorType.Equal Then
					operand = strVal.Substring(0, 1)
					If operand.Equals(">") Then
						type = BinaryOperatorType.Greater
					ElseIf operand.Equals("<") Then
						type = BinaryOperatorType.Less
					End If
				End If
				If type <> BinaryOperatorType.Equal Then

					Dim val As String = strVal.Replace(operand, String.Empty)
					Try
						Dim dt As Date = Date.ParseExact(val, "d", column.RealColumnEdit.EditFormat.Format)
						Return New BinaryOperator(column.FieldName, dt, type)
					Catch
						Return Nothing
					End Try
				End If
			End If
			Return MyBase.CreateAutoFilterCriterion(column, condition, _value, strVal)
		End Function
	End Class
End Namespace
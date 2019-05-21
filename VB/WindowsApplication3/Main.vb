Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Globalization
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid

Namespace DXSample
	Partial Public Class Main
		Inherits XtraForm

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub OnFormLoad(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			myGridControl1.DataSource = DataHelper.CreateTable()
		End Sub
	End Class
End Namespace

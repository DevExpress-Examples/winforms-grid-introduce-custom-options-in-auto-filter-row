Namespace DXSample
	Partial Public Class Main
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
			Me.myGridControl1 = New DXSample.MyGridControl()
			Me.myGridView1 = New DXSample.MyGridView()
			Me.colOrderID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colOrderDate = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colRequiredDate = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colShipVia = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colFreight = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colShipCity = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.myGridView2 = New DXSample.MyGridView()
			CType(Me.myGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' defaultLookAndFeel1
			' 
			Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Blue"
			' 
			' myGridControl1
			' 
			Me.myGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.myGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.myGridControl1.MainView = Me.myGridView1
			Me.myGridControl1.Name = "myGridControl1"
			Me.myGridControl1.Size = New System.Drawing.Size(846, 531)
			Me.myGridControl1.TabIndex = 0
			Me.myGridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.myGridView1, Me.myGridView2})
			' 
			' myGridView1
			' 
			Me.myGridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colOrderID, Me.colOrderDate, Me.colRequiredDate, Me.colShipVia, Me.colFreight, Me.colShipCity})
			Me.myGridView1.GridControl = Me.myGridControl1
			Me.myGridView1.Name = "myGridView1"
			Me.myGridView1.OptionsView.ShowAutoFilterRow = True
			' 
			' colOrderID
			' 
			Me.colOrderID.FieldName = "OrderID"
			Me.colOrderID.Name = "colOrderID"
			Me.colOrderID.Visible = True
			Me.colOrderID.VisibleIndex = 0
			' 
			' colOrderDate
			' 
			Me.colOrderDate.FieldName = "OrderDate"
			Me.colOrderDate.Name = "colOrderDate"
			Me.colOrderDate.Visible = True
			Me.colOrderDate.VisibleIndex = 1
			' 
			' colRequiredDate
			' 
			Me.colRequiredDate.FieldName = "RequiredDate"
			Me.colRequiredDate.Name = "colRequiredDate"
			Me.colRequiredDate.Visible = True
			Me.colRequiredDate.VisibleIndex = 2
			' 
			' colShipVia
			' 
			Me.colShipVia.FieldName = "ShipVia"
			Me.colShipVia.Name = "colShipVia"
			Me.colShipVia.Visible = True
			Me.colShipVia.VisibleIndex = 3
			' 
			' colFreight
			' 
			Me.colFreight.FieldName = "Freight"
			Me.colFreight.Name = "colFreight"
			Me.colFreight.Visible = True
			Me.colFreight.VisibleIndex = 4
			' 
			' colShipCity
			' 
			Me.colShipCity.FieldName = "ShipCity"
			Me.colShipCity.Name = "colShipCity"
			Me.colShipCity.Visible = True
			Me.colShipCity.VisibleIndex = 5
			' 
			' myGridView2
			' 
			Me.myGridView2.GridControl = Me.myGridControl1
			Me.myGridView2.Name = "myGridView2"
			' 
			' Main
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(846, 531)
			Me.Controls.Add(Me.myGridControl1)
			Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
			Me.Name = "Main"
			Me.Text = "Custom Auto Row Filter"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.Load += new System.EventHandler(this.OnFormLoad);
			CType(Me.myGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myGridView2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
		Private myGridControl1 As MyGridControl
		Private myGridView1 As MyGridView
		Private myGridView2 As MyGridView
		Private colOrderID As DevExpress.XtraGrid.Columns.GridColumn
		Private colOrderDate As DevExpress.XtraGrid.Columns.GridColumn
		Private colRequiredDate As DevExpress.XtraGrid.Columns.GridColumn
		Private colShipVia As DevExpress.XtraGrid.Columns.GridColumn
		Private colFreight As DevExpress.XtraGrid.Columns.GridColumn
		Private colShipCity As DevExpress.XtraGrid.Columns.GridColumn
	End Class
End Namespace


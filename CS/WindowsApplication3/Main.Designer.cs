namespace DXSample {
    partial class Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.myGridControl1 = new DXSample.MyGridControl();
            this.myGridView1 = new DXSample.MyGridView();
            this.colOrderID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRequiredDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShipVia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFreight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShipCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.myGridView2 = new DXSample.MyGridView();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Blue";
            // 
            // myGridControl1
            // 
            this.myGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myGridControl1.Location = new System.Drawing.Point(0, 0);
            this.myGridControl1.MainView = this.myGridView1;
            this.myGridControl1.Name = "myGridControl1";
            this.myGridControl1.Size = new System.Drawing.Size(846, 531);
            this.myGridControl1.TabIndex = 0;
            this.myGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.myGridView1,
            this.myGridView2});
            // 
            // myGridView1
            // 
            this.myGridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOrderID,
            this.colOrderDate,
            this.colRequiredDate,
            this.colShipVia,
            this.colFreight,
            this.colShipCity});
            this.myGridView1.GridControl = this.myGridControl1;
            this.myGridView1.Name = "myGridView1";
            this.myGridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colOrderID
            // 
            this.colOrderID.FieldName = "OrderID";
            this.colOrderID.Name = "colOrderID";
            this.colOrderID.Visible = true;
            this.colOrderID.VisibleIndex = 0;
            // 
            // colOrderDate
            // 
            this.colOrderDate.FieldName = "OrderDate";
            this.colOrderDate.Name = "colOrderDate";
            this.colOrderDate.Visible = true;
            this.colOrderDate.VisibleIndex = 1;
            // 
            // colRequiredDate
            // 
            this.colRequiredDate.FieldName = "RequiredDate";
            this.colRequiredDate.Name = "colRequiredDate";
            this.colRequiredDate.Visible = true;
            this.colRequiredDate.VisibleIndex = 2;
            // 
            // colShipVia
            // 
            this.colShipVia.FieldName = "ShipVia";
            this.colShipVia.Name = "colShipVia";
            this.colShipVia.Visible = true;
            this.colShipVia.VisibleIndex = 3;
            // 
            // colFreight
            // 
            this.colFreight.FieldName = "Freight";
            this.colFreight.Name = "colFreight";
            this.colFreight.Visible = true;
            this.colFreight.VisibleIndex = 4;
            // 
            // colShipCity
            // 
            this.colShipCity.FieldName = "ShipCity";
            this.colShipCity.Name = "colShipCity";
            this.colShipCity.Visible = true;
            this.colShipCity.VisibleIndex = 5;
            // 
            // myGridView2
            // 
            this.myGridView2.GridControl = this.myGridControl1;
            this.myGridView2.Name = "myGridView2";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 531);
            this.Controls.Add(this.myGridControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.Text = "Custom Auto Row Filter";
            this.Load += new System.EventHandler(this.OnFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private MyGridControl myGridControl1;
        private MyGridView myGridView1;
        private MyGridView myGridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderID;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderDate;
        private DevExpress.XtraGrid.Columns.GridColumn colRequiredDate;
        private DevExpress.XtraGrid.Columns.GridColumn colShipVia;
        private DevExpress.XtraGrid.Columns.GridColumn colFreight;
        private DevExpress.XtraGrid.Columns.GridColumn colShipCity;
    }
}


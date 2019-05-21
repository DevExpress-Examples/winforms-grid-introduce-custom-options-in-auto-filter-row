using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace DXSample {
    public partial class Main: XtraForm {
        public Main() {
            InitializeComponent();
        }
       
        private void OnFormLoad(object sender, EventArgs e) {
            myGridControl1.DataSource = DataHelper.CreateTable();
        }
    }
}

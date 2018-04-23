using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;
// ...

namespace ConditionallyHideSeriesLabels {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'gspDataSet.GSP' table.
            // You can move, or remove it, as needed.
            this.gSPTableAdapter.Fill(this.gspDataSet.GSP);
        }

        private void chartControl1_CustomDrawSeriesPoint(object sender, CustomDrawSeriesPointEventArgs e) {
            // If the value is less than 1, hide the point's label.
            if(e.SeriesPoint[0] < 1) {
                e.LabelText = "";
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace TransposeXRTable {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            XtraReport1 rep = new XtraReport1();
            rep.ShowPreviewDialog();
        }

        private void button2_Click(object sender, EventArgs e) {
            XtraReport2 rep = new XtraReport2();
            rep.ShowPreviewDialog();
        }

        private void button3_Click(object sender, EventArgs e) {
            XtraReport3 rep = new XtraReport3();
            rep.ShowPreviewDialog();
        }

        
    }
}
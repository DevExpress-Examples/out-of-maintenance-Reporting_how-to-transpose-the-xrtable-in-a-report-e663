using System.Drawing;
using DevExpress.XtraReports.UI;
using System.Data;
using System.IO;

namespace TransposeXRTable {
    public partial class XtraReport2 : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport2() {
            InitializeComponent();
        }
        
        int rp = 0;
        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {

            DevExpress.Data.Browsing.DataBrowser db = this.fDataContext[this.DataSource, this.DataMember];
            if(db.Position * 5 < db.Count) {
                db.Position = rp * 5;
                int prevpos = -1;

                for(int i = 0; i < 5; i++) {

                    if((db.Current != null) && prevpos != db.Position) {
                        DataRowView dr = db.Current as DataRowView;
                        this.xrTable1.Rows[0].Cells[i + 1].Text = dr[0].ToString();
                        this.xrTable1.Rows[1].Cells[i + 1].Text = dr[1].ToString();
                        this.xrTable1.Rows[2].Cells[i + 1].Text = dr[2].ToString();
                        byte[] byte_Picture = (byte[])dr[3];
                        MemoryStream stream_Picture = new MemoryStream(byte_Picture);
                        ((XRPictureBox)this.xrTable1.Rows[3].Cells[i + 1].Controls[0]).Image = Image.FromStream(stream_Picture);

                    }
                    else {
                        this.xrTable1.Rows[0].Cells[i + 1].Visible = false;
                        this.xrTable1.Rows[1].Cells[i + 1].Visible = false;
                        this.xrTable1.Rows[2].Cells[i + 1].Visible = false;
                        this.xrTable1.Rows[3].Cells[i + 1].Visible = false;

                    }
                    prevpos = db.Position;
                    db.Position++;
                }

                rp++;
            }
            else {
                e.Cancel = true;
            }
        }
    }
}

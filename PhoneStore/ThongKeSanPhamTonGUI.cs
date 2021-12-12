using System;
using System.Windows.Forms;

namespace PhoneStore
{
    public partial class ThongKeSanPhamTonGUI : Form
    {
        public ThongKeSanPhamTonGUI()
        {
            InitializeComponent();
        }

        private void ThongKeSanPhamTonGUI_Load(object sender, EventArgs e)
        {
            ThongKeSanPhamTonReport rpt = new ThongKeSanPhamTonReport();

            crystalReportViewer1.ReportSource = rpt;
            rpt.SetDatabaseLogon("sa", "123", "KIKKDT", "dbPhoneStore");
            crystalReportViewer1.Refresh();
        }
    }
}
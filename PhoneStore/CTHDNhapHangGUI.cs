using System;
using System.Windows.Forms;

namespace PhoneStore
{
    public partial class CTHDNhapHangGUI : Form
    {
        private int _maHDNH;
        private string _hoTen;
        private DateTime _ngayLap;

        public CTHDNhapHangGUI(int maHDNH, string hoTen, DateTime ngayLap)
        {
            InitializeComponent();
            this._maHDNH = maHDNH;
            this._hoTen = hoTen;
            this._ngayLap = ngayLap;
        }

        private void CTHDNhapHangGUI_Load(object sender, EventArgs e)
        {
            CTHDNhapHangReport rpt = new CTHDNhapHangReport();

            rpt.SetParameterValue("MaHDNH", _maHDNH);
            rpt.SetParameterValue("HoTen", _hoTen);
            rpt.SetParameterValue("NgayLap", _ngayLap);

            crystalReportViewer1.ReportSource = rpt;
            rpt.SetDatabaseLogon("sa", "123", "KIKKDT", "dbPhoneStore");
            crystalReportViewer1.Refresh();
        }
    }
}
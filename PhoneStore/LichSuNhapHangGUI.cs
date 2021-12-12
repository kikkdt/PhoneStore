using PhoneStore.DAO;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PhoneStore
{
    public partial class LichSuNhapHangGUI : Form
    {
        private HDNhapHangDAO _hdNhapHang = new HDNhapHangDAO();

        public LichSuNhapHangGUI()
        {
            InitializeComponent();
            LoadDgViewHdNhapHang();
            AddLinkColumn();
            datePickerFrom.MaxDate = DateTime.Now;
            datePickerFrom.Value = DateTime.Now;
            datePickerTo.MaxDate = DateTime.Now;
            datePickerTo.Value = DateTime.Now;
        }

        #region Prepare data

        private void LoadDgViewHdNhapHang()
        {
            try
            {
                DataTable dt = _hdNhapHang.GetLichSuHDNhapHang();
                if (dt is null) return;
                dgViewHDNhapHang.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDgViewHdNhapHang(DateTime from, DateTime to)
        {
            try
            {
                DataTable dt = _hdNhapHang.GetLichSuHDNhapHang(from, to);
                if (dt is null) return;
                dgViewHDNhapHang.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddLinkColumn()
        {
            DataGridViewLinkColumn links = new DataGridViewLinkColumn
            {
                UseColumnTextForLinkValue = true,
                HeaderText = "Action",
                DataPropertyName = "Action",
                ActiveLinkColor = Color.White,
                LinkBehavior = LinkBehavior.SystemDefault,
                LinkColor = Color.Blue,
                TrackVisitedState = true,
                VisitedLinkColor = Color.YellowGreen,
                Text = "Xem chi tiết"
            };

            dgViewHDNhapHang.Columns.Add(links);
        }

        #endregion Prepare data

        #region Handle event

        private void BtnXem_Click(object sender, EventArgs e)
        {
            DateTime from = new DateTime(datePickerFrom.Value.Ticks);
            DateTime to = new DateTime(datePickerTo.Value.Ticks);
            to = to.AddHours(23).AddMinutes(59).AddSeconds(59);
            LoadDgViewHdNhapHang(from, to);
        }

        private void DgViewHDNhapHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) // Click on "Xem chi tiết" column
            {
                DataGridViewRow row = dgViewHDNhapHang.Rows[e.RowIndex];
                int maHdnh = int.Parse(row.Cells["MaHDNH"].Value.ToString());
                string hoTen = row.Cells["HoTen"].Value.ToString();
                DateTime ngayLap = DateTime.Parse(row.Cells["NgayLap"].Value.ToString());
                CTHDNhapHangGUI rpt = new CTHDNhapHangGUI(maHdnh, hoTen, ngayLap);
                rpt.Show();
            }
        }

        #endregion Handle event
    }
}
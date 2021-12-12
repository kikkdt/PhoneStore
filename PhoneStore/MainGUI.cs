using PhoneStore.DAO;
using PhoneStore.DTO;
using System;
using System.Windows.Forms;

namespace PhoneStore
{
    public partial class MainGUI : Form
    {
        public MainGUI(TaiKhoanDTO taiKhoan)
        {
            InitializeComponent();
            TaiKhoan = taiKhoan;
            lblHello.Text = "Xin chào, " + new NhanVienDAO().GetNhanVien(taiKhoan.Username).HoTen;
            if (TaiKhoan.ChucVu == 2) // User is "Nhân viên"
                quanLySanPhamtoolStripMenuItem.Enabled =
                    quanLyNhanVientoolStripMenuItem.Enabled =
                        btnQuanLySanPham.Enabled = btnQuanLyNhanVien.Enabled = false;
        }

        public static TaiKhoanDTO TaiKhoan { get; set; }

        private void QuanLySanPhamtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmSanPham = new QLSanPhamGUI();
            if (ActiveMdiChild is not null)
                ActiveMdiChild.Close();
            pnlHome.Visible = false;
            frmSanPham.MdiParent = this;
            frmSanPham.Dock = DockStyle.Fill;
            frmSanPham.FormBorderStyle = FormBorderStyle.None;
            frmSanPham.ControlBox = false;
            frmSanPham.Show();
        }

        private void NhapHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmNhapHang = new QLNhapHangGUI();
            if (ActiveMdiChild is not null)
                ActiveMdiChild.Close();
            pnlHome.Visible = false;
            frmNhapHang.MdiParent = this;
            frmNhapHang.Dock = DockStyle.Fill;
            frmNhapHang.FormBorderStyle = FormBorderStyle.None;
            frmNhapHang.ControlBox = false;
            frmNhapHang.Show();
        }

        private void LichSuNhapHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmLichSuNhapHang = new LichSuNhapHangGUI();
            frmLichSuNhapHang.ShowDialog();
        }

        private void QuanLyNhanVientoolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmNhanVienGui = new QLNhanVienGUI();
            if (ActiveMdiChild is not null)
                ActiveMdiChild.Close();
            pnlHome.Visible = false;
            frmNhanVienGui.MdiParent = this;
            frmNhanVienGui.Dock = DockStyle.Fill;
            frmNhanVienGui.FormBorderStyle = FormBorderStyle.None;
            frmNhanVienGui.ControlBox = false;
            frmNhanVienGui.Show();
        }

        private void SanPhamTonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmThongKe = new ThongKeSanPhamTonGUI();
            pnlHome.Visible = false;
            frmThongKe.Show();
        }

        private void ThayDoiMatKhauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmDoiMatKhau = new DoiMatKhauGUI();
            frmDoiMatKhau.ShowDialog();
        }

        private void DangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmDangNhap = new DangNhapGUI();
            frmDangNhap.Show();
            frmDangNhap.FormClosing += delegate { Close(); };
            Hide();
        }

        private void HomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild is not null)
                ActiveMdiChild.Close();
            pnlHome.Visible = true;
        }

        private void BtnQuanLySanPham_Click(object sender, EventArgs e)
        {
            quanLySanPhamtoolStripMenuItem.PerformClick();
        }

        private void BtnNhapHang_Click(object sender, EventArgs e)
        {
            nhapHangToolStripMenuItem.PerformClick();
        }

        private void BtnLichSuNhapHang_Click(object sender, EventArgs e)
        {
            lichSuNhapHangToolStripMenuItem.PerformClick();
        }

        private void BtnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            quanLyNhanVientoolStripMenuItem.PerformClick();
        }

        private void BtnThongKeTon_Click(object sender, EventArgs e)
        {
            sanPhamTonToolStripMenuItem.PerformClick();
        }

        private void BtnDoiMatKhau_Click(object sender, EventArgs e)
        {
            thayDoiMatKhauToolStripMenuItem.PerformClick();
        }

        private void BtnDangXuat_Click(object sender, EventArgs e)
        {
            dangXuatToolStripMenuItem.PerformClick();
        }
    }
}
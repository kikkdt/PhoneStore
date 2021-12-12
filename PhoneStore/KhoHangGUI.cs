using PhoneStore.DAO;
using PhoneStore.DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace PhoneStore
{
    public partial class KhoHangGUI : Form
    {
        private SanPhamDTO _sanPham;
        private CTHDNhapHangDTO _cthdNhap;
        private KhoHangDAO _khoHang = new KhoHangDAO();

        public KhoHangGUI(SanPhamDTO sanPham, CTHDNhapHangDTO cthdNhap)
        {
            _cthdNhap = cthdNhap;
            _sanPham = sanPham;
            InitializeComponent();
            txtSanPham.Text = this._sanPham.TenSP;
            txtGiaNhap.Text = string.Format("{0:C}", this._cthdNhap.GiaNhap);
            txtSanPham.Enabled = txtGiaNhap.Enabled = false;
            LoadDgViewKhoHang();
        }

        public KhoHangGUI(SanPhamDTO sanPham, CTHDNhapHangDTO cthdNhap, DataTable dt)
        {
            _cthdNhap = cthdNhap;
            _sanPham = sanPham;
            InitializeComponent();
            txtSanPham.Text = this._sanPham.TenSP;
            txtGiaNhap.Text = this._cthdNhap.GiaNhap.ToString();
            txtSanPham.Enabled = txtGiaNhap.Enabled = false;
            LoadDgViewKhoHang(dt);
        }

        #region Prepare data

        private DataTable _dt;

        private void LoadDgViewKhoHang()
        {
            try
            {
                _dt = new DataTable("tb_KhoHang");
                _dt.Columns.Add("MaCTHDNhap");
                _dt.Columns.Add("IMEI");
                _dt.Columns.Add("TrangThai");
                dgViewKhoHang.DataSource = _dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDgViewKhoHang(DataTable dt)
        {
            try
            {
                dgViewKhoHang.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion Prepare data

        #region Handle event

        private void DgViewKhoHang_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["MaCTHDNhap"].Value = _cthdNhap.ID;
            e.Row.Cells["TrangThai"].Value = false;
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            _dt = (DataTable)dgViewKhoHang.DataSource;
            if (new KhoHangDAO().Update(_dt) > 0)
            {
                btnLuu.Tag = "saved";
                MessageBox.Show("Nhập kho thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Nhập kho thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                try
                {
                    new CTHDNhapHangDAO().Delete(_cthdNhap.ID);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DgViewKhoHang_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string headerText =
                dgViewKhoHang.Columns[e.ColumnIndex].HeaderText;

            // Abort validation if cell is not in the IMEI column.
            if (!headerText.Equals("IMEI")) return;

            // Confirm that the cell is not exist.
            if (_khoHang.IsExistIMEI(e.FormattedValue.ToString()) || e.FormattedValue.ToString().Length > 15)
            {
                dgViewKhoHang.Rows[e.RowIndex].ErrorText =
                    "IMEI không được trùng và độ dài tối đa 15 ký tự.";
                e.Cancel = true;
            }
        }

        private void KhoHangGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btnLuu.Tag is not null) return;

            // Display a MsgBox asking the user to save changes or abort.
            DialogResult choosen = MessageBox.Show("Bạn chưa hoàn tất kho hàng của mình, lưu trước khi thoát?", "Xác nhận thoát", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (choosen == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else if (choosen == DialogResult.No)
            {
                try
                {
                    new CTHDNhapHangDAO().Delete(_cthdNhap.ID);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                btnLuu.PerformClick();
            }
        }

        #endregion Handle event
    }
}
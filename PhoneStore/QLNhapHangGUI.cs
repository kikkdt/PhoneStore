using PhoneStore.DAO;
using PhoneStore.DTO;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PhoneStore
{
    public partial class QLNhapHangGUI : Form
    {
        private HDNhapHangDTO _hdNhapHang;
        private SanPhamDAO _sanPham = new SanPhamDAO();
        private CTHDNhapHangDAO _cthdNhapHang = new CTHDNhapHangDAO();
        private bool _isInsert = false;

        public QLNhapHangGUI()
        {
            InitializeComponent();
            LoadHdNhapHang();
            LoadCboSanPham();
            LoadCthdNhapHang();
            AddLinkColumn();
            EnableAllTextbox(false);
            panelSaveCancel.Visible = false;
            btnSua.Enabled = btnXoa.Enabled = false;
        }

        #region Prepare data

        private void LoadHdNhapHang()
        {
            try
            {
                DateTime now = new DateTime(DateTime.Now.Ticks);
                NhanVienDTO nhanVien = new NhanVienDAO().GetNhanVien(MainGUI.TaiKhoan.Username);
                if (nhanVien is not null)
                {
                    HDNhapHangDAO hdnhDao = new HDNhapHangDAO();
                    if (hdnhDao.Insert(new HDNhapHangDTO(nhanVien.MaNV, now)) > 0)
                    {
                        _hdNhapHang = hdnhDao.GetHDNhapHang(nhanVien.MaNV, now);
                        txtMaHDNH.Text = _hdNhapHang.MaHDNH.ToString();
                        txtNgayLap.Text = _hdNhapHang.NgayLap.ToString();
                        txtMaNV.Text = _hdNhapHang.MaNV.ToString();
                        txtTenNV.Text = nhanVien.HoTen;
                    }
                    else
                    {
                        MessageBox.Show("Tạo hoá đơn nhập hàng thất bại.", "Lỗi", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên hợp lệ.", "Lỗi", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCthdNhapHang()
        {
            try
            {
                DataTable dt = _cthdNhapHang.GetCthdNhapHang(_hdNhapHang.MaHDNH);
                if (dt is null) return;
                dgViewCTHDNhapHang.DataSource = dt;
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
                Text = "Nhập kho"
            };

            dgViewCTHDNhapHang.Columns.Add(links);
        }

        private void LoadCboSanPham()
        {
            DataTable dt = _sanPham.Dset.Tables["tb_SanPham"];
            if (dt is null) return;

            cboSanPham.DataSource = dt;
            cboSanPham.DisplayMember = "TenSP";
            cboSanPham.ValueMember = "ID";
            cboSanPham.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboSanPham.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void EnableAllTextbox(bool isEnable)
        {
            txtMaHDNH.Enabled = txtNgayLap.Enabled = txtMaNV.Enabled = txtTenNV.Enabled =
                cboSanPham.Enabled = numGiaNhap.Enabled = isEnable;
        }

        #endregion Prepare data

        #region Validate

        private bool ValidateForm()
        {
            return NumGiaNhap_Validating();
        }

        private bool NumGiaNhap_Validating()
        {
            if (numGiaNhap.Value == 0)
            {
                errorProvider1.SetError(lblGiaNhap, "Nhập giá nhập sản phẩm.");
                return false;
            }
            else
            {
                errorProvider1.SetError(lblGiaNhap, "");
                return true;
            }
        }

        #endregion Validate

        #region Handle event

        private void TableLayoutPanel3_Leave(object sender, EventArgs e)
        {
            btnHuy.PerformClick();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            panelSaveCancel.Visible = true;
            numGiaNhap.Value = 0;
            cboSanPham.SelectedIndex = 0;
            cboSanPham.Enabled = numGiaNhap.Enabled = true;
            _isInsert = true;
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            var rowsSelected = dgViewCTHDNhapHang.SelectedRows;
            if (rowsSelected.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 dòng cần xoá.", "Lỗi", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else // Is valid
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xoá " + rowsSelected.Count + " CTHD nhập hàng?", "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;

                int countSuccess = 0;
                for (int i = 0; i < rowsSelected.Count; i++)
                {
                    int maCthdNhap = (int)rowsSelected[i].Cells["ID"].Value;
                    if (new KhoHangDAO().Delete(maCthdNhap) > 0)
                    {
                        if (new CTHDNhapHangDAO().Delete(maCthdNhap) > 0)
                            countSuccess++;
                    }
                    else
                    {
                        MessageBox.Show("Xoá thất bại.", "Lỗi", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }

                MessageBox.Show("Xoá thành công " + countSuccess + "/" + rowsSelected.Count + " CTHĐ nhập hàng.", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                LoadCthdNhapHang();
                EnableAllTextbox(false);
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (_rowSelected is null)
            {
                MessageBox.Show("Vui lòng chọn 1 sản phẩm cần sửa.", "Lỗi", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                EnableAllTextbox(false);
                numGiaNhap.Enabled = true;
                panelSaveCancel.Visible = true;
                numGiaNhap.Focus();
                _isInsert = false;
            }
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            AutoValidate = AutoValidate.Disable;
            CausesValidation = false;
            panelSaveCancel.Visible = false;
            EnableAllTextbox(false);
            errorProvider1.Clear();
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các trường thông tin bắt buộc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (_isInsert)
                {
                    int rowAffected = _cthdNhapHang.Insert(new CTHDNhapHangDTO(_hdNhapHang.MaHDNH,
                        (int)cboSanPham.SelectedValue, (double)numGiaNhap.Value, 0));
                    if (rowAffected > 0)
                    {
                        CTHDNhapHangDTO cthdNhapTmp = _cthdNhapHang.GetCthdNhapHang(_hdNhapHang.MaHDNH,
                            (int)cboSanPham.SelectedValue);

                        KhoHangGUI khoHang = new KhoHangGUI(_sanPham.GetSanPham((int)cboSanPham.SelectedValue), cthdNhapTmp);
                        khoHang.FormBorderStyle = FormBorderStyle.FixedDialog;
                        khoHang.MinimizeBox = false;
                        khoHang.MaximizeBox = false;
                        khoHang.ShowDialog(this);
                        LoadCthdNhapHang();
                        btnHuy.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Thêm CTHĐ nhập hàng thất bại.", "Lỗi", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else // Update
                {
                    int id = (int)_rowSelected.Cells["ID"].Value;
                    int rowAffected = _cthdNhapHang.Update(new CTHDNhapHangDTO(id, _hdNhapHang.MaHDNH,
                        (int)cboSanPham.SelectedValue, (double)numGiaNhap.Value, (int)_rowSelected.Cells["SoLuong"].Value));
                    if (rowAffected > 0)
                    {
                        MessageBox.Show("Cập nhật CTHĐ nhập hàng thành công.", "Thông báo", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật CTHĐ nhập hàng thất bại.", "Lỗi", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadCthdNhapHang();
        }

        private void DgViewCTHDNhapHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) // Click on "Action" column
            {
                DataTable dt = new KhoHangDAO().GetKhoHang((int)dgViewCTHDNhapHang.Rows[e.RowIndex].Cells["ID"].Value);
                SanPhamDTO sanPham = this._sanPham.GetSanPham((int)dgViewCTHDNhapHang.Rows[e.RowIndex].Cells["MaSP"].Value);
                CTHDNhapHangDTO cthdNhap =
                    _cthdNhapHang.GetCthdNhapHangById((int)dgViewCTHDNhapHang.Rows[e.RowIndex].Cells["ID"].Value);

                KhoHangGUI khoHang = new KhoHangGUI(sanPham, cthdNhap, dt);
                khoHang.FormBorderStyle = FormBorderStyle.FixedDialog;
                khoHang.MinimizeBox = false;
                khoHang.MaximizeBox = false;
                khoHang.ShowDialog(this);
                LoadCthdNhapHang();
                btnHuy.PerformClick();
            }
        }

        private DataGridViewRow _rowSelected = null;

        private void DgViewCTHDNhapHang_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            if (e.StateChanged == DataGridViewElementStates.Selected)
            {
                if (dgViewCTHDNhapHang.SelectedCells.Count == 0) return;

                _rowSelected = dgViewCTHDNhapHang.Rows[dgViewCTHDNhapHang.SelectedCells[0].RowIndex];
                cboSanPham.SelectedValue = _rowSelected.Cells["MaSP"].Value;
                numGiaNhap.Value = decimal.Parse(_rowSelected.Cells["GiaNhap"].Value.ToString());
                btnXoa.Enabled = btnSua.Enabled = true;
            }
        }

        private void DgViewCTHDNhapHang_SelectionChanged(object sender, EventArgs e)
        {
            int rowsCount = dgViewCTHDNhapHang.SelectedRows.Count;
            if (rowsCount == 0) return;

            _rowSelected = dgViewCTHDNhapHang.Rows[dgViewCTHDNhapHang.SelectedCells[0].RowIndex];
            cboSanPham.SelectedValue = _rowSelected.Cells["MaSP"].Value.ToString();
            numGiaNhap.Value = decimal.Parse(_rowSelected.Cells["GiaNhap"].Value.ToString());
            btnXoa.Enabled = btnSua.Enabled = true;
        }

        private void DgViewCTHDNhapHang_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = dgViewCTHDNhapHang.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0) // Show context menu
                {
                    dgViewCTHDNhapHang.ClearSelection();
                    dgViewCTHDNhapHang.Rows[currentMouseOverRow].Selected = true;
                    contextMenuStrip1.Show(dgViewCTHDNhapHang, new Point(e.X, e.Y));
                }
            }
        }

        private void ToolStripMenuItemSua_Click(object sender, EventArgs e)
        {
            btnSua.PerformClick();
        }

        private void ToolStripMenuItemXoa_Click(object sender, EventArgs e)
        {
            btnXoa.PerformClick();
        }

        #endregion Handle event
    }
}
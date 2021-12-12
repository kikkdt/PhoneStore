using PhoneStore.DAO;
using PhoneStore.DTO;
using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PhoneStore
{
    public partial class QLNhanVienGUI : Form
    {
        private NhanVienDAO _nhanVien = new NhanVienDAO();
        private TaiKhoanDAO _taiKhoan = new TaiKhoanDAO();
        private bool _isInsert = false;

        public QLNhanVienGUI()
        {
            InitializeComponent();
        }

        private void QLNhanVien_Load(object sender, EventArgs e)
        {
            AddLinkColumn();
            LoadDgViewNhanVien();
            LoadCboChucVu();
            EnableAllTextbox(false);
            datePickerNgaySinh.MaxDate = DateTime.Now;
            panelSaveCancel.Visible = false;
        }

        #region Prepare data

        private void LoadDgViewNhanVien()
        {
            try
            {
                DataTable dt = _nhanVien.GetDtNhanVien();
                if (dt is null) return;
                dgViewNhanVien.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDgViewNhanVien(DataTable dt)
        {
            try
            {
                if (dt is null) return;
                dgViewNhanVien.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCboChucVu()
        {
            DataTable dt = new ChucVuDAO().GetData().Tables["tb_ChucVu"];
            if (dt is null) return;

            cboChucVu.DataSource = dt;
            cboChucVu.DisplayMember = "TenChucVu";
            cboChucVu.ValueMember = "MaChucVu";
        }

        private void EnableAllTextbox(bool isEnable)
        {
            txtHoTen.Enabled = txtSdt.Enabled = datePickerNgaySinh.Enabled = txtDiaChi.Enabled = txtUsername.Enabled =
                cboChucVu.Enabled = radioButtonNam.Enabled = radioButtonNu.Enabled = isEnable;
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
                Text = "Reset",
                DisplayIndex = 0
            };

            dgViewNhanVien.Columns.Add(links);
        }

        #endregion Prepare data

        #region Validate

        private bool ValidateForm()
        {
            return TxtHoTen_Validating() && TxtSdt_Validating() && DatePickerNgaySinh_Validating() &&
                   RadioGioiTinh_Validating();
        }

        private bool TxtHoTen_Validating()
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                errorProvider1.SetError(lblHoTen, "Nhập họ tên nhân viên.");
                return false;
            }
            else
            {
                errorProvider1.SetError(lblHoTen, "");
                return true;
            }
        }

        private bool TxtSdt_Validating()
        {
            Regex regexPhone = new Regex(@"^0([0-9]){9}$");
            if (!regexPhone.IsMatch(txtSdt.Text))
            {
                errorProvider1.SetError(lblSdt, "Nhập số điện thoại.");
                return false;
            }
            else
            {
                errorProvider1.SetError(lblSdt, "");
                return true;
            }
        }

        private bool DatePickerNgaySinh_Validating()
        {
            if (DateTime.Now.Year - datePickerNgaySinh.Value.Year < 18)
            {
                errorProvider1.SetError(lblNgaySinh, "Ngày sinh không hợp lệ.");
                return false;
            }
            else
            {
                errorProvider1.SetError(lblNgaySinh, "");
                return true;
            }
        }

        private bool RadioGioiTinh_Validating()
        {
            if (!radioButtonNam.Checked && !radioButtonNu.Checked)
            {
                errorProvider1.SetError(lblGioiTinh, "Chọn giới tính.");
                return false;
            }
            else
            {
                errorProvider1.SetError(lblGioiTinh, "");
                return true;
            }
        }

        #endregion Validate

        #region Hanlde event

        private void BtnThem_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = txtDiaChi.Text = txtSdt.Text = txtUsername.Text = string.Empty;
            datePickerNgaySinh.Value = DateTime.Now.Date;
            radioButtonNam.Checked = radioButtonNu.Checked = false;
            cboChucVu.SelectedIndex = cboChucVu.FindStringExact("Nhân viên");
            EnableAllTextbox(true);
            txtUsername.Enabled = false;
            txtHoTen.Focus();
            panelSaveCancel.Visible = true;
            _isInsert = true;
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (_rowSelected is null)
            {
                MessageBox.Show("Vui lòng chọn 1 nhân viên cần sửa.", "Lỗi", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                EnableAllTextbox(true);
                txtHoTen.Focus();
                panelSaveCancel.Visible = true;
                txtUsername.Enabled = false;
                _isInsert = false;
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            var rowsSelected = dgViewNhanVien.SelectedRows;
            if (rowsSelected.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 dòng cần xoá.", "Lỗi", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xoá " + rowsSelected.Count + " nhân viên?", "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;

                int countSuccess = 0;
                for (int i = 0; i < rowsSelected.Count; i++)
                {
                    int maNv = (int)rowsSelected[i].Cells["MaNV"].Value;
                    if (_nhanVien.Delete(maNv) > 0)
                    {
                        countSuccess++;
                    }
                }

                MessageBox.Show("Xoá thành công " + countSuccess + "/" + rowsSelected.Count + " nhân viên.", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                LoadDgViewNhanVien();
                EnableAllTextbox(false);
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

            try // Is valid
            {
                if (_isInsert)
                {
                    string username = _taiKhoan.CreateUsername(txtHoTen.Text);
                    // Insert TaiKhoan with default password "123"
                    if (_taiKhoan.Insert(new TaiKhoanDTO(username, "123",
                        (int)cboChucVu.SelectedValue)) > 0)
                    {
                        string gioiTinh = radioButtonNam.Checked ? "Nam" : "Nữ";
                        string diaChi = string.IsNullOrWhiteSpace(txtDiaChi.Text) ? "unknown" : txtDiaChi.Text;
                        int rowAffected = _nhanVien.Insert(new NhanVienDTO(txtHoTen.Text,
                            gioiTinh, txtSdt.Text, datePickerNgaySinh.Value, username, diaChi, false));
                        if (rowAffected > 0)
                        {
                            MessageBox.Show("Thêm nhân viên thành công.", "Thông báo", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Thêm nhân viên thất bại.", "Lỗi", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Thêm tài khoản nhân viên thất bại.", "Lỗi", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else // Update
                {
                    int maNv = int.Parse(_rowSelected.Cells["MaNV"].Value.ToString());
                    string gioiTinh = radioButtonNam.Checked ? "Nam" : "Nữ";
                    string diaChi = string.IsNullOrWhiteSpace(txtDiaChi.Text) ? "unknown" : txtDiaChi.Text;
                    int rowAffected = _nhanVien.Update(new NhanVienDTO(maNv, txtHoTen.Text,
                        gioiTinh, txtSdt.Text, datePickerNgaySinh.Value, txtUsername.Text, diaChi, false));
                    if (rowAffected > 0)
                    {
                        MessageBox.Show("Cập nhật nhân viên thành công.", "Thông báo", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật nhân viên thất bại.", "Lỗi", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadDgViewNhanVien();
        }

        private DataGridViewRow _rowSelected;

        private void DgViewNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) // Click on "Action" column
            {
                string username = dgViewNhanVien.Rows[e.RowIndex].Cells["Username"].Value.ToString();
                int rowAffected = _taiKhoan.ResetPassword(username);
                if (rowAffected > 0)
                {
                    MessageBox.Show("Reset mật khẩu thànhh công.", "Thông báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Reset mật khẩu thất bại.", "Lỗi", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                LoadDgViewNhanVien();
                btnHuy.PerformClick();
            }
        }

        private void DgViewNhanVien_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            if (e.StateChanged == DataGridViewElementStates.Selected)
            {
                if (dgViewNhanVien.SelectedCells.Count == 0) return;

                _rowSelected = dgViewNhanVien.Rows[dgViewNhanVien.SelectedCells[0].RowIndex];
                txtHoTen.Text = _rowSelected.Cells["HoTen"].Value.ToString();
                txtSdt.Text = _rowSelected.Cells["SDT"].Value.ToString();
                datePickerNgaySinh.Value = DateTime.Parse(_rowSelected.Cells["NgaySinh"].Value.ToString());
                txtDiaChi.Text = _rowSelected.Cells["DiaChi"].Value.ToString();
                if (_rowSelected.Cells["GioiTinh"].Value.ToString().Equals("Nam"))
                    radioButtonNam.Checked = true;
                else
                    radioButtonNu.Checked = true;
                txtUsername.Text = _rowSelected.Cells["Username"].Value.ToString();
                cboChucVu.SelectedValue = _rowSelected.Cells["MaChucVu"].Value;
                btnXoa.Enabled = btnSua.Enabled = true;
                btnHuy.PerformClick();
            }
        }

        private void DgViewNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            int rowsCount = dgViewNhanVien.SelectedRows.Count;
            if (rowsCount == 0) return;

            _rowSelected = dgViewNhanVien.Rows[dgViewNhanVien.SelectedCells[0].RowIndex];
            txtHoTen.Text = _rowSelected.Cells["HoTen"].Value.ToString();
            txtSdt.Text = _rowSelected.Cells["SDT"].Value.ToString();
            datePickerNgaySinh.Value = DateTime.Parse(_rowSelected.Cells["NgaySinh"].Value.ToString());
            txtDiaChi.Text = _rowSelected.Cells["DiaChi"].Value.ToString();
            if (_rowSelected.Cells["GioiTinh"].Value.ToString().Equals("Nam"))
                radioButtonNam.Checked = true;
            else
                radioButtonNu.Checked = true;
            txtUsername.Text = _rowSelected.Cells["Username"].Value.ToString();
            cboChucVu.SelectedValue = _rowSelected.Cells["MaChucVu"].Value;
            btnXoa.Enabled = btnSua.Enabled = true;
            btnHuy.PerformClick();
        }

        private void DgViewNhanVien_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = dgViewNhanVien.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0) // Show context menu
                {
                    dgViewNhanVien.ClearSelection();
                    dgViewNhanVien.Rows[currentMouseOverRow].Selected = true;
                    contextMenuStrip1.Show(dgViewNhanVien, new Point(e.X, e.Y));
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

        private void TableLayoutPanel2_Leave(object sender, EventArgs e)
        {
            btnHuy.PerformClick();
        }

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            LoadDgViewNhanVien(_nhanVien.SearchNhanVien(txtTimKiem.Text));
        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnTimKiem.PerformClick();
        }

        #endregion Hanlde event
    }
}
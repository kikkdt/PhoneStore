using PhoneStore.DAO;
using PhoneStore.DTO;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PhoneStore
{
    public partial class QLSanPhamGUI : Form
    {
        private DanhMucDAO _danhMuc = new DanhMucDAO();
        private NhomSanPhamDAO _nhomSP = new NhomSanPhamDAO();
        private SanPhamDAO _sanPham = new SanPhamDAO();
        private TrangThaiSanPhamDAO _trangThai = new TrangThaiSanPhamDAO();
        private bool _isInsert = false;

        public QLSanPhamGUI()
        {
            InitializeComponent();
            CreateTreeView();
            LoadDgViewSanPham();
            LoadCboNhomSp();
            LoadCboTrangThai();
            EnableAllTextbox(false);
            panelSaveCancel.Visible = false;
            btnXoa.Enabled = btnSua.Enabled = false;
            btnHinh.Visible = false;
        }

        #region Prepare data

        private void CreateTreeView()
        {
            CreateDanhMucNodes();
            CreateNhomSanPhamNodes();
        }

        private void CreateDanhMucNodes()
        {
            treeView1.Nodes.Clear();
            treeView1.Nodes.Add("Tất cả sản phẩm");
            _danhMuc.GetList().ForEach(item => { treeView1.Nodes[0].Nodes.Add(item.MaDM.ToString(), item.TenDM); });
            treeView1.ExpandAll();
        }

        private void CreateNhomSanPhamNodes()
        {
            _nhomSP.GetList().ForEach(item => { treeView1.Nodes.Find(item.MaDM.ToString(), true)[0].Nodes.Add(item.MaNSP.ToString(), item.TenNSP); });
        }

        private void LoadCboNhomSp()
        {
            DataTable dt = _nhomSP.Dset.Tables["tb_NhomSanPham"];
            if (dt is null) return;

            cboxNhomSP.DataSource = dt;
            cboxNhomSP.DisplayMember = "TenNSP";
            cboxNhomSP.ValueMember = "MaNSP";
        }

        private void LoadCboTrangThai()
        {
            DataTable dt = _trangThai.Dset.Tables["tb_TrangThaiSanPham"];
            if (dt is null) return;

            cboTrangThai.DataSource = dt;
            cboTrangThai.DisplayMember = "TenTTSP";
            cboTrangThai.ValueMember = "MaTTSP";
        }

        private void LoadDgViewSanPham()
        {
            try
            {
                DataTable dt = _sanPham.GetDetail();
                if (dt is null) return;
                dgViewSanPham.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDgViewSanPham(DataTable dt)
        {
            try
            {
                if (dt is null) return;
                dgViewSanPham.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion Prepare data

        #region Hanlde event

        private void EnableAllTextbox(bool isEnable)
        {
            txtTenSP.Enabled = numGiaBan.Enabled = numGiaNiemYet.Enabled = cboTrangThai.Enabled =
                cboxNhomSP.Enabled = numSluongTon.Enabled = numThoiGianBH.Enabled = isEnable;
            txtNgayCapNhat.Text = string.Empty;
        }

        private DataGridViewRow _rowSelected = null;
        private int _idSelected = -1;

        private void DgViewSanPham_SelectionChanged(object sender, EventArgs e)
        {
            int rowsCount = dgViewSanPham.SelectedRows.Count;
            if (rowsCount == 0) return;

            _rowSelected = dgViewSanPham.SelectedRows[0];
            _idSelected = (int)_rowSelected.Cells["ID"].Value;
            txtTenSP.Text = _rowSelected.Cells["TenSP"].Value.ToString();
            cboxNhomSP.SelectedIndex = cboxNhomSP.FindStringExact(_rowSelected.Cells["TenNSP"].Value.ToString());
            numGiaNiemYet.Value = decimal.Parse(_rowSelected.Cells["GiaNiemYet"].Value.ToString());
            numGiaBan.Value = decimal.Parse(_rowSelected.Cells["GiaBan"].Value.ToString());
            txtNgayCapNhat.Text = _rowSelected.Cells["NgayCapNhat"].Value.ToString();
            numSluongTon.Value = (int)_rowSelected.Cells["SoLuongTon"].Value;
            numThoiGianBH.Value = (int)_rowSelected.Cells["ThoiGianBH"].Value;
            cboTrangThai.SelectedIndex = cboTrangThai.FindStringExact(_rowSelected.Cells["TenTTSP"].Value.ToString());
            try
            {
                pictureBox1.Image = Image.FromFile("../../Image/Products/" + _rowSelected.Cells["UrlHinh"].Value);
            }
            catch (FileNotFoundException)
            {
                pictureBox1.Image = Image.FromFile("../../Image/no-data.png");
            }
            pictureBox1.Text = _rowSelected.Cells["UrlHinh"].Value.ToString();
            btnXoa.Enabled = btnSua.Enabled = true;
        }

        private void DgViewSanPham_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            if (e.StateChanged == DataGridViewElementStates.Selected)
            {
                if (dgViewSanPham.SelectedCells.Count == 0) return;

                _rowSelected = dgViewSanPham.Rows[dgViewSanPham.SelectedCells[0].RowIndex];
                _idSelected = (int)_rowSelected.Cells["ID"].Value;
                txtTenSP.Text = _rowSelected.Cells["TenSP"].Value.ToString();
                cboxNhomSP.SelectedIndex = cboxNhomSP.FindStringExact(_rowSelected.Cells["TenNSP"].Value.ToString());
                numGiaNiemYet.Value = decimal.Parse(_rowSelected.Cells["GiaNiemYet"].Value.ToString());
                numGiaBan.Value = decimal.Parse(_rowSelected.Cells["GiaBan"].Value.ToString());
                txtNgayCapNhat.Text = _rowSelected.Cells["NgayCapNhat"].Value.ToString();
                numSluongTon.Value = (int)_rowSelected.Cells["SoLuongTon"].Value;
                numThoiGianBH.Value = (int)_rowSelected.Cells["ThoiGianBH"].Value;
                cboTrangThai.SelectedIndex = cboTrangThai.FindStringExact(_rowSelected.Cells["TenTTSP"].Value.ToString());
                try
                {
                    pictureBox1.Image = Image.FromFile("../../Image/Products/" + _rowSelected.Cells["UrlHinh"].Value);
                }
                catch (FileNotFoundException)
                {
                    pictureBox1.Image = Image.FromFile("../../Image/no-data.png");
                }
                pictureBox1.Text = _rowSelected.Cells["UrlHinh"].Value.ToString();
                btnXoa.Enabled = btnSua.Enabled = true;
            }
        }

        private void DgViewSanPham_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = dgViewSanPham.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0) // Show context menu
                {
                    dgViewSanPham.ClearSelection();
                    dgViewSanPham.Rows[currentMouseOverRow].Selected = true;
                    contextMenuStrip1.Show(dgViewSanPham, new Point(e.X, e.Y));
                }
            }
        }

        private void TreeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            switch (e.Node.Level)
            {
                case 1: // Filter by DanhMuc
                    {
                        int maDm = _danhMuc.GetList().Find(item => item.TenDM == e.Node.Text).MaDM;
                        LoadDgViewSanPham(_sanPham.GetDetailByDanhMuc(maDm));
                    }
                    break;

                case 2: // Filter by NhomSanPham
                    {
                        int maNsp = _nhomSP.GetList().Find(item => item.TenNSP == e.Node.Text).MaNSP;
                        LoadDgViewSanPham(_sanPham.GetDetailByNhomSp(maNsp));
                    }
                    break;

                default:
                    LoadDgViewSanPham();
                    break;
            }
        }

        private void TableLayoutPanel3_Leave(object sender, EventArgs e)
        {
            btnHuy.PerformClick();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            EnableAllTextbox(true);
            panelSaveCancel.Visible = true;
            txtTenSP.Text = string.Empty;
            txtTenSP.Focus();
            numGiaNiemYet.Value = numGiaBan.Value = numThoiGianBH.Value = numSluongTon.Value = 0;
            cboTrangThai.SelectedIndex = cboTrangThai.FindStringExact("Còn hàng");
            btnHinh.Visible = true;
            pictureBox1.Image = null;
            pictureBox1.Text = string.Empty;
            _isInsert = true;
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            var rowsSelected = dgViewSanPham.SelectedRows;
            if (rowsSelected.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 dòng cần xoá.", "Lỗi", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xoá " + rowsSelected.Count + " sản phẩm?", "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;

                int countSuccess = 0;
                for (int i = 0; i < rowsSelected.Count; i++)
                {
                    if (_sanPham.Delete((int)rowsSelected[i].Cells["ID"].Value) > 0)
                        countSuccess++;
                }

                MessageBox.Show("Xoá thành công " + countSuccess + "/" + rowsSelected.Count + " sản phẩm.", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                LoadDgViewSanPham();
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
                EnableAllTextbox(true);
                panelSaveCancel.Visible = true;
                btnHinh.Visible = true;
                txtTenSP.Focus();
                _isInsert = false;
            }
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.Disable;
            this.CausesValidation = false;
            dgViewSanPham.Rows[0].Cells[0].Selected = true;
            panelSaveCancel.Visible = false;
            LoadDgViewSanPham();
            EnableAllTextbox(false);
            pictureBox1.Image = null;
            btnHinh.Visible = false;
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
                    int rowAffected =
                        _sanPham.Insert(new SanPhamDTO(txtTenSP.Text, (int)cboxNhomSP.SelectedValue, (int)numGiaNiemYet.Value, (int)numSluongTon.Value, (int)numThoiGianBH.Value, pictureBox1.Text, string.Empty, (int)cboTrangThai.SelectedValue, false));
                    if (rowAffected > 0)
                    {
                        int maSp = _sanPham.GetList().Find(item => item.TenSP.Equals(txtTenSP.Text)).ID;
                        new GiaBanDAO().Insert(new GiaBanDTO(maSp, DateTime.Now, (double)numGiaBan.Value == 0 ? (double)numGiaNiemYet.Value : (double)numGiaBan.Value));
                        MessageBox.Show("Thêm sản phẩm thành công.", "Thông báo", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm sản phẩm thất bại.", "Lỗi", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    int maSp = (int)_rowSelected.Cells["ID"].Value;
                    int rowAffected =
                        _sanPham.Update(new SanPhamDTO(maSp, txtTenSP.Text, (int)cboxNhomSP.SelectedValue, (int)numGiaNiemYet.Value, (int)numSluongTon.Value, (int)numThoiGianBH.Value, pictureBox1.Text, string.Empty, (int)cboTrangThai.SelectedValue, false));
                    if (rowAffected > 0)
                    {
                        new GiaBanDAO().Insert(new GiaBanDTO(maSp, DateTime.Now, (double)numGiaBan.Value == 0 ? (double)numGiaNiemYet.Value : (double)numGiaBan.Value));
                        MessageBox.Show("Cập nhật sản phẩm thành công.", "Thông báo", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật sản phẩm thất bại.", "Lỗi", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                LoadDgViewSanPham();
                EnableAllTextbox(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                Title = "Chọn hình ảnh sản phẩm",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF",
                RestoreDirectory = true,
            };

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(fileDialog.FileName);
                pictureBox1.Text = fileDialog.SafeFileName;

                string fileName = fileDialog.SafeFileName;
                string srcFile = fileDialog.FileName;
                string destFile = "../../Image/Products/" + fileName;

                // To copy a file to another location and
                // overwrite the destination file if it already exists.
                System.IO.File.Copy(srcFile, destFile, true);
            }
        }

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            LoadDgViewSanPham(_sanPham.SearchSanPham(txtTimKiem.Text.Trim()));
        }

        private void TxtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnTimKiem.PerformClick();
        }

        private void ToolStripMenuItemSua_Click(object sender, EventArgs e)
        {
            btnSua.PerformClick();
        }

        private void ToolStripMenuItemXoa_Click(object sender, EventArgs e)
        {
            btnXoa.PerformClick();
        }

        #endregion Hanlde event

        #region Validate

        private bool ValidateForm()
        {
            return TxtTenSP_Validating() && NumGiaNiemYet_Validating();
        }

        private bool TxtTenSP_Validating()
        {
            if (string.IsNullOrWhiteSpace(txtTenSP.Text))
            {
                errorProvider1.SetError(lblTenSP, "Nhập tên sản phẩm.");
                return false;
            }
            else if (_sanPham.IsExistTenSp(txtTenSP.Text) && _isInsert)
            {
                errorProvider1.SetError(lblTenSP, "Tên sản phẩm đã tồn tại.");
                return false;
            }
            else
            {
                errorProvider1.SetError(lblTenSP, string.Empty);
                return true;
            }
        }

        private bool NumGiaNiemYet_Validating()
        {
            if (numGiaNiemYet.Value == 0)
            {
                errorProvider1.SetError(lblGiaNiemYet, "Nhập giá niêm yết sản phẩm.");
                return false;
            }
            else
            {
                errorProvider1.SetError(lblGiaNiemYet, string.Empty);
                return true;
            }
        }

        #endregion Validate
    }
}
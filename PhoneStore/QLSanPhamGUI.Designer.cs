
namespace PhoneStore
{
    partial class QLSanPhamGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components is not null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLSanPhamGUI));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgViewSanPham = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaNiemYet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayCapNhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianBH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrlHinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTTSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxNhomSP = new System.Windows.Forms.ComboBox();
            this.lblGiaNiemYet = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numThoiGianBH = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numSluongTon = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSaveCancel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.btnHinh = new System.Windows.Forms.Button();
            this.numGiaNiemYet = new System.Windows.Forms.NumericUpDown();
            this.numGiaBan = new System.Windows.Forms.NumericUpDown();
            this.txtNgayCapNhat = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemSua = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewSanPham)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numThoiGianBH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSluongTon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelSaveCancel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaNiemYet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.treeView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 673F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 673F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1262, 673);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(309, 667);
            this.treeView1.TabIndex = 1;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeView1_NodeMouseClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.dgViewSanPham, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(318, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(941, 667);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // dgViewSanPham
            // 
            this.dgViewSanPham.AllowUserToAddRows = false;
            this.dgViewSanPham.AllowUserToDeleteRows = false;
            this.dgViewSanPham.AllowUserToOrderColumns = true;
            this.dgViewSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgViewSanPham.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgViewSanPham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgViewSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TenSP,
            this.TenNSP,
            this.GiaNiemYet,
            this.GiaBan,
            this.NgayCapNhat,
            this.SoLuongTon,
            this.ThoiGianBH,
            this.UrlHinh,
            this.TenTTSP});
            this.dgViewSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgViewSanPham.Location = new System.Drawing.Point(3, 369);
            this.dgViewSanPham.Name = "dgViewSanPham";
            this.dgViewSanPham.ReadOnly = true;
            this.dgViewSanPham.RowHeadersWidth = 51;
            this.dgViewSanPham.RowTemplate.Height = 24;
            this.dgViewSanPham.Size = new System.Drawing.Size(935, 295);
            this.dgViewSanPham.TabIndex = 0;
            this.dgViewSanPham.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.DgViewSanPham_CellStateChanged);
            this.dgViewSanPham.SelectionChanged += new System.EventHandler(this.DgViewSanPham_SelectionChanged);
            this.dgViewSanPham.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DgViewSanPham_MouseClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên sản phẩm";
            this.TenSP.MinimumWidth = 6;
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            // 
            // TenNSP
            // 
            this.TenNSP.DataPropertyName = "TenNSP";
            this.TenNSP.HeaderText = "Nhóm sản phẩm";
            this.TenNSP.MinimumWidth = 6;
            this.TenNSP.Name = "TenNSP";
            this.TenNSP.ReadOnly = true;
            // 
            // GiaNiemYet
            // 
            this.GiaNiemYet.DataPropertyName = "GiaNiemYet";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.GiaNiemYet.DefaultCellStyle = dataGridViewCellStyle1;
            this.GiaNiemYet.HeaderText = "Giá niêm yết";
            this.GiaNiemYet.MinimumWidth = 6;
            this.GiaNiemYet.Name = "GiaNiemYet";
            this.GiaNiemYet.ReadOnly = true;
            // 
            // GiaBan
            // 
            this.GiaBan.DataPropertyName = "GiaBan";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.GiaBan.DefaultCellStyle = dataGridViewCellStyle2;
            this.GiaBan.HeaderText = "Giá bán";
            this.GiaBan.MinimumWidth = 6;
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.ReadOnly = true;
            // 
            // NgayCapNhat
            // 
            this.NgayCapNhat.DataPropertyName = "NgayCapNhat";
            this.NgayCapNhat.HeaderText = "Ngày cập nhật";
            this.NgayCapNhat.MinimumWidth = 6;
            this.NgayCapNhat.Name = "NgayCapNhat";
            this.NgayCapNhat.ReadOnly = true;
            // 
            // SoLuongTon
            // 
            this.SoLuongTon.DataPropertyName = "SoLuongTon";
            this.SoLuongTon.HeaderText = "Số lượng tồn";
            this.SoLuongTon.MinimumWidth = 6;
            this.SoLuongTon.Name = "SoLuongTon";
            this.SoLuongTon.ReadOnly = true;
            // 
            // ThoiGianBH
            // 
            this.ThoiGianBH.DataPropertyName = "ThoiGianBH";
            this.ThoiGianBH.HeaderText = "Thời gian BH";
            this.ThoiGianBH.MinimumWidth = 6;
            this.ThoiGianBH.Name = "ThoiGianBH";
            this.ThoiGianBH.ReadOnly = true;
            // 
            // UrlHinh
            // 
            this.UrlHinh.DataPropertyName = "UrlHinh";
            this.UrlHinh.HeaderText = "Url hình";
            this.UrlHinh.MinimumWidth = 6;
            this.UrlHinh.Name = "UrlHinh";
            this.UrlHinh.ReadOnly = true;
            this.UrlHinh.Visible = false;
            // 
            // TenTTSP
            // 
            this.TenTTSP.DataPropertyName = "TenTTSP";
            this.TenTTSP.HeaderText = "Trạng thái";
            this.TenTTSP.MinimumWidth = 6;
            this.TenTTSP.Name = "TenTTSP";
            this.TenTTSP.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(935, 360);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel4.Controls.Add(this.txtTimKiem, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnTimKiem, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(167, 18);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(600, 50);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimKiem.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiem.Location = new System.Drawing.Point(3, 3);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(384, 38);
            this.txtTimKiem.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtTimKiem, "Search here...");
            this.txtTimKiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTimKiem_KeyPress);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Image = global::PhoneStore.Properties.Resources.icons8_search_32;
            this.btnTimKiem.Location = new System.Drawing.Point(393, 3);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(100, 34);
            this.btnTimKiem.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnTimKiem, "Tìm kiếm");
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.BtnTimKiem_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Location = new System.Drawing.Point(14, 264);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(906, 60);
            this.panel2.TabIndex = 1;
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.btnSua.Image = global::PhoneStore.Properties.Resources.icons8_rename_32;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(295, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnSua.Size = new System.Drawing.Size(124, 51);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "&Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnSua, "Sửa");
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.btnXoa.Image = global::PhoneStore.Properties.Resources.icons8_minus_32;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(149, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnXoa.Size = new System.Drawing.Size(124, 50);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnXoa, "Xoá");
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.btnThem.Image = global::PhoneStore.Properties.Resources.icons8_add_32;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(3, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnThem.Size = new System.Drawing.Size(124, 50);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "&Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnThem, "Thêm");
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 206F));
            this.tableLayoutPanel3.Controls.Add(this.lblTenSP, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtTenSP, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.cboxNhomSP, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblGiaNiemYet, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label4, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.numThoiGianBH, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label8, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.numSluongTon, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.label7, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.pictureBox1, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.panelSaveCancel, 2, 4);
            this.tableLayoutPanel3.Controls.Add(this.cboTrangThai, 3, 3);
            this.tableLayoutPanel3.Controls.Add(this.btnHinh, 4, 3);
            this.tableLayoutPanel3.Controls.Add(this.numGiaNiemYet, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.numGiaBan, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtNgayCapNhat, 3, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(14, 74);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(906, 189);
            this.tableLayoutPanel3.TabIndex = 0;
            this.tableLayoutPanel3.Leave += new System.EventHandler(this.TableLayoutPanel3_Leave);
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Location = new System.Drawing.Point(3, 0);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(77, 34);
            this.lblTenSP.TabIndex = 0;
            this.lblTenSP.Text = "Tên sản phẩm *";
            this.toolTip1.SetToolTip(this.lblTenSP, "Tên sản phẩm *");
            // 
            // txtTenSP
            // 
            this.txtTenSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenSP.Location = new System.Drawing.Point(108, 3);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(239, 34);
            this.txtTenSP.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhóm sản phẩm *";
            this.toolTip1.SetToolTip(this.label2, "Nhóm sản phẩm *");
            // 
            // cboxNhomSP
            // 
            this.cboxNhomSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboxNhomSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxNhomSP.FormattingEnabled = true;
            this.cboxNhomSP.Location = new System.Drawing.Point(458, 3);
            this.cboxNhomSP.Name = "cboxNhomSP";
            this.cboxNhomSP.Size = new System.Drawing.Size(239, 32);
            this.cboxNhomSP.TabIndex = 3;
            // 
            // lblGiaNiemYet
            // 
            this.lblGiaNiemYet.AutoSize = true;
            this.lblGiaNiemYet.Location = new System.Drawing.Point(3, 34);
            this.lblGiaNiemYet.Name = "lblGiaNiemYet";
            this.lblGiaNiemYet.Size = new System.Drawing.Size(86, 34);
            this.lblGiaNiemYet.TabIndex = 4;
            this.lblGiaNiemYet.Text = "Giá niêm yết *";
            this.lblGiaNiemYet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.lblGiaNiemYet, "Giá niêm yết *");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 34);
            this.label4.TabIndex = 6;
            this.label4.Text = "Thời gian BH";
            this.toolTip1.SetToolTip(this.label4, "Thời gian BH");
            // 
            // numThoiGianBH
            // 
            this.numThoiGianBH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numThoiGianBH.Location = new System.Drawing.Point(458, 37);
            this.numThoiGianBH.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numThoiGianBH.Name = "numThoiGianBH";
            this.numThoiGianBH.Size = new System.Drawing.Size(239, 34);
            this.numThoiGianBH.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Giá bán";
            this.toolTip1.SetToolTip(this.label5, "Giá bán");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(353, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 34);
            this.label8.TabIndex = 10;
            this.label8.Text = "- Ngày cập nhật:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 34);
            this.label6.TabIndex = 11;
            this.label6.Text = "Số lượng tồn";
            this.toolTip1.SetToolTip(this.label6, "Số lượng tồn");
            // 
            // numSluongTon
            // 
            this.numSluongTon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numSluongTon.Location = new System.Drawing.Point(108, 105);
            this.numSluongTon.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numSluongTon.Name = "numSluongTon";
            this.numSluongTon.Size = new System.Drawing.Size(239, 34);
            this.numSluongTon.TabIndex = 12;
            this.numSluongTon.ThousandsSeparator = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(353, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 34);
            this.label7.TabIndex = 14;
            this.label7.Text = "Trạng thái *";
            this.toolTip1.SetToolTip(this.label7, "Trạng thái *");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(703, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.tableLayoutPanel3.SetRowSpan(this.pictureBox1, 3);
            this.pictureBox1.Size = new System.Drawing.Size(200, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // panelSaveCancel
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.panelSaveCancel, 2);
            this.panelSaveCancel.Controls.Add(this.btnLuu);
            this.panelSaveCancel.Controls.Add(this.btnHuy);
            this.panelSaveCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSaveCancel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.panelSaveCancel.Location = new System.Drawing.Point(353, 139);
            this.panelSaveCancel.Name = "panelSaveCancel";
            this.panelSaveCancel.Size = new System.Drawing.Size(344, 47);
            this.panelSaveCancel.TabIndex = 16;
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.btnLuu.Image = global::PhoneStore.Properties.Resources.icons8_save_32;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(261, 3);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(80, 34);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.BtnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.CausesValidation = false;
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuy.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.btnHuy.Image = global::PhoneStore.Properties.Resources.icons8_cancel_32;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(175, 3);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(80, 34);
            this.btnHuy.TabIndex = 9;
            this.btnHuy.Text = "&Huỷ";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.BtnHuy_Click);
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Location = new System.Drawing.Point(458, 105);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(239, 32);
            this.cboTrangThai.TabIndex = 17;
            // 
            // btnHinh
            // 
            this.btnHinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHinh.Location = new System.Drawing.Point(703, 105);
            this.btnHinh.Name = "btnHinh";
            this.btnHinh.Size = new System.Drawing.Size(200, 28);
            this.btnHinh.TabIndex = 18;
            this.btnHinh.Text = "Chọn hình ảnh...";
            this.btnHinh.UseVisualStyleBackColor = true;
            this.btnHinh.Click += new System.EventHandler(this.BtnHinh_Click);
            // 
            // numGiaNiemYet
            // 
            this.numGiaNiemYet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numGiaNiemYet.Location = new System.Drawing.Point(108, 37);
            this.numGiaNiemYet.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numGiaNiemYet.Name = "numGiaNiemYet";
            this.numGiaNiemYet.Size = new System.Drawing.Size(239, 34);
            this.numGiaNiemYet.TabIndex = 19;
            this.numGiaNiemYet.ThousandsSeparator = true;
            // 
            // numGiaBan
            // 
            this.numGiaBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numGiaBan.Location = new System.Drawing.Point(108, 71);
            this.numGiaBan.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numGiaBan.Name = "numGiaBan";
            this.numGiaBan.Size = new System.Drawing.Size(239, 34);
            this.numGiaBan.TabIndex = 20;
            this.numGiaBan.ThousandsSeparator = true;
            // 
            // txtNgayCapNhat
            // 
            this.txtNgayCapNhat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNgayCapNhat.Enabled = false;
            this.txtNgayCapNhat.Location = new System.Drawing.Point(458, 71);
            this.txtNgayCapNhat.Name = "txtNgayCapNhat";
            this.txtNgayCapNhat.ReadOnly = true;
            this.txtNgayCapNhat.Size = new System.Drawing.Size(239, 34);
            this.txtNgayCapNhat.TabIndex = 21;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSua,
            this.toolStripMenuItemXoa});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(120, 64);
            // 
            // toolStripMenuItemSua
            // 
            this.toolStripMenuItemSua.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.toolStripMenuItemSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.toolStripMenuItemSua.Image = global::PhoneStore.Properties.Resources.icons8_rename_32;
            this.toolStripMenuItemSua.Name = "toolStripMenuItemSua";
            this.toolStripMenuItemSua.Size = new System.Drawing.Size(119, 30);
            this.toolStripMenuItemSua.Text = "Sửa";
            this.toolStripMenuItemSua.Click += new System.EventHandler(this.ToolStripMenuItemSua_Click);
            // 
            // toolStripMenuItemXoa
            // 
            this.toolStripMenuItemXoa.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.toolStripMenuItemXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.toolStripMenuItemXoa.Image = global::PhoneStore.Properties.Resources.icons8_minus_32;
            this.toolStripMenuItemXoa.Name = "toolStripMenuItemXoa";
            this.toolStripMenuItemXoa.Size = new System.Drawing.Size(119, 30);
            this.toolStripMenuItemXoa.Text = "Xoá";
            this.toolStripMenuItemXoa.Click += new System.EventHandler(this.ToolStripMenuItemXoa_Click);
            // 
            // QLSanPhamGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QLSanPhamGUI";
            this.Text = "Quản lý Sản phẩm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgViewSanPham)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numThoiGianBH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSluongTon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelSaveCancel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numGiaNiemYet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgViewSanPham;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxNhomSP;
        private System.Windows.Forms.Label lblGiaNiemYet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numThoiGianBH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numSluongTon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel panelSaveCancel;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnHinh;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.NumericUpDown numGiaNiemYet;
        private System.Windows.Forms.NumericUpDown numGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaNiemYet;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayCapNhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianBH;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrlHinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTTSP;
        private System.Windows.Forms.TextBox txtNgayCapNhat;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSua;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemXoa;
    }
}
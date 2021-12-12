
namespace PhoneStore
{
    partial class MainGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGUI));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLySanPhamtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.nhapHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lichSuNhapHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyNhanVientoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongKeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sanPhamTonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyTaiKhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thayDoiMatKhauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangXuatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnQuanLySanPham = new System.Windows.Forms.Button();
            this.btnNhapHang = new System.Windows.Forms.Button();
            this.btnLichSuNhapHang = new System.Windows.Forms.Button();
            this.btnQuanLyNhanVien = new System.Windows.Forms.Button();
            this.btnThongKeTon = new System.Windows.Forms.Button();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblHello = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlHome.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.quanLySanPhamtoolStripMenuItem,
            this.toolStripMenuItem2,
            this.quanLyNhanVientoolStripMenuItem,
            this.thongKeToolStripMenuItem,
            this.quanLyTaiKhoanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1262, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Image = global::PhoneStore.Properties.Resources.icons8_home_48;
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(34, 28);
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.HomeToolStripMenuItem_Click);
            // 
            // quanLySanPhamtoolStripMenuItem
            // 
            this.quanLySanPhamtoolStripMenuItem.Name = "quanLySanPhamtoolStripMenuItem";
            this.quanLySanPhamtoolStripMenuItem.Size = new System.Drawing.Size(169, 28);
            this.quanLySanPhamtoolStripMenuItem.Text = "Quản lý Sản phẩm";
            this.quanLySanPhamtoolStripMenuItem.Click += new System.EventHandler(this.QuanLySanPhamtoolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhapHangToolStripMenuItem,
            this.lichSuNhapHangToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(176, 28);
            this.toolStripMenuItem2.Text = "Quản lý Nhập hàng";
            // 
            // nhapHangToolStripMenuItem
            // 
            this.nhapHangToolStripMenuItem.Image = global::PhoneStore.Properties.Resources.icons8_in_transit_48;
            this.nhapHangToolStripMenuItem.Name = "nhapHangToolStripMenuItem";
            this.nhapHangToolStripMenuItem.Size = new System.Drawing.Size(245, 28);
            this.nhapHangToolStripMenuItem.Text = "Nhập hàng";
            this.nhapHangToolStripMenuItem.Click += new System.EventHandler(this.NhapHangToolStripMenuItem_Click);
            // 
            // lichSuNhapHangToolStripMenuItem
            // 
            this.lichSuNhapHangToolStripMenuItem.Image = global::PhoneStore.Properties.Resources.icons8_order_history_48;
            this.lichSuNhapHangToolStripMenuItem.Name = "lichSuNhapHangToolStripMenuItem";
            this.lichSuNhapHangToolStripMenuItem.Size = new System.Drawing.Size(245, 28);
            this.lichSuNhapHangToolStripMenuItem.Text = "Lịch sử Nhập hàng";
            this.lichSuNhapHangToolStripMenuItem.Click += new System.EventHandler(this.LichSuNhapHangToolStripMenuItem_Click);
            // 
            // quanLyNhanVientoolStripMenuItem
            // 
            this.quanLyNhanVientoolStripMenuItem.Name = "quanLyNhanVientoolStripMenuItem";
            this.quanLyNhanVientoolStripMenuItem.Size = new System.Drawing.Size(169, 28);
            this.quanLyNhanVientoolStripMenuItem.Text = "Quản lý Nhân viên";
            this.quanLyNhanVientoolStripMenuItem.Click += new System.EventHandler(this.QuanLyNhanVientoolStripMenuItem_Click);
            // 
            // thongKeToolStripMenuItem
            // 
            this.thongKeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sanPhamTonToolStripMenuItem});
            this.thongKeToolStripMenuItem.Name = "thongKeToolStripMenuItem";
            this.thongKeToolStripMenuItem.Size = new System.Drawing.Size(97, 28);
            this.thongKeToolStripMenuItem.Text = "Thống kê";
            // 
            // sanPhamTonToolStripMenuItem
            // 
            this.sanPhamTonToolStripMenuItem.Image = global::PhoneStore.Properties.Resources.icons8_graph_48;
            this.sanPhamTonToolStripMenuItem.Name = "sanPhamTonToolStripMenuItem";
            this.sanPhamTonToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.sanPhamTonToolStripMenuItem.Text = "Sản phẩm tồn";
            this.sanPhamTonToolStripMenuItem.Click += new System.EventHandler(this.SanPhamTonToolStripMenuItem_Click);
            // 
            // quanLyTaiKhoanToolStripMenuItem
            // 
            this.quanLyTaiKhoanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thayDoiMatKhauToolStripMenuItem,
            this.dangXuatToolStripMenuItem});
            this.quanLyTaiKhoanToolStripMenuItem.Name = "quanLyTaiKhoanToolStripMenuItem";
            this.quanLyTaiKhoanToolStripMenuItem.Size = new System.Drawing.Size(102, 28);
            this.quanLyTaiKhoanToolStripMenuItem.Text = "Tài khoản";
            // 
            // thayDoiMatKhauToolStripMenuItem
            // 
            this.thayDoiMatKhauToolStripMenuItem.Image = global::PhoneStore.Properties.Resources.icons8_user_settings_48;
            this.thayDoiMatKhauToolStripMenuItem.Name = "thayDoiMatKhauToolStripMenuItem";
            this.thayDoiMatKhauToolStripMenuItem.Size = new System.Drawing.Size(243, 28);
            this.thayDoiMatKhauToolStripMenuItem.Text = "Thay đổi mật khẩu";
            this.thayDoiMatKhauToolStripMenuItem.Click += new System.EventHandler(this.ThayDoiMatKhauToolStripMenuItem_Click);
            // 
            // dangXuatToolStripMenuItem
            // 
            this.dangXuatToolStripMenuItem.Image = global::PhoneStore.Properties.Resources.icons8_logout_48;
            this.dangXuatToolStripMenuItem.Name = "dangXuatToolStripMenuItem";
            this.dangXuatToolStripMenuItem.Size = new System.Drawing.Size(243, 28);
            this.dangXuatToolStripMenuItem.Text = "Đăng xuất";
            this.dangXuatToolStripMenuItem.Click += new System.EventHandler(this.DangXuatToolStripMenuItem_Click);
            // 
            // pnlHome
            // 
            this.pnlHome.Controls.Add(this.tableLayoutPanel2);
            this.pnlHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHome.Location = new System.Drawing.Point(0, 32);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(1262, 641);
            this.pnlHome.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1262, 641);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::PhoneStore.Properties.Resources.logo;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1256, 183);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 291);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1256, 347);
            this.panel2.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnQuanLySanPham, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNhapHang, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLichSuNhapHang, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnQuanLyNhanVien, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnThongKeTon, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDoiMatKhau, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDangXuat, 3, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(158, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(941, 291);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnQuanLySanPham
            // 
            this.btnQuanLySanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.btnQuanLySanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuanLySanPham.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQuanLySanPham.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnQuanLySanPham.Image = global::PhoneStore.Properties.Resources.icons8_fast_cart_96;
            this.btnQuanLySanPham.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQuanLySanPham.Location = new System.Drawing.Point(3, 3);
            this.btnQuanLySanPham.Name = "btnQuanLySanPham";
            this.tableLayoutPanel1.SetRowSpan(this.btnQuanLySanPham, 2);
            this.btnQuanLySanPham.Size = new System.Drawing.Size(229, 285);
            this.btnQuanLySanPham.TabIndex = 0;
            this.btnQuanLySanPham.Text = "Quản lý Sản phẩm";
            this.btnQuanLySanPham.UseVisualStyleBackColor = false;
            this.btnQuanLySanPham.Click += new System.EventHandler(this.BtnQuanLySanPham_Click);
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.btnNhapHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNhapHang.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhapHang.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnNhapHang.Image = global::PhoneStore.Properties.Resources.icons8_in_transit_56;
            this.btnNhapHang.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNhapHang.Location = new System.Drawing.Point(238, 3);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(229, 139);
            this.btnNhapHang.TabIndex = 1;
            this.btnNhapHang.Text = "Nhập hàng";
            this.btnNhapHang.UseVisualStyleBackColor = false;
            this.btnNhapHang.Click += new System.EventHandler(this.BtnNhapHang_Click);
            // 
            // btnLichSuNhapHang
            // 
            this.btnLichSuNhapHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.btnLichSuNhapHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLichSuNhapHang.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLichSuNhapHang.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLichSuNhapHang.Image = global::PhoneStore.Properties.Resources.icons8_order_history_56;
            this.btnLichSuNhapHang.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLichSuNhapHang.Location = new System.Drawing.Point(238, 148);
            this.btnLichSuNhapHang.Name = "btnLichSuNhapHang";
            this.btnLichSuNhapHang.Size = new System.Drawing.Size(229, 140);
            this.btnLichSuNhapHang.TabIndex = 2;
            this.btnLichSuNhapHang.Text = "Lịch sử nhập hàng";
            this.btnLichSuNhapHang.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLichSuNhapHang.UseVisualStyleBackColor = false;
            this.btnLichSuNhapHang.Click += new System.EventHandler(this.BtnLichSuNhapHang_Click);
            // 
            // btnQuanLyNhanVien
            // 
            this.btnQuanLyNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.btnQuanLyNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuanLyNhanVien.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQuanLyNhanVien.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnQuanLyNhanVien.Image = global::PhoneStore.Properties.Resources.icons8_name_tag_56;
            this.btnQuanLyNhanVien.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQuanLyNhanVien.Location = new System.Drawing.Point(473, 3);
            this.btnQuanLyNhanVien.Name = "btnQuanLyNhanVien";
            this.btnQuanLyNhanVien.Size = new System.Drawing.Size(229, 139);
            this.btnQuanLyNhanVien.TabIndex = 3;
            this.btnQuanLyNhanVien.Text = "Quản lý Nhân viên";
            this.btnQuanLyNhanVien.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQuanLyNhanVien.UseVisualStyleBackColor = false;
            this.btnQuanLyNhanVien.Click += new System.EventHandler(this.BtnQuanLyNhanVien_Click);
            // 
            // btnThongKeTon
            // 
            this.btnThongKeTon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.btnThongKeTon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThongKeTon.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThongKeTon.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnThongKeTon.Image = global::PhoneStore.Properties.Resources.icons8_graph_56;
            this.btnThongKeTon.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThongKeTon.Location = new System.Drawing.Point(473, 148);
            this.btnThongKeTon.Name = "btnThongKeTon";
            this.btnThongKeTon.Size = new System.Drawing.Size(229, 140);
            this.btnThongKeTon.TabIndex = 5;
            this.btnThongKeTon.Text = "Thống kê Sản phẩm tồn";
            this.btnThongKeTon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThongKeTon.UseVisualStyleBackColor = false;
            this.btnThongKeTon.Click += new System.EventHandler(this.BtnThongKeTon_Click);
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.btnDoiMatKhau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDoiMatKhau.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDoiMatKhau.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDoiMatKhau.Image = global::PhoneStore.Properties.Resources.icons8_user_settings_56;
            this.btnDoiMatKhau.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(708, 3);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(230, 139);
            this.btnDoiMatKhau.TabIndex = 4;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.UseVisualStyleBackColor = false;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.BtnDoiMatKhau_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDangXuat.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDangXuat.Image = global::PhoneStore.Properties.Resources.icons8_logout_56;
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDangXuat.Location = new System.Drawing.Point(708, 148);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(230, 140);
            this.btnDangXuat.TabIndex = 4;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.BtnDangXuat_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblHello);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 192);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1256, 93);
            this.panel3.TabIndex = 3;
            // 
            // lblHello
            // 
            this.lblHello.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHello.AutoSize = true;
            this.lblHello.Font = new System.Drawing.Font("Roboto Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHello.Location = new System.Drawing.Point(158, 28);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(126, 37);
            this.lblHello.TabIndex = 0;
            this.lblHello.Text = "Xin chào,";
            // 
            // MainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.pnlHome);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý cửa hàng điện thoại và phụ kiện";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlHome.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quanLySanPhamtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem nhapHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lichSuNhapHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyNhanVientoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyTaiKhoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongKeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sanPhamTonToolStripMenuItem;
        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thayDoiMatKhauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dangXuatToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnQuanLySanPham;
        private System.Windows.Forms.Button btnNhapHang;
        private System.Windows.Forms.Button btnLichSuNhapHang;
        private System.Windows.Forms.Button btnQuanLyNhanVien;
        private System.Windows.Forms.Button btnThongKeTon;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblHello;
    }
}
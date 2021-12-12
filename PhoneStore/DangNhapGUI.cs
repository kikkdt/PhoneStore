using PhoneStore.DAO;
using PhoneStore.DTO;
using System;
using System.Windows.Forms;

namespace PhoneStore
{
    public partial class DangNhapGUI : Form
    {
        public DangNhapGUI()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu không không được trống.", "Lỗi", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            try
            {
                TaiKhoanDTO account = new TaiKhoanDAO().Login(txtUsername.Text, txtPassword.Text);
                if (account is null) // Login fail
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Lỗi", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else // Login success
                {
                    MainGUI frmMain = new MainGUI(account);
                    frmMain.Show();
                    frmMain.FormClosing += delegate { Close(); };
                    Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
using PhoneStore.DAO;
using PhoneStore.DTO;
using System;
using System.Windows.Forms;

namespace PhoneStore
{
    public partial class DoiMatKhauGUI : Form
    {
        private TaiKhoanDAO _taiKhoan = new TaiKhoanDAO();

        public DoiMatKhauGUI()
        {
            InitializeComponent();
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCurrentPassword.Text) ||
                string.IsNullOrWhiteSpace(txtChangedPassword.Text) || string.IsNullOrWhiteSpace(txtRetypePassword.Text))
            {
                MessageBox.Show("Nhập đầy đủ các trường thông tin bắt buộc.", "Lỗi", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else if (!IsCorrectCurrentPassword())
            {
                MessageBox.Show("Mật khẩu hiện tại không đúng.", "Lỗi", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else if (!IsMatchNewPassword())
            {
                MessageBox.Show("Mật khẩu mới không trùng khớp.", "Lỗi", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else // Is valid
            {
                TaiKhoanDTO account = MainGUI.TaiKhoan;
                account.Password = txtChangedPassword.Text;
                try
                {
                    if (_taiKhoan.Update(account) > 0)
                    {
                        MessageBox.Show("Thay đổi mật khẩu thànhh công.", "Thông báo", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        btnLuu.Tag = "saved";
                    }
                    else
                    {
                        MessageBox.Show("Thay đổi mật khẩu thất bại.", "Lỗi", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private bool IsCorrectCurrentPassword()
        {
            return TaiKhoanDAO.EncryptPassword(txtCurrentPassword.Text + MainGUI.TaiKhoan.Username).Equals(MainGUI.TaiKhoan.Password);
        }

        private bool IsMatchNewPassword()
        {
            return txtChangedPassword.Text.Equals(txtRetypePassword.Text);
        }

        private void DoiMatKhauGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btnLuu.Tag is not null) return;

            // Display a MsgBox asking the user to save changes or abort.
            DialogResult choosen = MessageBox.Show("Mật khẩu mới chưa được lưu, lưu trước khi thoát?", "Xác nhận thoát", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (choosen == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else if (choosen == DialogResult.Yes)
            {
                btnLuu.PerformClick();
            }
        }
    }
}
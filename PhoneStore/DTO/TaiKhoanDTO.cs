namespace PhoneStore.DTO
{
    public class TaiKhoanDTO
    {
        public TaiKhoanDTO(string username, string password, int chucVu)
        {
            Username = username;
            Password = password;
            ChucVu = chucVu;
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public int ChucVu { get; set; }
    }
}
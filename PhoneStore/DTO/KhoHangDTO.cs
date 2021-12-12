namespace PhoneStore.DTO
{
    public class KhoHangDTO
    {
        public KhoHangDTO(int maCTHDNhap, string imei, bool trangThai)
        {
            MaCTHDNhap = maCTHDNhap;
            IMEI = imei;
            TrangThai = trangThai;
        }

        public KhoHangDTO(int maCTHDNhap, string imei)
        {
            MaCTHDNhap = maCTHDNhap;
            IMEI = imei;
            TrangThai = false;
        }

        public int MaCTHDNhap { get; set; }
        public string IMEI { get; set; }
        public bool TrangThai { get; set; } // true: sold and false: otherwise
    }
}
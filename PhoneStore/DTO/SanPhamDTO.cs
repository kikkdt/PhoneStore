namespace PhoneStore.DTO
{
    public class SanPhamDTO
    {
        public SanPhamDTO(int id, string tenSP, int maNSP, double giaNiemYet, int soLuongTon, int thoiGianBgiờ,
            string urlHinh, string moTa, int trangThai, bool daXoa)
        {
            ID = id;
            TenSP = tenSP;
            MaNSP = maNSP;
            GiaNiemYet = giaNiemYet;
            SoLuongTon = soLuongTon;
            ThoiGianBH = thoiGianBgiờ;
            UrlHinh = urlHinh;
            MoTa = moTa;
            TrangThai = trangThai;
            DaXoa = daXoa;
        }

        public SanPhamDTO(string tenSP, int maNSP, double giaNiemYet, int soLuongTon, int thoiGianBgiờ,
            string urlHinh, string moTa, int trangThai, bool daXoa)
        {
            ID = int.MinValue;
            TenSP = tenSP;
            MaNSP = maNSP;
            GiaNiemYet = giaNiemYet;
            SoLuongTon = soLuongTon;
            ThoiGianBH = thoiGianBgiờ;
            UrlHinh = urlHinh;
            MoTa = moTa;
            TrangThai = trangThai;
            DaXoa = daXoa;
        }

        public int ID { get; set; }
        public string TenSP { get; set; }
        public int MaNSP { get; set; }
        public double GiaNiemYet { get; set; }
        public int SoLuongTon { get; set; }
        public int ThoiGianBH { get; set; }
        public string UrlHinh { get; set; }
        public string MoTa { get; set; }
        public int TrangThai { get; set; }
        public bool DaXoa { get; set; }
    }
}
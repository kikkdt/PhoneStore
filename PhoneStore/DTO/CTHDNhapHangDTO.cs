namespace PhoneStore.DTO
{
    public class CTHDNhapHangDTO
    {
        public CTHDNhapHangDTO(int id, int maHDNH, int maSP, double giaNhap, int soLuong)
        {
            ID = id;
            MaHDNH = maHDNH;
            MaSP = maSP;
            GiaNhap = giaNhap;
            SoLuong = soLuong;
        }

        public CTHDNhapHangDTO(int maHDNH, int maSP, double giaNhap, int soLuong)
        {
            ID = int.MinValue;
            MaHDNH = maHDNH;
            MaSP = maSP;
            GiaNhap = giaNhap;
            SoLuong = soLuong;
        }

        public int ID { get; set; }
        public int MaHDNH { get; set; }
        public int MaSP { get; set; }
        public double GiaNhap { get; set; }
        public int SoLuong { get; set; }
    }
}
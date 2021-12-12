using System;

namespace PhoneStore.DTO
{
    public class HDNhapHangDTO
    {
        public HDNhapHangDTO(int maHDNH, int maNV, DateTime ngayLap)
        {
            MaHDNH = maHDNH;
            MaNV = maNV;
            NgayLap = ngayLap;
        }

        public HDNhapHangDTO(int maNV, DateTime ngayLap)
        {
            MaHDNH = int.MinValue;
            MaNV = maNV;
            NgayLap = ngayLap;
        }

        public int MaHDNH { get; set; }
        public int MaNV { get; set; }
        public DateTime NgayLap { get; set; }
    }
}
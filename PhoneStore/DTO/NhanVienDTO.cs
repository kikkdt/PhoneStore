using System;

namespace PhoneStore.DTO
{
    public class NhanVienDTO
    {
        public NhanVienDTO(int maNV, string hoTen, string gioiTinh, string sdt, DateTime ngaySinh, string username,
            string diaChi, bool daXoa)
        {
            MaNV = maNV;
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            SDT = sdt;
            NgaySinh = ngaySinh;
            Username = username;
            DiaChi = diaChi;
            DaXoa = daXoa;
        }

        public NhanVienDTO(string hoTen, string gioiTinh, string sdt, DateTime ngaySinh, string username, string diaChi,
            bool daXoa)
        {
            MaNV = int.MinValue;
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            SDT = sdt;
            NgaySinh = ngaySinh;
            Username = username;
            DiaChi = diaChi;
            DaXoa = daXoa;
        }

        public int MaNV { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public string SDT { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Username { get; set; }
        public string DiaChi { get; set; }
        public bool DaXoa { get; set; }
    }
}
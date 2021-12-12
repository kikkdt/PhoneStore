using System;

namespace PhoneStore.DTO
{
    public class GiaBanDTO
    {
        public GiaBanDTO(int maSP, DateTime ngayCapNhat, double giaBan)
        {
            MaSP = maSP;
            NgayCapNhat = ngayCapNhat;
            GiaBan = giaBan;
        }

        public int MaSP { get; set; }
        public DateTime NgayCapNhat { get; set; }
        public double GiaBan { get; set; }
    }
}
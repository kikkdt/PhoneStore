namespace PhoneStore.DTO
{
    public class ChucVuDTO
    {
        public ChucVuDTO(int maChucVu, string tenChucVu)
        {
            MaChucVu = maChucVu;
            TenChucVu = tenChucVu;
        }

        public int MaChucVu { get; set; }
        public string TenChucVu { get; set; }
    }
}
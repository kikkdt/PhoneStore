namespace PhoneStore.DTO
{
    public class TrangThaiSanPhamDTO
    {
        public TrangThaiSanPhamDTO(int maTTSP, string tenTTSP)
        {
            MaTTSP = maTTSP;
            TenTTSP = tenTTSP;
        }

        public int MaTTSP { get; set; }
        public string TenTTSP { get; set; }
    }
}
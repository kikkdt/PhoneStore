namespace PhoneStore.DTO
{
    public class NhomSanPhamDTO
    {
        public NhomSanPhamDTO(int maNSP, string tenNSP, int maDM, bool daXoa)
        {
            MaNSP = maNSP;
            TenNSP = tenNSP;
            MaDM = maDM;
            DaXoa = daXoa;
        }

        public NhomSanPhamDTO(string tenNSP, int maDM, bool daXoa)
        {
            MaNSP = int.MinValue;
            TenNSP = tenNSP;
            MaDM = maDM;
            DaXoa = daXoa;
        }

        public int MaNSP { get; set; }
        public string TenNSP { get; set; }
        public int MaDM { get; set; }
        public bool DaXoa { get; set; }
    }
}
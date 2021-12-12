namespace PhoneStore.DTO
{
    public class DanhMucDTO
    {
        public DanhMucDTO(int maDM, string tenDM, bool daXoa)
        {
            MaDM = maDM;
            TenDM = tenDM;
            DaXoa = daXoa;
        }

        public DanhMucDTO(string tenDM, bool daXoa)
        {
            MaDM = int.MinValue;
            TenDM = tenDM;
            DaXoa = daXoa;
        }

        public int MaDM { get; set; }
        public string TenDM { get; set; }
        public bool DaXoa { get; set; }
    }
}
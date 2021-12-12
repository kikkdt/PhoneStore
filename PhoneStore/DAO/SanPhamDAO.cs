using PhoneStore.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace PhoneStore.DAO
{
    public class SanPhamDAO
    {
        private string _query = "SELECT * FROM tb_SanPham";
        public DataSet Dset { get; set; }

        public SanPhamDAO()
        {
            GetData();
        }

        public DataSet GetData()
        {
            using (SqlDataAdapter sda = new SqlDataAdapter(_query, SqlServerProvider.ConnString))
            {
                Dset = new DataSet();
                sda.Fill(Dset, "tb_SanPham");

                Dset.Tables["tb_SanPham"].PrimaryKey = new[] { Dset.Tables["tb_SanPham"].Columns["ID"] };
                // ID is identity
                Dset.Tables["tb_SanPham"].Columns["ID"].AllowDBNull = true;
                return Dset;
            }
        }

        public DataTable GetDetail()
        {
            return SqlServerProvider.ExecuteStoredProcedure("up_GetCTSanPham");
        }

        public DataTable GetDetailByDanhMuc(int maDm)
        {
            return SqlServerProvider.ExecuteStoredProcedure("up_GetCTSanPhamByDanhMuc", new { MaDM = maDm });
        }

        public DataTable GetDetailByNhomSp(int maNsp)
        {
            return SqlServerProvider.ExecuteStoredProcedure("up_GetCTSanPhamByNhomSP", new { MaNSP = maNsp });
        }

        public DataTable SearchSanPham(string strSearch)
        {
            return SqlServerProvider.ExecuteStoredProcedure("up_SearchSanPham", new { StringSearch = strSearch });
        }

        public List<SanPhamDTO> GetList()
        {
            List<SanPhamDTO> lstSanPham = new List<SanPhamDTO>();
            DataTable dt = GetData().Tables["tb_SanPham"];
            foreach (DataRow row in dt.Rows)
            {
                lstSanPham.Add(new SanPhamDTO((int)row["ID"], (string)row["TenSP"], (int)row["MaNSP"], double.Parse(row["GiaNiemYet"].ToString()), (int)row["SoLuongTon"], (int)row["ThoiGianBH"], (string)row["UrlHinh"], (string)row["MoTa"], (int)row["TrangThai"], (bool)row["DaXoa"]));
            }

            return lstSanPham;
        }

        public SanPhamDTO GetSanPham(int maSP)
        {
            return GetList().Find(item => item.ID == maSP);
        }

        public bool IsExistTenSp(string tenSP)
        {
            return (int)SqlServerProvider.ExecuteScalar("SELECT COUNT(*) FROM tb_SanPham WHERE TenSP=N'" + tenSP + "'") > 0;
        }

        public int Insert(SanPhamDTO sanPham)
        {
            int res;
            DataRow newRow = Dset.Tables["tb_SanPham"].NewRow();
            try
            {
                newRow["TenSP"] = sanPham.TenSP;
                newRow["MaNSP"] = sanPham.MaNSP;
                newRow["GiaNiemYet"] = sanPham.GiaNiemYet;
                newRow["SoLuongTon"] = sanPham.SoLuongTon;
                newRow["ThoiGianBH"] = sanPham.ThoiGianBH;
                newRow["UrlHinh"] = sanPham.UrlHinh;
                newRow["MoTa"] = sanPham.MoTa;
                newRow["TrangThai"] = sanPham.TrangThai;
                newRow["DaXoa"] = sanPham.DaXoa;
                Dset.Tables["tb_SanPham"].Rows.Add(newRow);
                using (SqlDataAdapter sda = new SqlDataAdapter(_query, SqlServerProvider.ConnString))
                {
                    new SqlCommandBuilder(sda);
                    res = sda.Update(Dset, "tb_SanPham");
                }
            }
            catch (Exception)
            {
                newRow.Delete();
                throw;
            }
            return res;
        }

        public int Update(SanPhamDTO sanPham)
        {
            int res = 0;
            DataRow updateRow = Dset.Tables["tb_SanPham"].Rows.Find(sanPham.ID);
            if (updateRow is not null)
            {
                updateRow["TenSP"] = sanPham.TenSP;
                updateRow["MaNSP"] = sanPham.MaNSP;
                updateRow["GiaNiemYet"] = sanPham.GiaNiemYet;
                updateRow["SoLuongTon"] = sanPham.SoLuongTon;
                updateRow["ThoiGianBH"] = sanPham.ThoiGianBH;
                updateRow["UrlHinh"] = sanPham.UrlHinh;
                updateRow["MoTa"] = sanPham.MoTa;
                updateRow["TrangThai"] = sanPham.TrangThai;
                updateRow["DaXoa"] = sanPham.DaXoa;
                using (SqlDataAdapter sda = new SqlDataAdapter(_query, SqlServerProvider.ConnString))
                {
                    new SqlCommandBuilder(sda);
                    res = sda.Update(Dset, "tb_SanPham");
                }
            }

            return res;
        }

        public int Delete(int maSP)
        {
            int res = 0;
            // Delete foreign key
            if (new GiaBanDAO().Delete(maSP) > 0)
            {
                DataRow findRow = Dset.Tables["tb_SanPham"].Rows.Find(maSP);
                if (findRow is not null)
                {
                    findRow["DaXoa"] = true;
                    using (SqlDataAdapter sda = new SqlDataAdapter(_query, SqlServerProvider.ConnString))
                    {
                        new SqlCommandBuilder(sda);
                        res = sda.Update(Dset, "tb_SanPham");
                    }
                }
            }

            return res;
        }
    }
}
using PhoneStore.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace PhoneStore.DAO
{
    public class NhomSanPhamDAO
    {
        private string _query = "SELECT * FROM tb_NhomSanPham";
        public DataSet Dset { get; set; }

        public NhomSanPhamDAO()
        {
            GetData();
        }

        public DataSet GetData()
        {
            using (SqlDataAdapter sda = new SqlDataAdapter(_query, SqlServerProvider.ConnString))
            {
                Dset = new DataSet();
                sda.Fill(Dset, "tb_NhomSanPham");

                Dset.Tables["tb_NhomSanPham"].PrimaryKey = new[] { Dset.Tables["tb_NhomSanPham"].Columns["MaNSP"] };
                // MaNSP is identity
                Dset.Tables["tb_NhomSanPham"].Columns["MaNSP"].AllowDBNull = true;
                return Dset;
            }
        }

        public List<NhomSanPhamDTO> GetList()
        {
            List<NhomSanPhamDTO> lstNhoSP = new List<NhomSanPhamDTO>();
            DataTable dt = GetData().Tables["tb_NhomSanPham"];
            foreach (DataRow row in dt.Rows)
            {
                lstNhoSP.Add(new NhomSanPhamDTO((int)row["MaNSP"], (string)row["TenNSP"], (int)row["MaDM"],
                    (bool)row["DaXoa"]));
            }

            return lstNhoSP;
        }

        public int Insert(NhomSanPhamDTO nhomSP)
        {
            int res;
            DataRow newRow = Dset.Tables["tb_NhomSanPham"].NewRow();
            try
            {
                newRow["TenNSP"] = nhomSP.TenNSP;
                newRow["MaDM"] = nhomSP.MaDM;
                newRow["DaXoa"] = nhomSP.DaXoa;
                Dset.Tables["tb_NhomSanPham"].Rows.Add(newRow);
                using (SqlDataAdapter sda = new SqlDataAdapter(_query, SqlServerProvider.ConnString))
                {
                    new SqlCommandBuilder(sda);
                    res = sda.Update(Dset, "tb_NhomSanPham");
                }
            }
            catch (Exception)
            {
                newRow.Delete();
                throw;
            }
            return res;
        }

        public int Update(NhomSanPhamDTO nhomSP)
        {
            int res = 0;
            DataRow updateRow = Dset.Tables["tb_NhomSanPham"].Rows.Find(nhomSP.MaNSP);
            if (updateRow is not null)
            {
                updateRow["TenDM"] = nhomSP.TenNSP;
                updateRow["MaDM"] = nhomSP.MaDM;
                updateRow["DaXoa"] = nhomSP.DaXoa;
                using (SqlDataAdapter sda = new SqlDataAdapter(_query, SqlServerProvider.ConnString))
                {
                    new SqlCommandBuilder(sda);
                    res = sda.Update(Dset, "tb_NhomSanPham");
                    // Refresh data adapter
                    GetData();
                }
            }

            return res;
        }

        public int Delete(int maNSP)
        {
            int res = 0;
            DataRow findRow = Dset.Tables["tb_NhomSanPham"].Rows.Find(maNSP);
            if (findRow is not null)
            {
                findRow.Delete();
                using (SqlDataAdapter sda = new SqlDataAdapter(_query, SqlServerProvider.ConnString))
                {
                    new SqlCommandBuilder(sda);
                    res = sda.Update(Dset, "tb_NhomSanPham");
                }
            }

            return res;
        }
    }
}
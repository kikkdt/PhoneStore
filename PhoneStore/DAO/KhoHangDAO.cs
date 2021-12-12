using PhoneStore.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace PhoneStore.DAO
{
    public class KhoHangDAO
    {
        private string _query = "SELECT * FROM tb_KhoHang";
        public DataSet Dset { get; set; }

        public KhoHangDAO()
        {
            GetData();
        }

        public DataSet GetData()
        {
            using (SqlDataAdapter sda = new SqlDataAdapter(_query, SqlServerProvider.ConnString))
            {
                Dset = new DataSet();
                sda.Fill(Dset, "tb_KhoHang");

                Dset.Tables["tb_KhoHang"].PrimaryKey = new[] { Dset.Tables["tb_KhoHang"].Columns["MaCTHDNhap"], Dset.Tables["tb_KhoHang"].Columns["IMEI"] };
                return Dset;
            }
        }

        public DataTable GetKhoHang(int maCthdNhap)
        {
            string queryCondition = " WHERE MaCTHDNhap=" + maCthdNhap;
            using (SqlDataAdapter sda = new SqlDataAdapter(_query + queryCondition, SqlServerProvider.ConnString))
            {
                DataSet ds = new DataSet();
                sda.Fill(ds, "tb_KhoHang");

                ds.Tables["tb_KhoHang"].PrimaryKey = new[] { ds.Tables["tb_KhoHang"].Columns["MaCTHDNhap"], ds.Tables["tb_KhoHang"].Columns["IMEI"] };
                return ds.Tables["tb_KhoHang"];
            }
        }

        public bool IsExistIMEI(string imei)
        {
            return GetList().Exists(khoHang => khoHang.IMEI.Equals(imei, StringComparison.OrdinalIgnoreCase));
        }

        public List<KhoHangDTO> GetList()
        {
            List<KhoHangDTO> lstKhoHang = new List<KhoHangDTO>();
            DataTable dt = GetData().Tables["tb_KhoHang"];
            foreach (DataRow row in dt.Rows)
            {
                lstKhoHang.Add(new KhoHangDTO((int)row["MaCTHDNhap"], (string)row["IMEI"], (bool)row["TrangThai"]));
            }
            return lstKhoHang;
        }

        public int Insert(KhoHangDTO khoHang)
        {
            int res;
            DataRow newRow = Dset.Tables["tb_KhoHang"].NewRow();
            try
            {
                newRow["MaCTHDNhap"] = khoHang.MaCTHDNhap;
                newRow["IMEI"] = khoHang.IMEI;
                newRow["TrangThai"] = khoHang.TrangThai;
                Dset.Tables["tb_KhoHang"].Rows.Add(newRow);
                using (SqlDataAdapter sda = new SqlDataAdapter(_query, SqlServerProvider.ConnString))
                {
                    new SqlCommandBuilder(sda);
                    res = sda.Update(Dset, "tb_KhoHang");
                }
            }
            catch (Exception)
            {
                newRow.Delete();
                throw;
            }
            return res;
        }

        public int Update(KhoHangDTO khoHang)
        {
            int res = 0;
            DataRow updateRow = Dset.Tables["tb_KhoHang"].Rows.Find(new object[] { khoHang.MaCTHDNhap, khoHang.IMEI });
            if (updateRow is not null)
            {
                updateRow["TrangThai"] = khoHang.TrangThai;
                using (SqlDataAdapter sda = new SqlDataAdapter(_query, SqlServerProvider.ConnString))
                {
                    new SqlCommandBuilder(sda);
                    res = sda.Update(Dset, "tb_KhoHang");
                }
            }

            return res;
        }

        public int Update(DataTable dt)
        {
            int res;
            using (SqlDataAdapter sda = new SqlDataAdapter(_query, SqlServerProvider.ConnString))
            {
                new SqlCommandBuilder(sda);
                res = sda.Update(dt);
            }

            return res;
        }

        public int Delete(int maCthdNhap)
        {
            return SqlServerProvider.ExecuteNonQuery("DELETE FROM tb_KhoHang WHERE MaCTHDNhap=" + maCthdNhap);
        }
    }
}
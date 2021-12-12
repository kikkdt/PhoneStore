using PhoneStore.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace PhoneStore.DAO
{
    public class NhanVienDAO
    {
        private string _query = "SELECT * FROM tb_NhanVien";
        public DataSet Dset { get; set; }

        public NhanVienDAO()
        {
            GetData();
        }

        public DataSet GetData()
        {
            using (SqlDataAdapter sda = new SqlDataAdapter(_query, SqlServerProvider.ConnString))
            {
                Dset = new DataSet();
                sda.Fill(Dset, "tb_NhanVien");

                Dset.Tables["tb_NhanVien"].PrimaryKey = new[] { Dset.Tables["tb_NhanVien"].Columns["MaNV"] };
                // MaNV is identity
                Dset.Tables["tb_NhanVien"].Columns["MaNV"].AllowDBNull = true;
                return Dset;
            }
        }

        public DataTable GetDtNhanVien()
        {
            return SqlServerProvider.ExecuteStoredProcedure("up_GetNhanVien");
        }

        public List<NhanVienDTO> GetList()
        {
            List<NhanVienDTO> lstNhanVien = new List<NhanVienDTO>();
            DataTable dt = GetData().Tables["tb_NhanVien"];
            foreach (DataRow row in dt.Rows)
            {
                lstNhanVien.Add(new NhanVienDTO((int)row["MaNV"], (string)row["HoTen"], (string)row["GioiTinh"], (string)row["SDT"], (DateTime)row["NgaySinh"], (string)row["Username"], (string)row["DiaChi"], (bool)row["DaXoa"]));
            }
            return lstNhanVien;
        }

        public NhanVienDTO GetNhanVien(string username)
        {
            return GetList().Find(item => item.Username.Equals(username));
        }

        public DataTable SearchNhanVien(string strSearch)
        {
            return SqlServerProvider.ExecuteStoredProcedure("up_SearchNhanVien", new { StringSearch = strSearch });
        }

        public int Insert(NhanVienDTO nhanVien)
        {
            int res;
            DataRow newRow = Dset.Tables["tb_NhanVien"].NewRow();
            try
            {
                newRow["HoTen"] = nhanVien.HoTen;
                newRow["GioiTinh"] = nhanVien.GioiTinh;
                newRow["SDT"] = nhanVien.SDT;
                newRow["NgaySinh"] = nhanVien.NgaySinh;
                newRow["Username"] = nhanVien.Username;
                newRow["DiaChi"] = nhanVien.DiaChi;
                newRow["DaXoa"] = nhanVien.DaXoa;
                Dset.Tables["tb_NhanVien"].Rows.Add(newRow);
                using (SqlDataAdapter sda = new SqlDataAdapter(_query, SqlServerProvider.ConnString))
                {
                    new SqlCommandBuilder(sda);
                    res = sda.Update(Dset, "tb_NhanVien");
                    GetData();
                }
            }
            catch (Exception)
            {
                newRow.Delete();
                throw;
            }
            return res;
        }

        public int Update(NhanVienDTO nhanVien)
        {
            int res = 0;
            DataRow updateRow = Dset.Tables["tb_NhanVien"].Rows.Find(nhanVien.MaNV);
            if (updateRow is not null)
            {
                updateRow["HoTen"] = nhanVien.HoTen;
                updateRow["GioiTinh"] = nhanVien.GioiTinh;
                updateRow["SDT"] = nhanVien.SDT;
                updateRow["NgaySinh"] = nhanVien.NgaySinh;
                updateRow["Username"] = nhanVien.Username;
                updateRow["DiaChi"] = nhanVien.DiaChi;
                updateRow["DaXoa"] = nhanVien.DaXoa;
                using (SqlDataAdapter sda = new SqlDataAdapter(_query, SqlServerProvider.ConnString))
                {
                    new SqlCommandBuilder(sda);
                    res = sda.Update(Dset, "tb_NhanVien");
                }
            }

            return res;
        }

        public int Delete(int maNv)
        {
            int res = 0;
            DataRow updateRow = Dset.Tables["tb_NhanVien"].Rows.Find(maNv);
            if (updateRow is not null)
            {
                updateRow["DaXoa"] = true;
                using (SqlDataAdapter sda = new SqlDataAdapter(_query, SqlServerProvider.ConnString))
                {
                    new SqlCommandBuilder(sda);
                    res = sda.Update(Dset, "tb_NhanVien");
                }
            }

            return res;
        }
    }
}
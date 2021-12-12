using PhoneStore.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace PhoneStore.DAO
{
    public class CTHDNhapHangDAO
    {
        private string _query = "SELECT * FROM tb_CTHDNhapHang";
        public DataSet Dset { get; set; }

        public CTHDNhapHangDAO()
        {
            GetData();
        }

        public DataSet GetData()
        {
            using (SqlDataAdapter sda = new SqlDataAdapter(_query, SqlServerProvider.ConnString))
            {
                Dset = new DataSet();
                sda.Fill(Dset, "tb_CTHDNhapHang");

                Dset.Tables["tb_CTHDNhapHang"].PrimaryKey = new[] { Dset.Tables["tb_CTHDNhapHang"].Columns["ID"] };
                // ID is identity
                Dset.Tables["tb_CTHDNhapHang"].Columns["ID"].AllowDBNull = true;
                return Dset;
            }
        }

        public List<CTHDNhapHangDTO> GetList()
        {
            List<CTHDNhapHangDTO> lstCthdNhap = new List<CTHDNhapHangDTO>();
            DataTable dt = GetData().Tables["tb_CTHDNhapHang"];
            foreach (DataRow row in dt.Rows)
            {
                lstCthdNhap.Add(new CTHDNhapHangDTO((int)row["ID"], (int)row["MaHDNH"], (int)row["MaSP"], double.Parse(row["GiaNhap"].ToString()), (int)row["SoLuong"]));
            }
            return lstCthdNhap;
        }

        public CTHDNhapHangDTO GetCthdNhapHangById(int id)
        {
            return GetList().Find(item => item.ID == id);
        }

        public DataTable GetCthdNhapHang(int maHDNH)
        {
            return SqlServerProvider.ExecuteStoredProcedure("up_GetCTHDNhap", new { MaHDNH = maHDNH });
        }

        public CTHDNhapHangDTO GetCthdNhapHang(int maHDNH, int maSP)
        {
            return GetList().Find(item => item.MaHDNH == maHDNH && item.MaSP == maSP);
        }

        public int Insert(CTHDNhapHangDTO cthdNhap)
        {
            int res;
            DataRow newRow = GetData().Tables["tb_CTHDNhapHang"].NewRow();
            try
            {
                newRow["MaHDNH"] = cthdNhap.MaHDNH;
                newRow["MaSP"] = cthdNhap.MaSP;
                newRow["GiaNhap"] = cthdNhap.GiaNhap;
                newRow["SoLuong"] = cthdNhap.SoLuong;
                Dset.Tables["tb_CTHDNhapHang"].Rows.Add(newRow);
                using (SqlDataAdapter sda = new SqlDataAdapter(_query, SqlServerProvider.ConnString))
                {
                    new SqlCommandBuilder(sda);
                    res = sda.Update(Dset, "tb_CTHDNhapHang");
                }
            }
            catch (Exception)
            {
                newRow.Delete();
                throw;
            }
            return res;
        }

        public int Update(CTHDNhapHangDTO cthdNhap)
        {
            int res = 0;
            DataRow updateRow = GetData().Tables["tb_CTHDNhapHang"].Rows.Find(cthdNhap.ID);
            if (updateRow is not null)
            {
                updateRow["MaHDNH"] = cthdNhap.MaHDNH;
                updateRow["MaSP"] = cthdNhap.MaSP;
                updateRow["GiaNhap"] = cthdNhap.GiaNhap;
                updateRow["SoLuong"] = cthdNhap.SoLuong;
                using (SqlDataAdapter sda = new SqlDataAdapter(_query, SqlServerProvider.ConnString))
                {
                    new SqlCommandBuilder(sda);
                    res = sda.Update(Dset, "tb_CTHDNhapHang");
                }
            }

            return res;
        }

        public int Delete(int id)
        {
            int res = 0;
            DataRow findRow = GetData().Tables["tb_CTHDNhapHang"].Rows.Find(id);
            if (findRow is not null)
            {
                findRow.Delete();
                using (SqlDataAdapter sda = new SqlDataAdapter(_query, SqlServerProvider.ConnString))
                {
                    new SqlCommandBuilder(sda);
                    res = sda.Update(Dset, "tb_CTHDNhapHang");
                }
            }

            return res;
        }
    }
}
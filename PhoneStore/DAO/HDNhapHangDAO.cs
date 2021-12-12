using PhoneStore.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace PhoneStore.DAO
{
    public class HDNhapHangDAO
    {
        private string _query = "SELECT * FROM tb_HDNhapHang";
        public DataSet Dset { get; set; }

        public HDNhapHangDAO()
        {
            GetData();
        }

        public DataSet GetData()
        {
            using (SqlDataAdapter sda = new SqlDataAdapter(_query, SqlServerProvider.ConnString))
            {
                Dset = new DataSet();
                sda.Fill(Dset, "tb_HDNhapHang");

                Dset.Tables["tb_HDNhapHang"].PrimaryKey = new[] { Dset.Tables["tb_HDNhapHang"].Columns["MaHDNH"] };
                // MaHDNH is identity
                Dset.Tables["tb_HDNhapHang"].Columns["MaHDNH"].AllowDBNull = true;
                return Dset;
            }
        }

        public List<HDNhapHangDTO> GetList()
        {
            List<HDNhapHangDTO> lstHdnh = new List<HDNhapHangDTO>();
            DataTable dt = GetData().Tables["tb_HDNhapHang"];
            foreach (DataRow row in dt.Rows)
            {
                lstHdnh.Add(new HDNhapHangDTO((int)row["MaHDNH"], (int)row["MaNV"], (DateTime)row["NgayLap"]));
            }
            return lstHdnh;
        }

        public HDNhapHangDTO GetHDNhapHang(int maNv, DateTime ngayLap)
        {
            return GetList().Find(item => (item.MaNV == maNv && item.NgayLap.DayOfYear == ngayLap.DayOfYear && item.NgayLap.Hour == ngayLap.Hour && item.NgayLap.Minute == ngayLap.Minute && item.NgayLap.Second == ngayLap.Second));
        }

        public DataTable GetLichSuHDNhapHang()
        {
            return SqlServerProvider.ExecuteStoredProcedure("up_GetLichSuHDNH");
        }

        public DataTable GetLichSuHDNhapHang(DateTime from, DateTime to)
        {
            return SqlServerProvider.ExecuteStoredProcedure("up_GetLichSuHDNHByDate", new { From = from, To = to });
        }

        public int Insert(HDNhapHangDTO hdnh)
        {
            int res;
            DataRow newRow = Dset.Tables["tb_HDNhapHang"].NewRow();
            try
            {
                newRow["MaNV"] = hdnh.MaNV;
                newRow["NgayLap"] = hdnh.NgayLap;
                Dset.Tables["tb_HDNhapHang"].Rows.Add(newRow);
                using (SqlDataAdapter sda = new SqlDataAdapter(_query, SqlServerProvider.ConnString))
                {
                    new SqlCommandBuilder(sda);
                    res = sda.Update(Dset, "tb_HDNhapHang");
                }
            }
            catch (Exception)
            {
                newRow.Delete();
                throw;
            }
            return res;
        }
    }
}
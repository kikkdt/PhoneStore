using PhoneStore.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace PhoneStore.DAO
{
    public class GiaBanDAO
    {
        private string _query = "SELECT * FROM tb_GiaBanSP";
        public DataSet Dset { get; set; }

        public GiaBanDAO()
        {
            GetData();
        }

        public DataSet GetData()
        {
            using (SqlDataAdapter sda = new SqlDataAdapter(_query, SqlServerProvider.ConnString))
            {
                Dset = new DataSet();
                sda.Fill(Dset, "tb_GiaBanSP");

                Dset.Tables["tb_GiaBanSP"].PrimaryKey = new[]
                    {Dset.Tables["tb_GiaBanSP"].Columns["MaSP"], Dset.Tables["tb_GiaBanSP"].Columns["NgayCapNhat"]};
                return Dset;
            }
        }

        public List<GiaBanDTO> GetList(int maSp)
        {
            List<GiaBanDTO> lstGiaBan = new List<GiaBanDTO>();
            DataRow[] rows = GetData().Tables["tb_GiaBanSP"].Select("MaSP=" + maSp);
            foreach (DataRow row in rows)
            {
                lstGiaBan.Add(new GiaBanDTO((int)row["MaSP"], (DateTime)row["NgayCapNhat"], (double)row["GiaBan"]));
            }

            return lstGiaBan;
        }

        public int Insert(GiaBanDTO giaBan)
        {
            int res;
            DataRow newRow = Dset.Tables["tb_GiaBanSP"].NewRow();
            try
            {
                newRow["MaSP"] = giaBan.MaSP;
                newRow["NgayCapNhat"] = giaBan.NgayCapNhat;
                newRow["GiaBan"] = giaBan.GiaBan;
                Dset.Tables["tb_GiaBanSP"].Rows.Add(newRow);
                using (SqlDataAdapter sda = new SqlDataAdapter(_query, SqlServerProvider.ConnString))
                {
                    new SqlCommandBuilder(sda);
                    res = sda.Update(Dset, "tb_GiaBanSP");
                }
            }
            catch (Exception)
            {
                newRow.Delete();
                throw;
            }
            return res;
        }

        public int Update(GiaBanDTO giaBan)
        {
            int res = 0;
            DataRow updateRow = Dset.Tables["tb_GiaBanSP"].Rows.Find(new object[] { giaBan.MaSP, giaBan.NgayCapNhat });
            if (updateRow is not null)
            {
                updateRow["GiaBan"] = giaBan.GiaBan;
                using (SqlDataAdapter sda = new SqlDataAdapter(_query, SqlServerProvider.ConnString))
                {
                    new SqlCommandBuilder(sda);
                    res = sda.Update(Dset, "tb_GiaBanSP");
                }
            }

            return res;
        }

        public int Delete(int maSp, DateTime ngayCapNhat)
        {
            int res = 0;
            DataRow findRow = Dset.Tables["tb_GiaBanSP"].Rows.Find(new object[] { maSp, ngayCapNhat });
            if (findRow is not null)
            {
                findRow.Delete();
                using (SqlDataAdapter sda = new SqlDataAdapter(_query, SqlServerProvider.ConnString))
                {
                    new SqlCommandBuilder(sda);
                    res = sda.Update(Dset, "tb_GiaBanSP");
                }
            }

            return res;
        }

        public int Delete(int maSp)
        {
            return SqlServerProvider.ExecuteNonQuery("DELETE FROM tb_GiaBanSP WHERE MaSP=" + maSp);
        }
    }
}
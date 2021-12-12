using PhoneStore.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace PhoneStore.DAO
{
    public class DanhMucDAO
    {
        private string _query = "SELECT * FROM tb_DanhMuc";
        public DataSet Dset { get; set; }

        public DanhMucDAO()
        {
            GetData();
        }

        public DataSet GetData()
        {
            using (SqlDataAdapter sda = new SqlDataAdapter(_query, SqlServerProvider.ConnString))
            {
                Dset = new DataSet();
                sda.Fill(Dset, "tb_DanhMuc");

                Dset.Tables["tb_DanhMuc"].PrimaryKey = new[] { Dset.Tables["tb_DanhMuc"].Columns["MaDM"] };
                // MaDM is identity
                Dset.Tables["tb_DanhMuc"].Columns["MaDM"].AllowDBNull = true;
                return Dset;
            }
        }

        public List<DanhMucDTO> GetList()
        {
            List<DanhMucDTO> lstDanhMuc = new List<DanhMucDTO>();
            DataTable dt = GetData().Tables["tb_DanhMuc"];
            foreach (DataRow row in dt.Rows)
            {
                lstDanhMuc.Add(new DanhMucDTO((int)row["MaDM"], (string)row["TenDM"], (bool)row["DaXoa"]));
            }
            return lstDanhMuc;
        }

        public int Insert(DanhMucDTO danhMuc)
        {
            int res;
            DataRow newRow = Dset.Tables["tb_DanhMuc"].NewRow();
            try
            {
                newRow["TenDM"] = danhMuc.TenDM;
                newRow["DaXoa"] = danhMuc.DaXoa;
                Dset.Tables["tb_DanhMuc"].Rows.Add(newRow);
                using (SqlDataAdapter sda = new SqlDataAdapter(_query, SqlServerProvider.ConnString))
                {
                    new SqlCommandBuilder(sda);
                    res = sda.Update(Dset, "tb_DanhMuc");
                }
            }
            catch (Exception)
            {
                newRow.Delete();
                throw;
            }
            return res;
        }

        public int Update(DanhMucDTO danhMuc)
        {
            int res = 0;
            DataRow updateRow = Dset.Tables["tb_DanhMuc"].Rows.Find(danhMuc.MaDM);
            if (updateRow is not null)
            {
                updateRow["TenDM"] = danhMuc.TenDM;
                updateRow["DaXoa"] = danhMuc.DaXoa;
                using (SqlDataAdapter sda = new SqlDataAdapter(_query, SqlServerProvider.ConnString))
                {
                    new SqlCommandBuilder(sda);
                    res = sda.Update(Dset, "tb_DanhMuc");
                }
            }

            return res;
        }

        public int Delete(int maDM)
        {
            int res = 0;
            DataRow findRow = Dset.Tables["tb_DanhMuc"].Rows.Find(maDM);
            if (findRow is not null)
            {
                findRow.Delete();
                using (SqlDataAdapter sda = new SqlDataAdapter(_query, SqlServerProvider.ConnString))
                {
                    new SqlCommandBuilder(sda);
                    res = sda.Update(Dset, "tb_DanhMuc");
                }
            }

            return res;
        }
    }
}
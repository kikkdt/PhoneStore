using System.Data;
using System.Data.SqlClient;

namespace PhoneStore.DAO
{
    public class TrangThaiSanPhamDAO
    {
        private string _query = "SELECT * FROM tb_TrangThaiSanPham";
        public DataSet Dset { get; set; }

        public TrangThaiSanPhamDAO()
        {
            GetData();
        }

        public DataSet GetData()
        {
            using (SqlDataAdapter sda = new SqlDataAdapter(_query, SqlServerProvider.ConnString))
            {
                Dset = new DataSet();
                sda.Fill(Dset, "tb_TrangThaiSanPham");

                Dset.Tables["tb_TrangThaiSanPham"].PrimaryKey =
                    new[] { Dset.Tables["tb_TrangThaiSanPham"].Columns["MaTTSP"] };
                return Dset;
            }
        }
    }
}
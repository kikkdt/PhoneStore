using System.Data;
using System.Data.SqlClient;

namespace PhoneStore.DAO
{
    public class ChucVuDAO
    {
        private string _query = "SELECT * FROM tb_ChucVu";
        public DataSet Dset { get; set; }

        public ChucVuDAO()
        {
            GetData();
        }

        public DataSet GetData()
        {
            using (SqlDataAdapter sda = new SqlDataAdapter(_query, SqlServerProvider.ConnString))
            {
                Dset = new DataSet();
                sda.Fill(Dset, "tb_ChucVu");

                Dset.Tables["tb_ChucVu"].PrimaryKey = new[] { Dset.Tables["tb_ChucVu"].Columns["MaChucVu"] };
                // MaChucVu is identity
                Dset.Tables["tb_ChucVu"].Columns["MaChucVu"].AllowDBNull = true;
                return Dset;
            }
        }
    }
}
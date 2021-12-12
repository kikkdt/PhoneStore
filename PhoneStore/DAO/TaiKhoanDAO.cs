using PhoneStore.DTO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace PhoneStore.DAO
{
    public class TaiKhoanDAO
    {
        private string _query = "SELECT * FROM tb_TaiKhoan";
        public DataSet Dset { get; set; }

        public TaiKhoanDAO()
        {
            GetData();
        }

        public DataSet GetData()
        {
            using (SqlDataAdapter sda = new SqlDataAdapter(_query, SqlServerProvider.ConnString))
            {
                Dset = new DataSet();
                sda.Fill(Dset, "tb_TaiKhoan");

                Dset.Tables["tb_TaiKhoan"].PrimaryKey = new[] { Dset.Tables["tb_TaiKhoan"].Columns["Username"] };
                return Dset;
            }
        }

        public DataRow[] GetLikeUsername(string username)
        {
            return GetData().Tables["tb_TaiKhoan"].Select("Username LIKE '" + username + "%'");
        }

        private string RemoveUnicodeString(string input)
        {
            string[] str = input.Trim().ToLower().Split(' ');
            // My Example Name => return "nameme" (Name & M & E)
            input = str[str.Length - 1];
            for (int i = 0; i < str.Length - 1; i++)
            {
                input += str[i][0];
            }

            input = input.ToLower().Replace(" ", string.Empty);
            input = Regex.Replace(input, @"à|á|ạ|ả|ã|â|ầ|ấ|ậ|ẩ|ẫ|ă|ằ|ắ|ặ|ẳ|ẵ", "a");
            input = Regex.Replace(input, "è|é|ẹ|ẻ|ẽ|ê|ề|ế|ệ|ể|ễ", "e");
            input = Regex.Replace(input, @"ì|í|ị|ỉ|ĩ", "i");
            input = Regex.Replace(input, @"ò|ó|ọ|ỏ|õ|ô|ồ|ố|ộ|ổ|ỗ|ơ|ờ|ớ|ợ|ở|ỡ", "o");
            input = Regex.Replace(input, @"ù|ú|ụ|ủ|ũ|ư|ừ|ứ|ự|ử|ữ", "u");
            input = Regex.Replace(input, @"ỳ|ý|ỵ|ỷ|ỹ", "y");
            input = Regex.Replace(input, @"đ", "d");
            // Some system encode vietnamese combining accent as individual utf-8 characters
            input = Regex.Replace(input, @"/\u0300|\u0301|\u0303|\u0309|\u0323/ g", ""); // Huyền sắc hỏi ngã nặng

            return input;
        }

        public string CreateUsername(string hoTen)
        {
            string username = RemoveUnicodeString(hoTen);
            DataRow[] rows = GetLikeUsername(username);
            if (rows.Length > 0)
            {
                username += rows.Length;
            }

            return username;
        }

        public static string EncryptPassword(string input)
        {
            var encrypt = MD5.Create();
            var hashCode = encrypt.ComputeHash(Encoding.Unicode.GetBytes(input));

            var stringBuilder = new StringBuilder();
            foreach (var t in hashCode)
                stringBuilder.Append(t.ToString("x2"));
            return stringBuilder.ToString();
        }

        public TaiKhoanDTO Login(string username, string password)
        {
            DataTable dt = SqlServerProvider.ExecuteStoredProcedure("up_Login",
                new { Username = username, Password = EncryptPassword(password + username) });
            if (dt.Rows.Count > 0)
            {
                return new TaiKhoanDTO(dt.Rows[0]["Username"].ToString(), dt.Rows[0]["Password"].ToString(),
                    (int)dt.Rows[0]["ChucVu"]);
            }
            else return null;
        }

        public int Insert(TaiKhoanDTO taiKhoan)
        {
            int res;
            DataRow newRow = Dset.Tables["tb_TaiKhoan"].NewRow();
            try
            {
                newRow["Username"] = taiKhoan.Username;
                newRow["Password"] = EncryptPassword(taiKhoan.Password + taiKhoan.Username);
                newRow["ChucVu"] = taiKhoan.ChucVu;
                Dset.Tables["tb_TaiKhoan"].Rows.Add(newRow);
                using (SqlDataAdapter sda = new SqlDataAdapter(_query, SqlServerProvider.ConnString))
                {
                    new SqlCommandBuilder(sda);
                    res = sda.Update(Dset, "tb_TaiKhoan");
                }
            }
            catch (Exception)
            {
                newRow.Delete();
                throw;
            }
            return res;
        }

        public int Update(TaiKhoanDTO taiKhoan)
        {
            int res = 0;
            DataRow updateRow = Dset.Tables["tb_TaiKhoan"].Rows.Find(taiKhoan.Username);
            if (updateRow is not null)
            {
                updateRow["Password"] = EncryptPassword(taiKhoan.Password + taiKhoan.Username);
                updateRow["ChucVu"] = taiKhoan.ChucVu;
                using (SqlDataAdapter sda = new SqlDataAdapter(_query, SqlServerProvider.ConnString))
                {
                    new SqlCommandBuilder(sda);
                    res = sda.Update(Dset, "tb_TaiKhoan");
                }
            }

            return res;
        }

        public int ResetPassword(string username)
        {
            int res = 0;
            DataRow updateRow = Dset.Tables["tb_TaiKhoan"].Rows.Find(username);
            if (updateRow is not null)
            {
                updateRow["Password"] = EncryptPassword("123" + username);
                using (SqlDataAdapter sda = new SqlDataAdapter(_query, SqlServerProvider.ConnString))
                {
                    new SqlCommandBuilder(sda);
                    res = sda.Update(Dset, "tb_TaiKhoan");
                }
            }

            return res;
        }

        public int Delete(string username)
        {
            int res = 0;
            DataRow findRow = Dset.Tables["tb_TaiKhoan"].Rows.Find(username);
            if (findRow is not null)
            {
                findRow.Delete();
                using (SqlDataAdapter sda = new SqlDataAdapter(_query, SqlServerProvider.ConnString))
                {
                    new SqlCommandBuilder(sda);
                    res = sda.Update(Dset, "tb_TaiKhoan");
                }
            }

            return res;
        }
    }
}
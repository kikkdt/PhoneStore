using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace PhoneStore.DAO
{
    public class SqlServerProvider
    {
        public static string ConnString { get; } =
            "Data Source=KIKKDT;Initial Catalog=dbPhoneStore;User ID=sa;Password=123";

        public static DataTable ExecuteQuery(string query)
        {
            var dataResult = new DataTable();
            using (var connection = new SqlConnection(ConnString))
            {
                try
                {
                    connection.Open();

                    var sqlCmd = new SqlCommand(query, connection);
                    var sda = new SqlDataAdapter(sqlCmd);
                    sda.Fill(dataResult);
                }
                finally
                {
                    connection.Close();
                }

                return dataResult;
            }
        }

        public static DataTable ExecuteStoredProcedure(string procedureName)
        {
            var ds = new DataSet();
            using (var connection = new SqlConnection(ConnString))
            {
                try
                {
                    connection.Open();

                    var sqlCmd = new SqlCommand(procedureName, connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    var sda = new SqlDataAdapter(sqlCmd);
                    sda.Fill(ds);
                }
                finally
                {
                    connection.Close();
                }
            }

            return ds.Tables[0];
        }

        public static DataTable ExecuteStoredProcedure(string procedureName, object model)
        {
            var ds = new DataSet();
            var parameters = GenerateSqlParameters(model);
            using (var connection = new SqlConnection(ConnString))
            {
                try
                {
                    connection.Open();

                    var sqlCmd = new SqlCommand(procedureName, connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    foreach (var param in parameters) sqlCmd.Parameters.Add(param);
                    var sda = new SqlDataAdapter(sqlCmd);
                    sda.Fill(ds);
                }
                finally
                {
                    connection.Close();
                }
            }

            return ds.Tables[0];
        }

        private static List<SqlParameter> GenerateSqlParameters(object model)
        {
            var paramList = new List<SqlParameter>();
            var modelType = model.GetType();
            var properties = modelType.GetProperties();
            foreach (var property in properties)
                paramList.Add(property.GetValue(model) is null
                    ? new SqlParameter(property.Name, DBNull.Value)
                    : new SqlParameter(property.Name, property.GetValue(model)));
            return paramList;
        }

        public static int ExecuteNonQuery(string query)
        {
            var rowAffected = 0;
            using (var connection = new SqlConnection(ConnString))
            {
                try
                {
                    connection.Open();

                    var sqlCmd = new SqlCommand(query, connection);
                    rowAffected = sqlCmd.ExecuteNonQuery();
                }
                finally
                {
                    connection.Close();
                }
            }

            return rowAffected;
        }

        public static int ExecuteNonQuery(string query, object model)
        {
            var rowAffected = 0;
            var parameters = GenerateSqlParameters(model);
            using (var connection = new SqlConnection(ConnString))
            {
                try
                {
                    connection.Open();

                    var sqlCmd = new SqlCommand(query, connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    foreach (var param in parameters) sqlCmd.Parameters.Add(param);
                    rowAffected = sqlCmd.ExecuteNonQuery();
                }
                finally
                {
                    connection.Close();
                }
            }

            return rowAffected;
        }

        public static object ExecuteScalar(string query)
        {
            object dataResult = null;
            using (var connection = new SqlConnection(ConnString))
            {
                try
                {
                    connection.Open();

                    var sqlCmd = new SqlCommand(query, connection);
                    dataResult = sqlCmd.ExecuteScalar();
                }
                finally
                {
                    connection.Close();
                }

                return dataResult;
            }
        }
    }
}
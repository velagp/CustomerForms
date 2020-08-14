using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace MyCustomerForms
{
   public class DBHelper
    {
        private string _connectionString { get; set; }
        public DBHelper()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["CustomerConnectionString"].ConnectionString;
        }

        public void CreateConnection()
        {
            try
            {
                SqlConnection con = new SqlConnection(_connectionString);
            }
            catch (Exception)
            {
                throw;

            }

        }

        public SqlCommand CreateCommand(SqlConnection con, string command, params Object[] parameters)
        {
            try {
                con.Open();
                SqlCommand cmd = new SqlCommand(command);
                //foreach (var param in parameters)
                //{
                //    cmd.Parameters.Add()
                //}
                return cmd;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

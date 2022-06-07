using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace test_DB
{
    class DataBase
    {
        SqlConnection SqlConnection = new SqlConnection(@"Data Source = localhost\SQLEXPRESS; Initial Catalog = WSS; Integrated Security = True");

        public void openConnection()
        {
            if(SqlConnection.State == System.Data.ConnectionState.Closed)
            {
                SqlConnection.Open();
            }
        }

        public void closeConnection()
        {
            if(SqlConnection.State == System.Data.ConnectionState.Open)
            {
                SqlConnection.Close();
            }
        }

        public SqlConnection getSqlConnection()
        {
            return SqlConnection;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data.SqlClient;

namespace DB
{
    internal class CorporacionBD
    {
        private static readonly string ConnectionString =
                    "Data Source=DESKTOP-588G3OU,1433;" //?????
                    + "Initial Catalog=BD_Corporacion ;"
                    + "Integrated Security=True;" 
                    + "Encrypt=False;"
                    + "TrustServerCertificate=False;"
                    + "Connection Timeout=30;";

        private SqlConnection connection;

        public CorporacionBD()
        {
            connection = GetConnection();
        }

        public static SqlConnection GetConnection()
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                return sqlConnection;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }
    








    }
}

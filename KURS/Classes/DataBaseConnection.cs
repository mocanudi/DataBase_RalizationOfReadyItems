using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KURS.Classes
{
    class DataBase
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source = DIN; Initial Catalog = test_bd; Integrated Security = True");

        
        public void OpenConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void ClosedConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }


        public SqlConnection getConnection()
        {
            return sqlConnection;
        }
    }
}

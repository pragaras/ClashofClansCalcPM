using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace coc_database
{
    public class ClashDatabase
    {
        public void db_insert(string connectionstring, string insertstring)
        {
            SqlConnection cnn = new SqlConnection(connectionstring);

            cnn.Close();
        }
        public void db_update(string connectionstring, string updatestring)
        {
            SqlConnection cnn = new SqlConnection(connectionstring);

            cnn.Close();
        }

        public void db_update(string connectionstring, string updatestring, string where)
        {
            SqlConnection cnn = new SqlConnection(connectionstring);

            cnn.Close();
        }
        public void db_select(string connectionstring, string table, string coloumns = "*")
        {
            SqlConnection cnn = new SqlConnection(connectionstring);

            cnn.Close();
        }

        public void db_select(string connectionstring, string table, string coloumns, string where)
        {
            SqlConnection cnn = new SqlConnection(connectionstring);

            cnn.Close();
        }
    }
}

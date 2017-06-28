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
        private List<string> readerList = new List<string>();
        public void db_insert(string connectionstring, string insertstring)
        {
            SqlConnection cnn = new SqlConnection(connectionstring);
            cnn.Open();
            try
            {
                
                SqlCommand com = new SqlCommand(insertstring, cnn);
                com.ExecuteNonQuery();
                
            }
            catch(Exception d)
            {
                string data = d.Data.ToString();
            }
            cnn.Close();
        }
        public void db_update(string connectionstring, string updatestring)
        {
            SqlConnection cnn = new SqlConnection(connectionstring);
            cnn.Open();
            try
            {

                SqlCommand com = new SqlCommand(updatestring, cnn);
                com.ExecuteNonQuery();

            }
            catch (Exception d)
            {

            }
            cnn.Close();
        }

        public void db_update(string connectionstring, string updatestring, string where)
        {
            SqlConnection cnn = new SqlConnection(connectionstring);
            cnn.Open();
            try
            {

                SqlCommand com = new SqlCommand(updatestring + " " + where, cnn);
                com.ExecuteNonQuery();

            }
            catch (Exception d)
            {

            }
            cnn.Close();
        }
        public List<String> db_select(string connectionstring, string selectstring)
        {
            int i = 0;
            readerList.Clear();
            SqlConnection cnn = new SqlConnection(connectionstring);
            cnn.Open();
            try
            {
                SqlCommand com = new SqlCommand(selectstring, cnn);
                SqlDataReader reader = com.ExecuteReader();
                while(reader.Read())
                {
                    readerList.Add(reader[i].ToString());
                    i++;
                }

            }
            catch (Exception d)
            {
                string except = d.Data.ToString();
            }
            cnn.Close();
            return readerList;
        }

        public List<string> db_select(string connectionstring, string selectstring, string where)
        {
            int i = 0;
            readerList.Clear();
            SqlConnection cnn = new SqlConnection(connectionstring);
            cnn.Open();
            try
            {
                SqlCommand com = new SqlCommand(selectstring + " " + where, cnn);
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    readerList.Add(reader[i].ToString());
                    i++;
                }

            }
            catch (Exception d)
            {

            }
            cnn.Close();
            return readerList;
        }
    }
}

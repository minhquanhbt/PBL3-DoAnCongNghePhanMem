using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ĐoAnCongNghePhanMem.DAO
{
    public class DBHelper
    {
        private static DBHelper _Instance;
        public SqlConnection cnn { get; set; }
        public static DBHelper Instance
        {
            get
            {
                if (_Instance == null)
                {
                    string cnnstr = @"Data Source=DESKTOP-75872NT\SQLEXPRESS;Initial Catalog=PBL3;Integrated Security=True";
                    _Instance = new DBHelper(cnnstr);
                }
                return _Instance;
            }
            private set { }
        }
        public DBHelper(string s)
        {
            cnn = new SqlConnection(s);
        }
        public DataTable GetRecords(string query)
        {
            DataTable data = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, cnn);
            cnn.Open();
            da.Fill(data);
            cnn.Close();
            return data;
        }

        public bool ExecuteDB(string query)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cnn.Open();
                if (cmd.ExecuteNonQuery() < 0) return false;
                cnn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                cnn.Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Helper
{
    static class Sql
    {
        static string connectionString = "Server=DESKTOP-9GSQT59\\SQLEXPRESS; Database=SpotifyMain; Trusted_Connection=True";
        static SqlConnection _connection;
        public static SqlConnection Connection
        {
            get
            {
                if (_connection == null)
                {
                    _connection = new SqlConnection(connectionString);
                }
                return _connection;
            }
        }
        public static void ExecCommand(string command)
        {
            Connection.Open();
            using (SqlCommand cmd = new SqlCommand(command, Connection))
            {
                cmd.ExecuteNonQuery();
            }
            Connection.Close();
        }
        public static DataTable ExecQuery(string query)
        {
            DataTable dt = new DataTable();
            Connection.Open();
            using (SqlDataAdapter da = new SqlDataAdapter(query, Connection))
            {
                da.Fill(dt);
            }
            Connection.Close();
            return dt;
        }
    }
}

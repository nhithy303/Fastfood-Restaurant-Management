using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DAL
{
    public class DatabaseAccess
    {
        private static SqlConnection connection = null;

        public DatabaseAccess()
        {
            string server = "LAPTOP-NL39PTHM\\MEI";
            string database = "DAHLIA_FFR";
            string connStr = string.Format("Data Source={0};Initial Catalog={1};Integrated Security=True", server, database);
            connection = new SqlConnection(connStr);
        }

        public DataTable ExecuteQuery(string procedure, string action, SqlParameter[] parameters)
        {
            DataTable table = new DataTable();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(procedure, connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(parameters);
                cmd.Parameters.AddWithValue("@ActionType", action);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);
            }
            catch { }
            finally
            {
                connection.Close();
            }
            return table;
        }

        public int ExecuteNonQuery(string procedure, string action, SqlParameter[] parameters)
        {
            int count;
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(procedure, connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(parameters);
                cmd.Parameters.AddWithValue("@ActionType", action);
                count = cmd.ExecuteNonQuery();
            }
            catch
            {
                count = -1;
            }
            finally
            {
                connection.Close();
            }
            return count;
        }
    }
}

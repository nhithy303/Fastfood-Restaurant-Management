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
            string database = "DAHLIA_FastFoodRestaurant";
            string connStr = string.Format("Data Source={0};Initial Catalog={1};Integrated Security=True", server, database);
            connection = new SqlConnection(connStr);
        }
        public DataTable ExecuteQuery(string procedure)
        {
            DataTable table = new DataTable();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(procedure, connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                adapter.Fill(table);
            }
            catch
            {
                
            }
            finally
            {
                connection.Close();
            }
            return table;
        }
        public bool ExecuteNonQuery(string procedure, object[] parameters)
        {
            bool succeeded = true;
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(procedure, connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
            }
            catch
            {
                succeeded = false;
            }
            finally
            {
                connection.Close();
            }
            return succeeded;
        }
    }
}

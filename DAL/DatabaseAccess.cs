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
    internal class DatabaseAccess
    {
        private static SqlConnection connection = null;
        private static SqlBulkCopy copy = null;

        public DatabaseAccess()
        {

        }

        public static bool ConfigDatabase(string server, string database)
        {
            string connStr = string.Format("Data Source={0};Initial Catalog={1};Integrated Security=True", server, database);
            connection = new SqlConnection(connStr);
            copy = new SqlBulkCopy(connStr);
            try
            {
                connection.Open();
                connection.Close();
                return true;
            }
            catch
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
                server = "";
                database = "";
                return false;
            }
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

        public bool ExecuteBulkCopy(DataTable table)
        {
            try
            {
                connection.Open();
                copy.DestinationTableName = table.TableName;
                copy.WriteToServer(table);
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}

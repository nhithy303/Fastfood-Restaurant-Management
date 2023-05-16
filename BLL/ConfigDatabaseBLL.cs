using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ConfigDatabaseBLL
    {
        ConfigDatabaseDAL configdb_dal = new ConfigDatabaseDAL();
        public int ConfigDatabase(string server, string database)
        {
            if (server == "")
            {
                return 2;
            }
            if (database == "")
            {
                return 3;
            }
            if (configdb_dal.ConfigDatabase(server, database))
            {
                return 1;
            }
            return 0;
        }
    }
}

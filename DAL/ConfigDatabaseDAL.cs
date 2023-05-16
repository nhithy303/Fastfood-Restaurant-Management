using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ConfigDatabaseDAL
    {
        public bool ConfigDatabase(string server, string database)
        {
            return DatabaseAccess.ConfigDatabase(server, database);
        }
    }
}

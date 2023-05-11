using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ThamSoDAL
    {
        DatabaseAccess da = new DatabaseAccess();
        string procedure = "spTHAMSO";

        private SqlParameter[] GetParametersArray(ThamSo ts)
        {
            return new SqlParameter[]
            {
                new SqlParameter("@TenTS", ts.TenTS),
                new SqlParameter("@GiaTri", ts.GiaTri),
                new SqlParameter("@MoTa", ts.MoTa)
            };
        }

        private ThamSo GetDonViTinhFromDataRow(DataRow row)
        {
            ThamSo ts = new ThamSo();
            ts.TenTS = row["TENTS"].ToString();
            ts.GiaTri = int.Parse(row["GIATRI"].ToString());
            ts.MoTa = row["MOTA"].ToString();
            return ts;
        }

        public ThamSo[] GetList(ThamSo ts)
        {
            ThamSo[] list = null;
            DataTable table = da.ExecuteQuery(procedure, "Select", GetParametersArray(ts));
            int len = table.Rows.Count;
            if (len == 0) { return null; }
            list = new ThamSo[len];
            for (int i = 0; i < len; i++)
            {
                list[i] = GetDonViTinhFromDataRow(table.Rows[i]);
            }
            return list;
        }

        public int Create(ThamSo ts)
        {
            return da.ExecuteNonQuery(procedure, "Create", GetParametersArray(ts));
        }

        public int Update(ThamSo ts)
        {
            return da.ExecuteNonQuery(procedure, "Update", GetParametersArray(ts));
        }

        public int Delete(ThamSo ts)
        {
            return da.ExecuteNonQuery(procedure, "Delete", GetParametersArray(ts));
        }
    }
}

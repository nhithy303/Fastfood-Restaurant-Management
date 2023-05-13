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
    public class PhanQuyenDAL
    {
        DatabaseAccess da = new DatabaseAccess();
        string procedure = "spPHANQUYEN";
        private SqlParameter[] GetParametersArray(PhanQuyen pq)
        {
            return new SqlParameter[]
            {
                new SqlParameter("@MaPQ", pq.MaPQ),
                new SqlParameter("@TenPQ", pq.TenPQ)
            };
        }

        private PhanQuyen GetPhanQuyenFromDataRow(DataRow row)
        {
            PhanQuyen pq = new PhanQuyen();
            pq.MaPQ  = row["MAPQ"].ToString();
            pq.TenPQ = row["TENPQ"].ToString();
            return pq;
        }

        public PhanQuyen[] GetList(PhanQuyen pq)
        {
            PhanQuyen[] list = null;
            DataTable table = da.ExecuteQuery(procedure, "Select", GetParametersArray(pq));
            int len = table.Rows.Count;
            if (len == 0) { return null; }
            list = new PhanQuyen[len];
            for (int i = 0; i < len; i++)
            {
                list[i] = GetPhanQuyenFromDataRow(table.Rows[i]);
            }
            return list;
        }

        public int Create(PhanQuyen pq)
        {
            return da.ExecuteNonQuery(procedure, "Create", GetParametersArray(pq));
        }

        public int Update(PhanQuyen pq)
        {
            return da.ExecuteNonQuery(procedure, "Update", GetParametersArray(pq));
        }

        public int Delete(PhanQuyen pq)
        {
            return da.ExecuteNonQuery(procedure, "Delete", GetParametersArray(pq));
        }

        public int Restore(PhanQuyen pq)
        {
            return da.ExecuteNonQuery(procedure, "Restore", GetParametersArray(pq));
        }
    }
}

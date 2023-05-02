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
    public class DonViTinhDAL
    {
        DatabaseAccess da = new DatabaseAccess();
        string procedure = "spDONVITINH";

        private SqlParameter[] GetParametersArray(DonViTinh dvt)
        {
            return new SqlParameter[]
            {
                new SqlParameter("@MaDVT", dvt.MaDVT),
                new SqlParameter("@TenDVT", dvt.TenDVT)
            };
        }

        private DonViTinh GetDonViTinhFromDataRow(DataRow row)
        {
            DonViTinh dvt = new DonViTinh();
            dvt.MaDVT = int.Parse(row["MADVT"].ToString());
            dvt.TenDVT = row["TENDVT"].ToString();
            return dvt;
        }

        public DonViTinh[] GetList(DonViTinh dvt)
        {
            DonViTinh[] list = null;
            DataTable table = da.ExecuteQuery(procedure, "Select", GetParametersArray(dvt));
            int len = table.Rows.Count;
            if (len == 0) { return null; }
            list = new DonViTinh[len];
            for (int i = 0; i < len; i++)
            {
                list[i] = GetDonViTinhFromDataRow(table.Rows[i]);
            }
            return list;
        }

        public int Create(DonViTinh dvt)
        {
            return da.ExecuteNonQuery(procedure, "Create", GetParametersArray(dvt));
        }

        public int Update(DonViTinh dvt)
        {
            return da.ExecuteNonQuery(procedure, "Update", GetParametersArray(dvt));
        }

        public int Delete(DonViTinh dvt)
        {
            return da.ExecuteNonQuery(procedure, "Delete", GetParametersArray(dvt));
        }
    }
}

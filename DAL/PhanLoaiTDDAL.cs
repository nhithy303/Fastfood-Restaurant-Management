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
    public class PhanLoaiTDDAL
    {
        DatabaseAccess da = new DatabaseAccess();
        string procedure = "spPHANLOAITD";
        private SqlParameter[] GetParametersArray(PhanLoaiTD pltd)
        {
            return new SqlParameter[]
            {
                new SqlParameter("@MaLoai", pltd.MaLoai),
                new SqlParameter("@TenLoai", pltd.TenLoai)
            };
        }

        private PhanLoaiTD GetPhanLoaiTDFromDataRow(DataRow row)
        {
            PhanLoaiTD pltd = new PhanLoaiTD();
            pltd.MaLoai = int.Parse(row["MALOAI"].ToString());
            pltd.TenLoai = row["TENLOAI"].ToString();
            return pltd;
        }

        public PhanLoaiTD[] GetList()
        {
            PhanLoaiTD[] list = null;
            DataTable table = da.ExecuteQuery(procedure, "Select", new SqlParameter[] { });
            int len = table.Rows.Count;
            if (len == 0) { return null; }
            list = new PhanLoaiTD[len];
            for (int i = 0; i < len; i++)
            {
                list[i] = GetPhanLoaiTDFromDataRow(table.Rows[i]);
            }
            return list;
        }

        public string Create(PhanLoaiTD pltd)
        {
            return da.ExecuteNonQuery(procedure, "Create", GetParametersArray(pltd));
        }

        public string Update(PhanLoaiTD pltd)
        {
            return da.ExecuteNonQuery(procedure, "Update", GetParametersArray(pltd));
        }

        public string Delete(PhanLoaiTD pltd)
        {
            return da.ExecuteNonQuery(procedure, "Delete", GetParametersArray(pltd));
        }

        public string Restore(PhanLoaiTD pltd)
        {
            return da.ExecuteNonQuery(procedure, "Restore", GetParametersArray(pltd));
        }
    }
}

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
    public class NguyenLieuDAL
    {
        DatabaseAccess da = new DatabaseAccess();
        string procedure = "spNGUYENLIEU";

        private SqlParameter[] GetParametersArray(NguyenLieu nl)
        {
            return new SqlParameter[]
            {
                new SqlParameter("@MaNL", nl.MaNL),
                new SqlParameter("@TenNL", nl.TenNL),
                new SqlParameter("@TongTonKho", nl.TongTonKho),
                new SqlParameter("@DonViTinh", nl.DonViTinh)
            };
        }

        private NguyenLieu GetNguyenLieuFromDataRow(DataRow row)
        {
            NguyenLieu nl = new NguyenLieu();
            nl.MaNL = int.Parse(row["MANL"].ToString());
            nl.TenNL = row["TENNL"].ToString();
            nl.TongTonKho = int.Parse(row["TONGTONKHO"].ToString());
            nl.DonViTinh = int.Parse(row["DONVITINH"].ToString());
            return nl;
        }

        public NguyenLieu[] GetList()
        {
            NguyenLieu[] list = null;
            DataTable table = da.ExecuteQuery(procedure, "Select", new SqlParameter[] { });
            int len = table.Rows.Count;
            if (len == 0) { return null; }
            list = new NguyenLieu[len];
            for (int i = 0; i < len; i++)
            {
                list[i] = GetNguyenLieuFromDataRow(table.Rows[i]);
            }
            return list;
        }

        public string Create(NguyenLieu nl)
        {
            return da.ExecuteNonQuery(procedure, "Create", GetParametersArray(nl));
        }

        public string Update(NguyenLieu nl)
        {
            return da.ExecuteNonQuery(procedure, "Update", GetParametersArray(nl));
        }

        public string Delete(NguyenLieu nl)
        {
            return da.ExecuteNonQuery(procedure, "Delete", GetParametersArray(nl));
        }
    }
}

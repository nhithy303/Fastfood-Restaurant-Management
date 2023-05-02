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
    public class QuanLyDAL
    {
        DatabaseAccess da = new DatabaseAccess();
        string procedure = "spQUANLY";
        private SqlParameter[] GetParametersArray(QuanLy ql)
        {
            return new SqlParameter[]
            {
                new SqlParameter("@MaQL", ql.MaQL),
                new SqlParameter("@MaTK", ql.MaTK),
                new SqlParameter("@HoQL", ql.HoQL),
                new SqlParameter("@TenQL", ql.TenQL),
                new SqlParameter("@NgaySinh", ql.NgaySinh),
                new SqlParameter("@GioiTinh", ql.GioiTinh),
                new SqlParameter("@Sdt", ql.Sdt),
            };
        }

        private QuanLy GetQuanLyFromDataRow(DataRow row)
        {
            QuanLy ql = new QuanLy();
            ql.MaQL = int.Parse(row["MAQL"].ToString());
            ql.MaTK = int.Parse(row["MATK"].ToString());
            ql.HoQL = row["HOQL"].ToString();
            ql.TenQL = row["TENQL"].ToString();
            ql.NgaySinh = DateTime.Parse(row["NGAYSINH"].ToString()).ToString("dd/MM/yyyy");
            ql.GioiTinh = int.Parse(row["GIOITINH"].ToString());
            ql.Sdt = row["SDT"].ToString();
            return ql;
        }

        public QuanLy[] GetList(QuanLy ql)
        {
            QuanLy[] list = null;
            DataTable table = da.ExecuteQuery(procedure, "Select", GetParametersArray(ql));
            int len = table.Rows.Count;
            if (len == 0) { return null; }
            list = new QuanLy[len];
            for (int i = 0; i < len; i++)
            {
                list[i] = GetQuanLyFromDataRow(table.Rows[i]);
            }
            return list;
        }

        public int Create(QuanLy ql)
        {
            return da.ExecuteNonQuery(procedure, "Create", GetParametersArray(ql));
        }

        public int AddAccount(QuanLy ql)
        {
            return da.ExecuteNonQuery(procedure, "AddAccount", GetParametersArray(ql));
        }

        public int Update(QuanLy ql)
        {
            return da.ExecuteNonQuery(procedure, "Update", GetParametersArray(ql));
        }

        public int Delete(QuanLy ql)
        {
            return da.ExecuteNonQuery(procedure, "Delete", GetParametersArray(ql));
        }

        public int Restore(QuanLy ql)
        {
            return da.ExecuteNonQuery(procedure, "Restore", GetParametersArray(ql));
        }
    }
}

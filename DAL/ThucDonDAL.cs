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
    public class ThucDonDAL
    {
        DatabaseAccess da = new DatabaseAccess();
        string procedure = "spTHUCDON";
        private SqlParameter[] GetParametersArray(ThucDon td)
        {
            return new SqlParameter[]
            {
                new SqlParameter("@MaMon", td.MaMon),
                new SqlParameter("@MaLoai", td.MaLoai),
                new SqlParameter("@TenMon", td.TenMon),
                new SqlParameter("@AnhMon", td.AnhMon),
                new SqlParameter("@GiaGoc", td.GiaGoc),
                new SqlParameter("@GiaBan", td.GiaBan),
            };
        }

        private ThucDon GetThucDonFromDataRow(DataRow row)
        {
            ThucDon td = new ThucDon();
            td.MaMon = int.Parse(row["MAMON"].ToString());
            td.MaLoai = int.Parse(row["MALOAI"].ToString());
            td.TenMon = row["TENMON"].ToString();
            td.AnhMon = row["ANHMON"].ToString();
            td.GiaGoc = int.Parse(row["GIAGOC"].ToString());
            td.GiaBan = int.Parse(row["GIABAN"].ToString());
            return td;
        }

        public ThucDon[] GetList(ThucDon td)
        {
            ThucDon[] list = null;
            DataTable table = da.ExecuteQuery(procedure, "Select", GetParametersArray(td));
            int len = table.Rows.Count;
            if (len == 0) { return null; }
            list = new ThucDon[len];
            for (int i = 0; i < len; i++)
            {
                list[i] = GetThucDonFromDataRow(table.Rows[i]);
            }
            return list;
        }

        public int Create(ThucDon td)
        {
            return da.ExecuteNonQuery(procedure, "Create", GetParametersArray(td));
        }

        public int Update(ThucDon td)
        {
            return da.ExecuteNonQuery(procedure, "Update", GetParametersArray(td));
        }

        public int Delete(ThucDon td)
        {
            return da.ExecuteNonQuery(procedure, "Delete", GetParametersArray(td));
        }

        public int Restore(ThucDon td)
        {
            return da.ExecuteNonQuery(procedure, "Restore", GetParametersArray(td));
        }
    }
}

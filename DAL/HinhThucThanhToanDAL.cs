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
    public class HinhThucThanhToanDAL
    {
        DatabaseAccess da = new DatabaseAccess();
        string procedure = "spHINHTHUCTHANHTOAN";
        private SqlParameter[] GetParametersArray(HinhThucThanhToan httt)
        {
            return new SqlParameter[]
            {
                new SqlParameter("@MaHTTT", httt.MaHTTT),
                new SqlParameter("@TenHTTT", httt.TenHTTT)
            };
        }

        private HinhThucThanhToan GetHinhThucThanhToanFromDataRow(DataRow row)
        {
            HinhThucThanhToan httt = new HinhThucThanhToan();
            httt.MaHTTT = int.Parse(row["MAHTTT"].ToString());
            httt.TenHTTT = row["TENHTTT"].ToString();
            return httt;
        }

        public HinhThucThanhToan[] GetList(HinhThucThanhToan httt)
        {
            HinhThucThanhToan[] list = null;
            DataTable table = da.ExecuteQuery(procedure, "Select", GetParametersArray(httt));
            int len = table.Rows.Count;
            if (len == 0) { return null; }
            list = new HinhThucThanhToan[len];
            for (int i = 0; i < len; i++)
            {
                list[i] = GetHinhThucThanhToanFromDataRow(table.Rows[i]);
            }
            return list;
        }

        public int Create(HinhThucThanhToan httt)
        {
            return da.ExecuteNonQuery(procedure, "Create", GetParametersArray(httt));
        }

        public int Update(HinhThucThanhToan httt)
        {
            return da.ExecuteNonQuery(procedure, "Update", GetParametersArray(httt));
        }

        public int Delete(HinhThucThanhToan httt)
        {
            return da.ExecuteNonQuery(procedure, "Delete", GetParametersArray(httt));
        }

        public int Restore(HinhThucThanhToan httt)
        {
            return da.ExecuteNonQuery(procedure, "Restore", GetParametersArray(httt));
        }
    }
}

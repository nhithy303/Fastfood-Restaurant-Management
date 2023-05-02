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
    public class HoaDonNhapHangDAL
    {
        DatabaseAccess da = new DatabaseAccess();
        string procedure = "spHOADONNHAPHANG";

        private SqlParameter[] GetParametersArray(HoaDonNhapHang hdnh)
        {
            return new SqlParameter[]
            {
                new SqlParameter("@MaHD", hdnh.MaHD),
                new SqlParameter("@MaQL", hdnh.MaQL),
                new SqlParameter("@NgayHD", hdnh.NgayHD),
                new SqlParameter("@TongTien", hdnh.TongTien)
            };
        }

        private HoaDonNhapHang GetHoaDonNhapHangFromDataRow(DataRow row)
        {
            HoaDonNhapHang hdnh = new HoaDonNhapHang();
            hdnh.MaHD = int.Parse(row["MAHD"].ToString());
            hdnh.MaQL = int.Parse(row["MAQL"].ToString());
            hdnh.NgayHD = DateTime.Parse(row["NGAYHD"].ToString()).ToString("dd/MM/yyyy");
            hdnh.TongTien = int.Parse(row["TONGTIEN"].ToString());
            return hdnh;
        }

        public HoaDonNhapHang[] GetList(HoaDonNhapHang hdnh)
        {
            HoaDonNhapHang[] list = null;
            DataTable table = da.ExecuteQuery(procedure, "Select", GetParametersArray(hdnh));
            int len = table.Rows.Count;
            if (len == 0) { return null; }
            list = new HoaDonNhapHang[len];
            for (int i = 0; i < len; i++)
            {
                list[i] = GetHoaDonNhapHangFromDataRow(table.Rows[i]);
            }
            return list;
        }

        public int Create(HoaDonNhapHang hdnh)
        {
            return da.ExecuteNonQuery(procedure, "Create", GetParametersArray(hdnh));
        }

        public int Update(HoaDonNhapHang hdnh)
        {
            return da.ExecuteNonQuery(procedure, "Update", GetParametersArray(hdnh));
        }

        public int Delete(HoaDonNhapHang hdnh)
        {
            return da.ExecuteNonQuery(procedure, "Delete", GetParametersArray(hdnh));
        }
    }
}

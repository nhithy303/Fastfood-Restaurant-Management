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
    public class ChiTietHDBHDAL
    {
        DatabaseAccess da = new DatabaseAccess();
        string procedure = "spCHITIETHDBH";

        private SqlParameter[] GetParametersArray(ChiTietHDBH cthdbh)
        {
            return new SqlParameter[]
            {
                new SqlParameter("@MaHD", cthdbh.MaHD),
                new SqlParameter("@MaMon", cthdbh.MaMon),
                new SqlParameter("@SoLuong", cthdbh.SoLuong),
                new SqlParameter("@DonViTinh", cthdbh.DonViTinh),
                new SqlParameter("@DonGia", cthdbh.DonGia),
                new SqlParameter("@ThanhTien", cthdbh.ThanhTien)
            };
        }

        private ChiTietHDBH GetChiTietHDBHFromDataRow(DataRow row)
        {
            ChiTietHDBH cthdbh = new ChiTietHDBH();
            cthdbh.MaHD = int.Parse(row["MAHD"].ToString());
            cthdbh.MaMon = int.Parse(row["MAMON"].ToString());
            cthdbh.SoLuong = int.Parse(row["SOLUONG"].ToString());
            cthdbh.DonViTinh = int.Parse(row["DONVITINH"].ToString());
            cthdbh.DonGia = int.Parse(row["DONGIA"].ToString());
            cthdbh.ThanhTien = int.Parse(row["THANHTIEN"].ToString());
            return cthdbh;
        }

        public ChiTietHDBH[] GetList()
        {
            ChiTietHDBH[] list = null;
            DataTable table = da.ExecuteQuery(procedure, "Select", new SqlParameter[] { });
            int len = table.Rows.Count;
            if (len == 0) { return null; }
            list = new ChiTietHDBH[len];
            for (int i = 0; i < len; i++)
            {
                list[i] = GetChiTietHDBHFromDataRow(table.Rows[i]);
            }
            return list;
        }

        public string Create(ChiTietHDBH cthdbh)
        {
            return da.ExecuteNonQuery(procedure, "Create", GetParametersArray(cthdbh));
        }

        public string Update(ChiTietHDBH cthdbh)
        {
            return da.ExecuteNonQuery(procedure, "Update", GetParametersArray(cthdbh));
        }

        public string Delete(ChiTietHDBH cthdbh)
        {
            return da.ExecuteNonQuery(procedure, "Delete", GetParametersArray(cthdbh));
        }
    }
}

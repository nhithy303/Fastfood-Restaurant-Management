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
    public class ChiTietHDNHDAL
    {
        DatabaseAccess da = new DatabaseAccess();
        string procedure = "spCHITIETHDNH";

        private SqlParameter[] GetParametersArray(ChiTietHDNH cthdnh)
        {
            return new SqlParameter[]
            {
                new SqlParameter("@MaHD", cthdnh.MaHD),
                new SqlParameter("@MaNL", cthdnh.MaNL),
                new SqlParameter("@HanSuDung", cthdnh.HanSuDung),
                new SqlParameter("@SoLuong", cthdnh.SoLuong),
                new SqlParameter("@DonViTinh", cthdnh.DonViTinh),
                new SqlParameter("@DonGia", cthdnh.DonGia),
                new SqlParameter("@ThanhTien", cthdnh.ThanhTien)
            };
        }

        private ChiTietHDNH GetChiTietHDNHFromDataRow(DataRow row)
        {
            ChiTietHDNH cthdnh = new ChiTietHDNH();
            cthdnh.MaHD = int.Parse(row["MAHD"].ToString());
            cthdnh.MaNL = int.Parse(row["MANL"].ToString());
            cthdnh.HanSuDung = DateTime.Parse(row["HANSUDUNG"].ToString()).ToString("dd/MM/yyyy");
            cthdnh.SoLuong = int.Parse(row["SOLUONG"].ToString());
            cthdnh.DonViTinh = int.Parse(row["DONVITINH"].ToString());
            cthdnh.DonGia = int.Parse(row["DONGIA"].ToString());
            cthdnh.ThanhTien = int.Parse(row["THANHTIEN"].ToString());
            return cthdnh;
        }

        public ChiTietHDNH[] GetList()
        {
            ChiTietHDNH[] list = null;
            DataTable table = da.ExecuteQuery(procedure, "Select", new SqlParameter[] { });
            int len = table.Rows.Count;
            if (len == 0) { return null; }
            list = new ChiTietHDNH[len];
            for (int i = 0; i < len; i++)
            {
                list[i] = GetChiTietHDNHFromDataRow(table.Rows[i]);
            }
            return list;
        }

        public string Create(ChiTietHDNH cthdnh)
        {
            return da.ExecuteNonQuery(procedure, "Create", GetParametersArray(cthdnh));
        }

        public string Update(ChiTietHDNH cthdnh)
        {
            return da.ExecuteNonQuery(procedure, "Update", GetParametersArray(cthdnh));
        }

        public string Delete(ChiTietHDNH cthdnh)
        {
            return da.ExecuteNonQuery(procedure, "Delete", GetParametersArray(cthdnh));
        }
    }
}

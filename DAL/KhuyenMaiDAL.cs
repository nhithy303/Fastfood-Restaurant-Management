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
    public class KhuyenMaiDAL
    {
        DatabaseAccess da = new DatabaseAccess();
        string procedure = "spKHUYENMAI";

        private SqlParameter[] GetParametersArray(KhuyenMai km)
        {
            return new SqlParameter[]
            {
                new SqlParameter("@MaKM", km.MaKM),
                new SqlParameter("@MaMon", km.MaMon),
                new SqlParameter("@NgayBatDau", km.NgayBatDau),
                new SqlParameter("@NgayKetThuc", km.NgayKetThuc),
                new SqlParameter("@PhanTramGiamGia", km.PhanTramGiamGia)
            };
        }

        private KhuyenMai GetKhuyenMaiFromDataRow(DataRow row)
        {
            KhuyenMai km = new KhuyenMai();
            km.MaKM = int.Parse(row["MAKM"].ToString());
            km.MaMon = int.Parse(row["MAMON"].ToString());
            km.NgayBatDau = DateTime.Parse(row["NGAYBATDAU"].ToString()).ToString("dd/MM/yyyy");
            km.NgayKetThuc = DateTime.Parse(row["NGAYKETTHUC"].ToString()).ToString("dd/MM/yyyy");
            km.PhanTramGiamGia = int.Parse(row["PHANTRAMGIAMGIA"].ToString());
            return km;
        }

        public KhuyenMai[] GetList()
        {
            KhuyenMai[] list = null;
            DataTable table = da.ExecuteQuery(procedure, "Select", new SqlParameter[] { });
            int len = table.Rows.Count;
            if (len == 0) { return null; }
            list = new KhuyenMai[len];
            for (int i = 0; i < len; i++)
            {
                list[i] = GetKhuyenMaiFromDataRow(table.Rows[i]);
            }
            return list;
        }

        public string Create(KhuyenMai km)
        {
            return da.ExecuteNonQuery(procedure, "Create", GetParametersArray(km));
        }

        public string Update(KhuyenMai km)
        {
            return da.ExecuteNonQuery(procedure, "Update", GetParametersArray(km));
        }

        public string Delete(KhuyenMai km)
        {
            return da.ExecuteNonQuery(procedure, "Delete", GetParametersArray(km));
        }
    }
}

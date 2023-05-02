using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhanVienDAL
    {
        DatabaseAccess da = new DatabaseAccess();
        string procedure = "spNHANVIEN";
        private SqlParameter[] GetParametersArray(NhanVien nv)
        {
            return new SqlParameter[]
            {
                new SqlParameter("@MaNV", nv.MaNV),
                new SqlParameter("@MaTK", nv.MaTK),
                new SqlParameter("@HoNV", nv.HoNV),
                new SqlParameter("@TenNV", nv.TenNV),
                new SqlParameter("@NgaySinh", nv.NgaySinh),
                new SqlParameter("@GioiTinh", nv.GioiTinh),
                new SqlParameter("@Sdt", nv.Sdt),
                new SqlParameter("@DiaChi", nv.DiaChi),
                new SqlParameter("@MaLoai", nv.MaLoai),
                new SqlParameter("@NgayVaoLam", nv.NgayVaoLam),
            };
        }

        private NhanVien GetNhanVienFromDataRow(DataRow row)
        {
            NhanVien nv = new NhanVien();
            nv.MaNV = int.Parse(row["MANV"].ToString());
            nv.MaTK = int.Parse(row["MATK"].ToString());
            nv.HoNV = row["HONV"].ToString();
            nv.TenNV = row["TENNV"].ToString();
            nv.NgaySinh = DateTime.Parse(row["NGAYSINH"].ToString()).ToString("dd/MM/yyyy");
            nv.GioiTinh = int.Parse(row["GIOITINH"].ToString());
            nv.Sdt = row["SDT"].ToString();
            nv.DiaChi = row["DIACHI"].ToString();
            nv.MaLoai = int.Parse(row["MALOAI"].ToString());
            nv.NgayVaoLam = DateTime.Parse(row["NGAYVAOLAM"].ToString()).ToString("dd/MM/yyyy");
            return nv;
        }

        public NhanVien[] GetList(NhanVien nv)
        {
            NhanVien[] list = null;
            SqlParameter[] p = GetParametersArray(nv);
            DataTable table = da.ExecuteQuery(procedure, "Select", p);
            int len = table.Rows.Count;
            if (len == 0) { return null; }
            list = new NhanVien[len];
            for (int i = 0; i < len; i++)
            {
                list[i] = GetNhanVienFromDataRow(table.Rows[i]);
            }
            return list;
        }

        public int Create(NhanVien nv)
        {
            return da.ExecuteNonQuery(procedure, "Create", GetParametersArray(nv));
        }

        public int AddAccount(NhanVien nv)
        {
            return da.ExecuteNonQuery(procedure, "AddAccount", GetParametersArray(nv));
        }

        public int Update(NhanVien nv)
        {
            return da.ExecuteNonQuery(procedure, "Update", GetParametersArray(nv));
        }

        public int Delete(NhanVien nv)
        {
            return da.ExecuteNonQuery(procedure, "Delete", GetParametersArray(nv));
        }

        public int Restore(NhanVien nv)
        {
            return da.ExecuteNonQuery(procedure, "Restore", GetParametersArray(nv));
        }
    }
}

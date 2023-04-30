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
    public class TaiKhoanDAL
    {
        DatabaseAccess da = new DatabaseAccess();
        string procedure = "spTAIKHOAN";
        private SqlParameter[] GetParametersArray(TaiKhoan tk)
        {
            return new SqlParameter[]
            {
                new SqlParameter("@MaTK", tk.MaTK),
                new SqlParameter("@TenDangNhap", tk.TenDangNhap),
                new SqlParameter("@MatKhau", tk.MatKhau),
                new SqlParameter("@PhanQuyen", tk.PhanQuyen)
            };
        }

        private TaiKhoan GetTaiKhoanFromDataRow(DataRow row)
        {
            TaiKhoan tk = new TaiKhoan();
            tk.MaTK = int.Parse(row["MATK"].ToString());
            tk.TenDangNhap = row["TENDANGNHAP"].ToString();
            tk.MatKhau = row["MATKHAU"].ToString();
            tk.PhanQuyen = int.Parse(row["PHANQUYEN"].ToString());
            return tk;
        }

        public TaiKhoan[] GetList()
        {
            TaiKhoan[] list = null;
            DataTable table = da.ExecuteQuery(procedure, "Select", new SqlParameter[] { });
            int len = table.Rows.Count;
            if (len == 0) { return null; }
            list = new TaiKhoan[len];
            for (int i = 0; i < len; i++)
            {
                list[i] = GetTaiKhoanFromDataRow(table.Rows[i]);
            }
            return list;
        }

        public string Create(TaiKhoan tk)
        {
            return da.ExecuteNonQuery(procedure, "Create", GetParametersArray(tk));
        }

        public string Update(TaiKhoan tk)
        {
            return da.ExecuteNonQuery(procedure, "Update", GetParametersArray(tk));
        }

        public string ResetPassword(TaiKhoan tk)
        {
            return da.ExecuteNonQuery(procedure, "ResetPassword", GetParametersArray(tk));
        }

        public string Delete(TaiKhoan tk)
        {
            return da.ExecuteNonQuery(procedure, "Delete", GetParametersArray(tk));
        }

        public string Restore(TaiKhoan tk)
        {
            return da.ExecuteNonQuery(procedure, "Restore", GetParametersArray(tk));
        }
    }
}

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
    public class TrangThaiDonHangDAL
    {
        DatabaseAccess da = new DatabaseAccess();
        string procedure = "spTRANGTHAIDONHANG";

        private SqlParameter[] GetParametersArray(TrangThaiDonHang ttdh)
        {
            return new SqlParameter[]
            {
                new SqlParameter("@MaTT", ttdh.MaTT),
                new SqlParameter("@TenTT", ttdh.TenTT)
            };
        }

        private TrangThaiDonHang GetTrangThaiDonHangFromDataRow(DataRow row)
        {
            TrangThaiDonHang ttdh = new TrangThaiDonHang();
            ttdh.MaTT = int.Parse(row["MATT"].ToString());
            ttdh.TenTT = row["TENTT"].ToString();
            return ttdh;
        }

        public TrangThaiDonHang[] GetList(TrangThaiDonHang ttdh)
        {
            TrangThaiDonHang[] list = null;
            DataTable table = da.ExecuteQuery(procedure, "Select", GetParametersArray(ttdh));
            int len = table.Rows.Count;
            if (len == 0) { return null; }
            list = new TrangThaiDonHang[len];
            for (int i = 0; i < len; i++)
            {
                list[i] = GetTrangThaiDonHangFromDataRow(table.Rows[i]);
            }
            return list;
        }

        public int Create(TrangThaiDonHang ttdh)
        {
            return da.ExecuteNonQuery(procedure, "Create", GetParametersArray(ttdh));
        }

        public int Update(TrangThaiDonHang ttdh)
        {
            return da.ExecuteNonQuery(procedure, "Update", GetParametersArray(ttdh));
        }

        public int Delete(TrangThaiDonHang ttdh)
        {
            return da.ExecuteNonQuery(procedure, "Delete", GetParametersArray(ttdh));
        }

        public int Restore(TrangThaiDonHang ttdh)
        {
            return da.ExecuteNonQuery(procedure, "Restore", GetParametersArray(ttdh));
        }
    }
}

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
    public class ChiTietNLDAL
    {
        DatabaseAccess da = new DatabaseAccess();
        string procedure = "spCHITIETNL";

        private SqlParameter[] GetParametersArray(ChiTietNL ctnl)
        {
            return new SqlParameter[]
            {
                new SqlParameter("@MaNL", ctnl.MaNL),
                new SqlParameter("@HanSuDung", ctnl.HanSuDung),
                new SqlParameter("@TonKho", ctnl.TonKho)
            };
        }

        private ChiTietNL GetChiTietNLFromDataRow(DataRow row)
        {
            ChiTietNL ctnl = new ChiTietNL();
            ctnl.MaNL = int.Parse(row["MANL"].ToString());
            ctnl.HanSuDung = DateTime.Parse(row["HANSUDUNG"].ToString()).ToString("dd/MM/yyyy");
            ctnl.TonKho = int.Parse(row["TONKHO"].ToString());
            return ctnl;
        }

        public ChiTietNL[] GetList()
        {
            ChiTietNL[] list = null;
            DataTable table = da.ExecuteQuery(procedure, "Select", new SqlParameter[] { });
            int len = table.Rows.Count;
            if (len == 0) { return null; }
            list = new ChiTietNL[len];
            for (int i = 0; i < len; i++)
            {
                list[i] = GetChiTietNLFromDataRow(table.Rows[i]);
            }
            return list;
        }

        public string Create(ChiTietNL ctnl)
        {
            return da.ExecuteNonQuery(procedure, "Create", GetParametersArray(ctnl));
        }

        public string Update(ChiTietNL ctnl)
        {
            return da.ExecuteNonQuery(procedure, "Update", GetParametersArray(ctnl));
        }

        public string Delete(ChiTietNL ctnl)
        {
            return da.ExecuteNonQuery(procedure, "Delete", GetParametersArray(ctnl));
        }
    }
}

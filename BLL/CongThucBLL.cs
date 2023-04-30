using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CongThucBLL
    {
        CongThucDAL ct_dal = new CongThucDAL();

        public CongThuc[] GetList()
        {
            return ct_dal.GetList();
        }

        public string Create(CongThuc ct)
        {
            return ct_dal.Create(ct);
        }

        public string Update(CongThuc ct)
        {
            return ct_dal.Update(ct);
        }

        public string Delete(CongThuc ct)
        {
            return ct_dal.Delete(ct);
        }
    }
}

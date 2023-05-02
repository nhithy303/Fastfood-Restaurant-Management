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

        public CongThuc[] GetList(CongThuc ct)
        {
            return ct_dal.GetList(ct);
        }

        public int Create(CongThuc ct)
        {
            return ct_dal.Create(ct);
        }

        public int Update(CongThuc ct)
        {
            return ct_dal.Update(ct);
        }

        public int Delete(CongThuc ct)
        {
            return ct_dal.Delete(ct);
        }
    }
}

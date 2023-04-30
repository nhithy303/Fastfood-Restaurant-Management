using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChiTietNLBLL
    {
        ChiTietNLDAL ctnl_dal = new ChiTietNLDAL();

        public ChiTietNL[] GetList()
        {
            return ctnl_dal.GetList();
        }

        public string Create(ChiTietNL ctnl)
        {
            return ctnl_dal.Create(ctnl);
        }

        public string Update(ChiTietNL ctnl)
        {
            return ctnl_dal.Update(ctnl);
        }

        public string Delete(ChiTietNL ctnl)
        {
            return ctnl_dal.Delete(ctnl);
        }
    }
}

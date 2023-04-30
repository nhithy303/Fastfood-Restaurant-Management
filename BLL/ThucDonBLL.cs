using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ThucDonBLL
    {
        ThucDonDAL td_dal = new ThucDonDAL();
        public ThucDon[] GetList()
        {
            return td_dal.GetList();
        }

        public string Create(ThucDon td)
        {
            return td_dal.Create(td);
        }

        public string Update(ThucDon td)
        {
            return td_dal.Update(td);
        }

        public string Delete(ThucDon td)
        {
            return td_dal.Delete(td);
        }

        public string Restore(ThucDon td)
        {
            return td_dal.Restore(td);
        }
    }
}

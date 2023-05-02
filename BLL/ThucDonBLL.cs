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
        public ThucDon[] GetList(ThucDon td)
        {
            return td_dal.GetList(td);
        }

        public int Create(ThucDon td)
        {
            if (!IsValid(td))
            {
                return -2;
            }
            return td_dal.Create(td);
        }

        public int Update(ThucDon td)
        {
            return td_dal.Update(td);
        }

        public int Delete(ThucDon td)
        {
            return td_dal.Delete(td);
        }

        public int Restore(ThucDon td)
        {
            return td_dal.Restore(td);
        }

        private bool IsValid(ThucDon td)
        {
            return td.TenMon != String.Empty;
        }
    }
}

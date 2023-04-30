using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PhanQuyenBLL
    {
        PhanQuyenDAL pq_dal = new PhanQuyenDAL();
        public PhanQuyen[] GetList()
        {
            return pq_dal.GetList();
        }

        public string Create(PhanQuyen pq)
        {
            return pq_dal.Create(pq);
        }

        public string Update(PhanQuyen pq)
        {
            return pq_dal.Update(pq);
        }

        public string Delete(PhanQuyen pq)
        {
            return pq_dal.Delete(pq);
        }

        public string Restore(PhanQuyen pq)
        {
            return pq_dal.Restore(pq);
        }
    }
}

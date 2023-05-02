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
        public PhanQuyen[] GetList(PhanQuyen pq)
        {
            return pq_dal.GetList(pq);
        }

        public int Create(PhanQuyen pq)
        {
            return pq_dal.Create(pq);
        }

        public int Update(PhanQuyen pq)
        {
            return pq_dal.Update(pq);
        }

        public int Delete(PhanQuyen pq)
        {
            return pq_dal.Delete(pq);
        }

        public int Restore(PhanQuyen pq)
        {
            return pq_dal.Restore(pq);
        }
    }
}

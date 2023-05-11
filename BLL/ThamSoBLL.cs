using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ThamSoBLL
    {
        ThamSoDAL ts_dal = new ThamSoDAL();

        public ThamSo[] GetList(ThamSo ts)
        {
            return ts_dal.GetList(ts);
        }

        public int Create(ThamSo ts)
        {
            return ts_dal.Create(ts);
        }

        public int Update(ThamSo ts)
        {
            return ts_dal.Update(ts);
        }

        public int Delete(ThamSo ts)
        {
            return ts_dal.Delete(ts);
        }
    }
}

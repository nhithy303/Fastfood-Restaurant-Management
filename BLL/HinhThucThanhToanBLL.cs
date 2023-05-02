using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HinhThucThanhToanBLL
    {
        HinhThucThanhToanDAL httt_dal = new HinhThucThanhToanDAL();
        public HinhThucThanhToan[] GetList(HinhThucThanhToan httt)
        {
            return httt_dal.GetList(httt);
        }

        public int Create(HinhThucThanhToan httt)
        {
            return httt_dal.Create(httt);
        }

        public int Update(HinhThucThanhToan httt)
        {
            return httt_dal.Update(httt);
        }

        public int Delete(HinhThucThanhToan httt)
        {
            return httt_dal.Delete(httt);
        }

        public int Restore(HinhThucThanhToan httt)
        {
            return httt_dal.Restore(httt);
        }
    }
}

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
        public HinhThucThanhToan[] GetList()
        {
            return httt_dal.GetList();
        }

        public string Create(HinhThucThanhToan httt)
        {
            return httt_dal.Create(httt);
        }

        public string Update(HinhThucThanhToan httt)
        {
            return httt_dal.Update(httt);
        }

        public string Delete(HinhThucThanhToan httt)
        {
            return httt_dal.Delete(httt);
        }

        public string Restore(HinhThucThanhToan httt)
        {
            return httt_dal.Restore(httt);
        }
    }
}

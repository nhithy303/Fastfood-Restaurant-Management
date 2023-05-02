using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChiTietHDNHBLL
    {
        ChiTietHDNHDAL cthdnh_dal = new ChiTietHDNHDAL();

        public ChiTietHDNH[] GetList(ChiTietHDNH cthdnh)
        {
            return cthdnh_dal.GetList(cthdnh);
        }

        public int Create(ChiTietHDNH cthdnh)
        {
            return cthdnh_dal.Create(cthdnh);
        }

        public int Update(ChiTietHDNH cthdnh)
        {
            return cthdnh_dal.Update(cthdnh);
        }

        public int Delete(ChiTietHDNH cthdnh)
        {
            return cthdnh_dal.Delete(cthdnh);
        }
    }
}

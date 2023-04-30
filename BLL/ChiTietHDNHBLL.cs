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

        public ChiTietHDNH[] GetList()
        {
            return cthdnh_dal.GetList();
        }

        public string Create(ChiTietHDNH cthdnh)
        {
            return cthdnh_dal.Create(cthdnh);
        }

        public string Update(ChiTietHDNH cthdnh)
        {
            return cthdnh_dal.Update(cthdnh);
        }

        public string Delete(ChiTietHDNH cthdnh)
        {
            return cthdnh_dal.Delete(cthdnh);
        }
    }
}

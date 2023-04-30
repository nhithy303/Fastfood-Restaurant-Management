using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KhuyenMaiBLL
    {
        KhuyenMaiDAL km_dal = new KhuyenMaiDAL();

        public KhuyenMai[] GetList()
        {
            return km_dal.GetList();
        }

        public string Create(KhuyenMai km)
        {
            return km_dal.Create(km);
        }

        public string Update(KhuyenMai km)
        {
            return km_dal.Update(km);
        }

        public string Delete(KhuyenMai km)
        {
            return km_dal.Delete(km);
        }
    }
}

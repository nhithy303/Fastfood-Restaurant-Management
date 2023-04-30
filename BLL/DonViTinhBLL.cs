using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DonViTinhBLL
    {
        DonViTinhDAL dvt_dal = new DonViTinhDAL();

        public DonViTinh[] GetList()
        {
            return dvt_dal.GetList();
        }

        public string Create(DonViTinh dvt)
        {
            return dvt_dal.Create(dvt);
        }

        public string Update(DonViTinh dvt)
        {
            return dvt_dal.Update(dvt);
        }

        public string Delete(DonViTinh dvt)
        {
            return dvt_dal.Delete(dvt);
        }
    }
}

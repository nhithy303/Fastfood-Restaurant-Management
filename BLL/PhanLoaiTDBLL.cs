using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PhanLoaiTDBLL
    {
        PhanLoaiTDDAL pltd_dal = new PhanLoaiTDDAL();
        public PhanLoaiTD[] GetList()
        {
            return pltd_dal.GetList();
        }

        public string Create(PhanLoaiTD pltd)
        {
            return pltd_dal.Create(pltd);
        }

        public string Update(PhanLoaiTD pltd)
        {
            return pltd_dal.Update(pltd);
        }

        public string Delete(PhanLoaiTD pltd)
        {
            return pltd_dal.Delete(pltd);
        }

        public string Restore(PhanLoaiTD pltd)
        {
            return pltd_dal.Restore(pltd);
        }
    }
}

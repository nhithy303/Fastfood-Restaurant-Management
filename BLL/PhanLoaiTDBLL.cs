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
        public PhanLoaiTD[] GetList(PhanLoaiTD pltd)
        {
            return pltd_dal.GetList(pltd);
        }

        public int Create(PhanLoaiTD pltd)
        {
            if (!IsValid(pltd))
            {
                return -2;
            }
            return pltd_dal.Create(pltd);
        }

        public int Update(PhanLoaiTD pltd)
        {
            return pltd_dal.Update(pltd);
        }

        public int Delete(PhanLoaiTD pltd)
        {
            return pltd_dal.Delete(pltd);
        }

        public int Restore(PhanLoaiTD pltd)
        {
            return pltd_dal.Restore(pltd);
        }

        private bool IsValid(PhanLoaiTD pltd)
        {
            return pltd.TenLoai != String.Empty;
        }
    }
}

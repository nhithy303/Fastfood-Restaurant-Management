using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PhanLoaiNVBLL
    {
        PhanLoaiNVDAL plnv_dal = new PhanLoaiNVDAL();
        public PhanLoaiNV[] GetList(PhanLoaiNV plnv)
        {
            return plnv_dal.GetList(plnv);
        }

        public int Create(PhanLoaiNV plnv)
        {
            return plnv_dal.Create(plnv);
        }

        public int Update(PhanLoaiNV plnv)
        {
            return plnv_dal.Update(plnv);
        }

        public int Delete(PhanLoaiNV plnv)
        {
            return plnv_dal.Delete(plnv);
        }

        public int Restore(PhanLoaiNV plnv)
        {
            return plnv_dal.Restore(plnv);
        }
    }
}

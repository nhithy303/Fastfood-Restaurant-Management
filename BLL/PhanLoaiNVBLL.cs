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
        public PhanLoaiNV[] GetList()
        {
            return plnv_dal.GetList();
        }

        public string Create(PhanLoaiNV plnv)
        {
            return plnv_dal.Create(plnv);
        }

        public string Update(PhanLoaiNV plnv)
        {
            return plnv_dal.Update(plnv);
        }

        public string Delete(PhanLoaiNV plnv)
        {
            return plnv_dal.Delete(plnv);
        }

        public string Restore(PhanLoaiNV plnv)
        {
            return plnv_dal.Restore(plnv);
        }
    }
}

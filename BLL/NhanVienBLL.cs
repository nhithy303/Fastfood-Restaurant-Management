using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhanVienBLL
    {
        NhanVienDAL nv_dal = new NhanVienDAL();
        public NhanVien[] GetList()
        {
            return nv_dal.GetList();
        }

        public string Create(NhanVien nv)
        {
            return nv_dal.Create(nv);
        }

        public string AddAccount(NhanVien nv)
        {
            return nv_dal.AddAccount(nv);
        }

        public string Update(NhanVien nv)
        {
            return nv_dal.Update(nv);
        }

        public string Delete(NhanVien nv)
        {
            return nv_dal.Delete(nv);
        }

        public string Restore(NhanVien nv)
        {
            return nv_dal.Restore(nv);
        }
    }
}

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
        public NhanVien[] GetList(NhanVien nv)
        {
            return nv_dal.GetList(nv);
        }

        public NhanVien[] GetFullName(NhanVien nv)
        {
            return nv_dal.GetFullName(nv);
        }

        public int Create(NhanVien nv)
        {
            if (!IsValid(nv))
            {
                return -2;
            }
            return nv_dal.Create(nv);
        }

        public int AddAccount(NhanVien nv)
        {
            return nv_dal.AddAccount(nv);
        }

        public int Update(NhanVien nv)
        {
            return nv_dal.Update(nv);
        }

        public int Delete(NhanVien nv)
        {
            return nv_dal.Delete(nv);
        }

        public int Restore(NhanVien nv)
        {
            return nv_dal.Restore(nv);
        }

        private bool IsValid(NhanVien nv)
        {
            return nv.HoNV != String.Empty && nv.TenNV != String.Empty
                && nv.Sdt != String.Empty && nv.DiaChi != String.Empty;
        }
    }
}

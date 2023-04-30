using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TaiKhoanBLL
    {
        TaiKhoanDAL tk_dal = new TaiKhoanDAL();
        public TaiKhoan[] GetList()
        {
            return tk_dal.GetList();
        }

        public string Create(TaiKhoan tk)
        {
            return tk_dal.Create(tk);
        }

        public string Update(TaiKhoan tk)
        {
            return tk_dal.Update(tk);
        }

        public string ResetPassword(TaiKhoan tk)
        {
            return tk_dal.ResetPassword(tk);
        }

        public string Delete(TaiKhoan tk)
        {
            return tk_dal.Delete(tk);
        }

        public string Restore(TaiKhoan tk)
        {
            return tk_dal.Restore(tk);
        }
    }
}

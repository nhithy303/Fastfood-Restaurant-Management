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
        public TaiKhoan[] GetList(TaiKhoan tk)
        {
            return tk_dal.GetList(tk);
        }

        public int Create(TaiKhoan tk)
        {
            return tk_dal.Create(tk);
        }

        public int Update(TaiKhoan tk)
        {
            return tk_dal.Update(tk);
        }

        public int ResetPassword(TaiKhoan tk)
        {
            return tk_dal.ResetPassword(tk);
        }

        public int Delete(TaiKhoan tk)
        {
            return tk_dal.Delete(tk);
        }

        public int Restore(TaiKhoan tk)
        {
            return tk_dal.Restore(tk);
        }

        public bool IsValidated(TaiKhoan tk)
        {
            if (tk.TenDangNhap == String.Empty)
            {
                return false;
            }
            if (tk.MatKhau == String.Empty)
            {
                return false;
            }
            return true;
        }
    }
}

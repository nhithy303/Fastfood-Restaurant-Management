using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HoaDonNhapHangBLL
    {
        HoaDonNhapHangDAL hdnh_dal = new HoaDonNhapHangDAL();

        public HoaDonNhapHang[] GetList()
        {
            return hdnh_dal.GetList();
        }

        public string Create(HoaDonNhapHang hdnh)
        {
            return hdnh_dal.Create(hdnh);
        }

        public string Update(HoaDonNhapHang hdnh)
        {
            return hdnh_dal.Update(hdnh);
        }

        public string Delete(HoaDonNhapHang hdnh)
        {
            return hdnh_dal.Delete(hdnh);
        }
    }
}

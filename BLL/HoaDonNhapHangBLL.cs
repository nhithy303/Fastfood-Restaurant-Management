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

        public HoaDonNhapHang[] GetList(HoaDonNhapHang hdnh)
        {
            return hdnh_dal.GetList(hdnh);
        }

        public int Create(HoaDonNhapHang hdnh)
        {
            return hdnh_dal.Create(hdnh);
        }

        public int Update(HoaDonNhapHang hdnh)
        {
            return hdnh_dal.Update(hdnh);
        }

        public int Delete(HoaDonNhapHang hdnh)
        {
            return hdnh_dal.Delete(hdnh);
        }
    }
}

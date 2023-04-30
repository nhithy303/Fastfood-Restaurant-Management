using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HoaDonBanHangBLL
    {
        HoaDonBanHangDAL hdbh_dal = new HoaDonBanHangDAL();

        public HoaDonBanHang[] GetList()
        {
            return hdbh_dal.GetList();
        }

        public string Create(HoaDonBanHang hdbh)
        {
            return hdbh_dal.Create(hdbh);
        }

        public string Update(HoaDonBanHang hdbh)
        {
            return hdbh_dal.Update(hdbh);
        }

        public string Delete(HoaDonBanHang hdbh)
        {
            return hdbh_dal.Delete(hdbh);
        }
    }
}

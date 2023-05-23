using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HoaDonBanHangBLL
    {
        HoaDonBanHangDAL hdbh_dal = new HoaDonBanHangDAL();

        public HoaDonBanHang[] GetList(HoaDonBanHang hdbh)
        {
            return hdbh_dal.GetList(hdbh);
        }

        public int GetLatest()
        {
            return hdbh_dal.GetLatest();
        }

        public int Create(HoaDonBanHang hdbh)
        {
            return hdbh_dal.Create(hdbh);
        }

        public int Update(HoaDonBanHang hdbh)
        {
            return hdbh_dal.Update(hdbh);
        }

        public int Delete(HoaDonBanHang hdbh)
        {
            return hdbh_dal.Delete(hdbh);
        }
    }
}

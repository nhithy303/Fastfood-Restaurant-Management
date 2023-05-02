using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TrangThaiDonHangBLL
    {
        TrangThaiDonHangDAL ttdh_dal = new TrangThaiDonHangDAL();

        public TrangThaiDonHang[] GetList(TrangThaiDonHang ttdh)
        {
            return ttdh_dal.GetList(ttdh);
        }

        public int Create(TrangThaiDonHang ttdh)
        {
            return ttdh_dal.Create(ttdh);
        }

        public int Update(TrangThaiDonHang ttdh)
        {
            return ttdh_dal.Update(ttdh);
        }

        public int Delete(TrangThaiDonHang ttdh)
        {
            return ttdh_dal.Delete(ttdh);
        }

        public int Restore(TrangThaiDonHang ttdh)
        {
            return ttdh_dal.Restore(ttdh);
        }

        public int Served()
        {
            TrangThaiDonHang ttdh_find = new TrangThaiDonHang();
            ttdh_find.TenTT = "Đã phục vụ";
            TrangThaiDonHang[] ttdh = ttdh_dal.GetList(ttdh_find);
            if (ttdh != null)
            {
                return ttdh[0].MaTT;
            }
            return 0;
        }
    }
}

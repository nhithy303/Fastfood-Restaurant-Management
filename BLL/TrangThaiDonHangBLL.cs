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

        public TrangThaiDonHang[] GetList()
        {
            return ttdh_dal.GetList();
        }

        public string Create(TrangThaiDonHang ttdh)
        {
            return ttdh_dal.Create(ttdh);
        }

        public string Update(TrangThaiDonHang ttdh)
        {
            return ttdh_dal.Update(ttdh);
        }

        public string Delete(TrangThaiDonHang ttdh)
        {
            return ttdh_dal.Delete(ttdh);
        }

        public string Restore(TrangThaiDonHang ttdh)
        {
            return ttdh_dal.Restore(ttdh);
        }
    }
}

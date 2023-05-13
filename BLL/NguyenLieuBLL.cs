using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NguyenLieuBLL
    {
        NguyenLieuDAL nl_dal = new NguyenLieuDAL();

        public NguyenLieu[] GetList(NguyenLieu nl)
        {
            return nl_dal.GetList(nl);
        }

        public int GetUnitPrice(NguyenLieu nl)
        {
            if (nl.MaNL == 0)
            {
                return -1;
            }
            return nl_dal.GetUnitPrice(nl);
        }

        public int Create(NguyenLieu nl)
        {
            if (!IsValid(nl))
            {
                return -2;
            }
            return nl_dal.Create(nl);
        }

        public int Update(NguyenLieu nl)
        {
            return nl_dal.Update(nl);
        }

        public int Delete(NguyenLieu nl)
        {
            return nl_dal.Delete(nl);
        }

        private bool IsValid(NguyenLieu nl)
        {
            return nl.TenNL != String.Empty && nl.TonKho >= 0 && nl.DonGia >= 0;
        }
    }
}

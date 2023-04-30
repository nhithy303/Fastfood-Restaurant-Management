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

        public NguyenLieu[] GetList()
        {
            return nl_dal.GetList();
        }

        public string Create(NguyenLieu nl)
        {
            return nl_dal.Create(nl);
        }

        public string Update(NguyenLieu nl)
        {
            return nl_dal.Update(nl);
        }

        public string Delete(NguyenLieu nl)
        {
            return nl_dal.Delete(nl);
        }
    }
}

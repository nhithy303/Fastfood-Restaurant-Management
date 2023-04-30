using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChiTietHDBHBLL
    {
        ChiTietHDBHDAL cthdbh_dal = new ChiTietHDBHDAL();

        public ChiTietHDBH[] GetList()
        {
            return cthdbh_dal.GetList();
        }

        public string Create(ChiTietHDBH cthdbh)
        {
            return cthdbh_dal.Create(cthdbh);
        }

        public string Update(ChiTietHDBH cthdbh)
        {
            return cthdbh_dal.Update(cthdbh);
        }

        public string Delete(ChiTietHDBH cthdbh)
        {
            return cthdbh_dal.Delete(cthdbh);
        }
    }
}

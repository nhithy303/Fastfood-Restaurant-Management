using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class QuanLyBLL
    {
        QuanLyDAL ql_dal = new QuanLyDAL();
        public QuanLy[] GetList()
        {
            return ql_dal.GetList();
        }

        public string Create(QuanLy ql)
        {
            return ql_dal.Create(ql);
        }

        public string AddAccount(QuanLy ql)
        {
            return ql_dal.AddAccount(ql);
        }

        public string Update(QuanLy ql)
        {
            return ql_dal.Update(ql);
        }

        public string Delete(QuanLy ql)
        {
            return ql_dal.Delete(ql);
        }

        public string Restore(QuanLy ql)
        {
            return ql_dal.Restore(ql);
        }
    }
}

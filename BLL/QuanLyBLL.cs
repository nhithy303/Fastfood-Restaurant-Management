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
        public QuanLy[] GetList(QuanLy ql)
        {
            return ql_dal.GetList(ql);
        }

        public int Create(QuanLy ql)
        {
            return ql_dal.Create(ql);
        }

        public int AddAccount(QuanLy ql)
        {
            return ql_dal.AddAccount(ql);
        }

        public int Update(QuanLy ql)
        {
            return ql_dal.Update(ql);
        }

        public int Delete(QuanLy ql)
        {
            return ql_dal.Delete(ql);
        }

        public int Restore(QuanLy ql)
        {
            return ql_dal.Restore(ql);
        }
    }
}

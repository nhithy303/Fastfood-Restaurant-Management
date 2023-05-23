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
        CongThucBLL ct_bll = new CongThucBLL();
        NguyenLieuBLL nl_bll = new NguyenLieuBLL();

        public ChiTietHDBH[] GetList(ChiTietHDBH cthdbh)
        {
            return cthdbh_dal.GetList(cthdbh);
        }

        public int Create(ChiTietHDBH cthdbh)
        {
            int result = cthdbh_dal.Create(cthdbh);
            if (result > 0)
            {
                // Subtract amount of ingredient after selling dishes
                CongThuc ct_find = new CongThuc();
                ct_find.MaMon = cthdbh.MaMon;
                CongThuc[] ct = ct_bll.GetList(ct_find);
                if (ct != null)
                {
                    foreach (CongThuc ct_item in ct)
                    {
                        NguyenLieu nl_find = new NguyenLieu();
                        nl_find.MaNL = ct_item.MaNL;
                        NguyenLieu[] nl = nl_bll.GetList(nl_find);
                        if (nl != null)
                        {
                            nl[0].TonKho -= cthdbh.SoLuong * ct_item.SoLuong;
                            result = nl_bll.Update(nl[0]);
                        }
                    }
                }
            }
            return result;
        }

        public int Update(ChiTietHDBH cthdbh)
        {
            return cthdbh_dal.Update(cthdbh);
        }

        public int Delete(ChiTietHDBH cthdbh)
        {
            return cthdbh_dal.Delete(cthdbh);
        }

        public bool CheckStorage(List<ChiTietHDBH> cthdbh)
        {
            foreach (ChiTietHDBH cthdbh_item in cthdbh)
            {
                CongThuc ct_find = new CongThuc();
                ct_find.MaMon = cthdbh_item.MaMon;
                CongThuc[] ct = ct_bll.GetList(ct_find);
                //cthdbh_item.SoLuong
                if (ct != null)
                {
                    foreach (CongThuc ct_item in ct)
                    {
                        //ct_item.MaNL
                        //ct_item.SoLuong
                        NguyenLieu nl_find = new NguyenLieu();
                        nl_find.MaNL = ct_item.MaNL;
                        NguyenLieu[] nl = nl_bll.GetList(nl_find);
                        if (nl != null)
                        {
                            //nl[0].TonKho
                            if (nl[0].TonKho < cthdbh_item.SoLuong * ct_item.SoLuong)
                            {
                                return false;
                            }
                        }
                    }
                }
            }
            return true;
        }
    }
}

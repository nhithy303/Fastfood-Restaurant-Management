using DTO;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Employee
{
    public partial class frmOrderDetailPrint : Form
    {
        HoaDonBanHang hdbh;
        DataTable cthdbh;
        public frmOrderDetailPrint(HoaDonBanHang hdbh, DataTable table)
        {
            InitializeComponent();
            this.hdbh = hdbh;
            cthdbh = table;
            cthdbh.TableName = "INVOICE";
            this.Load += frmOrderDetailPrint_Load;
        }

        private void frmOrderDetailPrint_Load(object sender, EventArgs e)
        {
            ReportDataSource source = new ReportDataSource("OrderDetail", cthdbh);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(source);
            ReportParameter[] p = new ReportParameter[4];
            p[0] = new ReportParameter("pMaHD", hdbh.MaHD.ToString(), true);
            p[1] = new ReportParameter("pMaNV", hdbh.MaNV.ToString(), true);
            p[2] = new ReportParameter("pNgayHD", hdbh.NgayHD, true);
            p[3] = new ReportParameter("pTongTien", hdbh.TongTien.ToString(), true);
            this.reportViewer1.LocalReport.SetParameters(p);
            reportViewer1.RefreshReport();
        }
    }
}

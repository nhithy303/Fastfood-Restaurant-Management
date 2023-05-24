using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmSalesManagement : Form
    {
        HoaDonBanHangBLL hdbh_bll = new HoaDonBanHangBLL();
        HinhThucThanhToan[] httt;
        HinhThucThanhToanBLL httt_bll = new HinhThucThanhToanBLL();
        TrangThaiDonHang[] ttdh;
        TrangThaiDonHangBLL ttdh_bll = new TrangThaiDonHangBLL();
        NhanVien[] nv;
        NhanVienBLL nv_bll = new NhanVienBLL();
        ExcelBLL excel_bll = new ExcelBLL();

        public frmSalesManagement()
        {
            InitializeComponent();
            this.Load += frmSalesManagement_Load;
            dgvSale.SelectionChanged += dgvSale_SelectionChanged;
            cbEmployee.CheckedChanged += cbEmployee_CheckedChanged;
            cbDate.CheckedChanged += cbDate_CheckedChanged;
            cbPayment.CheckedChanged += cbPayment_CheckedChanged;
            btnSearch.Click += btnSearch_Click;
            btnDetail.Click += btnDetail_Click;
            btnReload.Click += btnReload_Click;
            btnExportExcel.Click += btnExportExcel_Click;
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.CustomFormat = "dd'/'MM'/'yyyy";
            btnDetail.Enabled = false;
        }

        private void frmSalesManagement_Load(object sender, EventArgs e)
        {
            cboEmployee_Load();
            cboPayment_Load();
            cboState_Load();
            dgvSale_Load();
            cboEmployee.Enabled = cboPayment.Enabled = cboState.Enabled = false;
            cbEmployee.Checked = cbDate.Checked = cbPayment.Checked = btnSearch.Enabled = false;
        }

        private void dgvSale_Load()
        {
            dgvSale.DataSource = hdbh_bll.GetList(new HoaDonBanHang());
            dgvSale.Font = new Font("Times New Roman", 13F);
        }

        private void dgvSale_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSale.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvSale.CurrentRow;
                txtID.Text = row.Cells[0].Value.ToString();
                cboEmployee.SelectedValue = int.Parse(row.Cells[1].Value.ToString());
                dtpDate.Value = DateTime.Parse(ReverseDateFormat(row.Cells[2].Value.ToString()));
                txtTotal.Text = row.Cells[3].Value.ToString();
                cboPayment.SelectedValue = int.Parse(row.Cells[4].Value.ToString());
                cboState.SelectedValue = int.Parse(row.Cells[5].Value.ToString());
                btnDetail.Enabled = true;
            }
            else
            {
                btnDetail.Enabled = false;
            }
        }

        private void cboEmployee_Load()
        {
            nv = nv_bll.GetFullName(new NhanVien());
            cboEmployee.DisplayMember = "TenNV";
            cboEmployee.ValueMember = "MaNV";
            cboEmployee.DataSource = nv;
        }

        private void cboPayment_Load()
        {
            httt = httt_bll.GetList(new HinhThucThanhToan());
            cboPayment.DisplayMember = "TenHTTT";
            cboPayment.ValueMember = "MaHTTT";
            cboPayment.DataSource = httt;
        }

        private void cboState_Load()
        {
            ttdh = ttdh_bll.GetList(new TrangThaiDonHang());
            cboState.DisplayMember = "TenTT";
            cboState.ValueMember = "MaTT";
            cboState.DataSource = ttdh;
        }        

        private void cbEmployee_CheckedChanged(object sender, EventArgs e)
        {
            cboEmployee.Enabled = cbEmployee.Checked;
            EnableFeature();
        }

        private void cbDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpDate.Enabled = cbDate.Checked;
            EnableFeature();
        }

        private void cbPayment_CheckedChanged(object sender, EventArgs e)
        {
            cboPayment.Enabled = cbPayment.Checked;
            EnableFeature();
        }

        private void EnableFeature()
        {
            dgvSale.Enabled = (!cbEmployee.Checked && !cbDate.Checked && !cbPayment.Checked);
            btnSearch.Enabled = (cbEmployee.Checked || cbDate.Checked || cbPayment.Checked);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            HoaDonBanHang hdbh_filter = new HoaDonBanHang();
            if (cbEmployee.Checked)
            {
                hdbh_filter.MaNV = Convert.ToInt32(cboEmployee.SelectedValue);
            }
            if (cbDate.Checked)
            {
                hdbh_filter.NgayHD = dtpDate.Value.ToString();
            }
            if (cbPayment.Checked)
            {
                hdbh_filter.ThanhToan = Convert.ToInt32(cboPayment.SelectedValue);
            }
            dgvSale.DataSource = hdbh_bll.GetList(hdbh_filter);
            dgvSale.Font = new Font("Times New Roman", 13F);
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvSale.CurrentRow;
            HoaDonBanHang hdbh = new HoaDonBanHang();
            hdbh.MaHD = int.Parse(row.Cells[0].Value.ToString());
            hdbh.MaNV = int.Parse(row.Cells[1].Value.ToString());
            hdbh.NgayHD = ReverseDateFormat(row.Cells[2].Value.ToString());
            hdbh.TongTien = int.Parse(row.Cells[3].Value.ToString());
            hdbh.ThanhToan = int.Parse(row.Cells[4].Value.ToString());
            hdbh.TrangThai = int.Parse(row.Cells[5].Value.ToString());
            new frmOrderDetail(hdbh, true).ShowDialog();
            dgvSale_Load();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            dgvSale_Load();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            // Convert DataGridView to DataTable
            HoaDonBanHang[] hdbh = (HoaDonBanHang[])(dgvSale.DataSource);
            DataTable table = new DataTable();
            table.Columns.Add("Mã hóa đơn");
            table.Columns.Add("Mã nhân viên");
            table.Columns.Add("Họ tên nhân viên");
            table.Columns.Add("Ngày hóa đơn");
            table.Columns.Add("Tổng tiền");
            table.Columns.Add("Hình thức thanh toán");
            table.Columns.Add("Trạng thái");
            for (int i = 0; i < hdbh.Length; i++)
            {
                DataRow row = table.NewRow();
                row[0] = hdbh[i].MaHD;
                row[1] = hdbh[i].MaNV;
                row[2] = nv.First(item => item.MaNV == hdbh[i].MaNV).TenNV;
                row[3] = ReverseDateFormat(hdbh[i].NgayHD);
                row[4] = hdbh[i].TongTien;
                row[5] = httt.First(item => item.MaHTTT == hdbh[i].ThanhToan).TenHTTT;
                row[6] = ttdh.First(item => item.MaTT == hdbh[i].TrangThai).TenTT;
                table.Rows.Add(row);
            }

            // Export file Excel
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Export file Excel";
            dialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (excel_bll.Export(table, dialog.FileName))
                {
                    ShowMessage("Xuất file Excel thành công!");
                }
                else
                {
                    ShowError("Xuất file Excel thất bại!");
                }
            }
        }

        private void ShowError(string error)
        {
            MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowMessage(string message)
        {
            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string ReverseDateFormat(string date)
        {
            string[] str = date.Split('/', '-');
            return str[2] + "/" + str[1] + "/" + str[0];
        }
    }
}

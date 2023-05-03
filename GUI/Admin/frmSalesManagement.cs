using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmSalesManagement : Form
    {
        HoaDonBanHangBLL hdbh_bll = new HoaDonBanHangBLL();
        HinhThucThanhToanBLL httt_bll = new HinhThucThanhToanBLL();
        TrangThaiDonHangBLL ttdh_bll = new TrangThaiDonHangBLL();
        NhanVienBLL nv_bll = new NhanVienBLL();

        public frmSalesManagement()
        {
            InitializeComponent();
            this.Load += frmSalesManagement_Load;
            dgvSale.SelectionChanged += dgvSale_SelectionChanged;
            btnDetail.Click += btnDetail_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnSave.Click += btnSave_Click;
            btnDelete.Click += btnDelete_Click;
            btnExportExcel.Click += btnExportExcel_Click;
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.CustomFormat = "dd'/'MM'/'yyyy";
        }

        private void frmSalesManagement_Load(object sender, EventArgs e)
        {
            dgvSale_Load();
            cboEmployee_Load();
            cboPayment_Load();
            cboState_Load();
            btnSave.Enabled = false;
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

                btnUpdate.Enabled = btnDelete.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = btnDelete.Enabled = false;
            }
        }

        private void cboEmployee_Load()
        {
            NhanVien[] nv = nv_bll.GetFullName(new NhanVien());
            cboEmployee.DisplayMember = "TenNV";
            cboEmployee.ValueMember = "MaNV";
            cboEmployee.DataSource = nv;
        }

        private void cboPayment_Load()
        {
            HinhThucThanhToan[] httt = httt_bll.GetList(new HinhThucThanhToan());
            cboPayment.DisplayMember = "TenHTTT";
            cboPayment.ValueMember = "MaHTTT";
            cboPayment.DataSource = httt;
        }

        private void cboState_Load()
        {
            TrangThaiDonHang[] ttdh = ttdh_bll.GetList(new TrangThaiDonHang());
            cboState.DisplayMember = "TenTT";
            cboState.ValueMember = "MaTT";
            cboState.DataSource = ttdh;
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvSale.CurrentRow;
            HoaDonBanHang hdbh = new HoaDonBanHang();
            hdbh.MaHD = int.Parse(row.Cells[0].Value.ToString());
            hdbh.ThanhToan = int.Parse(row.Cells[4].Value.ToString());
            hdbh.TrangThai = int.Parse(row.Cells[5].Value.ToString());
            new frmOrderDetail(hdbh).ShowDialog();
            //dgvSale_Load();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Text == "Sửa")
            {
                btnUpdate.Text = "Hủy";
                btnSave.Enabled = true;
                btnDelete.Enabled = false;
            }
            else // btnUpdate.Text == "Hủy"
            {
                btnUpdate.Text = "Sửa";
                btnSave.Enabled = false;
                btnDelete.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            HoaDonBanHang hdbh = new HoaDonBanHang();
            hdbh.MaHD = int.Parse(txtID.Text);
            hdbh.MaNV = int.Parse(cboEmployee.SelectedValue.ToString());
            hdbh.TongTien = int.Parse(txtTotal.Text);
            hdbh.ThanhToan = int.Parse(cboPayment.SelectedValue.ToString());
            hdbh.TrangThai = int.Parse(cboState.SelectedValue.ToString());

            int result = hdbh_bll.Update(hdbh);
            if (result > 0)
            {
                btnUpdate.Text = "Sửa";
                btnSave.Enabled = false;
                btnDelete.Enabled = true;
                ShowMessage("Sửa thông tin hóa đơn bán hàng thành công!");
                dgvSale_Load();
            }
            else if (result == -2)
            {
                ShowError("Thông tin không hợp lệ!");
            }
            else
            {
                ShowError("Sửa thông tin hóa đơn bán hàng thất bại!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvSale.CurrentRow;
            string question = String.Format("Bạn có chắc chắn muốn xóa đơn hàng {0} không?",
                row.Cells[0].Value.ToString());
            DialogResult r = MessageBox.Show(question, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                HoaDonBanHang hdbh_delete = new HoaDonBanHang();
                hdbh_delete.MaHD = int.Parse(row.Cells[0].Value.ToString());
                hdbh_delete.TrangThai = int.Parse(row.Cells[5].Value.ToString());
                int result = hdbh_bll.Delete(hdbh_delete);
                if (result > 0)
                {
                    ShowMessage("Xóa đơn hàng thành công!");
                    dgvSale_Load();
                }
                else if (result == -2)
                {
                    ShowError("Không thể xóa đơn hàng đã phục vụ!");
                }
                else
                {
                    ShowError("Xóa đơn hàng thất bại!");
                }
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {

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

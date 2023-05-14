using BLL;
using DTO;
using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Employee
{
    public partial class frmOrderManagement : Form
    {
        NhanVien nv;
        HoaDonBanHangBLL hdbh_bll = new HoaDonBanHangBLL();
        HinhThucThanhToanBLL httt_bll = new HinhThucThanhToanBLL();
        TrangThaiDonHangBLL ttdh_bll = new TrangThaiDonHangBLL();

        public frmOrderManagement(NhanVien nv)
        {
            InitializeComponent();
            this.Load += frmOrderManagement_Load;
            this.nv = nv;
            dgvOrder.SelectionChanged += dgvOrder_SelectionChanged;
            btnDetail.Click += btnDetail_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnSave.Click += btnSave_Click;
            btnDelete.Click += btnDelete_Click;
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.CustomFormat = "dd'/'MM'/'yyyy";
        }

        private void frmOrderManagement_Load(object sender, EventArgs e)
        {
            cboPayment_Load();
            cboState_Load();
            dgvOrder_Load();
            DisableInput();
            btnSave.Enabled = false;
        }

        private void dgvOrder_Load()
        {
            HoaDonBanHang hdbh_find = new HoaDonBanHang();
            hdbh_find.MaNV = nv.MaNV;
            dgvOrder.DataSource = hdbh_bll.GetList(hdbh_find);
            dgvOrder.Font = new Font("Times New Roman", 13F);
        }

        private void dgvOrder_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrder.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvOrder.CurrentRow;
                txtID.Text = row.Cells[0].Value.ToString();
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
            DataGridViewRow row = dgvOrder.CurrentRow;
            HoaDonBanHang hdbh = new HoaDonBanHang();
            hdbh.MaHD = int.Parse(row.Cells[0].Value.ToString());
            hdbh.MaNV = int.Parse(row.Cells[1].Value.ToString());
            hdbh.NgayHD = ReverseDateFormat(row.Cells[2].Value.ToString());
            hdbh.TongTien = int.Parse(row.Cells[3].Value.ToString());
            hdbh.ThanhToan = int.Parse(row.Cells[4].Value.ToString());
            hdbh.TrangThai = int.Parse(row.Cells[5].Value.ToString());
            new frmOrderDetail(hdbh, false).ShowDialog();
            dgvOrder_Load();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Text == "Sửa")
            {
                btnUpdate.Text = "Hủy";
                btnSave.Enabled = true;
                btnDelete.Enabled = false;
                EnableInput();
            }
            else // btnUpdate.Text == "Hủy"
            {
                btnUpdate.Text = "Sửa";
                btnSave.Enabled = false;
                btnDelete.Enabled = true;
                DisableInput();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            HoaDonBanHang hdbh = new HoaDonBanHang();
            hdbh.MaHD = int.Parse(txtID.Text);
            hdbh.MaNV = nv.MaNV;
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
                DisableInput();
                dgvOrder_Load();
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
            DataGridViewRow row = dgvOrder.CurrentRow;
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
                    dgvOrder_Load();
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

        private void EnableInput()
        {
            cboPayment.Enabled = cboState.Enabled = true;
        }

        private void DisableInput()
        {
            cboPayment.Enabled = cboState.Enabled = false;
        }
    }
}

using BLL;
using DTO;
using GUI.Employee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmOrderDetail : Form
    {
        bool isAdmin;
        HoaDonBanHang hdbh;
        TrangThaiDonHangBLL ttdh_bll = new TrangThaiDonHangBLL();
        ChiTietHDBHBLL cthdbh_bll = new ChiTietHDBHBLL();
        ThucDonBLL td_bll = new ThucDonBLL();
        HoaDonBanHangBLL hdbh_bll = new HoaDonBanHangBLL();

        public frmOrderDetail(HoaDonBanHang hdbh, bool isAdmin)
        {
            InitializeComponent();
            this.isAdmin = isAdmin;
            this.hdbh = hdbh;
            this.Load += frmOrderDetail_Load;
            dgvOrderDetail.SelectionChanged += dgvOrderDetail_SelectionChanged;
            cboMenu.SelectedIndexChanged += cboMenu_SelectedIndexChanged;
            numQuantity.ValueChanged += numQuantity_ValueChanged;
            btnCreate.Click += btnCreate_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnSave.Click += btnSave_Click;
            btnDelete.Click += btnDelete_Click;
            btnPrint.Click += btnPrint_Click;
            btnUpdate.Enabled = btnDelete.Enabled = false;
        }

        private void frmOrderDetail_Load(object sender, EventArgs e)
        {
            EnableEdit();
            cboMenu_Load();
            dgvOrderDetail_Load();
            DisableInput();
            btnSave.Enabled = false;
            UpdateTotal();
        }

        private void dgvOrderDetail_Load()
        {
            ChiTietHDBH cthdbh = new ChiTietHDBH();
            cthdbh.MaHD = hdbh.MaHD;
            dgvOrderDetail.DataSource = cthdbh_bll.GetList(cthdbh);
            dgvOrderDetail.Font = new Font("Times New Roman", 13F);
        }

        private void dgvOrderDetail_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrderDetail.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvOrderDetail.CurrentRow;
                cboMenu.SelectedValue = int.Parse(row.Cells[1].Value.ToString());
                numQuantity.Value = int.Parse(row.Cells[2].Value.ToString());
                txtUnitPrice.Text = row.Cells[3].Value.ToString();
                txtTotalPrice.Text = row.Cells[4].Value.ToString();

                EnableEdit();
            }
            else
            {
                btnUpdate.Enabled = btnDelete.Enabled = false;
            }
        }

        private void cboMenu_Load()
        {
            ThucDon[] td = td_bll.GetList(new ThucDon());
            cboMenu.DisplayMember = "TenMon";
            cboMenu.ValueMember = "MaMon";
            cboMenu.DataSource = td;
        }

        private void cboMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMenu.SelectedIndex > 0)
            {
                ThucDon td_find = new ThucDon();
                td_find.MaMon = int.Parse(cboMenu.SelectedValue.ToString());
                ThucDon[] td = td_bll.GetList(td_find);
                if (td != null)
                {
                    txtUnitPrice.Text = td[0].GiaBan.ToString();
                    txtTotalPrice.Text = (numQuantity.Value * td[0].GiaBan).ToString();
                }
            }
        }

        private void numQuantity_ValueChanged(object sender, EventArgs e)
        {
            if (txtUnitPrice.Text != "")
            {
                txtTotalPrice.Text = (numQuantity.Value * int.Parse(txtUnitPrice.Text)).ToString();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (btnCreate.Text == "Thêm")
            {
                btnCreate.Text = "Hủy";
                btnSave.Enabled = true;
                btnUpdate.Enabled = btnDelete.Enabled = false;
                EnableInput();
            }
            else // btnCreate.Text == "Hủy"
            {
                btnCreate.Text = "Thêm";
                btnSave.Enabled = false;
                btnUpdate.Enabled = btnDelete.Enabled = true;
                DisableInput();
            }
            ResetInput();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Text == "Sửa")
            {
                btnUpdate.Text = "Hủy";
                btnSave.Enabled = true;
                btnCreate.Enabled = btnDelete.Enabled = false;
                EnableInput();
            }
            else // btnUpdate.Text == "Hủy"
            {
                btnUpdate.Text = "Sửa";
                btnSave.Enabled = false;
                btnCreate.Enabled = btnDelete.Enabled = true;
                DisableInput();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ChiTietHDBH cthdbh = new ChiTietHDBH();
            cthdbh.MaHD = hdbh.MaHD;
            cthdbh.MaMon = int.Parse(cboMenu.SelectedValue.ToString());
            cthdbh.SoLuong = int.Parse(numQuantity.Value.ToString());
            cthdbh.DonGia = int.Parse(txtUnitPrice.Text);
            cthdbh.ThanhTien = int.Parse(txtTotalPrice.Text);

            int result = 0;
            string action = "";
            if (btnCreate.Enabled)
            {
                action = "Thêm mới";
                result = cthdbh_bll.Create(cthdbh);
            }
            else if (btnUpdate.Enabled)
            {
                action = "Sửa thông tin";
                result = cthdbh_bll.Update(cthdbh);
            }

            if (result > 0)
            {
                if (btnCreate.Enabled)
                {
                    btnCreate.Text = "Thêm";
                    btnSave.Enabled = false;
                    btnUpdate.Enabled = btnDelete.Enabled = true;
                }
                else if (btnUpdate.Enabled)
                {
                    btnUpdate.Text = "Sửa";
                    btnSave.Enabled = false;
                    btnCreate.Enabled = btnDelete.Enabled = true;
                }
                ShowMessage(String.Format("{0} chi tiết hóa đơn thành công!", action));
                EnableEdit();
                DisableInput();
                dgvOrderDetail_Load();
                UpdateTotal();
            }
            else if (result == -2)
            {
                ShowError("Thông tin không hợp lệ!");
            }
            else
            {
                ShowError(String.Format("{0} chi tiết hóa đơn thất bại!", action));
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvOrderDetail.CurrentRow;
            string question = String.Format("Bạn có chắc chắn muốn xóa chi tiết hóa đơn \"{0}\" với món ăn \"{1}\" không?",
                hdbh.MaHD, cboMenu.SelectedText);
            DialogResult r = MessageBox.Show(question, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                ChiTietHDBH cthdbh_delete = new ChiTietHDBH();
                cthdbh_delete.MaHD = int.Parse(row.Cells[0].Value.ToString());
                cthdbh_delete.MaMon = int.Parse(row.Cells[1].Value.ToString());
                int result = cthdbh_bll.Delete(cthdbh_delete);
                if (result > 0)
                {
                    ShowMessage("Xóa chi tiết hóa đơn thành công!");
                    dgvOrderDetail_Load();
                    UpdateTotal();
                }
                else
                {
                    ShowError("Xóa chi tiết hóa đơn thất bại!");
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvOrderDetail.RowCount > 0)
            {
                // Pass table of ChiTietHDBH to print
                DataTable table = new DataTable();
                table.Columns.Add("TENMON");
                table.Columns.Add("SOLUONG");
                table.Columns.Add("DONGIA");
                table.Columns.Add("THANHTIEN");
                foreach (DataGridViewRow row in dgvOrderDetail.Rows)
                {
                    DataRow newRow = table.NewRow();

                    // Find TENMON of MAMON
                    ThucDon td_find = new ThucDon();
                    td_find.MaMon = int.Parse(row.Cells[1].Value.ToString());
                    ThucDon[] td = td_bll.GetList(td_find);
                    if (td != null)
                    {
                        newRow[0] = td[0].TenMon;
                    }
                    // Add value of other columns
                    newRow[1] = row.Cells[2].Value;
                    newRow[2] = row.Cells[3].Value;
                    newRow[3] = row.Cells[4].Value;

                    table.Rows.Add(newRow);
                }
                new frmOrderDetailPrint(hdbh, table).ShowDialog();
            }
            else
            {
                ShowError("Chi tiết hóa đơn bán hàng này còn trống!");
            }
        }

        private void UpdateTotal()
        {
            int total = 0;
            if (dgvOrderDetail.RowCount > 0)
            {
                foreach (DataGridViewRow row in dgvOrderDetail.Rows)
                {
                    total += int.Parse(row.Cells[4].Value.ToString());
                }
            }
            txtTotal.Text = total.ToString();
            hdbh.TongTien = total;
            int result = hdbh_bll.Update(hdbh);
        }

        private void ShowError(string error)
        {
            MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowMessage(string message)
        {
            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EnableEdit()
        {
            // If the current user is Admin
            // or
            // If this order has been already served -> don't allow editing
            if (isAdmin || hdbh.TrangThai == ttdh_bll.Served())
            {
                btnCreate.Enabled = btnUpdate.Enabled = btnDelete.Enabled = false;
            }
            else
            {
                btnCreate.Enabled = btnUpdate.Enabled = btnDelete.Enabled = true;
            }
        }

        private void ResetInput()
        {
            cboMenu.SelectedIndex = 0;
            numQuantity.Value = 0;
            txtUnitPrice.Text = txtTotalPrice.Text = "";
        }

        private void EnableInput()
        {
            cboMenu.Enabled = numQuantity.Enabled = true;
        }

        private void DisableInput()
        {
            cboMenu.Enabled = numQuantity.Enabled = false;
        }
    }
}

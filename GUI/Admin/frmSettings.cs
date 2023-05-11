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
using System.Xml.Linq;

namespace GUI.Admin
{
    public partial class frmSettings : Form
    {
        DonViTinhBLL dvt_bll = new DonViTinhBLL();
        HinhThucThanhToanBLL httt_bll = new HinhThucThanhToanBLL();
        PhanLoaiNVBLL plnv_bll = new PhanLoaiNVBLL();
        PhanLoaiTDBLL pltd_bll = new PhanLoaiTDBLL();
        TrangThaiDonHangBLL ttdh_bll = new TrangThaiDonHangBLL();
        ThamSoBLL ts_bll = new ThamSoBLL();

        public frmSettings()
        {
            InitializeComponent();
            this.Load += frmSettings_Load;
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            tpGeneral_Load();
            tpUnit_Load();
            tpPaymentMethod_Load();
            tpEmployeeCategory_Load();
            tpMenuCategory_Load();
            tpOrderState_Load();
        }

        // General
        private void tpGeneral_Load()
        {

        }

        // Unit
        private void tpUnit_Load()
        {

        }

        // Payment Method
        private void tpPaymentMethod_Load()
        {

        }

        // Employee Category
        private void tpEmployeeCategory_Load()
        {

        }

        // Menu Category
        private void tpMenuCategory_Load()
        {
            dgvMenuCategory_Load();
            dgvMenuCategory.SelectionChanged += dgvMenuCategory_SelectionChanged;
            btnCreateMenuCategory.Click += btnCreateMenuCategory_Click;
            btnUpdateMenuCategory.Click += btnUpdateMenuCategory_Click;
            btnSaveMenuCategory.Click += btnSaveMenuCategory_Click;
            btnDeleteMenuCategory.Click += btnDeleteMenuCategory_Click;
            DisableMenuCategoryInput();
            btnSaveMenuCategory.Enabled = false;
        }

        private void dgvMenuCategory_Load()
        {
            dgvMenuCategory.DataSource = pltd_bll.GetList(new PhanLoaiTD());
            dgvMenuCategory.Font = new Font("Times New Roman", 13F);
        }

        private void btnCreateMenuCategory_Click(object sender, EventArgs e)
        {
            if (btnCreateMenuCategory.Text == "Thêm")
            {
                btnCreateMenuCategory.Text = "Hủy";
                btnSaveMenuCategory.Enabled = true;
                btnUpdateMenuCategory.Enabled = btnDeleteMenuCategory.Enabled = dgvMenuCategory.Enabled = false;
                txtMenuCategoryName.Clear();
                EnableMenuCategoryInput();
            }
            else // btnCreateMenuCategory.Text == "Hủy"
            {
                btnCreateMenuCategory.Text = "Thêm";
                btnSaveMenuCategory.Enabled = false;
                btnUpdateMenuCategory.Enabled = btnDeleteMenuCategory.Enabled = dgvMenuCategory.Enabled = true;
                DisableMenuCategoryInput();
            }
            txtMenuCategoryID.Text = "";
        }

        private void btnUpdateMenuCategory_Click(object sender, EventArgs e)
        {
            if (btnUpdateMenuCategory.Text == "Sửa")
            {
                btnUpdateMenuCategory.Text = "Hủy";
                btnSaveMenuCategory.Enabled = true;
                btnCreateMenuCategory.Enabled = btnDeleteMenuCategory.Enabled = dgvMenuCategory.Enabled = false;
                EnableMenuCategoryInput();
            }
            else // btnUpdateMenuCategory.Text == "Hủy"
            {
                btnUpdateMenuCategory.Text = "Sửa";
                btnSaveMenuCategory.Enabled = false;
                btnCreateMenuCategory.Enabled = btnDeleteMenuCategory.Enabled = dgvMenuCategory.Enabled = true;
                DisableMenuCategoryInput();
            }
        }

        private void btnSaveMenuCategory_Click(object sender, EventArgs e)
        {
            PhanLoaiTD pltd = new PhanLoaiTD();
            if (txtMenuCategoryID.Text != "")
            {
                pltd.MaLoai = int.Parse(txtMenuCategoryID.Text);
            }
            if (txtMenuCategoryName.Text != "")
            {
                pltd.TenLoai = txtMenuCategoryName.Text;
            }

            int result = 0;
            string action = "";
            if (btnCreateMenuCategory.Enabled)
            {
                action = "Thêm mới";
                result = pltd_bll.Create(pltd);
            }
            else if (btnUpdateMenuCategory.Enabled)
            {
                action = "Sửa thông tin";
                result = pltd_bll.Update(pltd);
            }

            if (result > 0)
            {
                if (btnCreateMenuCategory.Enabled)
                {
                    btnCreateMenuCategory.Text = "Thêm";
                    btnSaveMenuCategory.Enabled = false;
                    btnUpdateMenuCategory.Enabled = btnDeleteMenuCategory.Enabled = true;
                }
                else if (btnUpdateMenuCategory.Enabled)
                {
                    btnUpdateMenuCategory.Text = "Sửa";
                    btnSaveMenuCategory.Enabled = false;
                    btnCreateMenuCategory.Enabled = btnDeleteMenuCategory.Enabled = true;
                }
                ShowMessage(String.Format("{0} phân loại thực đơn thành công!", action));
                DisableMenuCategoryInput();
                dgvMenuCategory_Load();
            }
            else if (result == -2)
            {
                ShowError("Thông tin không hợp lệ!");
            }
            else
            {
                ShowError(String.Format("{0} phân loại thực đơn thất bại!", action));
            }
            dgvMenuCategory.Enabled = true;
        }

        private void btnDeleteMenuCategory_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvMenuCategory.CurrentRow;
            string question = String.Format("Bạn có chắc chắn muốn xóa phân loại thực đơn \"{0}\" không?",
                row.Cells[1].Value.ToString());
            DialogResult r = MessageBox.Show(question, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                PhanLoaiTD pltd_delete = new PhanLoaiTD();
                pltd_delete.MaLoai = int.Parse(row.Cells[0].Value.ToString());
                int result = pltd_bll.Delete(pltd_delete);
                if (result > 0)
                {
                    ShowMessage("Xóa phân loại thực đơn thành công!");
                    dgvMenuCategory_Load();
                }
                else
                {
                    ShowError("Xóa phân loại thực đơn thất bại!");
                }
            }
        }

        private void dgvMenuCategory_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMenuCategory.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvMenuCategory.CurrentRow;
                txtMenuCategoryID.Text = row.Cells[0].Value.ToString();
                txtMenuCategoryName.Text = row.Cells[1].Value.ToString();

                btnUpdateMenuCategory.Enabled = btnDeleteMenuCategory.Enabled = true;
            }
        }

        private void EnableMenuCategoryInput()
        {
            txtMenuCategoryName.ReadOnly = false;
        }

        private void DisableMenuCategoryInput()
        {
            txtMenuCategoryName.ReadOnly = true;
        }

        // Order State
        private void tpOrderState_Load()
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
    }
}

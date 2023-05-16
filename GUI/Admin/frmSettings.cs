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
using System.Xml.XPath;

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
        int menuColumns;
        int profitMargin;
        private void tpGeneral_Load()
        {
            // CheckBox & Input
            cbMenuColumns.Checked = cbProfitMargin.Checked = false;
            numMenuColumns.Enabled = txtProfitMargin.Enabled = false;
            cbMenuColumns.CheckedChanged += cbMenuColumns_CheckedChanged;
            cbProfitMargin.CheckedChanged += cbProfitMargin_CheckedChanged;
            // Menu columns
            numMenuColumns_Load();
            menuColumns = Convert.ToInt32(numMenuColumns.Value);
            // Profit margin
            txtProfitMargin_Load();
            profitMargin = int.Parse(txtProfitMargin.Text);
            // Button
            btnUpdateGeneral.Click += btnUpdateGeneral_Click;
            btnCancelGeneral.Click += btnCancelGeneral_Click;
        }

        private void numMenuColumns_Load()
        {
            ThamSo ts_MenuColumns = new ThamSo();
            ts_MenuColumns.TenTS = "MenuColumns";
            ThamSo[] ts = ts_bll.GetList(ts_MenuColumns);
            if (ts == null)
            {
                numMenuColumns.Value = 0;
                return;
            }
            numMenuColumns.Value = ts[0].GiaTri;
        }

        private void txtProfitMargin_Load()
        {
            ThamSo ts_ProfitMargin = new ThamSo();
            ts_ProfitMargin.TenTS = "ProfitMargin";
            ThamSo[] ts = ts_bll.GetList(ts_ProfitMargin);
            if (ts == null)
            {
                txtProfitMargin.Text = "0";
                return;
            }
            txtProfitMargin.Text = ts[0].GiaTri.ToString();
        }

        private void cbMenuColumns_CheckedChanged(object sender, EventArgs e)
        {
            numMenuColumns.Enabled = cbMenuColumns.Checked;
        }

        private void cbProfitMargin_CheckedChanged(object sender, EventArgs e)
        {
            txtProfitMargin.Enabled = cbProfitMargin.Checked;
        }

        private void btnUpdateGeneral_Click(object sender, EventArgs e)
        {
            int[] result = { -1, -1 };
            if (cbMenuColumns.Checked)
            {
                if (numMenuColumns.Value > 0)
                {
                    ThamSo ts_MenuColumns = new ThamSo();
                    ts_MenuColumns.TenTS = "MenuColumns";
                    ts_MenuColumns.GiaTri = Convert.ToInt32(numMenuColumns.Value);
                    if (ts_bll.Update(ts_MenuColumns) > 0)
                    {
                        result[0] = 1;
                        menuColumns = ts_MenuColumns.GiaTri;
                    }
                    else
                    {
                        result[0] = 0;
                    }
                }
            }
            if (cbProfitMargin.Checked)
            {
                if (txtProfitMargin.Text.Trim().Length == 0)
                {
                    ShowError("Thông tin phần trăm lợi nhuận còn trống!");
                }
                else if (!txtProfitMargin.Text.All(char.IsDigit))
                {
                    ShowError("Phần trăm lợi nhuận phải là giá trị số!");
                }
                else
                {
                    ThamSo ts_ProfitMargin = new ThamSo();
                    ts_ProfitMargin.TenTS = "ProfitMargin";
                    ts_ProfitMargin.GiaTri = int.Parse(txtProfitMargin.Text.Trim());
                    if (ts_bll.Update(ts_ProfitMargin) > 0)
                    {
                        result[1] = 1;
                        profitMargin = ts_ProfitMargin.GiaTri;
                    }
                    else
                    {
                        result[1] = 0;
                    }
                }
            }
            string message = "Kết quả cập nhật:\n";
            if (result[0] > -1)
            {
                message += "- Số cột thực đơn: " + (result[0] == 1 ? "Thành công" : "Thất bại");
            }
            if (result[1] > -1)
            {
                message += "\n- Phần trăm lợi nhuận: " + (result[1] == 1 ? "Thành công" : "Thất bại");
            }
            ShowMessage(message);
        }

        private void btnCancelGeneral_Click(object sender, EventArgs e)
        {
            cbMenuColumns.Checked = cbProfitMargin.Checked = false;
            numMenuColumns.Value = menuColumns;
            txtProfitMargin.Text = profitMargin.ToString();
        }

        // Unit
        private void tpUnit_Load()
        {
            dgvUnit_Load();
            dgvUnit.SelectionChanged += dgvUnit_SelectionChanged;
            btnCreateUnit.Click += btnCreateUnit_Click;
            btnUpdateUnit.Click += btnUpdateUnit_Click;
            btnSaveUnit.Click += btnSaveUnit_Click;
            btnDeleteUnit.Click += btnDeleteUnit_Click;
            DisableUnitInput();
            btnUpdateUnit.Enabled = btnSaveUnit.Enabled = btnDeleteUnit.Enabled = false;
        }

        private void dgvUnit_Load()
        {
            dgvUnit.DataSource = dvt_bll.GetList(new DonViTinh());
            dgvUnit.Font = new Font("Times New Roman", 13F);
        }

        private void btnCreateUnit_Click(object sender, EventArgs e)
        {
            if (btnCreateUnit.Text == "Thêm")
            {
                btnCreateUnit.Text = "Hủy";
                btnSaveUnit.Enabled = true;
                btnUpdateUnit.Enabled = btnDeleteUnit.Enabled = dgvUnit.Enabled = false;
                txtUnitName.Clear();
                EnableUnitInput();
            }
            else // btnCreateUnit.Text == "Hủy"
            {
                btnCreateUnit.Text = "Thêm";
                btnSaveUnit.Enabled = false;
                btnUpdateUnit.Enabled = btnDeleteUnit.Enabled = dgvUnit.Enabled = true;
                DisableUnitInput();
            }
            txtUnitID.Text = "";
        }

        private void btnUpdateUnit_Click(object sender, EventArgs e)
        {
            if (btnUpdateUnit.Text == "Sửa")
            {
                btnUpdateUnit.Text = "Hủy";
                btnSaveUnit.Enabled = true;
                btnCreateUnit.Enabled = btnDeleteUnit.Enabled = dgvUnit.Enabled = false;
                EnableUnitInput();
            }
            else // btnUpdateUnit.Text == "Hủy"
            {
                btnUpdateUnit.Text = "Sửa";
                btnSaveUnit.Enabled = false;
                btnCreateUnit.Enabled = btnDeleteUnit.Enabled = dgvUnit.Enabled = true;
                DisableUnitInput();
            }
        }

        private void btnSaveUnit_Click(object sender, EventArgs e)
        {
            DonViTinh dvt = new DonViTinh();
            if (txtUnitID.Text != "")
            {
                dvt.MaDVT = int.Parse(txtUnitID.Text);
            }
            if (txtUnitName.Text != "")
            {
                dvt.TenDVT = txtUnitName.Text;
            }

            int result = 0;
            string action = "";
            if (btnCreateUnit.Enabled)
            {
                action = "Thêm mới";
                result = dvt_bll.Create(dvt);
            }
            else if (btnUpdateUnit.Enabled)
            {
                action = "Sửa thông tin";
                result = dvt_bll.Update(dvt);
            }

            if (result > 0)
            {
                if (btnCreateUnit.Enabled)
                {
                    btnCreateUnit.Text = "Thêm";
                    btnSaveUnit.Enabled = false;
                    btnUpdateUnit.Enabled = btnDeleteUnit.Enabled = true;
                }
                else if (btnUpdateUnit.Enabled)
                {
                    btnUpdateUnit.Text = "Sửa";
                    btnSaveUnit.Enabled = false;
                    btnCreateUnit.Enabled = btnDeleteUnit.Enabled = true;
                }
                ShowMessage(String.Format("{0} đơn vị tính thành công!", action));
                DisableUnitInput();
                dgvUnit_Load();
            }
            else if (result == -2)
            {
                ShowError("Thông tin không hợp lệ!");
            }
            else
            {
                ShowError(String.Format("{0} đơn vị tính thất bại!", action));
            }
            dgvUnit.Enabled = true;
        }

        private void btnDeleteUnit_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvUnit.CurrentRow;
            string question = String.Format("Bạn có chắc chắn muốn xóa đơn vị tính \"{0}\" không?",
                row.Cells[1].Value.ToString());
            DialogResult r = MessageBox.Show(question, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                DonViTinh dvt_delete = new DonViTinh();
                dvt_delete.MaDVT = int.Parse(row.Cells[0].Value.ToString());
                int result = dvt_bll.Delete(dvt_delete);
                if (result > 0)
                {
                    ShowMessage("Xóa đơn vị tính thành công!");
                    dgvUnit_Load();
                }
                else
                {
                    ShowError("Xóa đơn vị tính thất bại!");
                }
            }
        }

        private void dgvUnit_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUnit.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvUnit.CurrentRow;
                txtUnitID.Text = row.Cells[0].Value.ToString();
                txtUnitName.Text = row.Cells[1].Value.ToString();

                btnUpdateUnit.Enabled = btnDeleteUnit.Enabled = true;
            }
            else
            {
                btnUpdateUnit.Enabled = btnDeleteUnit.Enabled = false;
            }
        }

        private void EnableUnitInput()
        {
            txtUnitName.ReadOnly = false;
        }

        private void DisableUnitInput()
        {
            txtUnitName.ReadOnly = true;
        }

        // Payment Method
        private void tpPaymentMethod_Load()
        {
            dgvPaymentMethod_Load();
            dgvPaymentMethod.SelectionChanged += dgvPaymentMethod_SelectionChanged;
            btnCreatePaymentMethod.Click += btnCreatePaymentMethod_Click;
            btnUpdatePaymentMethod.Click += btnUpdatePaymentMethod_Click;
            btnSavePaymentMethod.Click += btnSavePaymentMethod_Click;
            btnDeletePaymentMethod.Click += btnDeletePaymentMethod_Click;
            DisablePaymentMethodInput();
            btnUpdatePaymentMethod.Enabled = btnSavePaymentMethod.Enabled = btnDeletePaymentMethod.Enabled = false;
        }

        private void dgvPaymentMethod_Load()
        {
            dgvPaymentMethod.DataSource = httt_bll.GetList(new HinhThucThanhToan());
            dgvPaymentMethod.Font = new Font("Times New Roman", 13F);
        }

        private void btnCreatePaymentMethod_Click(object sender, EventArgs e)
        {
            if (btnCreatePaymentMethod.Text == "Thêm")
            {
                btnCreatePaymentMethod.Text = "Hủy";
                btnSavePaymentMethod.Enabled = true;
                btnUpdatePaymentMethod.Enabled = btnDeletePaymentMethod.Enabled = dgvPaymentMethod.Enabled = false;
                txtPaymentMethodName.Clear();
                EnablePaymentMethodInput();
            }
            else // btnCreatePaymentMethod.Text == "Hủy"
            {
                btnCreatePaymentMethod.Text = "Thêm";
                btnSavePaymentMethod.Enabled = false;
                btnUpdatePaymentMethod.Enabled = btnDeletePaymentMethod.Enabled = dgvPaymentMethod.Enabled = true;
                DisablePaymentMethodInput();
            }
            txtPaymentMethodID.Text = "";
        }

        private void btnUpdatePaymentMethod_Click(object sender, EventArgs e)
        {
            if (btnUpdatePaymentMethod.Text == "Sửa")
            {
                btnUpdatePaymentMethod.Text = "Hủy";
                btnSavePaymentMethod.Enabled = true;
                btnCreatePaymentMethod.Enabled = btnDeletePaymentMethod.Enabled = dgvPaymentMethod.Enabled = false;
                EnablePaymentMethodInput();
            }
            else // btnUpdatePaymentMethod.Text == "Hủy"
            {
                btnUpdatePaymentMethod.Text = "Sửa";
                btnSavePaymentMethod.Enabled = false;
                btnCreatePaymentMethod.Enabled = btnDeletePaymentMethod.Enabled = dgvPaymentMethod.Enabled = true;
                DisablePaymentMethodInput();
            }
        }

        private void btnSavePaymentMethod_Click(object sender, EventArgs e)
        {
            HinhThucThanhToan httt = new HinhThucThanhToan();
            if (txtPaymentMethodID.Text != "")
            {
                httt.MaHTTT = int.Parse(txtPaymentMethodID.Text);
            }
            if (txtPaymentMethodName.Text != "")
            {
                httt.TenHTTT = txtPaymentMethodName.Text;
            }

            int result = 0;
            string action = "";
            if (btnCreatePaymentMethod.Enabled)
            {
                action = "Thêm mới";
                result = httt_bll.Create(httt);
            }
            else if (btnUpdatePaymentMethod.Enabled)
            {
                action = "Sửa thông tin";
                result = httt_bll.Update(httt);
            }

            if (result > 0)
            {
                if (btnCreatePaymentMethod.Enabled)
                {
                    btnCreatePaymentMethod.Text = "Thêm";
                    btnSavePaymentMethod.Enabled = false;
                    btnUpdatePaymentMethod.Enabled = btnDeletePaymentMethod.Enabled = true;
                }
                else if (btnUpdatePaymentMethod.Enabled)
                {
                    btnUpdatePaymentMethod.Text = "Sửa";
                    btnSavePaymentMethod.Enabled = false;
                    btnCreatePaymentMethod.Enabled = btnDeletePaymentMethod.Enabled = true;
                }
                ShowMessage(String.Format("{0} hình thức thanh toán thành công!", action));
                DisablePaymentMethodInput();
                dgvPaymentMethod_Load();
            }
            else if (result == -2)
            {
                ShowError("Thông tin không hợp lệ!");
            }
            else
            {
                ShowError(String.Format("{0} hình thức thanh toán thất bại!", action));
            }
            dgvPaymentMethod.Enabled = true;
        }

        private void btnDeletePaymentMethod_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvPaymentMethod.CurrentRow;
            string question = String.Format("Bạn có chắc chắn muốn xóa hình thức thanh toán \"{0}\" không?",
                row.Cells[1].Value.ToString());
            DialogResult r = MessageBox.Show(question, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                HinhThucThanhToan httt_delete = new HinhThucThanhToan();
                httt_delete.MaHTTT = int.Parse(row.Cells[0].Value.ToString());
                int result = httt_bll.Delete(httt_delete);
                if (result > 0)
                {
                    ShowMessage("Xóa hình thức thanh toán thành công!");
                    dgvPaymentMethod_Load();
                }
                else
                {
                    ShowError("Xóa hình thức thanh toán thất bại!");
                }
            }
        }

        private void dgvPaymentMethod_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPaymentMethod.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvPaymentMethod.CurrentRow;
                txtPaymentMethodID.Text = row.Cells[0].Value.ToString();
                txtPaymentMethodName.Text = row.Cells[1].Value.ToString();

                btnUpdatePaymentMethod.Enabled = btnDeletePaymentMethod.Enabled = true;
            }
            else
            {
                btnUpdatePaymentMethod.Enabled = btnDeletePaymentMethod.Enabled = false;
            }
        }

        private void EnablePaymentMethodInput()
        {
            txtPaymentMethodName.ReadOnly = false;
        }

        private void DisablePaymentMethodInput()
        {
            txtPaymentMethodName.ReadOnly = true;
        }

        // Employee Category
        private void tpEmployeeCategory_Load()
        {
            dgvEmployeeCategory_Load();
            dgvEmployeeCategory.SelectionChanged += dgvEmployeeCategory_SelectionChanged;
            btnCreateEmployeeCategory.Click += btnCreateEmployeeCategory_Click;
            btnUpdateEmployeeCategory.Click += btnUpdateEmployeeCategory_Click;
            btnSaveEmployeeCategory.Click += btnSaveEmployeeCategory_Click;
            btnDeleteEmployeeCategory.Click += btnDeleteEmployeeCategory_Click;
            DisableEmployeeCategoryInput();
            btnUpdateEmployeeCategory.Enabled = btnSaveEmployeeCategory.Enabled = btnDeleteEmployeeCategory.Enabled = false;
        }

        private void dgvEmployeeCategory_Load()
        {
            dgvEmployeeCategory.DataSource = plnv_bll.GetList(new PhanLoaiNV());
            dgvEmployeeCategory.Font = new Font("Times New Roman", 13F);
        }

        private void btnCreateEmployeeCategory_Click(object sender, EventArgs e)
        {
            if (btnCreateEmployeeCategory.Text == "Thêm")
            {
                btnCreateEmployeeCategory.Text = "Hủy";
                btnSaveEmployeeCategory.Enabled = true;
                btnUpdateEmployeeCategory.Enabled = btnDeleteEmployeeCategory.Enabled = dgvEmployeeCategory.Enabled = false;
                txtEmployeeCategoryName.Clear();
                EnableEmployeeCategoryInput();
            }
            else // btnCreateEmployeeCategory.Text == "Hủy"
            {
                btnCreateEmployeeCategory.Text = "Thêm";
                btnSaveEmployeeCategory.Enabled = false;
                btnUpdateEmployeeCategory.Enabled = btnDeleteEmployeeCategory.Enabled = dgvEmployeeCategory.Enabled = true;
                DisableEmployeeCategoryInput();
            }
            txtEmployeeCategoryID.Text = "";
        }

        private void btnUpdateEmployeeCategory_Click(object sender, EventArgs e)
        {
            if (btnUpdateEmployeeCategory.Text == "Sửa")
            {
                btnUpdateEmployeeCategory.Text = "Hủy";
                btnSaveEmployeeCategory.Enabled = true;
                btnCreateEmployeeCategory.Enabled = btnDeleteEmployeeCategory.Enabled = dgvEmployeeCategory.Enabled = false;
                EnableEmployeeCategoryInput();
            }
            else // btnUpdateEmployeeCategory.Text == "Hủy"
            {
                btnUpdateEmployeeCategory.Text = "Sửa";
                btnSaveEmployeeCategory.Enabled = false;
                btnCreateEmployeeCategory.Enabled = btnDeleteEmployeeCategory.Enabled = dgvEmployeeCategory.Enabled = true;
                DisableEmployeeCategoryInput();
            }
        }

        private void btnSaveEmployeeCategory_Click(object sender, EventArgs e)
        {
            PhanLoaiNV plnv = new PhanLoaiNV();
            if (txtEmployeeCategoryID.Text != "")
            {
                plnv.MaLoai = int.Parse(txtEmployeeCategoryID.Text);
            }
            if (txtEmployeeCategoryName.Text != "")
            {
                plnv.TenLoai = txtEmployeeCategoryName.Text;
            }

            int result = 0;
            string action = "";
            if (btnCreateEmployeeCategory.Enabled)
            {
                action = "Thêm mới";
                result = plnv_bll.Create(plnv);
            }
            else if (btnUpdateEmployeeCategory.Enabled)
            {
                action = "Sửa thông tin";
                result = plnv_bll.Update(plnv);
            }

            if (result > 0)
            {
                if (btnCreateEmployeeCategory.Enabled)
                {
                    btnCreateEmployeeCategory.Text = "Thêm";
                    btnSaveEmployeeCategory.Enabled = false;
                    btnUpdateEmployeeCategory.Enabled = btnDeleteEmployeeCategory.Enabled = true;
                }
                else if (btnUpdateEmployeeCategory.Enabled)
                {
                    btnUpdateEmployeeCategory.Text = "Sửa";
                    btnSaveEmployeeCategory.Enabled = false;
                    btnCreateEmployeeCategory.Enabled = btnDeleteEmployeeCategory.Enabled = true;
                }
                ShowMessage(String.Format("{0} phân loại nhân viên thành công!", action));
                DisableEmployeeCategoryInput();
                dgvEmployeeCategory_Load();
            }
            else if (result == -2)
            {
                ShowError("Thông tin không hợp lệ!");
            }
            else
            {
                ShowError(String.Format("{0} phân loại nhân viên thất bại!", action));
            }
            dgvEmployeeCategory.Enabled = true;
        }

        private void btnDeleteEmployeeCategory_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvEmployeeCategory.CurrentRow;
            string question = String.Format("Bạn có chắc chắn muốn xóa phân loại nhân viên \"{0}\" không?",
                row.Cells[1].Value.ToString());
            DialogResult r = MessageBox.Show(question, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                PhanLoaiNV plnv_delete = new PhanLoaiNV();
                plnv_delete.MaLoai = int.Parse(row.Cells[0].Value.ToString());
                int result = plnv_bll.Delete(plnv_delete);
                if (result > 0)
                {
                    ShowMessage("Xóa phân loại nhân viên thành công!");
                    dgvEmployeeCategory_Load();
                }
                else
                {
                    ShowError("Xóa phân loại nhân viên thất bại!");
                }
            }
        }

        private void dgvEmployeeCategory_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmployeeCategory.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvEmployeeCategory.CurrentRow;
                txtEmployeeCategoryID.Text = row.Cells[0].Value.ToString();
                txtEmployeeCategoryName.Text = row.Cells[1].Value.ToString();

                btnUpdateEmployeeCategory.Enabled = btnDeleteEmployeeCategory.Enabled = true;
            }
            else
            {
                btnUpdateEmployeeCategory.Enabled = btnDeleteEmployeeCategory.Enabled = false;
            }
        }

        private void EnableEmployeeCategoryInput()
        {
            txtEmployeeCategoryName.ReadOnly = false;
        }

        private void DisableEmployeeCategoryInput()
        {
            txtEmployeeCategoryName.ReadOnly = true;
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
            btnUpdateMenuCategory.Enabled = btnSaveMenuCategory.Enabled = btnDeleteMenuCategory.Enabled = false;
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
            else
            {
                btnUpdateMenuCategory.Enabled = btnDeleteMenuCategory.Enabled = false;
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
            dgvOrderState_Load();
            dgvOrderState.SelectionChanged += dgvOrderState_SelectionChanged;
            btnCreateOrderState.Click += btnCreateOrderState_Click;
            btnUpdateOrderState.Click += btnUpdateOrderState_Click;
            btnSaveOrderState.Click += btnSaveOrderState_Click;
            btnDeleteOrderState.Click += btnDeleteOrderState_Click;
            DisableOrderStateInput();
            btnUpdateOrderState.Enabled = btnSaveOrderState.Enabled = btnDeleteOrderState.Enabled = false;
        }

        private void dgvOrderState_Load()
        {
            dgvOrderState.DataSource = ttdh_bll.GetList(new TrangThaiDonHang());
            dgvOrderState.Font = new Font("Times New Roman", 13F);
        }

        private void btnCreateOrderState_Click(object sender, EventArgs e)
        {
            if (btnCreateOrderState.Text == "Thêm")
            {
                btnCreateOrderState.Text = "Hủy";
                btnSaveOrderState.Enabled = true;
                btnUpdateOrderState.Enabled = btnDeleteOrderState.Enabled = dgvOrderState.Enabled = false;
                txtOrderStateName.Clear();
                EnableOrderStateInput();
            }
            else // btnCreateOrderState.Text == "Hủy"
            {
                btnCreateOrderState.Text = "Thêm";
                btnSaveOrderState.Enabled = false;
                btnUpdateOrderState.Enabled = btnDeleteOrderState.Enabled = dgvOrderState.Enabled = true;
                DisableOrderStateInput();
            }
            txtOrderStateID.Text = "";
        }

        private void btnUpdateOrderState_Click(object sender, EventArgs e)
        {
            if (btnUpdateOrderState.Text == "Sửa")
            {
                btnUpdateOrderState.Text = "Hủy";
                btnSaveOrderState.Enabled = true;
                btnCreateOrderState.Enabled = btnDeleteOrderState.Enabled = dgvOrderState.Enabled = false;
                EnableOrderStateInput();
            }
            else // btnUpdateOrderState.Text == "Hủy"
            {
                btnUpdateOrderState.Text = "Sửa";
                btnSaveOrderState.Enabled = false;
                btnCreateOrderState.Enabled = btnDeleteOrderState.Enabled = dgvOrderState.Enabled = true;
                DisableOrderStateInput();
            }
        }

        private void btnSaveOrderState_Click(object sender, EventArgs e)
        {
            TrangThaiDonHang ttdh = new TrangThaiDonHang();
            if (txtOrderStateID.Text != "")
            {
                ttdh.MaTT = int.Parse(txtOrderStateID.Text);
            }
            if (txtOrderStateName.Text != "")
            {
                ttdh.TenTT = txtOrderStateName.Text;
            }

            int result = 0;
            string action = "";
            if (btnCreateOrderState.Enabled)
            {
                action = "Thêm mới";
                result = ttdh_bll.Create(ttdh);
            }
            else if (btnUpdateOrderState.Enabled)
            {
                action = "Sửa thông tin";
                result = ttdh_bll.Update(ttdh);
            }

            if (result > 0)
            {
                if (btnCreateOrderState.Enabled)
                {
                    btnCreateOrderState.Text = "Thêm";
                    btnSaveOrderState.Enabled = false;
                    btnUpdateOrderState.Enabled = btnDeleteOrderState.Enabled = true;
                }
                else if (btnUpdateOrderState.Enabled)
                {
                    btnUpdateOrderState.Text = "Sửa";
                    btnSaveOrderState.Enabled = false;
                    btnCreateOrderState.Enabled = btnDeleteOrderState.Enabled = true;
                }
                ShowMessage(String.Format("{0} trạng thái đơn hàng thành công!", action));
                DisableOrderStateInput();
                dgvOrderState_Load();
            }
            else if (result == -2)
            {
                ShowError("Thông tin không hợp lệ!");
            }
            else
            {
                ShowError(String.Format("{0} trạng thái đơn hàng thất bại!", action));
            }
            dgvOrderState.Enabled = true;
        }

        private void btnDeleteOrderState_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvOrderState.CurrentRow;
            string question = String.Format("Bạn có chắc chắn muốn xóa trạng thái đơn hàng \"{0}\" không?",
                row.Cells[1].Value.ToString());
            DialogResult r = MessageBox.Show(question, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                TrangThaiDonHang ttdh_delete = new TrangThaiDonHang();
                ttdh_delete.MaTT = int.Parse(row.Cells[0].Value.ToString());
                int result = ttdh_bll.Delete(ttdh_delete);
                if (result > 0)
                {
                    ShowMessage("Xóa trạng thái đơn hàng thành công!");
                    dgvOrderState_Load();
                }
                else
                {
                    ShowError("Xóa trạng thái đơn hàng thất bại!");
                }
            }
        }

        private void dgvOrderState_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrderState.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvOrderState.CurrentRow;
                txtOrderStateID.Text = row.Cells[0].Value.ToString();
                txtOrderStateName.Text = row.Cells[1].Value.ToString();

                btnUpdateOrderState.Enabled = btnDeleteOrderState.Enabled = true;
            }
            else
            {
                btnUpdateOrderState.Enabled = btnDeleteOrderState.Enabled = false;
            }
        }

        private void EnableOrderStateInput()
        {
            txtOrderStateName.ReadOnly = false;
        }

        private void DisableOrderStateInput()
        {
            txtOrderStateName.ReadOnly = true;
        }

        // Helpers
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

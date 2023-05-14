using BLL;
using DTO;
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
    public partial class frmMenuRecipe : Form
    {
        ThucDon td;
        CongThucBLL ct_bll = new CongThucBLL();
        NguyenLieuBLL nl_bll = new NguyenLieuBLL();
        DonViTinhBLL dvt_bll = new DonViTinhBLL();

        public frmMenuRecipe(ThucDon td)
        {
            InitializeComponent();
            this.td = td;
            this.Load += frmMenuRecipe_Load;
            dgvRecipe.SelectionChanged += dgvRecipe_SelectionChanged;
            cboIngredient.SelectedIndexChanged += cboIngredient_SelectedIndexChanged;
            txtQuantity.Leave += txtQuantity_Leave;
            btnCreate.Click += btnCreate_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnSave.Click += btnSave_Click;
            btnDelete.Click += btnDelete_Click;
        }

        private void frmMenuRecipe_Load(object sender, EventArgs e)
        {
            txtID.Text = td.MaMon.ToString();
            txtName.Text = td.TenMon;
            cboIngredient_Load();
            cboUnit_Load();
            dgvRecipe_Load();
            DisableInput();
            btnSave.Enabled = false;
        }

        private void dgvRecipe_Load()
        {
            CongThuc ct = new CongThuc();
            ct.MaMon = td.MaMon;
            dgvRecipe.DataSource = ct_bll.GetList(ct);
            dgvRecipe.Font = new Font("Times New Roman", 13F);
        }

        private void dgvRecipe_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRecipe.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvRecipe.CurrentRow;
                txtID.Text = row.Cells[0].Value.ToString();
                cboIngredient.SelectedValue = int.Parse(row.Cells[1].Value.ToString());
                txtQuantity.Text = row.Cells[2].Value.ToString();
                cboUnit.SelectedValue = int.Parse(row.Cells[3].Value.ToString());
                txtCost.Text = row.Cells[4].Value.ToString();

                btnUpdate.Enabled = btnDelete.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = btnDelete.Enabled = false;
            }
        }

        private void cboIngredient_Load()
        {
            NguyenLieu[] nl = nl_bll.GetList(new NguyenLieu());
            cboIngredient.DisplayMember = "TenNL";
            cboIngredient.ValueMember = "MaNL";
            cboIngredient.DataSource = nl;
        }

        private void cboIngredient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboIngredient.SelectedIndex > 0)
            {
                NguyenLieu nl_find = new NguyenLieu();
                nl_find.MaNL = int.Parse(cboIngredient.SelectedValue.ToString());
                NguyenLieu[] nl = nl_bll.GetList(nl_find);
                if (nl.Length > 0)
                {
                    cboUnit.SelectedValue = nl[0].DonViTinh;
                }
            }
        }

        private void cboUnit_Load()
        {
            DonViTinh[] dvt = dvt_bll.GetList(new DonViTinh());
            cboUnit.DisplayMember = "TenDVT";
            cboUnit.ValueMember = "MaDVT";
            cboUnit.DataSource = dvt;
        }

        private void txtQuantity_Leave(object sender, EventArgs e)
        {
            if (txtQuantity.Text.Trim() != "")
            {
                int quantity = 0;
                if (int.TryParse(txtQuantity.Text, out quantity))
                {
                    NguyenLieu nl = new NguyenLieu();
                    nl.MaNL = int.Parse(cboIngredient.SelectedValue.ToString());
                    txtCost.Text = (nl_bll.GetUnitPrice(nl) * quantity).ToString();
                    return;
                }
            }
            txtCost.Text = "0";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (btnCreate.Text == "Thêm")
            {
                btnCreate.Text = "Hủy";
                btnSave.Enabled = true;
                btnUpdate.Enabled = btnDelete.Enabled = dgvRecipe.Enabled = false;
                txtName.Clear();
                EnableInput();
            }
            else // btnCreate.Text == "Hủy"
            {
                btnCreate.Text = "Thêm";
                btnSave.Enabled = false;
                btnUpdate.Enabled = btnDelete.Enabled = dgvRecipe.Enabled = true;
                DisableInput();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Text == "Sửa")
            {
                btnUpdate.Text = "Hủy";
                btnSave.Enabled = true;
                btnCreate.Enabled = btnDelete.Enabled = dgvRecipe.Enabled = false;
                EnableInput();
            }
            else // btnUpdate.Text == "Hủy"
            {
                btnUpdate.Text = "Sửa";
                btnSave.Enabled = false;
                btnCreate.Enabled = btnDelete.Enabled = dgvRecipe.Enabled = true;
                DisableInput();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CongThuc ct = new CongThuc();
            ct.MaMon = td.MaMon;
            ct.MaNL = int.Parse(cboIngredient.SelectedValue.ToString());
            ct.SoLuong = int.Parse(txtQuantity.Text);
            ct.DonViTinh = int.Parse(cboUnit.SelectedValue.ToString());
            ct.GiaNL = int.Parse(txtCost.Text);

            int result = 0;
            string action = "";
            if (btnCreate.Enabled)
            {
                action = "Thêm mới";
                result = ct_bll.Create(ct);
            }
            else if (btnUpdate.Enabled)
            {
                action = "Sửa thông tin";
                result = ct_bll.Update(ct);
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
                ShowMessage(String.Format("{0} công thức thành công!", action));
                DisableInput();
                dgvRecipe_Load();
            }
            else if (result == -2)
            {
                ShowError("Thông tin không hợp lệ!");
            }
            else
            {
                ShowError(String.Format("{0} công thức thất bại!", action));
            }
            dgvRecipe.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvRecipe.CurrentRow;
            string question = String.Format("Bạn có chắc chắn muốn xóa công thức của món \"{0}\" với nguyên liệu \"{1}\" không?",
                txtName.Text, cboIngredient.SelectedText);
            DialogResult r = MessageBox.Show(question, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                CongThuc ct_delete = new CongThuc();
                ct_delete.MaMon = int.Parse(row.Cells[0].Value.ToString());
                ct_delete.MaNL = int.Parse(row.Cells[1].Value.ToString());
                int result = ct_bll.Delete(ct_delete);
                if (result > 0)
                {
                    ShowMessage("Xóa công thức thành công!");
                    dgvRecipe_Load();
                }
                else
                {
                    ShowError("Xóa công thức thất bại!");
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

        private void EnableInput()
        {
            txtQuantity.ReadOnly = false;
            cboIngredient.Enabled = true;
        }

        private void DisableInput()
        {
            txtQuantity.ReadOnly = true;
            cboIngredient.Enabled = false;
        }
    }
}

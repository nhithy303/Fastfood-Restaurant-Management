using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmStorageManagement : Form
    {
        NguyenLieuBLL nl_bll = new NguyenLieuBLL();
        DonViTinhBLL dvt_bll = new DonViTinhBLL();

        public frmStorageManagement()
        {
            InitializeComponent();
            this.Load += frmStorageManagement_Load;
            dgvIngredient.SelectionChanged += dgvIngredient_SelectionChanged;
            btnCreate.Click += btnCreate_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnSave.Click += btnSave_Click;
            btnDelete.Click += btnDelete_Click;
        }

        private void frmStorageManagement_Load(object sender, EventArgs e)
        {
            dgvIngredient_Load();
            cboUnit_Load();
            DisableInput();
            btnSave.Enabled = false;
        }

        private void dgvIngredient_Load()
        {
            dgvIngredient.DataSource = nl_bll.GetList(new NguyenLieu());
            dgvIngredient.Font = new Font("Times New Roman", 13F);
        }

        private void dgvIngredient_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvIngredient.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvIngredient.CurrentRow;
                txtID.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtQuantity.Text = row.Cells[2].Value.ToString();
                cboUnit.SelectedValue = int.Parse(row.Cells[3].Value.ToString());
                txtUnitPrice.Text = row.Cells[4].Value.ToString();

                btnUpdate.Enabled = btnDelete.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = btnDelete.Enabled = false;
            }
        }

        private void cboUnit_Load()
        {
            DonViTinh[] dvt = dvt_bll.GetList(new DonViTinh());
            cboUnit.DisplayMember = "TenDVT";
            cboUnit.ValueMember = "MaDVT";
            cboUnit.DataSource = dvt;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (btnCreate.Text == "Thêm")
            {
                btnCreate.Text = "Hủy";
                btnSave.Enabled = true;
                btnUpdate.Enabled = btnDelete.Enabled = false;
                ResetInput();
                EnableInput();
            }
            else // btnCreate.Text == "Hủy"
            {
                btnCreate.Text = "Thêm";
                btnSave.Enabled = false;
                btnUpdate.Enabled = btnDelete.Enabled = true;
                DisableInput();
            }
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
            NguyenLieu nl = new NguyenLieu();
            if (txtID.Text != "")
            {
                nl.MaNL = int.Parse(txtID.Text);
            }
            nl.TenNL = txtName.Text;
            nl.TonKho = int.Parse(txtQuantity.Text);
            nl.DonViTinh = int.Parse(cboUnit.SelectedValue.ToString());
            nl.DonGia = int.Parse(txtUnitPrice.Text);

            int result = 0;
            string action = "";
            if (btnCreate.Enabled)
            {
                action = "Thêm mới";
                result = nl_bll.Create(nl);
            }
            else if (btnUpdate.Enabled)
            {
                action = "Sửa thông tin";
                result = nl_bll.Update(nl);
            }

            if (result > 0)
            {
                if (btnCreate.Enabled)
                {
                    btnCreate.Text = "Thêm";
                    btnSave.Enabled = false;
                    btnUpdate.Enabled = true;
                }
                else if (btnUpdate.Enabled)
                {
                    btnUpdate.Text = "Sửa";
                    btnSave.Enabled = false;
                    btnCreate.Enabled = true;
                }
                btnDelete.Enabled = true;
                ShowMessage(String.Format("{0} nguyên liệu thành công!", action));
                DisableInput();
                dgvIngredient_Load();
            }
            else if (result == -2)
            {
                ShowError("Thông tin không hợp lệ!");
            }
            else
            {
                ShowError(String.Format("{0} nguyên liệu thất bại!", action));
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvIngredient.CurrentRow;
            string question = String.Format("Bạn có chắc chắn muốn xóa nguyên liệu \'{0}\' không?",
                row.Cells[1].Value.ToString());
            DialogResult r = MessageBox.Show(question, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                NguyenLieu nl_delete = new NguyenLieu();
                nl_delete.MaNL = int.Parse(row.Cells[0].Value.ToString());
                int result = nl_bll.Delete(nl_delete);
                if (result > 0)
                {
                    ShowMessage("Xóa nguyên liệu thành công!");
                    dgvIngredient_Load();
                }
                else
                {
                    ShowError("Xóa nguyên liệu thất bại!");
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
            txtName.ReadOnly = txtQuantity.ReadOnly = txtUnitPrice.ReadOnly = false;
            cboUnit.Enabled = true;
        }

        private void DisableInput()
        {
            txtName.ReadOnly = txtQuantity.ReadOnly = txtUnitPrice.ReadOnly = true;
            cboUnit.Enabled = false;
        }

        private void ResetInput()
        {
            txtID.Text = "";
            txtName.Clear();
            txtQuantity.Clear();
            cboUnit.SelectedIndex = 0;
            txtUnitPrice.Clear();
        }
    }
}

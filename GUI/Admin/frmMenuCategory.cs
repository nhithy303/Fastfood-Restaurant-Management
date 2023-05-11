using BLL;
using DTO;
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

namespace GUI
{
    public partial class frmMenuCategory : Form
    {
        PhanLoaiTDBLL pltd_bll = new PhanLoaiTDBLL();

        public frmMenuCategory()
        {
            InitializeComponent();
            this.Load += frmMenuCategory_Load;
            dgvMenuCategory.SelectionChanged += dgvMenuCategory_SelectionChanged;
            btnCreate.Click += btnCreate_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnSave.Click += btnSave_Click;
            btnDelete.Click += btnDelete_Click;
        }

        private void frmMenuCategory_Load(object sender, EventArgs e)
        {
            dgvMenuCategory_Load();
            DisableInput();
            btnSave.Enabled = false;
        }

        private void dgvMenuCategory_Load()
        {
            dgvMenuCategory.DataSource = pltd_bll.GetList(new PhanLoaiTD());
            dgvMenuCategory.Font = new Font("Times New Roman", 13F);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (btnCreate.Text == "Thêm")
            {
                btnCreate.Text = "Hủy";
                btnSave.Enabled = true;
                btnUpdate.Enabled = btnDelete.Enabled = dgvMenuCategory.Enabled = false;
                txtName.Clear();
                EnableInput();
            }
            else // btnCreate.Text == "Hủy"
            {
                btnCreate.Text = "Thêm";
                btnSave.Enabled = false;
                btnUpdate.Enabled = btnDelete.Enabled = dgvMenuCategory.Enabled = true;
                DisableInput();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Text == "Sửa")
            {
                btnUpdate.Text = "Hủy";
                btnSave.Enabled = true;
                btnCreate.Enabled = btnDelete.Enabled = dgvMenuCategory.Enabled = false;
                EnableInput();
            }
            else // btnUpdate.Text == "Hủy"
            {
                btnUpdate.Text = "Sửa";
                btnSave.Enabled = false;
                btnCreate.Enabled = btnDelete.Enabled = dgvMenuCategory.Enabled = true;
                DisableInput();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PhanLoaiTD pltd = new PhanLoaiTD();
            if (txtID.Text != "")
            {
                pltd.MaLoai = int.Parse(txtID.Text);
            }
            if (txtName.Text != "")
            {
                pltd.TenLoai = txtName.Text;
            }

            int result = 0;
            string action = "";
            if (btnCreate.Enabled)
            {
                action = "Thêm mới";
                result = pltd_bll.Create(pltd);
            }
            else if (btnUpdate.Enabled)
            {
                action = "Sửa thông tin";
                result = pltd_bll.Update(pltd);
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
                ShowMessage(String.Format("{0} phân loại thực đơn thành công!", action));
                DisableInput();
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

        private void btnDelete_Click(object sender, EventArgs e)
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
                txtID.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();

                btnUpdate.Enabled = btnDelete.Enabled = true;
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
            txtName.ReadOnly = false;
        }

        private void DisableInput()
        {
            txtName.ReadOnly = true;
        }
    }
}

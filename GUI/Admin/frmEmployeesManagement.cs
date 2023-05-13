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
    public partial class frmEmployeesManagement : Form
    {
        TaiKhoanBLL tk_bll = new TaiKhoanBLL();
        NhanVienBLL nv_bll = new NhanVienBLL();
        PhanLoaiNVBLL plnv_bll = new PhanLoaiNVBLL();
        
        public frmEmployeesManagement()
        {
            InitializeComponent();
            this.Load += frmEmployeesManagement_Load;
            dgvEmployees.SelectionChanged += dgvEmployees_SelectionChanged;
            btnCreate.Click += btnCreate_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnSave.Click += btnSave_Click;
            btnDelete.Click += btnDelete_Click;
            btnResetPassword.Click += btnResetPassword_Click;
            dtpBirthday.Format = DateTimePickerFormat.Custom;
            dtpBirthday.CustomFormat = "dd'/'MM'/'yyyy";
            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.CustomFormat = "dd'/'MM'/'yyyy";
        }

        private void frmEmployeesManagement_Load(object sender, EventArgs e)
        {
            dgvEmployees_Load();
            cboGender_Load();
            cboType_Load();
            DisableInput();
            btnSave.Enabled = false;
        }

        private void dgvEmployees_Load()
        {
            dgvEmployees.DataSource = nv_bll.GetList(new NhanVien());
            dgvEmployees.Font = new Font("Times New Roman", 13F);
        }

        private void dgvEmployees_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvEmployees.CurrentRow;
                txtID.Text = row.Cells[0].Value.ToString();
                txtAccount.Text = row.Cells[1].Value.ToString();
                txtLastName.Text = row.Cells[2].Value.ToString();
                txtFirstName.Text = row.Cells[3].Value.ToString();
                dtpBirthday.Value = DateTime.Parse(ReverseDateFormat(row.Cells[4].Value.ToString()));
                cboGender.SelectedValue = int.Parse(row.Cells[5].Value.ToString());
                txtPhone.Text = row.Cells[6].Value.ToString();
                txtAddress.Text = row.Cells[7].Value.ToString();
                cboType.SelectedValue = int.Parse(row.Cells[8].Value.ToString());
                dtpStartDate.Value = DateTime.Parse(ReverseDateFormat(row.Cells[9].Value.ToString()));

                btnUpdate.Enabled = btnDelete.Enabled = btnResetPassword.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = btnDelete.Enabled = btnResetPassword.Enabled = false;
            }
        }

        private void cboGender_Load()
        {
            Dictionary<string, int> gender = new Dictionary<string, int>
            {
                {"Nữ", 1}, {"Nam", 2}
            };
            cboGender.DisplayMember = "Key";
            cboGender.ValueMember = "Value";
            cboGender.DataSource = new BindingSource(gender, null);
        }

        private void cboType_Load()
        {
            PhanLoaiNV[] plnv = plnv_bll.GetList(new PhanLoaiNV());
            cboType.DisplayMember = "TenLoai";
            cboType.ValueMember = "MaLoai";
            cboType.DataSource = plnv;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (btnCreate.Text == "Thêm")
            {
                btnCreate.Text = "Hủy";
                btnSave.Enabled = true;
                btnUpdate.Enabled = btnDelete.Enabled = btnResetPassword.Enabled = dgvEmployees.Enabled = false;
                ResetInput();
                EnableInput();
            }
            else // btnCreate.Text == "Hủy"
            {
                btnCreate.Text = "Thêm";
                btnSave.Enabled = false;
                btnUpdate.Enabled = btnDelete.Enabled = btnResetPassword.Enabled = dgvEmployees.Enabled = true;
                DisableInput();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Text == "Sửa")
            {
                btnUpdate.Text = "Hủy";
                btnSave.Enabled = true;
                btnCreate.Enabled = btnDelete.Enabled = btnResetPassword.Enabled = dgvEmployees.Enabled = false;
                EnableInput();
            }
            else // btnUpdate.Text == "Hủy"
            {
                btnUpdate.Text = "Sửa";
                btnSave.Enabled = false;
                btnCreate.Enabled = btnDelete.Enabled = btnResetPassword.Enabled = dgvEmployees.Enabled = true;
                DisableInput();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            if (txtID.Text != "" && txtAccount.Text != "")
            {
                nv.MaNV = int.Parse(txtID.Text);
                nv.MaTK = int.Parse(txtAccount.Text);
            }
            nv.HoNV = txtLastName.Text;
            nv.TenNV = txtFirstName.Text;
            nv.NgaySinh = DateTime.Parse(dtpBirthday.Value.ToString()).ToString("yyyy-MM-dd");
            nv.GioiTinh = int.Parse(cboGender.SelectedValue.ToString());
            nv.Sdt = txtPhone.Text;
            nv.DiaChi = txtAddress.Text;
            nv.MaLoai = int.Parse(cboType.SelectedValue.ToString());
            nv.NgayVaoLam = DateTime.Parse(dtpStartDate.Value.ToString()).ToString("yyyy-MM-dd");

            int result = 0;
            string action = "";
            if (btnCreate.Enabled)
            {
                action = "Thêm mới";
                result = nv_bll.Create(nv);
            }
            else if (btnUpdate.Enabled)
            {
                action = "Sửa thông tin";
                result = nv_bll.Update(nv);
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
                ShowMessage(String.Format("{0} nhân viên thành công!", action));
                DisableInput();
                dgvEmployees_Load();
            }
            else if (result == -2)
            {
                ShowError("Thông tin không hợp lệ!");
            }
            else
            {
                ShowError(String.Format("{0} nhân viên thất bại!", action));
            }
            dgvEmployees.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvEmployees.CurrentRow;
            string question = String.Format("Bạn có chắc chắn muốn xóa nhân viên {0} - {1} {2} không?",
                row.Cells[0].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString());
            DialogResult r = MessageBox.Show(question, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                NhanVien nv_delete = new NhanVien();
                nv_delete.MaNV = int.Parse(row.Cells[0].Value.ToString());
                nv_delete.MaTK = int.Parse(row.Cells[1].Value.ToString());
                int result = nv_bll.Delete(nv_delete);
                if (result > 0)
                {
                    ShowMessage("Xóa nhân viên thành công!");
                    dgvEmployees_Load();
                }
                else
                {
                    ShowError("Xóa nhân viên thất bại!");
                }
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvEmployees.CurrentRow;
            string question = String.Format("Bạn có chắc chắn muốn đặt lại mật khẩu cho tài khoản của nhân viên {0} - {1} {2} không?",
                row.Cells[0].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString());
            DialogResult r = MessageBox.Show(question, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                TaiKhoan tk = new TaiKhoan();
                tk.MaTK = int.Parse(row.Cells[1].Value.ToString());
                int result = tk_bll.ResetPassword(tk);
                if (result > 0)
                {
                    ShowMessage("Đặt lại mật khẩu thành công!");
                }
                else
                {
                    ShowError("Đặt lại mật khẩu thất bại!");
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
            txtLastName.ReadOnly = txtFirstName.ReadOnly = txtPhone.ReadOnly = txtAddress.ReadOnly = false;
            dtpBirthday.Enabled = cboGender.Enabled = cboType.Enabled = dtpStartDate.Enabled = true;
        }

        private void DisableInput()
        {
            txtLastName.ReadOnly = txtFirstName.ReadOnly = txtPhone.ReadOnly = txtAddress.ReadOnly = true;
            dtpBirthday.Enabled = cboGender.Enabled = cboType.Enabled = dtpStartDate.Enabled = false;
        }

        private void ResetInput()
        {
            txtID.Text = txtAccount.Text = "";
            txtLastName.Clear();
            txtFirstName.Clear();
            dtpBirthday.Value = DateTime.Now;
            cboGender.SelectedIndex = 0;
            txtPhone.Clear();
            txtAddress.Clear();
            cboType.SelectedIndex = 0;
            dtpStartDate.Value = DateTime.Now;
        }
    }
}

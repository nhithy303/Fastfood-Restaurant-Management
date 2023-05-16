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
    public partial class frmProfile : Form
    {
        NhanVien nv;
        NhanVienBLL nv_bll = new NhanVienBLL();
        PhanLoaiNVBLL plnv_bll = new PhanLoaiNVBLL();
        TaiKhoanBLL tk_bll = new TaiKhoanBLL();

        public frmProfile(NhanVien nv)
        {
            InitializeComponent();
            this.nv = nv;
            this.Load += frmProfile_Load;
            btnUpdate.Click += btnUpdate_Click;
            btnSave.Click += btnSave_Click;
            btnChangePassword.Click += btnChangePassword_Click;
        }

        private void frmProfile_Load(object sender, EventArgs e)
        {
            cboGender_Load();
            cboType_Load();
            tblInfo_Load();
            DisableInput();
            btnSave.Enabled = false;
        }

        private void tblInfo_Load()
        {
            if (nv != null)
            {
                txtID.Text = nv.MaNV.ToString();
                txtAccount.Text = nv.MaTK.ToString();
                txtLastName.Text = nv.HoNV;
                txtFirstName.Text = nv.TenNV;
                dtpBirthday.Value = DateTime.Parse(ReverseDateFormat(nv.NgaySinh));
                cboGender.SelectedValue = nv.GioiTinh;
                txtPhone.Text = nv.Sdt;
                txtAddress.Text = nv.DiaChi;
                cboType.SelectedValue = nv.MaLoai;
                dtpStartDate.Value = DateTime.Parse(ReverseDateFormat(nv.NgayVaoLam));
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Text == "Sửa")
            {
                btnUpdate.Text = "Hủy";
                btnSave.Enabled = true;
                EnableInput();
            }
            else // btnUpdate.Text == "Hủy"
            {
                btnUpdate.Text = "Sửa";
                btnSave.Enabled = false;
                DisableInput();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            NhanVien nv_update = nv;
            nv_update.HoNV = txtLastName.Text;
            nv_update.TenNV = txtFirstName.Text;
            nv_update.NgaySinh = DateTime.Parse(dtpBirthday.Value.ToString()).ToString("yyyy-MM-dd");
            nv_update.GioiTinh = int.Parse(cboGender.SelectedValue.ToString());
            nv_update.Sdt = txtPhone.Text;
            nv_update.DiaChi = txtAddress.Text;
            nv_update.NgayVaoLam = DateTime.Parse(dtpStartDate.Value.ToString()).ToString("yyyy-MM-dd");

            int result = nv_bll.Update(nv_update);
            if (result > 0)
            {
                ShowMessage("Sửa thông tin cá nhân thành công!");
                btnUpdate.Text = "Sửa";
                btnSave.Enabled = false;
                DisableInput();
            }
            else if (result == -2)
            {
                ShowError("Thông tin không hợp lệ!");
            }
            else
            {
                ShowError("Sửa thông tin cá nhân thất bại!");
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = new TaiKhoan();
            tk.MaTK = nv.MaTK;
            tk.MatKhau = txtCurrentPW.Text;
            int result = tk_bll.Update(tk, txtNewPW.Text, txtRetypePW.Text);
            if (result > 0)
            {
                ShowMessage("Đổi mật khẩu thành công!");
                txtCurrentPW.Clear();
                txtNewPW.Clear();
                txtRetypePW.Clear();
            }
            else if (result == -2)
            {
                ShowError("Mật khẩu mới không trùng khớp!");
            }
            else if (result == -3)
            {
                ShowError("Mật khẩu hiện tại không chính xác!");
            }
            else
            {
                ShowError("Đổi mật khẩu thất bại!");
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
            dtpBirthday.Enabled = cboGender.Enabled = true;
        }

        private void DisableInput()
        {
            txtLastName.ReadOnly = txtFirstName.ReadOnly = txtPhone.ReadOnly = txtAddress.ReadOnly = true;
            dtpBirthday.Enabled = cboGender.Enabled = false;
        }
    }
}

using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI
{
    public partial class frmMenuManagement : Form
    {
        ThucDonBLL td_bll = new ThucDonBLL();
        PhanLoaiTDBLL pltd_bll = new PhanLoaiTDBLL();

        public frmMenuManagement()
        {
            InitializeComponent();
            this.Load += frmMenuManagement_Load;
            dgvMenu.SelectionChanged += dgvMenu_SelectionChanged;            
            btnCreate.Click += btnCreate_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnSave.Click += btnSave_Click;
            btnDelete.Click += btnDelete_Click;
            btnRecipe.Click += btnRecipe_Click;
            btnUpload.Click += btnUpload_Click;
            btnPreview.Click += btnPreview_Click;
        }

        private void frmMenuManagement_Load(object sender, EventArgs e)
        {
            cboCategory_Load();
            dgvMenu_Load();
            DisableInput();
            btnRecipe.Enabled = btnDelete.Enabled = false;
        }

        private void dgvMenu_Load()
        {
            dgvMenu.DataSource = td_bll.GetList(new ThucDon());
            dgvMenu.Font = new Font("Times New Roman", 13F);
        }

        private void dgvMenu_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMenu.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvMenu.CurrentRow;
                txtID.Text = row.Cells[0].Value.ToString();
                cboCategory.SelectedValue = int.Parse(row.Cells[1].Value.ToString());
                txtName.Text = row.Cells[2].Value.ToString();
                picDish.Image = new Bitmap(row.Cells[3].Value.ToString());
                txtOriginalPrice.Text = row.Cells[4].Value.ToString();
                txtSellingPrice.Text = row.Cells[5].Value.ToString();

                btnUpdate.Enabled = btnDelete.Enabled = btnRecipe.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = btnDelete.Enabled = btnRecipe.Enabled = false;
            }
        }

        private void cboCategory_Load()
        {
            PhanLoaiTD[] pltd = pltd_bll.GetList(new PhanLoaiTD());
            cboCategory.DisplayMember = "TenLoai";
            cboCategory.ValueMember = "MaLoai";
            cboCategory.DataSource = pltd;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (btnCreate.Text == "Thêm")
            {
                btnCreate.Text = "Hủy";
                btnSave.Enabled = true;
                btnUpdate.Enabled = btnDelete.Enabled = btnRecipe.Enabled = dgvMenu.Enabled = false;
                EnableInput();
            }
            else // btnCreate.Text == "Hủy"
            {
                btnCreate.Text = "Thêm";
                btnSave.Enabled = false;
                btnUpdate.Enabled = btnDelete.Enabled = btnRecipe.Enabled = dgvMenu.Enabled = true;
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
                btnCreate.Enabled = btnDelete.Enabled = btnRecipe.Enabled = dgvMenu.Enabled = false;
                EnableInput();
                txtSellingPrice.ReadOnly = false;
            }
            else // btnUpdate.Text == "Hủy"
            {
                btnUpdate.Text = "Sửa";
                btnSave.Enabled = false;
                btnCreate.Enabled = btnDelete.Enabled = btnRecipe.Enabled = dgvMenu.Enabled = true;
                DisableInput();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ThucDon td = new ThucDon();
            if (txtID.Text != "") // Update only
            {
                td.MaMon = int.Parse(txtID.Text);
                td.GiaGoc = int.Parse(txtOriginalPrice.Text);
                td.GiaBan = int.Parse(txtSellingPrice.Text);
            }
            td.MaLoai = int.Parse(cboCategory.SelectedValue.ToString());
            td.TenMon = txtName.Text;
            //
            td.AnhMon = txtImagePath.Text;
            //

            int result = 0;
            string action = "";
            if (btnCreate.Enabled)
            {
                action = "Thêm mới";
                result = td_bll.Create(td);
            }
            else if (btnUpdate.Enabled)
            {
                action = "Sửa thông tin";
                result = td_bll.Update(td);
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
                ShowMessage(String.Format("{0} thực đơn thành công!", action));
                DisableInput();
                dgvMenu_Load();
            }
            else if (result == -2)
            {
                ShowError("Thông tin không hợp lệ!");
            }
            else
            {
                ShowError(String.Format("{0} thực đơn thất bại!", action));
            }
            dgvMenu.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvMenu.CurrentRow;
            string question = String.Format("Bạn có chắc chắn muốn xóa món \"{0}\" khỏi thực đơn không?",
                row.Cells[2].Value.ToString());
            DialogResult r = MessageBox.Show(question, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                ThucDon td_delete = new ThucDon();
                td_delete.MaMon = int.Parse(row.Cells[0].Value.ToString());
                int result = td_bll.Delete(td_delete);
                if (result > 0)
                {
                    ShowMessage("Xóa thực đơn thành công!");
                    dgvMenu_Load();
                }
                else
                {
                    ShowError("Xóa thực đơn thất bại!");
                }
            }
        }

        private void btnRecipe_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvMenu.CurrentRow;
            ThucDon td = new ThucDon();
            td.MaMon = int.Parse(row.Cells[0].Value.ToString());
            td.TenMon = row.Cells[2].Value.ToString();
            
            new frmMenuRecipe(td).ShowDialog();
            dgvMenu_Load();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog upload = new OpenFileDialog();
            upload.Title = "Open";
            upload.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";
            if (upload.ShowDialog() == DialogResult.OK)
            {
                txtImagePath.Text = upload.FileName;
                picDish.Image = new Bitmap(txtImagePath.Text);
                picDish.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            new frmMenuPreview().ShowDialog();
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
            cboCategory.Enabled = btnUpload.Enabled = btnSave.Enabled = true;
            if (txtOriginalPrice.Text != String.Empty && txtOriginalPrice.Text != "0")
            {
                txtSellingPrice.ReadOnly = false;
            }
        }

        private void DisableInput()
        {
            txtName.ReadOnly = txtSellingPrice.ReadOnly = true;
            cboCategory.Enabled = btnUpload.Enabled = btnSave.Enabled = false;
        }

        private void ResetInput()
        {
            txtID.Text = txtName.Text = txtOriginalPrice.Text = txtSellingPrice.Text = "";
            cboCategory.SelectedIndex = 0;
            picDish.Image = null;
        }
    }
}

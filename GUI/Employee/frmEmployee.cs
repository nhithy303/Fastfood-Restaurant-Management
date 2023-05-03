using BLL;
using DTO;
using GUI.Employee;
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
    public partial class frmEmployee : Form
    {
        TaiKhoan tk;
        NhanVien nv;
        NhanVienBLL nv_bll = new NhanVienBLL();

        public frmEmployee(TaiKhoan tk)
        {
            InitializeComponent();
            this.tk = tk;
            this.Load += frmEmployee_Load;
            btnProfile.Click += btnProfile_Click;
            btnSale.Click += btnSale_Click;
            btnOrder.Click += btnOrder_Click;
            btnLogOut.Click += btnLogOut_Click;
            picClose.Click += picClose_Click;
            this.FormClosing += frmAdmin_FormClosing;
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            NhanVien nv_condition = new NhanVien();
            nv_condition.MaTK = tk.MaTK;
            nv = nv_bll.GetList(nv_condition)[0];
            lblEmployeeName.Text = String.Format("[{0}] - {1} {2}", nv.MaNV, nv.HoNV, nv.TenNV);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            new frmProfile(nv).ShowDialog();
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            new frmSale(nv).ShowDialog();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            new frmOrderManagement(nv).ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Đăng xuất",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.Cancel = (result == DialogResult.No);
        }
    }
}

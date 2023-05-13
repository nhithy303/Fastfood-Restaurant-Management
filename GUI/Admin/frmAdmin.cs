using BLL;
using DTO;
using GUI.Admin;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace GUI
{
    public partial class frmAdmin : Form
    {
        TaiKhoan tk;
        QuanLy ql;
        QuanLyBLL ql_bll = new QuanLyBLL();
        public frmAdmin(TaiKhoan tk)
        {
            InitializeComponent();
            this.tk = tk;
            this.Load += frmAdmin_Load;
            btnEmployees.Click += btnEmployees_Click;
            btnImport.Click += btnImport_Click;
            btnStorage.Click += btnStorage_Click;
            btnSales.Click += btnSales_Click;
            btnMenu.Click += btnMenu_Click;
            btnSettings.Click += btnSettings_Click;
            btnLogOut.Click += btnLogOut_Click;
            picClose.Click += picClose_Click;
            this.FormClosing += frmAdmin_FormClosing;
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            QuanLy ql_condition = new QuanLy();
            ql_condition.MaTK = tk.MaTK;
            ql = ql_bll.GetList(ql_condition)[0];
            lblAdminName.Text = String.Format("{0} {1}", ql.HoQL, ql.TenQL);
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            new frmEmployeesManagement().ShowDialog();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            
        }

        private void btnStorage_Click(object sender, EventArgs e)
        {
            new frmStorageManagement().ShowDialog();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            new frmSalesManagement().ShowDialog();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            new frmMenuManagement().ShowDialog();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            new frmSettings().ShowDialog();
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

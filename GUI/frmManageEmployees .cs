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
    public partial class frmManageEmployees : Form
    {
        NhanVienBLL nv_bll = new NhanVienBLL();
        public frmManageEmployees()
        {
            InitializeComponent();
        }

        private void frmManageEmployees_Load(object sender, EventArgs e)
        {
            //dgvEmployees.AutoGenerateColumns = false;
            dgvEmployees.DataSource = nv_bll.GetList();
            dgvEmployees.Columns[0].HeaderText = "Mã NV";
            dgvEmployees.Columns[1].HeaderText = "Tài khoản";
            dgvEmployees.Columns[2].HeaderText = "Họ";
            dgvEmployees.Columns[3].HeaderText = "Tên";
            dgvEmployees.Columns[4].HeaderText = "Ngày sinh";
            dgvEmployees.Columns[5].HeaderText = "Giới tính";
            dgvEmployees.Columns[6].HeaderText = "Sđt";
            dgvEmployees.Columns[7].HeaderText = "Địa chỉ";
            dgvEmployees.Columns[8].HeaderText = "Loại NV";
            dgvEmployees.Columns[9].HeaderText = "Ngày vào làm";
        }
    }
}

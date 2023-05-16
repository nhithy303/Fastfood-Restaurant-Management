using BLL;
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
    public partial class frmConfigDatabase : Form
    {
        ConfigDatabaseBLL configdb_bll = new ConfigDatabaseBLL();
        public frmConfigDatabase()
        {
            InitializeComponent();
            btnConnect.Click += btnConnect_Click;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            int result = configdb_bll.ConfigDatabase(txtServer.Text, txtDatabase.Text);
            if (result == 2)
            {
                ShowError("Tên SQL Server còn trống!");
            }
            else if (result == 3)
            {
                ShowError("Tên Database còn trống!");
            }
            else if (result == 0)
            {
                ShowError("Kết nối cơ sở dữ liệu thất bại!");
            }
            else
            {
                MessageBox.Show("Kết nối cơ sở dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                new frmWelcome().Show();
            }
        }

        private void ShowError(string error)
        {
            MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

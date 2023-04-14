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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void ptb_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ptb_login_Click(object sender, EventArgs e)
        {
            Login mhc = new Login();
            mhc.Show();
            this.Hide();
        }

        private void lbl_login_Click(object sender, EventArgs e)
        {
            Login mhc = new Login();
            mhc.Show();
            this.Hide();
        }
    }
}

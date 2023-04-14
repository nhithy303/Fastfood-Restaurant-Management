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
    public partial class OrderSidedish : Form
    {
        public OrderSidedish()
        {
            InitializeComponent();
        }

        private void ptb_close_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}

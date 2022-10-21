using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zomato
{
    public partial class frm_front : Form
    {
        public frm_front()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form item = new frm_item();
            item.Show();
            this.Hide();
        }

        private void btn_Order_Click(object sender, EventArgs e)
        {
            Form item = new frm_item();
            item.Show();
            this.Hide();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm once you want to exit",
                "Online Food Ordering System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(iExit == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}

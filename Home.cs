using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maghaze_shokofe
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnitems_Click(object sender, EventArgs e)
        {
            Items items = new Items();
            items.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            Costumer costumer = new Costumer();
            costumer.Show();
        }
    }
}

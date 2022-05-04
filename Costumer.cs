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
    public partial class Costumer : Form
    {
        public Costumer()
        {
            InitializeComponent();
        }

        private void AddoneCostumer_Click(object sender, EventArgs e)
        {
            AddoneCostumer addonecustomer= new AddoneCostumer();
            addonecustomer.Show();
        }

        private void btnListCustomer_Click(object sender, EventArgs e)
        {
            listCustomer listCustomer = new listCustomer();
            listCustomer.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditorDelCustromer editorDelCustromer = new EditorDelCustromer();
            editorDelCustromer.Show();
        }
    }
}

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
    public partial class EditorDelCustromer : Form
    {
        shokofeEntities shokofe = new shokofeEntities();
        public EditorDelCustromer()
        {
            InitializeComponent();
        }
         private Customer nmcd()
        {
            Customer customer = null;
            if (txtCustomerName.Text != "")
            {
                string current = txtCustomerName.Text;
                customer = shokofe.Customer.Where(c => c.CustomerName == current).FirstOrDefault();
                return customer;
            }
            else if (txtCustomerCode.Text != "")
            {
                int current = Convert.ToInt32(txtCustomerCode.Text);
                customer = shokofe.Customer.Where(c => c.CustomerCode == current).FirstOrDefault();
                return customer;
            }
            else
            {
                MessageBox.Show("هیچ مقداری یافت نشد", "اخطار", MessageBoxButtons.OK);
                return customer;
            }

        }


        private void btndel_Click(object sender, EventArgs e)
        {
            Customer customer = nmcd();
            if (customer != null)
            {
                shokofe.Customer.Remove(customer);
                shokofe.SaveChanges();
                MessageBox.Show("عملیات(حذف) با موفقیت انجام شد", "توجه");

            }
            else
            {
                MessageBox.Show("مقداری یافت نشد", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Customer customer = nmcd();

            if (customer != null)
            {
                EditoneCustomer editone = new EditoneCustomer(customer.ID);
                editone.ShowDialog();
            }
            else
            {
                MessageBox.Show("مقداری یافت نشد", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtCustomerCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditorDelCustromer_Load(object sender, EventArgs e)
        {
            

            
        }
    }
}

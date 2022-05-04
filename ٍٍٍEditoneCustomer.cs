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
    public partial class EditoneCustomer : Form
    {
        shokofeEntities shokofe = new shokofeEntities();
        int ID;
        public EditoneCustomer(int ID)
        {
            this.ID = ID;
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Customer customer = shokofe.Customer.First(c => c.ID == ID);
            customer.CustomerCode = Convert.ToInt32(txtCostumerCode.Text);
            customer.CustomerName = txtCostumerName.Text;
            customer.CustomerAddress = txtAddress.Text;

            try
            {
                customer.CustomerMobile = Convert.ToInt32(txtCostumerMobile.Text);            
            }
            catch (Exception)
            {
                customer.CustomerMobile = 0;
            }

            try
            {
                shokofe.SaveChanges();
                MessageBox.Show("اطلاعات با موفقیت ذخیره شد", "توجه");

            }
            catch (Exception)
            {
                MessageBox.Show("اطلاعات وارد شده قابل ثبت نمی باشد", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void EditoneCustomer_Load(object sender, EventArgs e)
        {
            Customer customer = shokofe.Customer.First(c => c.ID == ID);
            txtCostumerCode.Text = customer.CustomerCode.ToString();
            txtCostumerMobile.Text = customer.CustomerMobile.ToString();
            txtCostumerName.Text = customer.CustomerName;
            txtAddress.Text = customer.CustomerAddress;


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

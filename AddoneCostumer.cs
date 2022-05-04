using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maghaze_shokofe
{
    public partial class AddoneCostumer : Form
    {
        
        public AddoneCostumer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            
            shokofeEntities shokofe = new shokofeEntities();//make a nemone at data base
            Customer customer = new Customer();// make nemone at table Item
            
                try
                {
                    customer.CustomerCode = Convert.ToInt32(txtCostumerCode.Text);// add text texbox to data base
                    customer.CustomerName = txtCostumerName.Text;// add text texbox to data base
                    customer.CustomerMobile = Convert.ToInt32(txtCostumerMobile.Text);// add text texbox to data base
                    try
                    {
                        customer.CustomerNumber = Convert.ToInt32(txtCostumerNumber.Text);// add text texbox to data base
                    }
                    catch (Exception)
                    {

                        customer.CustomerMobile = 0;
                    }
                    customer.CustomerAddress = txtAddress.Text;// add text texbox to data base
                    shokofe.Customer.Add(customer);
                    shokofe.SaveChanges();
                    MessageBox.Show("اطلاعات با موفقیت ثبت شد", "توجه");

                }
                catch (Exception)
                {
                    MessageBox.Show("اطلاعات وارد شده صحیح نمی باشد", "اخطار");
                }
            


        }
    }
}

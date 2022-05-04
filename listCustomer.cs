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
    public partial class listCustomer : Form
    {
        shokofeEntities shokofe = new shokofeEntities();

        public listCustomer()
        {
            InitializeComponent();
        }
        ///*S*/qlConnection con = new SqlConnection(Connection.ConnectionString);

        private void listCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shokofeDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.shokofeDataSet.Customer);


        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                txtCode.Text = dataGridView1.CurrentRow.Cells["customerCodeDataGridViewTextBoxColumn"].Value.ToString();//مقدار ستون کد رو از ردیفی که انتخاب کرده می ریزیم تو تکس باکس مربوطه
                txtName.Text = dataGridView1.CurrentRow.Cells["customerNameDataGridViewTextBoxColumn"].Value.ToString();//مقدار ستون نام محصول رو از ردیفی که انتخاب کرده می ریزیم تو تکس باکس مربوطه
                txtAddress.Text = dataGridView1.CurrentRow.Cells["customerAddressDataGridviewTextBoxColumn"].Value.ToString();//مقدار ستون تخفیف رو از ردیفی که انتخاب کرده می ریزیم تو تکس باکس مربوطه
                txtMobile.Text = dataGridView1.CurrentRow.Cells["customerMobileDataGridviewTextBoxColumn"].Value.ToString();//مقدار ستون قیمت رو از ردیفی که انتخاب کرده می ریزیم تو تکس باکس مربوطه
                txtNumber.Text = dataGridView1.CurrentRow.Cells["customerNumberDataGridviewTextBoxColumn"].Value.ToString();//مقدار ستون قیمت رو از ردیفی که انتخاب کرده می ریزیم تو تکس باکس مربوطه

            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int current = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());// اید ان ردیف انتخاب شده را میریزد داخل current
            Customer tu = shokofe.Customer.First(c => c.ID == current);// اگر id برابر بود با current  میریزیم داخل  tu
            shokofe.Customer.Remove(tu);
            shokofe.SaveChanges();
            this.customerTableAdapter.Fill(this.shokofeDataSet.Customer);

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {


            // TODO: This line of code loads data into the 'shokofeDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.shokofeDataSet.Customer);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int current = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());// اید ان ردیف انتخاب شده را میریزد داخل current
            Customer customer = shokofe.Customer.First(c => c.ID == current);
            customer.CustomerAddress = txtAddress.Text;
            customer.CustomerCode = Convert.ToInt32(txtCode.Text);
            customer.CustomerMobile = Convert.ToInt32(txtMobile.Text);
            customer.CustomerName = txtName.Text;
            customer.CustomerNumber = Convert.ToInt32(txtNumber.Text);

            shokofe.SaveChanges();

            MessageBox.Show("ویرایش با موفقیت انجام شد", "توجه", MessageBoxButtons.OK);
        }
    }
}

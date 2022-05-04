using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace maghaze_shokofe
{
    public partial class EditOneItem : Form
    {
        //SqlConnection cnn = new SqlConnection(Connection.ConnectionString);
        int ID;
        shokofeEntities shokofe = new shokofeEntities();


        public EditOneItem(int ID)
        {
            
            this.ID =ID;
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            Item item = shokofe.Item.Where(c => c.ID == ID).First();

            item.ItemCode = Convert.ToInt32(txtCode.Text);
            item.ItemName = txtName.Text;
            item.Price = Convert.ToInt32(txtPrice.Text);
            item.Dicount = Convert.ToInt32(txtDiscount.Text);




            try
            {
                shokofe.SaveChanges();
                MessageBox.Show("اطلاعات با موفقیت ثبت شد", "توجه", MessageBoxButtons.OK, MessageBoxIcon.None);

            }
            catch (Exception)
            {

                MessageBox.Show("اطلاعات وارد شده قابل ثبت نمی باشد", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditOneItem_Load(object sender, EventArgs e)
        {
            Item item = shokofe.Item.Where(c => c.ID == ID).First();


            txtCode.Text = item.ItemCode.ToString();
            txtCount.Text = item.Count.ToString();
            txtName.Text = item.ItemName;
            txtPrice.Text = item.Price.ToString();
            txtDiscount.Text = item.Dicount.ToString();

        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

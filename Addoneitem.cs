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
    public partial class Addoneitem : Form
    {
        public Addoneitem()
        {
            InitializeComponent();
        }

        public void btnYes_Click(object sender, EventArgs e)
        {
            bool currentinput = true;

            List<Label> listlbl = new List<Label>();

            listlbl.Add(lblThisfildcode);
            listlbl.Add(lblThisfildcount);
            listlbl.Add(lblThisfildname);
            listlbl.Add(lblThisfildprice);
            
            
            List<string> vs = new List<string>();
            vs.Add(txtCode.Text);
            vs.Add(txtCount.Text);
            vs.Add(txtName.Text);
            vs.Add(txtPrice.Text);
            for (int i = 0; i < vs.Count; i++)
            {
                if (vs[i] == "")
                {
                    listlbl[i].ForeColor = Color.Red;
                    currentinput = false;
                }
            }
            shokofeEntities shokofe = new shokofeEntities();//make a nemone at data base
            Item item = new Item();// make nemone at table Item
            if (currentinput)
            {
                try
                {
                    item.ItemCode = Convert.ToInt32(txtCode.Text);// add text texbox to data base
                    item.ItemName = txtName.Text;// add text texbox to data base
                    item.Price = Convert.ToInt32(txtPrice.Text);// add text texbox to data base
                    try
                    {
                        item.Dicount = Convert.ToInt32(txtDiscount.Text);// add text texbox to data base
                    }
                    catch (Exception)
                    {

                        item.Dicount = 0;
                    }
                    item.Count = Convert.ToInt32(txtCount.Text);// add text texbox to data base
                    shokofe.Item.Add(item);
                    shokofe.SaveChanges();
                    MessageBox.Show("اطلاعات با موفقیت ثبت شد", "توجه");

                }
                catch (Exception)
                {
                    MessageBox.Show("اطلاعات وارد شده صحیح نمی باشد", "اخطار");
                }
            }


        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Close();//close this windo
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            lblThisfildcode.ForeColor = Color.Black;
        }

        private void txtCount_TextChanged(object sender, EventArgs e)
        {
            lblThisfildcount.ForeColor = Color.Black;

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            lblThisfildprice.ForeColor = Color.Black;

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            lblThisfildname.ForeColor = Color.Black;
        }
    }
}

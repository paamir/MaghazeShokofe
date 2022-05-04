using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maghaze_shokofe
{
    public partial class addordellItem : Form
    {
        //SqlConnection cnn = new SqlConnection(Connection.ConnectionString);

        public void loadData()

        {
            Item item = new Item();
            //cnn.Open();

            //AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();

            //string querry = @"Select distinct [ItemName] from [Item]";

            //SqlCommand cmd = new SqlCommand(querry, cnn);

            //SqlDataReader dr = cmd.ExecuteReader();

            //if (dr.HasRows == true)

            //{

            //    while (dr.Read())

            //        namesCollection.Add(dr["ItemName"].ToString());



            //}



            //dr.Close();

            //cnn.Close();



            //txtItemName.AutoCompleteMode = AutoCompleteMode.Append;

            //txtItemName.AutoCompleteSource = AutoCompleteSource.CustomSource;

            //txtItemName.AutoCompleteCustomSource = namesCollection;

        }
        public addordellItem()
        {
            InitializeComponent();
        }
        shokofeEntities shokofe = new shokofeEntities();
        public Item nmcd()
        {
            Item item = null;
            if (txtItemName.Text != "")
            {
                string current = txtItemName.Text;
                item = shokofe.Item.Where(c => c.ItemName == current).FirstOrDefault();
                return item;
            }
            else if (txtItemCode.Text != "")
            {
                int current = Convert.ToInt32(txtItemCode.Text);
                item = shokofe.Item.Where(c => c.ItemCode == current).FirstOrDefault();
                return item;
            }
            else
            {
                MessageBox.Show("هیچ مقداری یافت نشد", "اخطار", MessageBoxButtons.OK);
                return item;
            }

        }


        private void btndel_Click(object sender, EventArgs e)
        {
            Item item = nmcd();

            if (item != null)
            {
                shokofe.Item.Remove(item);
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
            Item item = nmcd();

            if (item != null)
            {
                EditOneItem editOneItem = new EditOneItem(item.ID);
                editOneItem.ShowDialog();
            }
            else
            {
                MessageBox.Show("مقداری یافت نشد", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }







            //SqlConnection cnn = new SqlConnection(Connection.ConnectionString);
            //cnn.Open();
            //SqlCommand cmd = new SqlCommand();
            //cmd.Connection = cnn;
            //cmd.CommandType = System.Data.CommandType.Text;
            //cmd.CommandText = "select ID, ItemCode, ItemName from Item";

            //SqlDataAdapter dtap = new SqlDataAdapter();
            //dtap.SelectCommand = cmd;


            //DataTable dt = new DataTable();
            //dtap.Fill(dt);

            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    if (namercode.Text == dt.Rows[i][nmercd].ToString())
            //    {
            //        ID = Convert.ToInt32(dt.Rows[i]["ID"].ToString());
            //        ifor = i;
            //    }
            //}
            //List<string> vs = new List<string>();
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    vs.Add(dt.Rows[i]["ID"].ToString());
            //}

            //bool a = false;
            //string x;
            //for (int i = 0; i < vs.Count; i++)
            //{
            //    if (vs[i] == ID.ToString())
            //    {
            //        a = true;
            //    }
            //}
            //if (a)
            //{
            //    EditOneItem editOneItem = new EditOneItem(ID, ifor);
            //    editOneItem.Show();
            //    cnn.Close();
            //}
            //else
            //{
            //    if (nmercd == "ItemCode")
            //    {
            //        x = "کد";
            //    }
            //    else
            //    {
            //        x = "نام محصول";
            //    }
            //    String s = String.Format("{0} وارد شده صحیح نمی باشد", x);
            //    MessageBox.Show(s,"اخطار");

            //}

        }

        private void txtItemCode_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void txtItemName_TextChanged(object sender, EventArgs e)
        {
            loadData();
        }
    }
}

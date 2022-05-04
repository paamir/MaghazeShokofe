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
    public partial class Itemscounnt : Form
    {
        public Itemscounnt()
        {
            InitializeComponent();
        }
        shokofeEntities shokofe = new shokofeEntities();


        private void Itemscounnt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shokofeDataSet.Item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.shokofeDataSet.Item);

        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                txtCode.Text = dataGridView1.CurrentRow.Cells["itemCodeDataGridViewTextBoxColumn"].Value.ToString();//مقدار ستون کد رو از ردیفی که انتخاب کرده می ریزیم تو تکس باکس مربوطه
                txtName.Text = dataGridView1.CurrentRow.Cells["itemNameDataGridViewTextBoxColumn"].Value.ToString();//مقدار ستون نام محصول رو از ردیفی که انتخاب کرده می ریزیم تو تکس باکس مربوطه
                txtDiscount.Text = dataGridView1.CurrentRow.Cells["DicountDataGridviewTextBoxColumn"].Value.ToString();//مقدار ستون تخفیف رو از ردیفی که انتخاب کرده می ریزیم تو تکس باکس مربوطه
                txtPrice.Text = dataGridView1.CurrentRow.Cells["PriceDataGridviewTextBoxColumn"].Value.ToString();//مقدار ستون قیمت رو از ردیفی که انتخاب کرده می ریزیم تو تکس باکس مربوطه
                txtItemCount.Text = dataGridView1.CurrentRow.Cells["countDataGridViewTextBoxColumn"].Value.ToString();
            }
            
            
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

            int current = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());// اید ان ردیف انتخاب شده را میریزد داخل current
            Item tu = shokofe.Item.First(c => c.ID == current);
            shokofe.Item.Remove(tu);
            shokofe.SaveChanges();

            this.itemTableAdapter.Fill(this.shokofeDataSet.Item);//refresh data gridview

        }

        private void btnEdit_Click(object sender, EventArgs e)
        { 

            int current = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());// اید ان ردیف انتخاب شده را میریزد داخل current
            Item item = shokofe.Item.First(c => c.ID == current);
            item.ItemCode = Convert.ToInt32(txtCode.Text);
            item.ItemName = txtName.Text;
            item.Price = Convert.ToInt32(txtPrice.Text);
            item.Count = Convert.ToInt32(txtItemCount.Text);
            item.Dicount = Convert.ToInt32(txtDiscount.Text);
            
            shokofe.SaveChanges();


            this.itemTableAdapter.Fill(this.shokofeDataSet.Item);

        }

        private void RefreshGridView(object sender, EventArgs e)
        {
            //refresh the datagridview == set agayn datagridview
            this.itemTableAdapter.Fill(this.shokofeDataSet.Item);

        }
    }
}

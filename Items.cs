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
    public partial class Items : Form
    {
        public Items()
        {
            InitializeComponent();
        }

        private void btnAdditem_Click(object sender, EventArgs e)
        {
            Addoneitem addoneitem = new Addoneitem();// make a nemone at windos form Addoneitem

            addoneitem.Show();
            //addoneitem.ShowDialog();
        }

        private void Itemcount_Click(object sender, EventArgs e)
        {
            Itemscounnt itemscounnt = new Itemscounnt();
            itemscounnt.Show();
            //itemscounnt.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addordellItem addordellItem = new addordellItem();
            addordellItem.Show();

            
        }
    }
}

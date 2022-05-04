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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //shokofeEntities shokofe = new shokofeEntities();

            //usrpssw current = shokofe.usrpssw.FirstOrDefault(c => c.username == txtUsrname.Text);


            //if (current != null && current.password == txtPassword.Text)
            //{

            //    this.Hide();
            Home home = new Home();
            home.ShowDialog();
            //}
            //else
            //{
            //    MessageBox.Show("نام کاربری یا رمز عبور صحیح نمی باشد", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}

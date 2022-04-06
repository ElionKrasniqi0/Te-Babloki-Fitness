using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GmS5
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tctUserName.Text == "admin" && txtPassword.Text == "babloki")
            {
                Form1 fm = new Form1();
                fm.Show();
                this.Hide();

            } 
            else
            {
                MessageBox.Show("Incorrect used ID or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

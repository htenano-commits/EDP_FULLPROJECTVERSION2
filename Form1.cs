using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HerkLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[,] userCredentials =
    {
            {"admin","cashier"},
            {"admin","password"},
            {"Jerome Austria", "Juan Dela Cruz"},
            {"Admin Department","St" }
        };


        private void button1_Click(object sender, EventArgs e)
        {

            if (tbUsername.Text == "")
            {
                MessageBox.Show("Please enter username.", "Username required");
                tbUsername.Focus();
            }
            else if (tbPassword.Text == "")
            {
                MessageBox.Show("Please enter a password", "Password required");
                tbPassword.Focus();
            }
            else
                for (int x = 0; x < userCredentials.Length; x++)
                {
                    if (userCredentials[0, x] == tbUsername.Text)
                    {
                        if (userCredentials[1, x] == tbPassword.Text)
                        {
                            MessageBox.Show("Welcome " + userCredentials[2, x] + " from " + userCredentials[3, x]);
                            frmHome frm = new frmHome();
                            this.Hide();
                            frm.Show();
                            break;
                        }


                    }
                }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
    }
}

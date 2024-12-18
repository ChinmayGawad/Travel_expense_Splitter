using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel_expense_Splitter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void bthLogin_Click_1(object sender, EventArgs e)
        {
            string username;
            string password;

            username = TBUser.Text;
            password = TBPass.Text;

            if (username == "Admin" && password == "Admin")
            {
                MessageBox.Show("Login Successful !!!!");
                Dashbord dash = new Dashbord();
                dash.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Invalid Username OR Password");
                TBUser.Text = "";
                TBPass.Text = "";
            }
        }
    }
}

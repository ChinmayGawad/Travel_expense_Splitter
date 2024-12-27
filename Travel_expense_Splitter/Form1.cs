using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Travel_expense_Splitter.Adapter;

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

            try
            {
                using (DatabaseHelper dbHelper = new DatabaseHelper())
                {
                    username = TBUser.Text;
                    password = TBPass.Text;



                    int userCount = DatabaseOperations.GetUserCount(username, password);

                    if (userCount > 0)
                        {
                           //  MessageBox.Show("Login successful!");
                            UserSession.LoggedInUsername = username;
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
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}");
                TBUser.Text = "";
                TBPass.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                TBUser.Text = "";
                TBPass.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel2.BackColor = System.Drawing.Color.FromArgb(120, 0, 0, 0);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 signup = new Form5();
            signup.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form5 signup = new Form5();
            signup.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form6 pass = new Form6();
            pass.Show();

        }
    }
}

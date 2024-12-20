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

namespace Travel_expense_Splitter
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form1 login= new Form1();
            login.Show();
            this.Close();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            string name = tbName.Text.Trim();
            string email= tbEmail.Text.Trim();
            string password= tbPassword.Text.Trim();
            string confirmpassword = tbConfirmPassword.Text.Trim();


            // Check for empty fields
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Name cannot be empty.");
                tbName.Focus(); // Set focus back to the name textbox
                return;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Email cannot be empty.");
                tbEmail.Focus(); // Set focus back to the email textbox
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Password cannot be empty.");
                tbPassword.Focus(); // Set focus back to the password textbox
                return;
            }

            if (string.IsNullOrWhiteSpace(confirmpassword))
            {
                MessageBox.Show("Please confirm your password.");
                tbConfirmPassword.Focus(); // Set focus back to the confirm password textbox
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.");
                tbEmail.Focus();
                return;
            }

            if (password != confirmpassword)
            {
                MessageBox.Show("Passwords do not match.");
                tbPassword.Focus();
                return;
            }

            string connectionString = "Server=CHINMAY-N3P5PKK\\SQLEXPRESS;Database=travel_expenses;Integrated Security=True;";

            using (SqlConnection conn =new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "insert into login_table (username,Email,pass) values (@name,@email,@password);";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue ("@Password", password);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show(" Sign Up Successfully!");
                            Form1 login = new Form1();
                            login.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Sign Up Failed Due to some reason please try again later !!!");
                        }
                    }

                }
                catch (Exception ex) {
                    MessageBox.Show("Error :" +ex.Message);
                }
            }


        }

        private bool IsValidEmail(string email)
        {
            // Simple regex for email validation
            var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return System.Text.RegularExpressions.Regex.IsMatch(email, emailPattern);
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

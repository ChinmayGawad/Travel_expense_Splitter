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
using System.Xml.Linq;
using Travel_expense_Splitter.Adapter;

namespace Travel_expense_Splitter
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private bool IsValidEmail(string email)
        {
            // Simple regex for email validation
            var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return System.Text.RegularExpressions.Regex.IsMatch(email, emailPattern);
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            string name = tbName.Text.Trim();
            string email = tbEmail.Text.Trim();
            string password = tbPassword.Text.Trim();
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

            try
            {
                using (DatabaseHelper dbHelper = new DatabaseHelper())
                {
                    string query = "INSERT INTO login_table (username, Email, pass) VALUES (@name, @email, @password);";
                    using (SqlCommand cmd = new SqlCommand(query, dbHelper.Connection))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@password", password);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Sign Up Successfully!");
                            Form1 login = new Form1();
                            login.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Sign Up Failed. Please try again later.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}


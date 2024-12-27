using System;
using System.Windows.Forms;

namespace Travel_expense_Splitter
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
           

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text.Trim();
            string newPassword = textBox3.Text.Trim();
            string confirmPassword = textBox2.Text.Trim();

            // Validate fields
            if (!ValidationHelper.IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.");
                textBox1.Focus();
                return;
            }

            if (!ValidationHelper.IsValidPassword(newPassword))
            {
                MessageBox.Show("Password cannot be empty.");
                textBox3.Focus();
                return;
            }

            if (!ValidationHelper.IsPasswordMatch(newPassword, confirmPassword))
            {
                MessageBox.Show("Passwords do not match.");
                textBox2.Focus();
                return;
            }

            try
            {
                int rowsAffected = DatabaseOperations.UpdatePassword(email, newPassword);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Password reset successfully!");
                    Form1 login = new Form1();
                    login.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Failed to reset password. Please try again later.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
    
        }
    }
}


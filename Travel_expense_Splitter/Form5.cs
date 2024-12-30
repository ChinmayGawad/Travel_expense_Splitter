using System;
using System.Windows.Forms;

namespace Travel_expense_Splitter
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }


        private void btnSignup_Click(object sender, EventArgs e)
        {
            string name = tbName.Text.Trim();
            string email = tbEmail.Text.Trim();
            string password = tbPassword.Text.Trim();
            string confirmpassword = tbConfirmPassword.Text.Trim();

            // Check for empty fields
            if (!ValidationHelper.IsValidName(name))
            {
                MessageBox.Show("Name cannot be empty.");
                tbName.Focus(); // Set focus back to the name textbox
                return;
            }

            if (!ValidationHelper.IsValidEmail(email))
            {
                MessageBox.Show("Email cannot be empty.");
                tbEmail.Focus(); // Set focus back to the email textbox
                return;
            }

            if (!ValidationHelper.IsValidPassword(password))
            {
                MessageBox.Show("Password cannot be empty.");
                tbPassword.Focus(); // Set focus back to the password textbox
                return;
            }

            if (!ValidationHelper.IsPasswordMatch(password,confirmpassword))
            {
                MessageBox.Show("Please confirm your password.");
                tbConfirmPassword.Focus(); // Set focus back to the confirm password textbox
                return;
            }


            try
            { 

                        int rowsAffected = DatabaseOperations.SignUpUser(name,email,password);
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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}


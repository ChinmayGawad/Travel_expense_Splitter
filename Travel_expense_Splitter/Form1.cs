using System;
using System.Data.SqlClient;
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

            

            string connectionString = "Server=CHINMAY-N3P5PKK\\SQLEXPRESS;Database=travel_expenses;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    //MessageBox.Show("Connection Successful !!!");

                    username = TBUser.Text;
                    password = TBPass.Text;

                    string query = "SELECT COUNT(*) FROM login_table WHERE username = @username AND pass = @password ";

                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        int userCount = Convert.ToInt32(command.ExecuteScalar());

                        if (userCount > 0)
                        {
                            MessageBox.Show("Login successful!");
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
                finally
                {
                    // Ensure the connection is closed
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
            this.Hide();    
        }
    }
}

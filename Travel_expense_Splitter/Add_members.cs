using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Travel_expense_Splitter
{
    public partial class Add_members : Form
    {
        public Add_members()
        {
            InitializeComponent();
        }

        private void btn_AddMembers_Click(object sender, EventArgs e)
        {
            string member_name = tbName.Text;
            string mem_email = tbEmail.Text;
            string mem_phone = tbPhone.Text;

            if (!int.TryParse(mem_phone, out int phoneNo))
            {
                MessageBox.Show("Please enter a valid phone number.");
                return; // Exit the method if conversion fails
            }

            try
            {
                int rowsAffected = DatabaseOperations.AddMember(member_name,mem_email,mem_phone);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Member added successfully!");
                    Dashbord dash = new Dashbord();
                    dash.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to add member.");
                }
            }

            catch (SqlException ex)
            {
                Console.WriteLine($"Database error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        private void phone_Click(object sender, EventArgs e)
        {

        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashbord dashboard = new Dashbord();
            dashboard.Show();
            this.Close();
        }

        private void Add_members_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Dashbord dashbord = new Dashbord();
            dashbord.Show();
            this.Hide();
        }
    }
}


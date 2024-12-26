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
using Travel_expense_Splitter.Adapter;

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
                using (DatabaseHelper dbHelper = new DatabaseHelper())
                {
                    string query = "INSERT INTO Members (Member_Name, Email_ID, Phone) VALUES (@member_name, @mem_email, @phoneNo)";

                    using (SqlCommand cmd = new SqlCommand(query, dbHelper.Connection))
                    {
                        cmd.Parameters.AddWithValue("@member_name", member_name);
                        cmd.Parameters.AddWithValue("@mem_email", mem_email);
                        cmd.Parameters.AddWithValue("@phoneNo", phoneNo);

                        int rowsAffected = cmd.ExecuteNonQuery();
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
            this.Hide();
        }
    }
}


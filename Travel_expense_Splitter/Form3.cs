using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Travel_expense_Splitter.Adapter;
                            
namespace Travel_expense_Splitter
{
    public partial class Form3 : Form
    {
        public List<ExpenseAdapter> _expenseList = new List<ExpenseAdapter>();
        public int loginId;

        public Form3()
        {
            InitializeComponent();
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100,0,0,0);
            //if (string.IsNullOrEmpty(UserSession.LoggedInUsername))
            //{
            //    MessageBox.Show("User is not logged in.");
            //    Dashbord dashbord = new Dashbord();
            //    dashbord.Show();
            //    this.Close();
            //    return;
            //}

            //// Retrieve the login ID based on the logged-in user
            //loginId = GetLoginId(UserSession.LoggedInUsername);
            //LoadMembers();
            //LoadCheckBoxes();
        }

        private int GetLoginId(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentException("Username cannot be null or empty", nameof(username));
            }

            using (DatabaseHelper dbHelper = new DatabaseHelper())
            {
                string query = "SELECT Login_ID FROM login_table WHERE Username = @username"; 
                using (SqlCommand cmd = new SqlCommand(query, dbHelper.Connection))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        private void btn_AddExpense_Click(object sender, EventArgs e)
        {
            string expense_name = tbName.Text;
            string amount = tbAmount.Text;
            string memberSelected = PayerBox.Text;
            int memberid = 0;
            DateTime dateTime = dateTimePicker1.Value;

            foreach (ExpenseAdapter _obj in _expenseList)
            {
                if (_obj.member_name == memberSelected)
                {
                    memberid = _obj.Payer_id;
                }
            }

            List<int> checkedMemberIds = new List<int>();
            foreach (Control control in flowLayout.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    int checkedMemberId = (int)checkBox.Tag;
                    checkedMemberIds.Add(checkedMemberId);
                }
            }

            string checkedMembers = string.Join(",", checkedMemberIds);

            using (DatabaseHelper dbHelper = new DatabaseHelper())
            {
                try
                {
                    string query = "INSERT INTO Expense (Description, Amount, Payer_ID, Date, CheckedMembers, Login_ID) VALUES (@expense_name, @amount, @memberid, @dateTime, @checkedMembers, @loginId);";
                    using (SqlCommand cmd = new SqlCommand(query, dbHelper.Connection))
                    {
                        cmd.Parameters.AddWithValue("@expense_name", expense_name);
                        cmd.Parameters.AddWithValue("@amount", amount);
                        cmd.Parameters.AddWithValue("@memberid", memberid);
                        cmd.Parameters.AddWithValue("@dateTime", dateTime);
                        cmd.Parameters.AddWithValue("@checkedMembers", checkedMembers);
                        cmd.Parameters.AddWithValue("@loginId", loginId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Expense Added Successfully! You can check the balance by clicking on view balance!");
                            Dashbord dashbord = new Dashbord();
                            dashbord.Show();
                            this.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        private void LoadCheckBoxes()
        {
            using (DatabaseHelper dbHelper = new DatabaseHelper())
            {
                try
                {
                    string query = "SELECT Member_ID, Member_Name FROM Members;";
                    using (SqlDataReader reader = dbHelper.ExecuteReader(query))
                    {
                        while (reader.Read())
                        {
                            CheckBox checkBox = new CheckBox
                            {
                                Text = reader["Member_Name"].ToString(),
                                Tag = reader["Member_ID"],
                                AutoSize = true,
                                Margin = new Padding(10),
                                Font = new Font("Times New Roman", 14)

                            };

                            // Add the checkbox to the FlowLayoutPanel
                            flowLayout.Controls.Add(checkBox);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error loading checkboxes: " + ex.Message);
                }
            }
        }

        private void LoadMembers()
        {
            using (DatabaseHelper dbHelper = new DatabaseHelper())
            {
                try
                {
                    string query = "SELECT * FROM Members;";
                    using (SqlDataReader reader = dbHelper.ExecuteReader(query))
                    {
                        DataTable ExpenseTable = new DataTable();
                        ExpenseTable.Load(reader);

                        foreach (DataRow row in ExpenseTable.Rows)
                        {
                            ExpenseAdapter _obj = new ExpenseAdapter
                            {
                                member_name = row["Member_Name"].ToString(),
                                Payer_id = Convert.ToInt32(row["Member_ID"])
                            };
                            _expenseList.Add(_obj);
                            PayerBox.Items.Add(row["Member_Name"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error fetching members: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dashbord dashbord = new Dashbord();
            dashbord.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PayerBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Email_Click(object sender, EventArgs e)
        {

        }
    }
}



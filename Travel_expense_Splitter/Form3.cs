using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Travel_expense_Splitter.Adapter;

namespace Travel_expense_Splitter
{
    public partial class Form3 : Form
    {
        Boolean arrow = false;
        public List<ExpenseAdapter> _expenseList = new List<ExpenseAdapter>();
        public int loginId;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(UserSession.LoggedInUsername))
            //{
            //    MessageBox.Show("User is not logged in.");
            //    Dashbord dashbord = new Dashbord();
            //    dashbord.Show();
            //    this.Close();
            //    return;
            //}

            //// Retrieve the login ID based on the logged-in user
            //loginId = DatabaseOperations.GetLoginId(UserSession.LoggedInUsername);
            //LoadMembers();
            //LoadCheckBoxes();
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

            try
            {
                int rowsAffected = DatabaseOperations.AddExpense(expense_name, amount, memberid, dateTime, checkedMembers, loginId);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Expense Added Successfully! You can check the balance by clicking on view balance!");
                    Dashbord dashbord = new Dashbord();
                    dashbord.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void LoadCheckBoxes()
        {
            try
            {
                using (SqlDataReader reader = DatabaseOperations.GetMemberCheckBoxes())
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

        private void LoadMembers()
        {
            try
            {
                _expenseList = DatabaseOperations.GetMembers();
                foreach (var member in _expenseList)
                {
                    PayerBox.Items.Add(member.member_name);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error fetching members: " + ex.Message);
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

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (arrow)
            {
                arrow = false;
                button4.BackgroundImage = Properties.Resources.arrowDown;
                panel5.Hide();
            }
            else
            {
                arrow = true;
                button4.BackgroundImage = Properties.Resources.arrowUp;
                panel5.Show();
            }
        }
    }
}


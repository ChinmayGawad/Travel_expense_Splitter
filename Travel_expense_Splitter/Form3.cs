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
    public partial class Form3 : Form
    {
        public List<ExpenseAdapter> _expenseList = new List<ExpenseAdapter>();
        public string connectionString = "Server=CHINMAY-N3P5PKK\\SQLEXPRESS;Database=travel_expenses;Integrated Security=True;";
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadMembers();
            LoadCheckBoxes();
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

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    
                    string query = "insert into Expense (Description,Amount,Payer_ID,Date,CheckedMembers) values(@expense_name,@amount,@memberid,@dateTime,@checkedMembers);";
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@expense_name", expense_name);
                        cmd.Parameters.AddWithValue("@amount", amount);
                        cmd.Parameters.AddWithValue("@memberid", memberid);
                        cmd.Parameters.AddWithValue("@dateTime", dateTime);
                        cmd.Parameters.AddWithValue("@checkedMembers", checkedMembers);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Expense Added Successfuly !! You Can check Balance by clicking on view balance !!!");
                            Dashbord dashbord = new Dashbord();
                            dashbord.Show();
                            this.Close();

                        }
                    }

                }
                catch (Exception ex)
                {
                    {
                        Console.WriteLine("Error :" + ex.Message);
                    }
                }

            }
        }
        private void LoadCheckBoxes()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Member_ID, Member_Name FROM Members;";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            CheckBox checkBox = new CheckBox();
                            checkBox.Text = reader["Member_Name"].ToString();
                            checkBox.Tag = reader["Member_ID"];
                            checkBox.AutoSize = true;

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
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Members;";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        DataTable ExpenseTable = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(ExpenseTable);

                        foreach (DataRow row in ExpenseTable.Rows)
                        {
                            ExpenseAdapter _obj = new ExpenseAdapter();
                            _obj.member_name = row["Member_Name"].ToString();
                            _obj.Payer_id = Convert.ToInt32(row["Member_ID"]);
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
    }
}


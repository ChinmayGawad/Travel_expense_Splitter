using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Travel_expense_Splitter.Adapter;

namespace Travel_expense_Splitter
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=CHINMAY-N3P5PKK\\SQLEXPRESS;Database=travel_expenses;Integrated Security=True;";

            using (DatabaseHelper dbHelper = new DatabaseHelper(connectionString))
            {
                string query = @"SELECT mb.Member_ID, mb.Member_Name, Ex.Amount, Ex.CheckedMembers FROM Members mb JOIN Expense Ex ON Ex.Payer_ID = mb.Member_ID";
                SqlDataReader reader = dbHelper.ExecuteReader(query);

                var memberData = new List<(int MemberId, string MemberName, int Amount, string CheckedMembers)>();

                while (reader.Read())
                {
                    memberData.Add((reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.IsDBNull(3) ? string.Empty : reader.GetString(3)));
                }

                reader.Close();

                foreach (var data in memberData)
                {
                    // Create a new tab for each member
                    TabPage tp1 = new TabPage(data.MemberName);
                    tabControl1.TabPages.Add(tp1);

                    // Add controls to the tab
                    Label l1 = new Label();
                    l1.Text = "Total amount to be received";
                    l1.Font = new Font("Times New Roman", 12, FontStyle.Bold);
                    l1.Location = new Point(10, 5);
                    l1.AutoSize = true;

                    TextBox l2 = new TextBox();
                    l2.Text = data.Amount.ToString("C"); // Format as currency
                    l2.Enabled = false;
                    l2.Location = new Point(220, 5);

                    

                    // Display checked members
                    Label l3 = new Label();
                    l3.Text = " Members: " + GetMemberNames(data.CheckedMembers, dbHelper);
                    l3.Font = new Font("Times New Roman", 12, FontStyle.Bold);
                    l3.Location = new Point(10, 35);
                    l3.AutoSize = true;

                    // Calculate share amount
                    string[] memberIds = data.CheckedMembers.Split(',');
                    int numberOfMembers = memberIds.Length;
                    decimal shareAmount = data.Amount / numberOfMembers;

                    Label l4 = new Label();
                    l4.Text = "Each member's share: " + shareAmount.ToString("C");
                    l4.Font = new Font("Times New Roman", 12, FontStyle.Bold);
                    l4.Location = new Point(10, 65);
                    l4.AutoSize = true;




                    tp1.Controls.Add(l1);
                    tp1.Controls.Add(l2);
                    tp1.Controls.Add(l3);
                    tp1.Controls.Add(l4);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashbord dashbord = new Dashbord();
            dashbord.Show();
            this.Hide();
        }

        private string GetMemberNames(string checkedMembers, DatabaseHelper dbHelper)
        {
            if (string.IsNullOrEmpty(checkedMembers))
            {
                return "None";
            }

            string[] memberIds = checkedMembers.Split(',');
            string query = "SELECT Member_Name FROM Members WHERE Member_ID IN (" + string.Join(",", memberIds) + ")";
            SqlDataReader reader = dbHelper.ExecuteReader(query);

            List<string> memberNames = new List<string>();
            while (reader.Read())
            {
                memberNames.Add(reader.GetString(0));
            }

            reader.Close();
            return string.Join(", ", memberNames);
        }
    }
}

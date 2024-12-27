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
            try
            {
                var memberData = new List<(int MemberId, string MemberName, int Amount, string CheckedMembers, string Username)>();

                using (DatabaseHelper dbHelper = new DatabaseHelper())
                {
                    string query = @"SELECT mb.Member_ID, mb.Member_Name, Ex.Amount, Ex.CheckedMembers, lt.username 
                                     FROM Members mb 
                                     JOIN Expense Ex ON Ex.Payer_ID = mb.Member_ID
                                     JOIN login_table lt ON Ex.Login_ID = lt.Login_ID";
                    using (SqlDataReader reader = dbHelper.ExecuteReader(query))
                    {
                        while (reader.Read())
                        {
                            memberData.Add((
                                reader.GetInt32(0),
                                reader.GetString(1),
                                reader.GetInt32(2),
                                reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                                reader.GetString(4)
                            ));
                        }
                    }
                }

                foreach (var data in memberData)
                {
                    // Create a new tab for each member
                    TabPage tp1 = new TabPage(data.MemberName);
                    tabControl1.TabPages.Add(tp1);

                    Label l1 = new Label
                    {
                        Text = "Total amount to be received",
                        Font = new Font("Times New Roman", 12, FontStyle.Bold),
                        Location = new Point(10, 5),
                        AutoSize = true
                    };

                    TextBox l2 = new TextBox
                    {
                        Text = data.Amount.ToString("C"),
                        Enabled = false,
                        Location = new Point(220, 5)
                    };

                    Label l3 = new Label
                    {
                        Text = " Members: " + GetMemberNames(data.CheckedMembers),
                        Font = new Font("Times New Roman", 12, FontStyle.Bold),
                        Location = new Point(10, 35),
                        AutoSize = true
                    };

                    string[] memberIds = data.CheckedMembers.Split(',');
                    int numberOfMembers = memberIds.Length;
                    decimal shareAmount = numberOfMembers > 0 ? data.Amount / numberOfMembers : 0;

                    Label l4 = new Label
                    {
                        Text = "Amount to be paid by each member: " + shareAmount.ToString("C"),
                        Font = new Font("Times New Roman", 12, FontStyle.Bold),
                        Location = new Point(10, 65),
                        AutoSize = true
                    };

                    Label l5 = new Label
                    {
                        Text = "Entry Done By: " + data.Username,
                        Font = new Font("Times New Roman", 12, FontStyle.Bold),
                        Location = new Point(10, 95),
                        AutoSize = true
                    };

                    tp1.Controls.Add(l1);
                    tp1.Controls.Add(l2);
                    tp1.Controls.Add(l3);
                    tp1.Controls.Add(l4);
                    tp1.Controls.Add(l5);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private string GetMemberNames(string checkedMembers)
        {
            if (string.IsNullOrEmpty(checkedMembers))
            {
                return "None";
            }

            using (DatabaseHelper dbHelper = new DatabaseHelper())
            {
                string[] memberIds = checkedMembers.Split(',');
                string query = "SELECT Member_Name FROM Members WHERE Member_ID IN (" + string.Join(",", memberIds) + ")";
                using (SqlDataReader reader = dbHelper.ExecuteReader(query))
                {
                    List<string> memberNames = new List<string>();
                    while (reader.Read())
                    {
                        memberNames.Add(reader.GetString(0));
                    }
                    return string.Join(", ", memberNames);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashbord dashbord = new Dashbord();
            dashbord.Show();
            this.Close();
        }
    }
}





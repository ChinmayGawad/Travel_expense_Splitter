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
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            //try
            //{
            //    using (SqlDataReader reader = DatabaseOperations.GetExpenseDetails())
            //    {
            //        var memberData = new List<(int MemberId, string MemberName, int Amount, string CheckedMembers, string Username)>();

            //        while (reader.Read())
            //        {
            //            memberData.Add((reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.IsDBNull(3) ? string.Empty : reader.GetString(3), reader.GetString(4)));
            //        }

            //        reader.Close();

            //        foreach (var data in memberData)
            //        {
            //            // Create a new tab for each member
            //            TabPage tp1 = new TabPage(data.MemberName);
            //            tabControl1.TabPages.Add(tp1);

            //            // Add controls to the tab
            //            Label l1 = new Label();
            //            l1.Text = "Total amount to be received";
            //            l1.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            //            l1.Location = new Point(10, 5);
            //            l1.AutoSize = true;

            //            TextBox l2 = new TextBox();
            //            l2.Text = data.Amount.ToString("C");
            //            l2.Enabled = false;
            //            l2.Location = new Point(220, 5);

            //            // Display checked members
            //            Label l3 = new Label();
            //            l3.Text = " Members: " + DatabaseOperations.GetMemberNames(data.CheckedMembers);
            //            l3.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            //            l3.Location = new Point(10, 35);
            //            l3.AutoSize = true;

            //            // Calculate share amount
            //            string[] memberIds = data.CheckedMembers.Split(',');
            //            int numberOfMembers = memberIds.Length;
            //            decimal shareAmount = data.Amount / numberOfMembers;

            //            Label l4 = new Label();
            //            l4.Text = "Amount to be paid by each member: " + shareAmount.ToString("C");
            //            l4.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            //            l4.Location = new Point(10, 65);
            //            l4.AutoSize = true;

            //            // Display the username who made the entry
            //            Label l5 = new Label();
            //            l5.Text = "Entry Done By: " + data.Username;
            //            l5.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            //            l5.Location = new Point(10, 95);
            //            l5.AutoSize = true;

            //            tp1.Controls.Add(l1);
            //            tp1.Controls.Add(l2);
            //            tp1.Controls.Add(l3);
            //            tp1.Controls.Add(l4);
            //            tp1.Controls.Add(l5);
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error: " + ex.Message);
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dashbord dashbord = new Dashbord();
            dashbord.Show();
            this.Hide();
        }
    }
}



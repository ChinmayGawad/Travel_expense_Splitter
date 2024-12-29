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
        Boolean arrow = false;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            LoadTrips();
        }

        private void LoadTrips()
        {
            try
            {
                var trips = DatabaseOperations.GetTrips();
                cbTrips.Items.Clear();
                foreach (var trip in trips)
                {
                    cbTrips.Items.Add(new { trip.TripId, trip.TripName });
                }
                cbTrips.DisplayMember = "TripName";
                cbTrips.ValueMember = "TripId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading trips: " + ex.Message);
            }
        }

        private void cbTrips_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTrips.SelectedItem != null)
            {
                int selectedTripId = (cbTrips.SelectedItem as dynamic).TripId;
                LoadExpensesForTrip(selectedTripId);
            }
        }

        private void LoadExpensesForTrip(int tripId)
        {
            try
            {
                var memberData = DatabaseOperations.GetExpenseDetails(tripId);

                tabControl1.TabPages.Clear();

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
                    l2.Text = data.Amount.ToString("C");
                    l2.Enabled = false;
                    l2.Location = new Point(220, 5);


                    Label l6 = new Label();
                    l6.Text = "Expense Name: " + data.ExpenseName;
                    l6.Font = new Font("Times New Roman", 12, FontStyle.Bold);
                    l6.Location = new Point(10, 35);
                    l6.AutoSize = true;

                    // Display checked members
                    Label l3 = new Label();
                    l3.Text = " Members: " + DatabaseOperations.GetMemberNames(data.CheckedMembers);
                    l3.Font = new Font("Times New Roman", 12, FontStyle.Bold);
                    l3.Location = new Point(10, 65);
                    l3.AutoSize = true;

                    // Calculate share amount
                    string[] memberIds = data.CheckedMembers.Split(',');
                    int numberOfMembers = memberIds.Length;
                    decimal shareAmount = data.Amount / numberOfMembers;

                    Label l4 = new Label();
                    l4.Text = "Amount to be paid by each member: " + shareAmount.ToString("C");
                    l4.Font = new Font("Times New Roman", 12, FontStyle.Bold);
                    l4.Location = new Point(10, 95);
                    l4.AutoSize = true;

                    // Display the username who made the entry
                    Label l5 = new Label();
                    l5.Text = "Entry Done By: " + data.Username;
                    l5.Font = new Font("Times New Roman", 12, FontStyle.Bold);
                    l5.Location = new Point(10, 125);
                    l5.AutoSize = true;


                    

                    tp1.Controls.Add(l1);
                    tp1.Controls.Add(l2);
                    tp1.Controls.Add(l3);
                    tp1.Controls.Add(l4);
                    tp1.Controls.Add(l5);
                    tp1.Controls.Add(l6);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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


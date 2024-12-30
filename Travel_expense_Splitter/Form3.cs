using System;
using System.Collections.Generic;
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
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            if (string.IsNullOrEmpty(UserSession.LoggedInUsername))
            {
                MessageBox.Show("User is not logged in.");
                Dashbord dashbord = new Dashbord();
                dashbord.Show();
                this.Close();
                return;
            }

            // Initialize the connection string
            string connectionString = "Server=CHINMAY-N3P5PKK\\SQLEXPRESS;Database=travel_expenses;Integrated Security=True;";
            DatabaseHelper.ConnectionString = connectionString;

            // Retrieve the login ID based on the logged-in user
            loginId = DatabaseOperations.GetLoginId(UserSession.LoggedInUsername);
            LoadTrips();
            cbTrips.SelectedIndexChanged += cbTrips_SelectedIndexChanged;
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

        private void btnAddTrip_Click(object sender, EventArgs e)
        {
            addTrip formAddTrip = new addTrip();
            formAddTrip.ShowDialog();
            LoadTrips(); // Reload trips after adding a new trip
        }

        private void btn_AddExpense_Click(object sender, EventArgs e)
        {
            string expense_name = tbName.Text;
            string amount = tbAmount.Text;
            string memberSelected = PayerBox.Text;
            int memberid = 0;
            DateTime dateTime = dateTimePicker1.Value;
            int tripId = (cbTrips.SelectedItem as dynamic).TripId;

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
                int rowsAffected = DatabaseOperations.AddExpense(expense_name, amount, memberid, dateTime, checkedMembers, loginId, tripId);
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

        private void LoadCheckBoxes(int tripId)
        {
            try
            {
                var members = DatabaseOperations.GetMembersByTrip(tripId);
                flowLayout.Controls.Clear();
                foreach (var member in members)
                {
                    CheckBox checkBox = new CheckBox
                    {
                        Text = member.member_name,
                        Tag = member.Payer_id,
                        AutoSize = true,
                        Margin = new Padding(10),
                        Font = new Font("Times New Roman", 14)
                    };

                    // Add the checkbox to the FlowLayoutPanel
                    flowLayout.Controls.Add(checkBox);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading checkboxes: " + ex.Message);
            }
        }

        private void LoadMembers(int tripId)
        {
            try
            {
                _expenseList = DatabaseOperations.GetMembersByTrip(tripId);
                PayerBox.Items.Clear();
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

        private void cbTrips_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTrips.SelectedItem != null)
            {
                int tripId = (cbTrips.SelectedItem as dynamic).TripId;
                LoadMembers(tripId);
                LoadCheckBoxes(tripId);
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

        private void button1_Click(object sender, EventArgs e)
        {
            Dashbord dashbord = new Dashbord();
            dashbord.Show();
            this.Close();
        }

        /*   private void button4_Click(object sender, EventArgs e)
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
           }*/
    }
}

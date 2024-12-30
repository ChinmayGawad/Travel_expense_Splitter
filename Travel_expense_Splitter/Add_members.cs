using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Travel_expense_Splitter
{
    public partial class Add_members : Form
    {
        Boolean arrow = false;
        public string connectionString = "Server=CHINMAY-N3P5PKK\\SQLEXPRESS;Database=travel_expenses;Integrated Security=True;";

        public Add_members()
        {
            InitializeComponent();
        }

        private void Add_members_Load(object sender, EventArgs e)
        {
            LoadTrips();
        }

        private void LoadTrips()
        {
            try
            {
                var trips = DatabaseOperations.GetTrips();
                foreach (var trip in trips)
                {
                    ComboBoxItem item = new ComboBoxItem
                    {
                        Text = trip.TripName,
                        Value = trip.TripId
                    };
                    comboBox1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading trips: " + ex.Message);
            }
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

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a trip.");
                return; // Exit the method if no trip is selected
            }

            ComboBoxItem selectedTrip = (ComboBoxItem)comboBox1.SelectedItem;
            int tripId = (int)selectedTrip.Value;

            try
            {
                int rowsAffected = DatabaseOperations.AddMember(member_name, mem_email, mem_phone, tripId);
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

        private void button1_Click_2(object sender, EventArgs e)
        {
            Dashbord dashbord = new Dashbord();
            dashbord.Show();
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

        private void button5_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }

    public class ComboBoxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}

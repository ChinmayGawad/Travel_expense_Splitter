using System;
using System.Windows.Forms;

namespace Travel_expense_Splitter
{
    public partial class addTrip : Form
    {
        public addTrip()
        {
            InitializeComponent();
        }

        private void btnAddTrip_Click(object sender, EventArgs e)
        {
            string tripName = tbTripName.Text;

            if (string.IsNullOrEmpty(tripName))
            {
                MessageBox.Show("Please enter a trip name.");
                return;
            }

            try
            {
                int rowsAffected = DatabaseOperations.AddTrip(tripName);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Trip added successfully!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding trip: " + ex.Message);
            }
        }
    }
}



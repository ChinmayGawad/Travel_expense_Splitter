using System;
using System.Drawing;
using System.Windows.Forms;

namespace Travel_expense_Splitter
{
    public partial class Dashbord : Form
    {
        public Dashbord()
        {
            InitializeComponent();
        }

        private void Dashbord_Load(object sender, EventArgs e)
        {
            panel3.BackColor = Color.FromArgb(100,0,0,0);
            panel4.BackColor = Color.FromArgb(100, 0, 0, 0);
            button1.BackColor = Color.FromArgb(100, 0, 0, 0);
            button2.BackColor = Color.FromArgb(100, 0, 0, 0);
            button3.BackColor = Color.FromArgb(100, 0, 0, 0);


            int totalMembers = DatabaseOperations.GetTotalMembers();
            Total_Members.Text = totalMembers.ToString();

            decimal total_Expense = DatabaseOperations.GetTotalExpenses();
            Total_Expenses.Text = total_Expense.ToString("C");
        }

        private void Total_Members_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_members add_Members = new Add_members();
            add_Members.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 viewBalance = new Form4();
            viewBalance.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
      
       
    }
}

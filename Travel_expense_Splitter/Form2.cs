using System;
using System.Drawing;
using System.Windows.Forms;
using Travel_expense_Splitter.Adapter;

namespace Travel_expense_Splitter
{
    public partial class Dashbord : Form
    {
        Boolean arrow=false;
        public Dashbord()
        {
            InitializeComponent();
        }

        private void Dashbord_Load(object sender, EventArgs e)
        {
            DatabaseHelper databaseHelper = new DatabaseHelper();
            int totalMembers = DatabaseOperations.GetTotalMembers();
            Total_Members.Text = totalMembers.ToString();

            decimal total_Expense = DatabaseOperations.GetTotalExpenses();
            Total_Expenses.Text = total_Expense.ToString("C");

            int loginId = DatabaseOperations.GetLoginId(UserSession.LoggedInUsername);
            string username = DatabaseOperations.GetUsername(loginId);
            UsernameLabel.Text = username;
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

        private void button4_Click_1(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}

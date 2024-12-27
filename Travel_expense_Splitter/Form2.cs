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
    public partial class Dashbord : Form
    {
        public Dashbord()
        {
            InitializeComponent();
        }

        private void Dashbord_Load(object sender, EventArgs e)
        {
            //DatabaseHelper databaseHelper = new DatabaseHelper();
            //string query = "select sum(Amount) from Expense";
            //int totalMembers = GetTotalMembers();
            //Total_Members.Text = totalMembers.ToString();

            //decimal total_Expense = GetTotalExpenses();
            //Total_Expenses.Text = total_Expense.ToString("C");
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
        private int GetTotalMembers()
        {
            using (DatabaseHelper dbHelper = new DatabaseHelper())
            {
                string query = "SELECT COUNT(*) FROM Members";
                using (SqlCommand cmd = new SqlCommand(query, dbHelper.Connection))
                {
                    return (int)cmd.ExecuteScalar();
                }
            }
        }
        private decimal GetTotalExpenses()
        {
            using (DatabaseHelper dbHelper = new DatabaseHelper())
            {
                string query = "SELECT SUM(Amount) FROM Expense";
                using (SqlCommand cmd = new SqlCommand(query, dbHelper.Connection))
                {
                    object result = cmd.ExecuteScalar();
                    if (result == DBNull.Value)
                    {
                        return 0;
                    }
                    else
                    {
                        return Convert.ToDecimal(result);
                    }
                }
            }
        }
    }
}

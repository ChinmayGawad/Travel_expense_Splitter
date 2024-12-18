using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel_expense_Splitter
{
    public partial class Add_members : Form
    {
        public Add_members()
        {
            InitializeComponent();
        }

        private void btn_AddMembers_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Member Added Successfully !!!");
            Dashbord dash = new Dashbord();
            dash.Show();
            this.Close();

        }
    }
}

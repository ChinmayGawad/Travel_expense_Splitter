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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            int memberNo = 10;
            for (int i = 0; i < memberNo; i++)
            {
                tabControl1.TabPages.Add("Neel"+(i+1));
                int selectedMemberno = 10;
                for (int j = 0; j < selectedMemberno; j++)
                {
                    TabPage tp1 = tabControl1.TabPages[i];
                    if (j == 0)
                    {
                        Label l1 = new Label();
                        l1.Text = "Total amount to be received";
                        l1.Font = new Font("Times New Roman", 12, FontStyle.Bold);
                        l1.Location = new Point(10, 5 + j * 30);
                        l1.AutoSize = true;
                        TextBox l2 = new TextBox();
                        l2.Text = "=50.00";
                        l2.Enabled = false;
                        l2.Location = new Point(220, 5 + j * 30);
                        tp1.AutoScroll = true;
                        tp1.Controls.Add(l1);
                        tp1.Controls.Add(l2);
                    }
                    Label l3 = new Label();
                    l3.Text = "NEEL"+(j+1);
                    l3.Location = new Point(10, 35+j*30);
                    l3.AutoSize = true;
                    TextBox l4 = new TextBox();
                    l4.Text = "=25.00";
                    l4.Enabled = false;
                    l4.Location = new Point(500, 35+j*30);
                    tp1.Controls.Add(l3);
                    tp1.Controls.Add(l4);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashbord dashbord = new Dashbord();
            dashbord.Show();
            this.Hide();
        }
    }
}

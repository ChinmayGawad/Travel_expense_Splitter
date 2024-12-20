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
                    Label l1 = new Label();
                    l1.Text = "NEEL"+(j+1);
                    l1.Location = new Point(10, 5+j*30);
                    l1.AutoSize = true;
                    TextBox l2 = new TextBox();
                    l2.Text = "=25.00";
                    l2.Enabled = false;
                    l2.Location = new Point(500, 5+j*30);
                    TabPage tp1 = tabControl1.TabPages[i];
                    tp1.AutoScroll = true;
                    tp1.Controls.Add(l1);
                    tp1.Controls.Add(l2);
                }
            }
        }
    }
}

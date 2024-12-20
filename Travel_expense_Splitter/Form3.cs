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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            int memberNo = 10;
            for(int i = 0; i < memberNo; i++)
            {
                comboBox1.Items.Add("Neel" + (i + 1));
            }
            for(int i = 0; i < memberNo; i++)
            {
                CheckBox myCheckBox = new CheckBox();
                myCheckBox.Name = "myCheckBox"+(i+1);
                myCheckBox.Text = "Neel" + (i + 1);
                myCheckBox.Location = new Point(10,i * 30);
                myCheckBox.Font=new Font(myCheckBox.Font.FontFamily,14);

                panel2.Controls.Add(myCheckBox);
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

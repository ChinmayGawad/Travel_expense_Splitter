namespace Travel_expense_Splitter
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cbTrips;
        private System.Windows.Forms.Button btnAddTrip;
        private System.Windows.Forms.Button btnAddExpense;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.ComboBox PayerBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.FlowLayoutPanel flowLayout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTrip;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblPayer;
        private System.Windows.Forms.Label lblDate;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cbTrips = new System.Windows.Forms.ComboBox();
            this.btnAddTrip = new System.Windows.Forms.Button();
            this.btnAddExpense = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.PayerBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.flowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTrip = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblPayer = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbTrips
            // 
            this.cbTrips.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrips.FormattingEnabled = true;
            this.cbTrips.Location = new System.Drawing.Point(200, 37);
            this.cbTrips.Margin = new System.Windows.Forms.Padding(4);
            this.cbTrips.Name = "cbTrips";
            this.cbTrips.Size = new System.Drawing.Size(265, 24);
            this.cbTrips.TabIndex = 0;
            // 
            // btnAddTrip
            // 
            this.btnAddTrip.Location = new System.Drawing.Point(493, 37);
            this.btnAddTrip.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddTrip.Name = "btnAddTrip";
            this.btnAddTrip.Size = new System.Drawing.Size(100, 28);
            this.btnAddTrip.TabIndex = 1;
            this.btnAddTrip.Text = "Add Trip";
            this.btnAddTrip.UseVisualStyleBackColor = true;
            this.btnAddTrip.Click += new System.EventHandler(this.btnAddTrip_Click);
            // 
            // btnAddExpense
            // 
            this.btnAddExpense.Location = new System.Drawing.Point(67, 492);
            this.btnAddExpense.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.Size = new System.Drawing.Size(133, 28);
            this.btnAddExpense.TabIndex = 2;
            this.btnAddExpense.Text = "Add Expense";
            this.btnAddExpense.UseVisualStyleBackColor = true;
            this.btnAddExpense.Click += new System.EventHandler(this.btn_AddExpense_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(200, 86);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(265, 22);
            this.tbName.TabIndex = 3;
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(200, 135);
            this.tbAmount.Margin = new System.Windows.Forms.Padding(4);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(265, 22);
            this.tbAmount.TabIndex = 4;
            // 
            // PayerBox
            // 
            this.PayerBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PayerBox.FormattingEnabled = true;
            this.PayerBox.Location = new System.Drawing.Point(200, 185);
            this.PayerBox.Margin = new System.Windows.Forms.Padding(4);
            this.PayerBox.Name = "PayerBox";
            this.PayerBox.Size = new System.Drawing.Size(265, 24);
            this.PayerBox.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(200, 234);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // flowLayout
            // 
            this.flowLayout.Location = new System.Drawing.Point(67, 283);
            this.flowLayout.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayout.Name = "flowLayout";
            this.flowLayout.Size = new System.Drawing.Size(800, 185);
            this.flowLayout.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblTrip);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblAmount);
            this.panel1.Controls.Add(this.lblPayer);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.cbTrips);
            this.panel1.Controls.Add(this.btnAddTrip);
            this.panel1.Controls.Add(this.btnAddExpense);
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Controls.Add(this.tbAmount);
            this.panel1.Controls.Add(this.PayerBox);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.flowLayout);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 554);
            this.panel1.TabIndex = 8;
            // 
            // lblTrip
            // 
            this.lblTrip.AutoSize = true;
            this.lblTrip.Location = new System.Drawing.Point(67, 41);
            this.lblTrip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrip.Name = "lblTrip";
            this.lblTrip.Size = new System.Drawing.Size(31, 16);
            this.lblTrip.TabIndex = 8;
            this.lblTrip.Text = "Trip";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(67, 90);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(106, 16);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Expense Name :";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(67, 139);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(52, 16);
            this.lblAmount.TabIndex = 10;
            this.lblAmount.Text = "Amount";
            // 
            // lblPayer
            // 
            this.lblPayer.AutoSize = true;
            this.lblPayer.Location = new System.Drawing.Point(67, 188);
            this.lblPayer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPayer.Name = "lblPayer";
            this.lblPayer.Size = new System.Drawing.Size(43, 16);
            this.lblPayer.TabIndex = 11;
            this.lblPayer.Text = "Payer";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(67, 238);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 16);
            this.lblDate.TabIndex = 12;
            this.lblDate.Text = "Date";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 615);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.Text = "Add Expense";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button button1;
    }
}




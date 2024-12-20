namespace Travel_expense_Splitter
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btn_AddExpense = new System.Windows.Forms.Button();
            this.phone = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.member_name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.PayerBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1272, 97);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(523, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Log Expenses";
            // 
            // tbAmount
            // 
            this.tbAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAmount.Location = new System.Drawing.Point(505, 196);
            this.tbAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(354, 41);
            this.tbAmount.TabIndex = 18;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(505, 138);
            this.tbName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(354, 41);
            this.tbName.TabIndex = 17;
            // 
            // btn_AddExpense
            // 
            this.btn_AddExpense.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btn_AddExpense.FlatAppearance.BorderSize = 100;
            this.btn_AddExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddExpense.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_AddExpense.Location = new System.Drawing.Point(531, 612);
            this.btn_AddExpense.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddExpense.Name = "btn_AddExpense";
            this.btn_AddExpense.Size = new System.Drawing.Size(235, 57);
            this.btn_AddExpense.TabIndex = 16;
            this.btn_AddExpense.Text = "Add Expense";
            this.btn_AddExpense.UseVisualStyleBackColor = true;
            this.btn_AddExpense.Click += new System.EventHandler(this.btn_AddExpense_Click);
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(407, 265);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(92, 36);
            this.phone.TabIndex = 15;
            this.phone.Text = "Date :";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(365, 201);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(134, 36);
            this.Email.TabIndex = 14;
            this.Email.Text = "Amount :";
            // 
            // member_name
            // 
            this.member_name.AutoSize = true;
            this.member_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.member_name.Location = new System.Drawing.Point(259, 143);
            this.member_name.Name = "member_name";
            this.member_name.Size = new System.Drawing.Size(240, 36);
            this.member_name.TabIndex = 13;
            this.member_name.Text = " Expense Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(391, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 36);
            this.label2.TabIndex = 20;
            this.label2.Text = "Payer :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(505, 265);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(348, 41);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // PayerBox
            // 
            this.PayerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayerBox.FormattingEnabled = true;
            this.PayerBox.Location = new System.Drawing.Point(505, 328);
            this.PayerBox.Name = "PayerBox";
            this.PayerBox.Size = new System.Drawing.Size(348, 37);
            this.PayerBox.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(259, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(435, 36);
            this.label3.TabIndex = 23;
            this.label3.Text = "Members sharing this expense :";
            // 
            // flowLayout
            // 
            this.flowLayout.Location = new System.Drawing.Point(274, 428);
            this.flowLayout.Name = "flowLayout";
            this.flowLayout.Size = new System.Drawing.Size(585, 163);
            this.flowLayout.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1196, 748);
            this.Controls.Add(this.flowLayout);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PayerBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btn_AddExpense);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.member_name);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btn_AddExpense;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label member_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox PayerBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayout;
    }
}
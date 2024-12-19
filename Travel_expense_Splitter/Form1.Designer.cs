namespace Travel_expense_Splitter
{
    partial class Form1
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
            this.bthLogin = new System.Windows.Forms.Button();
            this.TBPass = new System.Windows.Forms.TextBox();
            this.TBUser = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bthLogin
            // 
            this.bthLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bthLogin.Location = new System.Drawing.Point(168, 299);
            this.bthLogin.Name = "bthLogin";
            this.bthLogin.Size = new System.Drawing.Size(170, 56);
            this.bthLogin.TabIndex = 9;
            this.bthLogin.Text = "Login";
            this.bthLogin.UseVisualStyleBackColor = true;
            this.bthLogin.Click += new System.EventHandler(this.bthLogin_Click_1);
            // 
            // TBPass
            // 
            this.TBPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPass.Location = new System.Drawing.Point(230, 217);
            this.TBPass.Name = "TBPass";
            this.TBPass.PasswordChar = '*';
            this.TBPass.Size = new System.Drawing.Size(206, 41);
            this.TBPass.TabIndex = 8;
            // 
            // TBUser
            // 
            this.TBUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBUser.Location = new System.Drawing.Point(230, 132);
            this.TBUser.Name = "TBUser";
            this.TBUser.Size = new System.Drawing.Size(206, 41);
            this.TBUser.TabIndex = 7;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbPassword.Location = new System.Drawing.Point(61, 217);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(163, 36);
            this.lbPassword.TabIndex = 6;
            this.lbPassword.Text = "Password :";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.ForeColor = System.Drawing.Color.Black;
            this.lbUsername.Location = new System.Drawing.Point(58, 135);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(166, 36);
            this.lbUsername.TabIndex = 5;
            this.lbUsername.Text = "Username :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1272, 97);
            this.panel1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(469, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(399, 44);
            this.label2.TabIndex = 11;
            this.label2.Text = "Travel Expense Splitter";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Bisque;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbUsername);
            this.panel2.Controls.Add(this.TBUser);
            this.panel2.Controls.Add(this.bthLogin);
            this.panel2.Controls.Add(this.lbPassword);
            this.panel2.Controls.Add(this.TBPass);
            this.panel2.Location = new System.Drawing.Point(390, 234);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(508, 454);
            this.panel2.TabIndex = 11;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1235, 774);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Total_members_label;
        private System.Windows.Forms.Label Total_expenses_label;
        private System.Windows.Forms.Button Add_Members;
        private System.Windows.Forms.Button Log_Expenses;
        private System.Windows.Forms.Button View_balance;
        private System.Windows.Forms.Button bthLogin;
        private System.Windows.Forms.TextBox TBPass;
        private System.Windows.Forms.TextBox TBUser;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
    }
}


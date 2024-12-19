namespace Travel_expense_Splitter
{
    partial class Add_members
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
            this.label1 = new System.Windows.Forms.Label();
            this.member_name = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.btn_AddMembers = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(523, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Members";
            // 
            // member_name
            // 
            this.member_name.AutoSize = true;
            this.member_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.member_name.Location = new System.Drawing.Point(376, 252);
            this.member_name.Name = "member_name";
            this.member_name.Size = new System.Drawing.Size(116, 36);
            this.member_name.TabIndex = 1;
            this.member_name.Text = " Name :";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(388, 318);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(104, 36);
            this.Email.TabIndex = 2;
            this.Email.Text = "Email :";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(388, 388);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(118, 36);
            this.phone.TabIndex = 3;
            this.phone.Text = "Phone :";
            this.phone.Click += new System.EventHandler(this.phone_Click);
            // 
            // btn_AddMembers
            // 
            this.btn_AddMembers.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btn_AddMembers.FlatAppearance.BorderSize = 100;
            this.btn_AddMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddMembers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_AddMembers.Location = new System.Drawing.Point(531, 495);
            this.btn_AddMembers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddMembers.Name = "btn_AddMembers";
            this.btn_AddMembers.Size = new System.Drawing.Size(235, 57);
            this.btn_AddMembers.TabIndex = 4;
            this.btn_AddMembers.Text = "Add Member";
            this.btn_AddMembers.UseVisualStyleBackColor = true;
            this.btn_AddMembers.Click += new System.EventHandler(this.btn_AddMembers_Click);
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(518, 247);
            this.tbName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(354, 41);
            this.tbName.TabIndex = 5;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(518, 315);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(354, 41);
            this.tbEmail.TabIndex = 6;
            // 
            // tbPhone
            // 
            this.tbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhone.Location = new System.Drawing.Point(518, 385);
            this.tbPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(354, 41);
            this.tbPhone.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1272, 97);
            this.panel1.TabIndex = 11;
            // 
            // Add_members
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1223, 732);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btn_AddMembers);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.member_name);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Add_members";
            this.Text = "Add_members";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label member_name;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Button btn_AddMembers;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Panel panel1;
    }
}
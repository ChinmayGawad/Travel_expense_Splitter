namespace Travel_expense_Splitter
{
    partial class addTrip
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox tbTripName;
        private System.Windows.Forms.Button btnAddTrip;
        private System.Windows.Forms.Label label1;

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
            this.tbTripName = new System.Windows.Forms.TextBox();
            this.btnAddTrip = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbTripName
            // 
            this.tbTripName.Location = new System.Drawing.Point(100, 50);
            this.tbTripName.Name = "tbTripName";
            this.tbTripName.Size = new System.Drawing.Size(200, 20);
            this.tbTripName.TabIndex = 0;
            // 
            // btnAddTrip
            // 
            this.btnAddTrip.Location = new System.Drawing.Point(100, 100);
            this.btnAddTrip.Name = "btnAddTrip";
            this.btnAddTrip.Size = new System.Drawing.Size(75, 23);
            this.btnAddTrip.TabIndex = 1;
            this.btnAddTrip.Text = "Add Trip";
            this.btnAddTrip.UseVisualStyleBackColor = true;
            this.btnAddTrip.Click += new System.EventHandler(this.btnAddTrip_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Trip Name";
            // 
            // FormAddTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddTrip);
            this.Controls.Add(this.tbTripName);
            this.Name = "FormAddTrip";
            this.Text = "Add Trip";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}



namespace DeveloperUI
{
    partial class AddDeveloper
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.FirstNameValue = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.LastNameValue = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.PhoneExtValue = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.GenderValue = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(77, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(497, 38);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Add Developer";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(12, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(123, 26);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "First Name";
            // 
            // FirstNameValue
            // 
            this.FirstNameValue.Location = new System.Drawing.Point(12, 106);
            this.FirstNameValue.Name = "FirstNameValue";
            this.FirstNameValue.Size = new System.Drawing.Size(202, 20);
            this.FirstNameValue.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(13, 163);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 23);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = "Last Name";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // LastNameValue
            // 
            this.LastNameValue.Location = new System.Drawing.Point(12, 193);
            this.LastNameValue.Name = "LastNameValue";
            this.LastNameValue.Size = new System.Drawing.Size(202, 20);
            this.LastNameValue.TabIndex = 5;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(12, 252);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(136, 23);
            this.textBox6.TabIndex = 6;
            this.textBox6.Text = "Phone Extension ";
            // 
            // PhoneExtValue
            // 
            this.PhoneExtValue.Location = new System.Drawing.Point(12, 282);
            this.PhoneExtValue.Name = "PhoneExtValue";
            this.PhoneExtValue.Size = new System.Drawing.Size(202, 20);
            this.PhoneExtValue.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(425, 85);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "Gender";
            // 
            // GenderValue
            // 
            this.GenderValue.Location = new System.Drawing.Point(425, 114);
            this.GenderValue.Name = "GenderValue";
            this.GenderValue.Size = new System.Drawing.Size(136, 20);
            this.GenderValue.TabIndex = 9;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(596, 412);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(142, 28);
            this.Add.TabIndex = 10;
            this.Add.Text = "Add Developer";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.addDev);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 412);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AddDeveloper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.GenderValue);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.PhoneExtValue);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.LastNameValue);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.FirstNameValue);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "AddDeveloper";
            this.Text = "AddDeveloper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox FirstNameValue;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox LastNameValue;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox PhoneExtValue;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox GenderValue;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button button2;
    }
}
namespace DeveloperCollections
{
    partial class DeveloperHub
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
            this.DisplayMenBtn = new System.Windows.Forms.Button();
            this.DisplayWomenBtn = new System.Windows.Forms.Button();
            this.DisplayAllbtn = new System.Windows.Forms.Button();
            this.RemoveAllbtn = new System.Windows.Forms.Button();
            this.AddDeveloperbtn = new System.Windows.Forms.Button();
            this.DeveloperListBox = new System.Windows.Forms.ListBox();
            this.LoadDevelopersBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DisplayMenBtn
            // 
            this.DisplayMenBtn.Location = new System.Drawing.Point(564, 80);
            this.DisplayMenBtn.Name = "DisplayMenBtn";
            this.DisplayMenBtn.Size = new System.Drawing.Size(151, 29);
            this.DisplayMenBtn.TabIndex = 2;
            this.DisplayMenBtn.Text = "Display Men";
            this.DisplayMenBtn.UseVisualStyleBackColor = true;
            // 
            // DisplayWomenBtn
            // 
            this.DisplayWomenBtn.Location = new System.Drawing.Point(564, 143);
            this.DisplayWomenBtn.Name = "DisplayWomenBtn";
            this.DisplayWomenBtn.Size = new System.Drawing.Size(151, 32);
            this.DisplayWomenBtn.TabIndex = 3;
            this.DisplayWomenBtn.Text = "Display Women";
            this.DisplayWomenBtn.UseVisualStyleBackColor = true;
            // 
            // DisplayAllbtn
            // 
            this.DisplayAllbtn.Location = new System.Drawing.Point(564, 208);
            this.DisplayAllbtn.Name = "DisplayAllbtn";
            this.DisplayAllbtn.Size = new System.Drawing.Size(151, 29);
            this.DisplayAllbtn.TabIndex = 4;
            this.DisplayAllbtn.Text = "Display All";
            this.DisplayAllbtn.UseVisualStyleBackColor = true;
            // 
            // RemoveAllbtn
            // 
            this.RemoveAllbtn.Location = new System.Drawing.Point(564, 326);
            this.RemoveAllbtn.Name = "RemoveAllbtn";
            this.RemoveAllbtn.Size = new System.Drawing.Size(151, 31);
            this.RemoveAllbtn.TabIndex = 5;
            this.RemoveAllbtn.Text = "Remove All";
            this.RemoveAllbtn.UseVisualStyleBackColor = true;
            // 
            // AddDeveloperbtn
            // 
            this.AddDeveloperbtn.Location = new System.Drawing.Point(637, 21);
            this.AddDeveloperbtn.Name = "AddDeveloperbtn";
            this.AddDeveloperbtn.Size = new System.Drawing.Size(151, 30);
            this.AddDeveloperbtn.TabIndex = 6;
            this.AddDeveloperbtn.Text = "Add Developer";
            this.AddDeveloperbtn.UseVisualStyleBackColor = true;
            this.AddDeveloperbtn.Click += new System.EventHandler(this.AddDeveloperbtn_Click);
            // 
            // DeveloperListBox
            // 
            this.DeveloperListBox.FormattingEnabled = true;
            this.DeveloperListBox.Location = new System.Drawing.Point(23, 80);
            this.DeveloperListBox.Name = "DeveloperListBox";
            this.DeveloperListBox.Size = new System.Drawing.Size(448, 277);
            this.DeveloperListBox.TabIndex = 7;
            // 
            // LoadDevelopersBtn
            // 
            this.LoadDevelopersBtn.Location = new System.Drawing.Point(23, 23);
            this.LoadDevelopersBtn.Name = "LoadDevelopersBtn";
            this.LoadDevelopersBtn.Size = new System.Drawing.Size(151, 28);
            this.LoadDevelopersBtn.TabIndex = 9;
            this.LoadDevelopersBtn.Text = "Load Developers";
            this.LoadDevelopersBtn.UseVisualStyleBackColor = true;
            this.LoadDevelopersBtn.Click += new System.EventHandler(this.LoadDevelopersBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(564, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DeveloperHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LoadDevelopersBtn);
            this.Controls.Add(this.DeveloperListBox);
            this.Controls.Add(this.AddDeveloperbtn);
            this.Controls.Add(this.RemoveAllbtn);
            this.Controls.Add(this.DisplayAllbtn);
            this.Controls.Add(this.DisplayWomenBtn);
            this.Controls.Add(this.DisplayMenBtn);
            this.Name = "DeveloperHub";
            this.Text = "Developer Hub";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DisplayMenBtn;
        private System.Windows.Forms.Button DisplayWomenBtn;
        private System.Windows.Forms.Button DisplayAllbtn;
        private System.Windows.Forms.Button RemoveAllbtn;
        private System.Windows.Forms.Button AddDeveloperbtn;
        private System.Windows.Forms.ListBox DeveloperListBox;
        private System.Windows.Forms.Button LoadDevelopersBtn;
        private System.Windows.Forms.Button button1;
    }
}


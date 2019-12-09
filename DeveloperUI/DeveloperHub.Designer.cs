namespace DeveloperUI
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
            this.AddDev = new System.Windows.Forms.Button();
            this.LoadDev = new System.Windows.Forms.Button();
            this.DisplayMen = new System.Windows.Forms.Button();
            this.DisplayWomen = new System.Windows.Forms.Button();
            this.DisplayAll = new System.Windows.Forms.Button();
            this.RemoveSelected = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.RemoveAll = new System.Windows.Forms.Button();
            this.devView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // AddDev
            // 
            this.AddDev.Location = new System.Drawing.Point(585, 72);
            this.AddDev.Name = "AddDev";
            this.AddDev.Size = new System.Drawing.Size(158, 27);
            this.AddDev.TabIndex = 1;
            this.AddDev.Text = "Add Developer";
            this.AddDev.UseVisualStyleBackColor = true;
            this.AddDev.Click += new System.EventHandler(this.AddDev_Click);
            // 
            // LoadDev
            // 
            this.LoadDev.Location = new System.Drawing.Point(583, 119);
            this.LoadDev.Name = "LoadDev";
            this.LoadDev.Size = new System.Drawing.Size(161, 26);
            this.LoadDev.TabIndex = 2;
            this.LoadDev.Text = "Load Developers";
            this.LoadDev.UseVisualStyleBackColor = true;
            this.LoadDev.Click += new System.EventHandler(this.LoadDev_Click);
            // 
            // DisplayMen
            // 
            this.DisplayMen.Location = new System.Drawing.Point(586, 163);
            this.DisplayMen.Name = "DisplayMen";
            this.DisplayMen.Size = new System.Drawing.Size(157, 26);
            this.DisplayMen.TabIndex = 3;
            this.DisplayMen.Text = "Display Men";
            this.DisplayMen.UseVisualStyleBackColor = true;
            this.DisplayMen.Click += new System.EventHandler(this.DisplayMen_Click);
            // 
            // DisplayWomen
            // 
            this.DisplayWomen.Location = new System.Drawing.Point(586, 211);
            this.DisplayWomen.Name = "DisplayWomen";
            this.DisplayWomen.Size = new System.Drawing.Size(158, 27);
            this.DisplayWomen.TabIndex = 4;
            this.DisplayWomen.Text = "Display Women";
            this.DisplayWomen.UseVisualStyleBackColor = true;
            this.DisplayWomen.Click += new System.EventHandler(this.DisplayWomen_Click);
            // 
            // DisplayAll
            // 
            this.DisplayAll.Location = new System.Drawing.Point(586, 257);
            this.DisplayAll.Name = "DisplayAll";
            this.DisplayAll.Size = new System.Drawing.Size(158, 25);
            this.DisplayAll.TabIndex = 5;
            this.DisplayAll.Text = "Display All";
            this.DisplayAll.UseVisualStyleBackColor = true;
            this.DisplayAll.Click += new System.EventHandler(this.DisplayAll_Click);
            // 
            // RemoveSelected
            // 
            this.RemoveSelected.Location = new System.Drawing.Point(586, 307);
            this.RemoveSelected.Name = "RemoveSelected";
            this.RemoveSelected.Size = new System.Drawing.Size(157, 26);
            this.RemoveSelected.TabIndex = 6;
            this.RemoveSelected.Text = "Remove";
            this.RemoveSelected.UseVisualStyleBackColor = true;
            this.RemoveSelected.Click += new System.EventHandler(this.RemoveSelected_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.textBox1.Location = new System.Drawing.Point(19, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(550, 45);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Developer Hub";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RemoveAll
            // 
            this.RemoveAll.Location = new System.Drawing.Point(583, 352);
            this.RemoveAll.Name = "RemoveAll";
            this.RemoveAll.Size = new System.Drawing.Size(161, 23);
            this.RemoveAll.TabIndex = 8;
            this.RemoveAll.Text = "Remove All";
            this.RemoveAll.UseVisualStyleBackColor = true;
            this.RemoveAll.Click += new System.EventHandler(this.RemoveAll_Click);
            // 
            // devView
            // 
            this.devView.HideSelection = false;
            this.devView.Location = new System.Drawing.Point(19, 72);
            this.devView.Name = "devView";
            this.devView.Size = new System.Drawing.Size(550, 314);
            this.devView.TabIndex = 9;
            this.devView.UseCompatibleStateImageBehavior = false;
            this.devView.SelectedIndexChanged += new System.EventHandler(this.DevView);
            // 
            // DeveloperHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.devView);
            this.Controls.Add(this.RemoveAll);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.RemoveSelected);
            this.Controls.Add(this.DisplayAll);
            this.Controls.Add(this.DisplayWomen);
            this.Controls.Add(this.DisplayMen);
            this.Controls.Add(this.LoadDev);
            this.Controls.Add(this.AddDev);
            this.Name = "DeveloperHub";
            this.Text = "DeveloperHub";
            this.Load += new System.EventHandler(this.DeveloperHub_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddDev;
        private System.Windows.Forms.Button LoadDev;
        private System.Windows.Forms.Button DisplayMen;
        private System.Windows.Forms.Button DisplayWomen;
        private System.Windows.Forms.Button DisplayAll;
        private System.Windows.Forms.Button RemoveSelected;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button RemoveAll;
        private System.Windows.Forms.ListView devView;
    }
}
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
            this.DeveloperListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // DeveloperListBox
            // 
            this.DeveloperListBox.ColumnWidth = 85;
            this.DeveloperListBox.FormattingEnabled = true;
            this.DeveloperListBox.HorizontalScrollbar = true;
            this.DeveloperListBox.Items.AddRange(new object[] {
            "Item 1, First Name",
            "Item 2, Last Name",
            "Item 3, Gender",
            "Item 4, Phone Extension"});
            this.DeveloperListBox.Location = new System.Drawing.Point(0, 0);
            this.DeveloperListBox.MultiColumn = true;
            this.DeveloperListBox.Name = "DeveloperListBox";
            this.DeveloperListBox.ScrollAlwaysVisible = true;
            this.DeveloperListBox.Size = new System.Drawing.Size(120, 95);
            this.DeveloperListBox.TabIndex = 0;
            // 
            // DeveloperHub
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.DeveloperListBox);
            this.Name = "DeveloperHub";
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


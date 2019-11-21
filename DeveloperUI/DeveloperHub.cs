using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeveloperUI.Properties;
using DeveloperCollections;
using DeveloperUI;


namespace DeveloperCollections
{


    public partial class DeveloperHub : Form
    {
        List<Developer> developers = new List<Developer>();

      
        public DeveloperHub()
        {
            
        }

        private void InitializeComponent()
        {
            ListBox DeveloperListBox = new ListBox();

            //DeveloperListBox.Size = new System.Drawing.Size(200, 100);
            //DeveloperListBox.Location = new System.Drawing.Point(10, 10);
            this.Controls.Add(DeveloperListBox); 
        
            this.DeveloperListBox = new System.Windows.Forms.ListBox();
            
            //this.SuspendLayout();

            this.DeveloperListBox.FormattingEnabled = true;
            this.DeveloperListBox.HorizontalScrollbar = true;
            this.DeveloperListBox.Items.AddRange(new object[]
            {
                "Item 1, First Name",
                "Item 2, Last Name",
                "Item 3, Gender",
                "Item 4, Phone Extension"
            });

           
            this.DeveloperListBox.MultiColumn = true;
            this.DeveloperListBox.ScrollAlwaysVisible = true;
            this.DeveloperListBox.Size = new System.Drawing.Size(300, 95);
            this.DeveloperListBox.TabIndex = 0;
            this.DeveloperListBox.ColumnWidth = 85; 
        }
        


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        Form frmAddDeveloper = new Form();

        private void AddDeveloperbtn_Click(object sender, EventArgs e)  //open the child form, add developer
        {
            //Call add developer form

            AddDeveloper frm = new AddDeveloper();
            frm.Show();
            
           
            
            


        }

        private void LoadDevelopersBtn_Click(object sender, EventArgs e)
        {
            DeveloperListBox.DisplayMember.ToString();
            
           
        }

        private void DisplayMenBtn_Click(object sender, EventArgs e)
        {

            //Need to compare the gender in the dev object 
            foreach(Developer developer in developers)
            {
                if(developer.Gender != "F") //Display the list in the listbox
                {
                    for (int i = 0; i < developers.Count; i++)
                    {
                        DeveloperListBox.Items.Add(developers.ElementAt(i));

                    }
                }
            }

            

          

        }

        private void DisplayWomenBtn_Click(object sender, EventArgs e)
        {

            //Need to compare the gender in the dev object 
            foreach (Developer developer in developers)
            {
                if (developer.Gender != "M") //Display the list in the listbox
                {
                    for (int i = 0; i < developers.Count; i++)  //Display the list in the listbox
                    {
                        DeveloperListBox.Items.Add(developers.ElementAt(i));

                    }
                }
            }


          
        }

        private void DisplayAllbtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < developers.Count; i++)
            {
                DeveloperListBox.Items.Add(developers.ElementAt(i));

            }
        }

        private void button1_Click(object sender, EventArgs e)  //remove btn need to rename the property on the UI      //Remove the  selected developer object from the list
        {
            if (DeveloperListBox.TopIndex != DeveloperListBox.SelectedIndex)
                DeveloperListBox.TopIndex = DeveloperListBox.SelectedIndex;

            for (int x = (DeveloperListBox.SelectedIndex -1); x >=0; x++)
            {
                DeveloperListBox.Items.RemoveAt(x); 
            }
        }

        private void RemoveAllbtn_Click(object sender, EventArgs e) //remove all the developers from the list, select the developer first
        {

            for (int x = (DeveloperListBox.SelectedIndex = -1); x >=0; x++) 
            {
                DeveloperListBox.Items.Clear();

            }

        }

        private void DeveloperListBox_SelectedIndexChanged(object sender, EventArgs e)  //display the current list of developers 
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

            DeveloperListBox.BeginUpdate();
            foreach( Developer developer in developers)
            {
                Console.WriteLine(); 
                   
            }

            DeveloperListBox.EndUpdate(); 
        }
    }

   class Developer
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneExtension { get; set; }
        public string Gender { get; set; }

        public string FullName { get; set; }
        public List<Developer> developers { get; set; }


        


        Developer developers1 = new Developer { FirstName = " Jay", LastName = "Frink", PhoneExtension = 6879, Gender = "M", FullName = "Jay Frink" };
        Developer developers2 = new Developer { FirstName = "Laura", LastName = "Talaat-Hamid", PhoneExtension = 8891, Gender = "F", FullName = "Laura Talaat-Hamid" };
        Developer developers3 = new Developer { FirstName = "Walter", LastName = "Snyder", PhoneExtension = 43389, Gender = "M", FullName = "Walter Snydedr" };
        Developer developers4 = new Developer { FirstName = "Christina", LastName = "Beckford", PhoneExtension = 9868, Gender = "F", FullName = "Christina Beckford" };
        Developer developers5 = new Developer { FirstName = "Peter", LastName = "Jackson", PhoneExtension = 2365, Gender = "M", FullName = "Peter Jackson" };
        Developer developers6 = new Developer { FirstName = "Bridget", LastName = "Pizzo", PhoneExtension = 5687, Gender = "F", FullName = "Bridget Pizzo" };
   

        public Developer(string firstName, string lastName, int phoneExtension, string gender)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;

            int PhoneExtension = 0;
            //int.TryParse(phoneExtension, out PhoneExtValue);
            PhoneExtension = phoneExtension;
             
            
        }
    }
}

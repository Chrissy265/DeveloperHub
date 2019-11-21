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
            
            
                frmAddDeveloper.Show(this);  //show the developer form 
                
            
            
            


        }

        private void LoadDevelopersBtn_Click(object sender, EventArgs e)
        {
            DeveloperListBox.DisplayMember.ToString();
            
           
        }

        private void DisplayMenBtn_Click(object sender, EventArgs e)
        {

            //Need to compare the gender in the dev object 

             


            //Display the list in the listbox

            for (int i = 0; i < developers.Count; i++)
            {
                DeveloperListBox.Items.Add(developers.ElementAt(i));

            }

        }

        private void DisplayWomenBtn_Click(object sender, EventArgs e)
        {

            //Need to compare the gender in the dev object 



            //Display the list in the listbox

            for (int i = 0; i < developers.Count; i++)
            {
                DeveloperListBox.Items.Add(developers.ElementAt(i));

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

        public string firstName { get; set; }
        public string lastName { get; set; }
        public int phoneExtension { get; set; }
        public string gender { get; set; }

        public string fullName { get; set; }
        private List<Developer> Dev { get; set; }





    }
}

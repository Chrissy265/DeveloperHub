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


namespace DeveloperCollections
{


    public partial class DeveloperHub : Form
    {
        List<Developer> Developers = new dev;

        public void loadDeveloper();

        public void displayWomen();


       
        public DeveloperHub()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddDeveloperbtn_Click(object sender, EventArgs e)
        {
            List<Developer> developers = new List<Developer>
            {
                new Developers { firstName = "Mike", lastName = "Smith", gender = "M", phoneExtension = 4899 },
                new Developers { firstName = "Laura", lastName = "Talaat", gender = "F", phoneExtension = 5869 },
                new Developers { firstName = "Peter", lastName = "Johnson", gender = "M", phoneExtension = 9884 },
                new Developers { firstName = "Bridget", lastName = "Pizzo", gender = "F", phoneExtension = 7889 }
            };


        }

        private void LoadDevelopersBtn_Click(object sender, EventArgs e)
        {

            loadDeveloper(List<Developer> Developers)  //load up the current list of developers and dis
            {
                foreach (Developers dev in Developers)
                {
                    displayAll(Developers);
                }

            }
        }

        private void DisplayMenBtn_Click(object sender, EventArgs e)
        {
             displayMen(List<Developer> dev)
            {
                if (gender == "M" && gender != null)
                {
                    Console.WriteLine("Male Developers" + dev);
                }
            }

        }

        private void DisplayWomenBtn_Click(object sender, EventArgs e)
        {
            displayWomen(List<Developer> dev)
            {
                if (gender == "W" && gender != null)
                {
                    Console.WriteLine("Women Developers" + dev);
                }
            }
        }

        private void DisplayAllbtn_Click(object sender, EventArgs e)
        {
            foreach (Developer developer in dev)
            {
                Console.Write(dev.ToString() + " ");
            }
        }

        private void button1_Click(object sender, EventArgs e)  //remove btn need to rename the property on the UI      //Remove the  selected developer object from the list
        {
            if (Dev != null)
            {
                Remove(dev);
            }

            return true;
        }

        private void RemoveAllbtn_Click(object sender, EventArgs e) //remove all the developers from the listbox
        {

            if (Dev != null)
            {
                Remove(dev);
            }

            return true;

        }
    }
}

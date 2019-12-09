using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeveloperUI
{
    public partial class DeveloperHub : Form
    {
        List<Developer> developers = new List<Developer>();
        //ObservableCollection<Developer> Dev { get; } = new ObservableCollection<Developer>();
        


        public DeveloperHub()
        {
            InitializeComponent();
            {
            }
        }

        private void DevView(object sender, EventArgs e)
        {
            ListView DevView = new ListView();

            DevView.View = View.Details;
            DevView.LabelEdit = true;
            DevView.GridLines = true;
            DevView.CheckBoxes = true;
            DevView.FullRowSelect = true;
            DevView.MultiSelect = true;


            DevView.Columns.Add("Full Name", 300, HorizontalAlignment.Left);

            DevView.Columns.Add("Gender", 70, HorizontalAlignment.Left);

            DevView.Columns.Add("Phone Extension", 70, HorizontalAlignment.Left);

            for (int i = 0; i < developers.Count; i++)
            {
                if (developers != null)
                {
                    ListViewItem viewItem = new ListViewItem(developers.ToString());


                }
            }

        }

        private void LoadDevList()
        {
            List<Developer> developers = new List<Developer>();

            devView.Items.Clear();

            for (int i = 0; i < developers.Count; i++)
            {
                if(developers !=null)
                {
                    ListViewItem viewItem = new ListViewItem(developers.ToString());

                   
                }
            }
        }
        
        private void DeveloperlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {

         

        }

        Form addDevfrm = new Form();
        private void AddDev_Click(object sender, EventArgs e)
        {

            //Call add developer for   

            addDevfrm.Show();

        }

        private void LoadDev_Click(object sender, EventArgs e)
        {
            //DeveloperListBox.DisplayMember.ToString();
           //DeveloperlistBox_SelectedIndexChanged.DataSource = developers;

            List<Developer> developers = new List<Developer>();

            devView.Items.Clear();

            for (int i = 0; i < developers.Count; i++)
            {
                if (developers != null)
                {
                    ListViewItem viewItem = new ListViewItem(developers.ToString());

                    devView.Items.Add(viewItem);
                }
            }


        }

        private void DisplayMen_Click(object sender, EventArgs e)
        {
            List<Developer> menDevs = new List<Developer>(); 
            //Need to compare the gender in the dev object 
            foreach (Developer developer in developers)
            {
             
                if (developer.Gender != "F") //Display the list in the listbox
                {
                    

                    devView.Items.Add(developer.ToString());
                   
                }
                


            }
           
        }

        private void DisplayWomen_Click(object sender, EventArgs e)
        {
            //Need to compare the gender in the dev object 
            foreach (Developer developer in developers)
            {
                if (developer.Gender != "M") //Display the list in the listbox
                {


                    devView.Items.Add(developer.ToString());
                    
                }

               
            }

        }

        private void DisplayAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < developers.Count; i++)
            {
                devView.Items.Add(developers.ToString());

            }
        }

        private void RemoveSelected_Click(object sender, EventArgs e)
        //{
        //    if (DeveloperlistBox.TopIndex != DeveloperlistBox.SelectedIndex)
        //        DeveloperlistBox.TopIndex = DeveloperlistBox.SelectedIndex;

        {
           for(int i =devView.Items.Count-1; i>=0; i--)
            {
                if(devView.Items[i].Selected)
                {
                    devView.Items[i].Remove(); 
                }
            }
        }

        private void RemoveAll_Click(object sender, EventArgs e)
        {
            for (int i = devView.Items.Count - 1; i >= 0; i--)
            {
                if(devView.Items[i].Selected)
                {
                    devView.Items[i].Remove(); 
                }
            }
        }

        private void DeveloperHub_Load(object sender, EventArgs e)
        {
            Developer developers1 = new Developer { FirstName = " Jay", LastName = "Frink", PhoneExtension = "6879", Gender = "M", FullName = "Jay Frink" };
            Developer developers2 = new Developer { FirstName = "Laura", LastName = "Talaat-Hamid", PhoneExtension = "8891", Gender = "F", FullName = "Laura Talaat-Hamid" };
            Developer developers3 = new Developer { FirstName = "Walter", LastName = "Snyder", PhoneExtension = "43389", Gender = "M", FullName = "Walter Snydedr" };
            Developer developers4 = new Developer { FirstName = "Christina", LastName = "Beckford", PhoneExtension = "9868", Gender = "F", FullName = "Christina Beckford" };
            Developer developers5 = new Developer { FirstName = "Peter", LastName = "Jackson", PhoneExtension = "2365", Gender = "M", FullName = "Peter Jackson" };
            Developer developers6 = new Developer { FirstName = "Bridget", LastName = "Pizzo", PhoneExtension = "5687", Gender = "F", FullName = "Bridget Pizzo" };

            developers.Add(developers1);
            developers.Add(developers2);
            developers.Add(developers3);
            developers.Add(developers4);
            developers.Add(developers5);
            developers.Add(developers6); 

            //Dev.Add(new Developer { FirstName = " Jay", LastName = "Frink", PhoneExtension = "6879", Gender = "M", FullName = "Jay Frink" });
            //Dev.Add(new Developer { FirstName = "Laura", LastName = "Talaat-Hamid", PhoneExtension = "8891", Gender = "F", FullName = "Laura Talaat-Hamid" });
            //Dev.Add(new Developer { FirstName = "Christina", LastName = "Beckford", PhoneExtension = "9868", Gender = "F", FullName = "Christina Beckford" });
            //Dev.Add(new Developer { FirstName = "Peter", LastName = "Jackson", PhoneExtension = "2365", Gender = "M", FullName = "Peter Jackson" });
            //Dev.Add(new Developer { FirstName = "Bridget", LastName = "Pizzo", PhoneExtension = "5687", Gender = "F", FullName = "Bridget Pizzo" });

           


        }

    
    }

    class Developer
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneExtension { get; set; }
        public string Gender { get; set; }

        public string FullName { get; set; }
        public List<Developer> developers { get; set; }
        //ObservableCollection<Developer> Dev { get { return Dev; } }

        
        //public Developer(string firstName, string lastName, string phoneExtension, string gender)
        //{
        //    FirstName = firstName;
        //    LastName = lastName;
        //    Gender = gender;
        //    PhoneExtension = phoneExtension;


        //    //int.TryParse(phoneExtension, out PhoneExtValue

        //}
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeveloperCollections;

namespace DeveloperCollections
{
   
        class Developers
        {

            public string firstName { get; set; }
            public string lastName { get; set; }
            public int phoneExtension { get; set; }
            public string gender { get; set; }

            public string fullName { get; set; }
            private List<Developers> Developer { get; set; }


        public void loadDeveloper(List<Developers> Developers)  //load up the current list of developers and dis
        {
            foreach (Developers dev in Developers)
            {
                displayAll(Developers);
            }

        }

        public void addDeveloper()
        {
            List<Developers> developers = new List<Developers>
            {
                new Developers { firstName = "Mike", lastName = "Smith", gender = "M", phoneExtension = 4899 },
                new Developers { firstName = "Laura", lastName = "Talaat", gender = "F", phoneExtension = 5869 },
                new Developers { firstName = "Peter", lastName = "Johnson", gender = "M", phoneExtension = 9884 },
                new Developers { firstName = "Bridget", lastName = "Pizzo", gender = "F", phoneExtension = 7889 }
            };




        }

        public void displayMen(List<Developers> developers)
        {
            if(gender == "M" && gender !=null)
            {
                Console.WriteLine("Male Developers" + developers); 
            }
        }

        public void displayWomen(List<Developers> developers)
        {
            if(gender =="W" && gender !=null)
            {
                Console.WriteLine("Women Developers" + developers); 
            }
        }


        public void displayAll(List<Developers> developers)
        {
            foreach ( Developers dev in developers)
            {
                Console.Write(dev.ToString() + " "); 
            }
        }

        public bool Remove(Developers developers)
        {
            //Remove the entire developer object from the collection
            if(Developer !=null)
            {
                Developer.Remove(developers);
            }
            
                return true; 
        }

        public bool RemoveAll(Developers developers)
        {

            if(Developer !=null)
            {
                Developer.Remove(developers);
            }

            return true; 
        }



       }




}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeveloperCollections; 

namespace DeveloperCollections
{
    class DevCollection
    {

       public DevCollection()
        {
            //var developers = new List<Developers>

            //developers.Add("PJ");
            //developers.Add("Walter");
            //developers.Add("Jay");
            //developers.Add("Christina");
            //developers.Add("Laura");
            //developers.Add("Bridget");




            //foreach (var dev in developers)
            //{
            //    Console.WriteLine(developers + "   "); 
            //}
        }

       public void DeveloperCollection()
        {
            var developers = new List<Developers>
            {
                new Developers() {firstName = "Peter", gender = "M"},
                new Developers() {firstName = "Laura", gender = "F"},
                new Developers() {firstName ="Bridget", gender = "F"},
                new Developers() {firstName ="Jay", gender="M"},
                new Developers() {firstName = "Walter", gender ="M"},
                new Developers() {firstName = "Christina", gender ="F"}; 



                foreach (Developers dev in developers)
                {
                 Console.WriteLine(dev.firstName + " "); 
                }



            };

        }

       
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeveloperCollections.Model;
using DeveloperUI.Properties



namespace DeveloperCollections
{
    public partial class DeveloperHub : Form
    {
        List<Developers> Developers = new dev;

       
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

        }

        private void LoadDevelopersBtn_Click(object sender, EventArgs e)
        {
          
            if(e !=null)
            {
                foreach (Developers dev in developers)
                {
                    Console.Write(dev.ToString() + " ");
                }

            }
        }

        
    }
}

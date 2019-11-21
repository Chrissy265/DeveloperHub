using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeveloperCollections;
using DeveloperCollections.DataAccess;


namespace DeveloperUI
{
    public partial class AddDeveloper : Form
    {
        IAddDeveloperRequester callingForm; 

        public AddDeveloper(IAddDeveloperRequester caller)
        {
            InitializeComponent();
            callingForm = caller;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void addDev(object sender, EventArgs e)
        {
           
            GlobalConfig.Connection.AddDeveloper(developer);
            callingForm.DeveloperComplete(developer);
            this.Close(); //close the addDeveloper form 
                 
        }
    }
}

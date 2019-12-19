using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace DeveloperUI
{
    public partial class AddDeveloper : Form
    {
        ISaveRequester callingForm; 

        public AddDeveloper(ISaveRequester caller)
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

        //private void AddDev(object sender, EventArgs e)
        //{
        //   if(ValidateForm())
        //    {
                

        //        //GlobalConfig.Connection.AddDevelopers();
        //        //callingForm.DeveloperComplete(developer);
        //        //this.Close(); //close the addDeveloper form 
        //    }
          
                 
        //}

        private bool ValidateForm()  //put in logic to valid the input on the form
        {
            throw new NotImplementedException();
        }
    }
}

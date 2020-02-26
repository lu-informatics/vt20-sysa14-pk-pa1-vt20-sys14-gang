using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsWebService
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowTxtFile_Click(object sender, EventArgs e)
        {
            OpenFileService.WebServiceAssignmentSoapClient client = new OpenFileService.WebServiceAssignmentSoapClient(); 
            string response = client.ShowFile(textBoxFileName.Text);
        
            lblResult.Text = response;



        }

        /*private void textBoxFileName_Click(object sender, EventArgs e)
        {

        }*/ 
    }
}

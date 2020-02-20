using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramKonstruktion
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
        }

        private TenantDAL tenantDal = new TenantDAL();
        private StorageDAL storageDal = new StorageDAL();
        private Tenant tenant = new Tenant();
        private Storage storage = new Storage();
       
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
   
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Button from view 1 has been clicked!!!");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            
                dateTxtBox.Text = monthCalendar.SelectionRange.Start.ToShortDateString();
            
        }

        private void ssnSearchTxt_TextChanged(object sender, EventArgs e)
        {
            TextBox ssnSearchTxt = (TextBox)sender;
            string inputSsn = ssnSearchTxt.Text;
            

            
        }

        private void dateTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchTenantBtn_Click(object sender, EventArgs e)
        {
            

        }

        private void bookBtn_Click(object sender, EventArgs e)
        {

        }

        private void dataGridBookings_CellContentClick (object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void addStorageBtn_Click(object sender, EventArgs e)
        {
            string nbr = storageNbrTxt.Text;
            //float price = stora

        }

        private void GUI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeIT2DataSet1.Tenant' table. You can move, or remove it, as needed.
            this.tenantTableAdapter.Fill(this.storeIT2DataSet1.Tenant);
            // TODO: This line of code loads data into the 'storeIT2DataSet.Storage' table. You can move, or remove it, as needed.
            this.storageTableAdapter.Fill(this.storeIT2DataSet.Storage);

        }

        private void updateStorage_Click(object sender, EventArgs e)
        {

        }
    }
}

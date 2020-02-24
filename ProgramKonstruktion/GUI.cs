using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            SetAllStoragesToComboBox();


        }

        private TenantDAL tenantDal = new TenantDAL();
        private StorageDAL storageDal = new StorageDAL();
        private Tenant tenant = new Tenant();
        private Storage storage = new Storage();
        private PK2DAL PK2Dal = new PK2DAL();


       

        public void SetAllStoragesToComboBox()

        {
            comboBoxStorage.Items.Clear();
            comboBoxStorage.Text = "Select available storage";
            List<Storage>  listOfStorage = storageDal.listOfAvailableStorages();
            Console.WriteLine(listOfStorage.Count);
            foreach (Storage s in listOfStorage)
            {

                comboBoxStorage.Items.Add(s);

            }

        }

       

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
            cleanBoxes();
            tenant.Ssn = ssnSearchTxt.Text;

            tenant = tenantDal.FindTenant(ssnSearchTxt.Text);

            errorBoxBooking.Text = "Tenant: " + tenant.Ssn + ", " + tenant.Name + ", " + tenant.Email;
    
        }

        //Book tenant on Storage
        private void bookBtn_Click(object sender, EventArgs e)
        {
            cleanBoxes();
            tenant.Ssn = ssnBookTxt.Text;
            tenant.Name = tenantNameTxt.Text;
            tenant.PhoneNbr = phoneNbrTxt.Text;
            tenant.Email = emailTxt.Text;
            
            Object selectedItem = comboBoxStorage.SelectedItem;
            var selected = this.comboBoxStorage.GetItemText(this.comboBoxStorage.SelectedItem);
            tenant.StorageNbr = selected;
            tenant.StorageAddress = "Fågelvägen 43"; //databasen ska ändras till att alla storage ligger på fågelvägen 43 eller om fk inte ska vara en kombo:)
           
            tenant.RentDate = monthCalendar.SelectionRange.Start;
            tenantDal.CreateTenant(tenant);
            Boolean added = tenantDal.CreateTenant(tenant);
            if (!added)
            {
                errorBoxBooking.Text = "Failed to add booking, try again.";
            }
            else
            {
                errorBoxBooking.Text = "Booking completed.";
            }
            this.tenantTableAdapter.Fill(this.storeIT2DataSet1.Tenant);
            cleanTextFields();


        }
        private void dataGridBookings_CellContentClick (object sender, DataGridViewCellEventArgs e)
        {
           

        }
        //fungerar
        private void addStorageBtn_Click(object sender, EventArgs e)
        {
            storage.Nbr = storageNbrTxt.Text;
            storage.Address = storageLocationTxt.Text;
            //ToSingle eller ToDouble?
            storage.Price = (float)Convert.ToDouble(storagePriceTxt.Text);
            storage.Size = (float)Convert.ToSingle(storageSizeTxt.Text);
           

            Boolean added = storageDal.CreateStorage(storage);
            if (!added)
            {
                    errorBoxUpdateStorages.Text = "Failed to add, try again";
                }
             else if (!(storage.Address.Equals("Fågelvägen 43")))
                    {

                errorBoxUpdateStorages.Text = "We dont have storages on this address, try with Fågelvägen 43";
                    }

          
                else if (added) { 
                    errorBoxUpdateStorages.Text = "Storage was added succefully!";
                     cleanTextFields();
                     this.storageTableAdapter.Fill(this.storeIT2DataSet.Storage);
                     SetAllStoragesToComboBox();
            }

            
          
            
            


        }

        private void GUI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeIT2DataSet3.Storage' table. You can move, or remove it, as needed.
            this.storageTableAdapter1.Fill(this.storeIT2DataSet3.Storage);
            // TODO: This line of code loads data into the 'storeIT2DataSet2.Tenant' table. You can move, or remove it, as needed.
            this.tenantTableAdapter1.Fill(this.storeIT2DataSet2.Tenant);
            // TODO: This line of code loads data into the 'storeIT2DataSet1.Tenant' table. You can move, or remove it, as needed.
            this.tenantTableAdapter.Fill(this.storeIT2DataSet1.Tenant);
            // TODO: This line of code loads data into the 'storeIT2DataSet.Storage' table. You can move, or remove it, as needed.
            this.storageTableAdapter.Fill(this.storeIT2DataSet.Storage);

        }

        //delete tenantBooking
        private void deleteBookingBtn_Click(object sender, EventArgs e)
        {
            cleanBoxes();
            tenant.Ssn = (string)dataGridBookings.Rows[dataGridBookings.CurrentCell.RowIndex].Cells[0].Value;

            Boolean deleted = tenantDal.DeleteTenant(tenant.Ssn);

            if (!deleted)
            {
                errorBoxBooking.Text = "Failed to delete, try again!";
            }
            else
            {
                errorBoxBooking.Text = "Booking with ssn: " + tenant.Ssn + " was deleted succefully!";
                this.tenantTableAdapter.Fill(this.storeIT2DataSet1.Tenant);
                cleanTextFields();


            }
           

        }

        private void dataGridStorages_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        //delete storage
        private void button8_Click(object sender, EventArgs e)
        {
            cleanBoxes();
            storage.Nbr = (string)dataGridStorages.Rows[dataGridStorages.CurrentCell.RowIndex].Cells[0].Value;
            storage.Address = (string)dataGridStorages.Rows[dataGridStorages.CurrentCell.RowIndex].Cells[3].Value;

            Boolean deleted = storageDal.DeleteStorage(storage.Nbr, storage.Address);
            if (!deleted)
            {
                errorBoxUpdateStorages.Text = "Failed, try again";

            }
            else
                errorBoxUpdateStorages.Text = "Storage with nbr: " + storage.Nbr + " was deleted succefully!";
                this.storageTableAdapter.Fill(this.storeIT2DataSet.Storage);
                this.tenantTableAdapter.Fill(this.storeIT2DataSet1.Tenant);
                cleanTextFields();
                SetAllStoragesToComboBox();

        }


        private void storageLocationTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxStorage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void updateTenantBtn_Click(object sender, EventArgs e)
        {
            cleanBoxes();
            tenant.Ssn = ssnBookTxt.Text;
            tenant.Name = tenantNameTxt.Text;
            tenant.PhoneNbr = phoneNbrTxt.Text;
            tenant.Email = emailTxt.Text;

            Tenant updated = tenantDal.UpdateTenant(tenant.Ssn, tenant.Name, tenant.PhoneNbr, tenant.Email);

            if(updated == null)
            {
                errorBoxBooking.Text = "Failed to update, try again!";
            } 
            else
            {
                errorBoxBooking.Text = "Tenant with ssn: " + tenant.Ssn + " was updated succefully!";
            }
            this.tenantTableAdapter.Fill(this.storeIT2DataSet1.Tenant);
            cleanTextFields();

        }

        private void updateStorageBtn_Click(object sender, EventArgs e)
        {
            cleanBoxes();
            storage.Nbr = storageNbrTxt.Text;
            storage.Address = storageLocationTxt.Text;
            //ToSingle eller ToDouble?
            storage.Price = (float)Convert.ToSingle(storagePriceTxt.Text);
            storage.Size = (float)Convert.ToSingle(storageSizeTxt.Text);


            Storage updated = storageDal.UpdateStorage(storage.Nbr, storage.Address, storage.Price, storage.Size);
            if (updated == null)
            {
                errorBoxUpdateStorages.Text = "Failed to update, try again";
            }
            else
            {
                errorBoxUpdateStorages.Text = "Storage with nbr: " + updated.Nbr + " was updated succefully!";

            }

            this.storageTableAdapter.Fill(this.storeIT2DataSet.Storage);
            cleanTextFields();
        }



        private void storageSearchBtn_Click(object sender, EventArgs e)
        {
            cleanBoxes();
            storage.Nbr = storageNmbrSearch.Text;
            storage.Address = storageAddressSearch.Text;

            storage = storageDal.FindStorage(storageNmbrSearch.Text, storageAddressSearch.Text);

            errorBoxUpdateStorages.Text = "Storage: " + storage.Nbr + ", " + storage.Address;

            cleanTextFields();
        }

        public void cleanBoxes()
        {
            errorBoxUpdateStorages.Text = "";
            errorBoxBooking.Text = "";
        }

        public void cleanTextFields()
        {
            
            ssnBookTxt.Text = "";
            tenantNameTxt.Text = "";
            comboBoxStorage.Text = "Select storage";
            phoneNbrTxt.Text = "";
            emailTxt.Text = "";
            ssnSearchTxt.Text = "";
            dateTxtBox.Text = "Select date";
            storageNbrTxt.Text = "";
            storageSizeTxt.Text = "";
            storagePriceTxt.Text = "";
            storageLocationTxt.Text = "";
            
        }

        private void phoneNbrTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void allColumnNamesBtn_Click(object sender, EventArgs e)
        {

        //SqlDataAdapter adp = new SqlDataAdapter(PK2Dal.AllColumnNames);

            //DataTable dt = new DataTable();

            //this.dataGridProgram2.DataSource = adp.Fill(dt);

        
            this.dataGridPK2.DataSource = null;
            this.dataGridPK2.Rows.Clear();

            //List<String> columns = PK2Dal.AllColumnNames();
             //foreach (String s in columns)
             //{

            // }
            
            this.dataGridPK2.DataSource = (PK2Dal.AllColumnNames());

        }

        private void dataGridProgram2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void numberOfRowsBtn_Click(object sender, EventArgs e)
        {
            this.dataGridPK2.DataSource = null;
            this.dataGridPK2.Rows.Clear();
            this.dataGridPK2.DataSource = (PK2Dal.NumberOfRows());
        }
    }
    }

  
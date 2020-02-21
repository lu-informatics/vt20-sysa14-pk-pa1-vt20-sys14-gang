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
            SetAllStoragesToComboBox();
           


    }

        private TenantDAL tenantDal = new TenantDAL();
        private StorageDAL storageDal = new StorageDAL();
        private Tenant tenant = new Tenant();
        private Storage storage = new Storage();
       

        public void SetAllStoragesToComboBox()
        {
            comboBoxStorage.Text = "Select available storage";
            List<Storage> listOfStorage = storageDal.listOfAvailableStorages();
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
            

        }

        private void bookBtn_Click(object sender, EventArgs e)
        {
            cleanBoxes();
            tenant.Ssn = ssnBookTxt.Text;
            tenant.Name = tenantNameTxt.Text;
            tenant.PhoneNbr = phoneNbrTxt.Text;
            tenant.Email = emailTxt.Text;
            // Storage storage = comboBoxStorage
            
            Object selectedItem = comboBoxStorage.SelectedItem;
            var selected = this.comboBoxStorage.GetItemText(this.comboBoxStorage.SelectedItem);

          //  tenant.StorageAddress = comboBoxStorage.SelectedValue.ToString();
            tenant.RentDate = monthCalendar.SelectionRange.Start;

            tenantDal.CreateTenant(tenant);

        }
        private void dataGridBookings_CellContentClick (object sender, DataGridViewCellEventArgs e)
        {
           

        }
        //fungerar
        private void addStorageBtn_Click(object sender, EventArgs e)
        {
            storage.Nbr = storageNbrTxt.Text;
            storage.Address = storagePriceTxt.Text;
            //ToSingle eller ToDouble?
            storage.Price = (float)Convert.ToSingle(storageLocationTxt.Text);
            storage.Size = (float)Convert.ToSingle(storageSizeTxt.Text);
           

            Boolean added = storageDal.CreateStorage(storage);
            if (!added)
            {
                    errorBoxUpdateStorages.Text = "Failed to add, try again";
                }
                else { 
                    errorBoxUpdateStorages.Text = "Storage was added succefully!";
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

        private void updateStorage_Click(object sender, EventArgs e)
        {

        }

        //delete tenantBooking
        private void deleteBookingBtn_Click(object sender, EventArgs e)
        {
            cleanBoxes();
            string ssn = (string)dataGridBookings.Rows[dataGridBookings.CurrentCell.RowIndex].Cells[0].Value;

            Boolean deleted = tenantDal.DeleteTenant(ssn);

            if (!deleted)
            {
                errorBoxBooking.Text = "Failed to delete, try again!";
            }
            else
            {
                errorBoxBooking.Text = "Booking with ssn: " + tenant.Ssn + " was deleted succefully!";
                
                
            }

        }

        private void dataGridStorages_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //fungerar ej
        private void button8_Click(object sender, EventArgs e)
        {
            cleanBoxes();
            string ssn = (string)dataGridStorages.Rows[dataGridStorages.CurrentCell.RowIndex].Cells[0].Value;
            string address = (string)dataGridStorages.Rows[dataGridStorages.CurrentCell.RowIndex].Cells[3].Value;

            Boolean deleted = storageDal.DeleteStorage(ssn, address);
            if (!deleted)
            {
                errorBoxUpdateStorages.Text = "Failed, try again";
            }
            else
                errorBoxUpdateStorages.Text = "Storage was deleted succefully!";

           
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

        }

        private void updateStorageBtn_Click(object sender, EventArgs e)
        {
            cleanBoxes();
            storage.Nbr = storageNbrTxt.Text;
            storage.Address = storagePriceTxt.Text;
            //ToSingle eller ToDouble?
            storage.Price = (float)Convert.ToSingle(storageLocationTxt.Text);
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
        }

        public void cleanBoxes()
        {
            errorBoxUpdateStorages.Text = "";
            errorBoxBooking.Text = "";


        }
    }
    }

  
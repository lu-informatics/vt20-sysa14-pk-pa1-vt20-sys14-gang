﻿using ProgramKonstruktion.ERP1WebRef;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            setDataToShowComboBox();



        }

        private TenantDAL tenantDal = new TenantDAL();
        private StorageDAL storageDal = new StorageDAL();
        private Tenant tenant = new Tenant();
        private Storage storage = new Storage();
        private Employee employee = new Employee();
        private PK2DAL PK2Dal = new PK2DAL();
        private EmployeeDAL emplyeeDal = new EmployeeDAL();
        private ERP1WebService erpWebService = new ERP1WebService();
        private ErrorHandler eh = new ErrorHandler();



        public void SetAllStoragesToComboBox()

        {
            comboBoxStorage.Items.Clear();
            comboBoxStorage.Text = "Select available storage";
            List<Storage> listOfStorage = storageDal.listOfAvailableStorages();
            Console.WriteLine(listOfStorage.Count);
            foreach (Storage s in listOfStorage)
            {

                comboBoxStorage.Items.Add(s);

            }

        }

        public void setDataToShowComboBox()
        {
            comboBoxChooseData.Items.Add("Content and metadata for Employee tables");
            comboBoxChooseData.Items.Add("Employees and their relatives");
            comboBoxChooseData.Items.Add("Sick employees 2004");
            comboBoxChooseData.Items.Add("Most absent employee");
            comboBoxChooseData.Items.Add("Metadata: Keys");
            comboBoxChooseData.Items.Add("Metadata: Indexes");
            comboBoxChooseData.Items.Add("Metadata: Table constraint");
            comboBoxChooseData.Items.Add("Metadata: All tables");
            comboBoxChooseData.Items.Add("Metadata: All columns");


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
            //TextBox ssnSearchTxt = (TextBox)sender;
            //string inputSsn = ssnSearchTxt.Text;



        }

        private void dateTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchTenantBtn_Click(object sender, EventArgs e)
        {
            cleanBoxes();

            dataGridBookings.DataSource = tenantDal.findTenants(ssnSearchTxt.Text);

            //tenant.Ssn = ssnSearchTxt.Text;

            //tenant = tenantDal.FindTenant(ssnSearchTxt.Text);

            //errorBoxBooking.Text = "Tenant: " + tenant.Ssn + ", " + tenant.Name + ", " + tenant.Email;

        }

        //Book tenant on Storage
        private void bookBtn_Click(object sender, EventArgs e)
        {
            cleanBoxes();
            tenant.Ssn = ssnBookTxt.Text;
            tenant.Name = tenantNameTxt.Text;
            tenant.PhoneNbr = phoneNbrTxt.Text;
            tenant.Email = emailTxt.Text;
            cleanTextFields();

            Object selectedItem = comboBoxStorage.SelectedItem;
            var selected = this.comboBoxStorage.GetItemText(this.comboBoxStorage.SelectedItem);
            tenant.StorageNbr = selected;
            tenant.RentDate = monthCalendar.SelectionRange.Start;
            //Boolean added = tenantDal.CreateTenant(tenant);


            if (string.IsNullOrEmpty(ssnBookTxt.Text) || string.IsNullOrEmpty(tenantNameTxt.Text) || string.IsNullOrEmpty(phoneNbrTxt.Text) || string.IsNullOrEmpty(emailTxt.Text))
            {
                errorBoxBooking.Text = "Please fill out all fields.";
            }
            else if (!(Regex.IsMatch(ssnBookTxt.Text, @"^[a-zA-Z]+$") || Regex.IsMatch(tenantNameTxt.Text, @"^[a-zA-Z]+$") || Regex.IsMatch(phoneNbrTxt.Text, @"^[a-zA-Z]+$") || Regex.IsMatch(emailTxt.Text, @"^[a-zA-Z]+$")))
            {
                errorBoxBooking.Text = "Please fill in the fields with right value";
            }
            else
            {
                Boolean added = tenantDal.CreateTenant(tenant);  
               
                if (added)
                {
                    errorBoxBooking.Text = "Booking completed.";
                    this.tenantTableAdapter4.Fill(this.sTOREITNEWDataSet.Tenant);

                    SetAllStoragesToComboBox();
                }

                else if (!added)
                {
                    errorBoxBooking.Text = "Failed to add booking, try again.";
                }

                
            }

            
        }

        private void dataGridBookings_CellContentClick (object sender, DataGridViewCellEventArgs e)
        {
           

        }
        //addstorage
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

           else if (added)
            {
                errorBoxUpdateStorages.Text = "Storage was added succefully!";
                cleanTextFields();
                this.storageTableAdapter3.Fill(this.sTOREITNEWDataSet1.Storage);//this.storageTableAdapter2.Fill(this.storeIT3DataSet1.Storage);
                SetAllStoragesToComboBox();
            }

        }

        

        private void GUI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sTOREITNEWDataSet1.Storage' table. You can move, or remove it, as needed.
            this.storageTableAdapter3.Fill(this.sTOREITNEWDataSet1.Storage);
            // TODO: This line of code loads data into the 'sTOREITNEWDataSet.Tenant' table. You can move, or remove it, as needed.
            this.tenantTableAdapter4.Fill(this.sTOREITNEWDataSet.Tenant);
            // TODO: This line of code loads data into the 'storeIT3DataSet2.Tenant' table. You can move, or remove it, as needed.
          //  this.tenantTableAdapter3.Fill(this.storeIT3DataSet2.Tenant);
            // TODO: This line of code loads data into the 'storeIT3DataSet1.Storage' table. You can move, or remove it, as needed.
          //  this.storageTableAdapter2.Fill(this.storeIT3DataSet1.Storage);
            // TODO: This line of code loads data into the 'storeIT3DataSet.Tenant' table. You can move, or remove it, as needed.
           // this.tenantTableAdapter2.Fill(this.storeIT3DataSet.Tenant);
            // TODO: This line of code loads data into the 'storeIT2DataSet3.Storage' table. You can move, or remove it, as needed.
            //this.storageTableAdapter1.Fill(this.storeIT2DataSet3.Storage);
            // TODO: This line of code loads data into the 'storeIT2DataSet2.Tenant' table. You can move, or remove it, as needed.
          // this.tenantTableAdapter1.Fill(this.storeIT2DataSet2.Tenant);
            // TODO: This line of code loads data into the 'storeIT2DataSet1.Tenant' table. You can move, or remove it, as needed.
           // this.tenantTableAdapter.Fill(this.storeIT2DataSet1.Tenant);
            // TODO: This line of code loads data into the 'storeIT2DataSet.Storage' table. You can move, or remove it, as needed.
           // this.storageTableAdapter.Fill(this.storeIT2DataSet.Storage);

           

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
                this.tenantTableAdapter4.Fill(this.sTOREITNEWDataSet.Tenant);
                cleanTextFields();
                SetAllStoragesToComboBox();

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
            //storage.Address = (string)dataGridStorages.Rows[dataGridStorages.CurrentCell.RowIndex].Cells[3].Value;

            Boolean deleted = storageDal.DeleteStorage(storage.Nbr);
            if (!deleted)
            {
                errorBoxUpdateStorages.Text = "Failed, try again";

            }
            else
                errorBoxUpdateStorages.Text = "Storage with nbr: " + storage.Nbr + " was deleted succefully!";

            this.storageTableAdapter3.Fill(this.sTOREITNEWDataSet1.Storage);
            this.tenantTableAdapter4.Fill(this.sTOREITNEWDataSet.Tenant);
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
                this.tenantTableAdapter4.Fill(this.sTOREITNEWDataSet.Tenant);
                cleanTextFields();
            }
            

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
                errorBoxUpdateStorages.Text = "Storage with nbr: " + storage.Nbr + " was updated succefully!";
                this.storageTableAdapter3.Fill(this.sTOREITNEWDataSet1.Storage);
                cleanTextFields();

            }

            
        }



        private void storageSearchBtn_Click(object sender, EventArgs e)
        {
            cleanBoxes();
    
            
            storage.Nbr = storageNmbrSearch.Text;
            

            dataGridStorages.DataSource = storageDal.FindStorages(storageNmbrSearch.Text);
            // storage.Address = storageAddressSearch.Text;

            //storage = storageDal.FindStorage(storageNmbrSearch.Text);

            //errorBoxUpdateStorages.Text = "Storage: " + storage.Nbr;

            //cleanTextFields();
        }

        public void cleanBoxes()
        {
            errorBoxUpdateStorages.Text = "";
            errorBoxBooking.Text = "";
            richTextBox1.Text = "";
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
            noTextBox.Text = "";
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            jobTitleTextBox.Text = "";
            addressTextBox.Text = "";
            phoneNumberTextBox.Text = "";
            emailTextBox.Text = "";
            ssnTextBox.Text = "";
            noTextBoxSearch.Text = "";



        }

        private void allColumnNamesBtn_Click(object sender, EventArgs e)
        {
                dataGridProgram2.DataSource = PK2Dal.ShowAllColumnNames();
        }

        private void dataGridProgram2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void numberOfRowsBtn_Click(object sender, EventArgs e)
        {
            dataGridProgram2.DataSource = PK2Dal.ShowNumberOfRows();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewServWebMeta.WebServiceERP12SoapClient client = new NewServWebMeta.WebServiceERP12SoapClient(); 
            //WebServiceNew.WebServiceERP12SoapClient client2 = new WebServiceNew.WebServiceERP12SoapClient();
            //OpenFileService.WebServiceAssignmentSoapClient client = new OpenFileService.WebServiceAssignmentSoapClient();
            string response = client.ShowFile(textBoxFileName.Text); 
            //string response = client.ShowFile(textBoxFileName.Text);

            lblResult.Text = response;

        }

        private void integrations2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void noTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        //Add Employee
        private void button4_Click(object sender, EventArgs e)
        {
            cleanBoxes();

            string no = noTextBox.Text;
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string jobTitle = jobTitleTextBox.Text;
            string address = addressTextBox.Text;
            string phoneNumber = phoneNumberTextBox.Text;
            string ssn = ssnTextBox.Text;
            string email = emailTextBox.Text;


            ERP1WebRef.Employee emp = new ERP1WebRef.Employee();

        
           emp = erpWebService.CreateEmployee(no, firstName, lastName, jobTitle, address, phoneNumber, ssn, email);

            if (emp == null)
            {
                richTextBox1.Text = "Failed to create employee, try again!";
            }
            else
            {
                richTextBox1.Text = "Employee added!";
                cleanTextFields();
            }






        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        //Find Employee
        private void button7_Click(object sender, EventArgs e)
        {
            cleanBoxes();
            string no = noTextBoxSearch.Text;

            ERP1WebRef.Employee emp = new ERP1WebRef.Employee();

            emp = erpWebService.FindEmployee(no);

            if (emp == null)
            {
                richTextBox1.Text = "Could not find employee, try again!";
            }
            else
            {

                richTextBox1.Text = "Employee with lastname: " + emp.LastName + ", Jobtitle: " + emp.JobTitle + ", Email: " + emp.Email;
                cleanTextFields();
            }


        }

        //Delete employee
        private void button6_Click(object sender, EventArgs e)
        {
            cleanBoxes();
            string no = noTextBoxSearch.Text;

             Boolean deleted =  erpWebService.DeleteEmployee(no);

            if (!deleted)
            {
                richTextBox1.Text = "Failed to delete, try again";
            }
            else
            {
                richTextBox1.Text = "Employee deleted!";
                cleanTextFields();
            }

        }

        //update Employee
        private void button5_Click(object sender, EventArgs e)
        {
            cleanBoxes();

            string no = noTextBox.Text;
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string jobTitle = jobTitleTextBox.Text;
            string address = addressTextBox.Text;
            string phoneNumber = phoneNumberTextBox.Text;
            string ssn = ssnTextBox.Text;
            string email = emailTextBox.Text;


            ERP1WebRef.Employee emp = new ERP1WebRef.Employee();

            emp = erpWebService.UpdateEmployee(no, firstName,lastName, jobTitle,address, phoneNumber, email);

            if (!(ssn.Equals(""))){
                richTextBox1.Text = "Can't update ssn, remove and try again!";
            }
               else if (emp == null) {
                richTextBox1.Text = "Can't update employee, try again!";
          
            } else
            {
                richTextBox1.Text = "Employee is updated!";
                cleanTextFields();
            }
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void runButton_Click(object sender, EventArgs e)
        {

            Object selectedItem = comboBoxChooseData.SelectedItem;
            var selected = this.comboBoxChooseData.GetItemText(this.comboBoxChooseData.SelectedItem);
            string choosenData = selected;

            //NewServWebMeta.WebServiceERP12SoapClient client = new NewServWebMeta.WebServiceERP12SoapClient(); 

            if (choosenData.Equals("Content and metadata for Employee tables"))
            {
                dataGridView3.Rows.Clear();
                NewWebRef.WebServiceERP12SoapClient c = new NewWebRef.WebServiceERP12SoapClient();
               // NewServWebMeta.WebServiceERP12SoapClient client = new NewServWebMeta.WebServiceERP12SoapClient();
                List<string> listOfRelatives = new List<string>(c.ShowContentOfCronusDataTable()); //OBS Fel!
                dataGridView3.Columns.Add(" ", " ");
                foreach (string s in listOfRelatives)
                {
                    dataGridView3.Rows.Add(s);
                }

            }
            else if(choosenData.Equals("Employees and their relatives"))
            {
                dataGridView3.Rows.Clear();
                NewWebRef.WebServiceERP12SoapClient c = new NewWebRef.WebServiceERP12SoapClient();
                //NewServWebMeta.WebServiceERP12SoapClient client = new NewServWebMeta.WebServiceERP12SoapClient();
                List<string> listOfRelatives = new List<string>(c.EmployeeAndRelatives());
                dataGridView3.Columns.Add(" ", " "); 
                foreach(string s in listOfRelatives)
                {
                    dataGridView3.Rows.Add(s); 
                }
               
            }
            else if(choosenData.Equals("Sick employees 2004"))
            {
                dataGridView3.Rows.Clear();
                NewWebRef.WebServiceERP12SoapClient c = new NewWebRef.WebServiceERP12SoapClient();
                //NewServWebMeta.WebServiceERP12SoapClient client = new NewServWebMeta.WebServiceERP12SoapClient();
                List<string> listOfRelatives = new List<string>(c.ShowSickEmployees2004());
                dataGridView3.Columns.Add(" ", " ");
                foreach (string s in listOfRelatives)
                {
                    dataGridView3.Rows.Add(s);
                }

            }
            else if(choosenData.Equals("Most absent employee"))
            {
                dataGridView3.Rows.Clear();
                NewWebRef.WebServiceERP12SoapClient c = new NewWebRef.WebServiceERP12SoapClient();
               // NewServWebMeta.WebServiceERP12SoapClient client = new NewServWebMeta.WebServiceERP12SoapClient();
                List<string> listOfRelatives = new List<string>(c.MostAbsentEmployees());
                dataGridView3.Columns.Add(" ", " ");
                foreach (string s in listOfRelatives)
                {
                    dataGridView3.Rows.Add(s);
                }

            }
            else if(choosenData.Equals("Metadata: Keys"))
            {
                dataGridView3.Rows.Clear();
                NewWebRef.WebServiceERP12SoapClient c = new NewWebRef.WebServiceERP12SoapClient();
                //NewServWebMeta.WebServiceERP12SoapClient client = new NewServWebMeta.WebServiceERP12SoapClient();
                List<string> listOfRelatives = new List<string>(c.AllKeys());
                dataGridView3.Columns.Add(" ", " ");
                foreach (string s in listOfRelatives)
                {
                    dataGridView3.Rows.Add(s);
                }

            }
            else if(choosenData.Equals("Metadata: Indexes"))
            {
                dataGridView3.Rows.Clear();
                NewWebRef.WebServiceERP12SoapClient c = new NewWebRef.WebServiceERP12SoapClient();
               // NewServWebMeta.WebServiceERP12SoapClient client = new NewServWebMeta.WebServiceERP12SoapClient();
                List<string> listOfRelatives = new List<string>(c.AllIndexes());
                dataGridView3.Columns.Add(" ", " ");
                foreach (string s in listOfRelatives)
                {
                    dataGridView3.Rows.Add(s);
                }
            }
            else if(choosenData.Equals("Metadata: Table constraint"))
            {
                dataGridView3.Rows.Clear();
                NewWebRef.WebServiceERP12SoapClient c = new NewWebRef.WebServiceERP12SoapClient();
               // NewServWebMeta.WebServiceERP12SoapClient client = new NewServWebMeta.WebServiceERP12SoapClient();
                List<string> listOfRelatives = new List<string>(c.AllTableConstrains());
                dataGridView3.Columns.Add(" ", " ");
                foreach (string s in listOfRelatives)
                {
                    dataGridView3.Rows.Add(s);
                }
            }
            else if (choosenData.Equals("Metadata: All tables"))
            {
                dataGridView3.Rows.Clear();
                NewWebRef.WebServiceERP12SoapClient c = new NewWebRef.WebServiceERP12SoapClient();
                //NewServWebMeta.WebServiceERP12SoapClient client = new NewServWebMeta.WebServiceERP12SoapClient();
                List<string> listOfRelatives = new List<string>(c.AllTablesInDatabaseSolOne());
                dataGridView3.Columns.Add(" ", " ");
                foreach (string s in listOfRelatives)
                {
                    dataGridView3.Rows.Add(s);
                }
            }
            else if(choosenData.Equals("Metadata: All columns"))
            {
                dataGridView3.Rows.Clear();
                NewWebRef.WebServiceERP12SoapClient c = new NewWebRef.WebServiceERP12SoapClient();
               // NewServWebMeta.WebServiceERP12SoapClient client = new NewServWebMeta.WebServiceERP12SoapClient();
                List<string> listOfRelatives = new List<string>(c.AllColEmpTableSolOne());
                dataGridView3.Columns.Add(" ", " ");
                foreach (string s in listOfRelatives)
                {
                    dataGridView3.Rows.Add(s);
                }
            }
                // dataGridProgram2.DataSource = PK2Dal.ShowAllColumnNames();


            
        }

        private void showAllBookingsBtn_Click(object sender, EventArgs e)
        {
            dataGridBookings.DataSource = tenantDal.ShowAllBookings();
        }

        private void showAllStorages_Click(object sender, EventArgs e)
        {
            dataGridStorages.DataSource = storageDal.ShowAllStorages();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

  
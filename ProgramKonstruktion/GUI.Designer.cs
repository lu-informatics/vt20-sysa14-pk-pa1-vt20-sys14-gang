namespace ProgramKonstruktion
{
    partial class GUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.bookStorage = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.comboBoxStorage = new System.Windows.Forms.ComboBox();
            this.deleteBookingBtn = new System.Windows.Forms.Button();
            this.dataGridBookings = new System.Windows.Forms.DataGridView();
            this.ssnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNbrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storageNbrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storageAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeIT2DataSet1 = new ProgramKonstruktion.StoreIT2DataSet1();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ssnBookTxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.errorBoxBooking = new System.Windows.Forms.RichTextBox();
            this.updateTenantBtn = new System.Windows.Forms.Button();
            this.bookBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ssnSearchTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.phoneNbrTxt = new System.Windows.Forms.TextBox();
            this.tenantNameTxt = new System.Windows.Forms.TextBox();
            this.searchTenantBtn = new System.Windows.Forms.Button();
            this.updateStorage = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.errorBoxUpdateStorages = new System.Windows.Forms.RichTextBox();
            this.storageSearchBtn = new System.Windows.Forms.Button();
            this.storageNmbrSearch = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.updateStorageBtn = new System.Windows.Forms.Button();
            this.addStorageBtn = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridStorages = new System.Windows.Forms.DataGridView();
            this.nbrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeIT2DataSet = new ProgramKonstruktion.StoreIT2DataSet();
            this.storageLocationTxt = new System.Windows.Forms.TextBox();
            this.storagePriceTxt = new System.Windows.Forms.TextBox();
            this.storageSizeTxt = new System.Windows.Forms.TextBox();
            this.storageNbrTxt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.programkonst2 = new System.Windows.Forms.TabPage();
            this.numberOfRowsBtn = new System.Windows.Forms.Button();
            this.allColumnNamesBtn = new System.Windows.Forms.Button();
            this.dataGridProgram2 = new System.Windows.Forms.DataGridView();
            this.integration1 = new System.Windows.Forms.TabPage();
            this.integrations2 = new System.Windows.Forms.TabPage();
            this.ERP = new System.Windows.Forms.TabPage();
            this.storageTableAdapter = new ProgramKonstruktion.StoreIT2DataSetTableAdapters.StorageTableAdapter();
            this.tenantTableAdapter = new ProgramKonstruktion.StoreIT2DataSet1TableAdapters.TenantTableAdapter();
            this.tabControl1.SuspendLayout();
            this.bookStorage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBookings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeIT2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.updateStorage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStorages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeIT2DataSet)).BeginInit();
            this.programkonst2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProgram2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.bookStorage);
            this.tabControl1.Controls.Add(this.updateStorage);
            this.tabControl1.Controls.Add(this.programkonst2);
            this.tabControl1.Controls.Add(this.integration1);
            this.tabControl1.Controls.Add(this.integrations2);
            this.tabControl1.Controls.Add(this.ERP);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1114, 652);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // bookStorage
            // 
            this.bookStorage.Controls.Add(this.label6);
            this.bookStorage.Controls.Add(this.dateTxtBox);
            this.bookStorage.Controls.Add(this.label5);
            this.bookStorage.Controls.Add(this.monthCalendar);
            this.bookStorage.Controls.Add(this.comboBoxStorage);
            this.bookStorage.Controls.Add(this.deleteBookingBtn);
            this.bookStorage.Controls.Add(this.dataGridBookings);
            this.bookStorage.Controls.Add(this.pictureBox1);
            this.bookStorage.Controls.Add(this.ssnBookTxt);
            this.bookStorage.Controls.Add(this.label11);
            this.bookStorage.Controls.Add(this.label10);
            this.bookStorage.Controls.Add(this.label7);
            this.bookStorage.Controls.Add(this.errorBoxBooking);
            this.bookStorage.Controls.Add(this.updateTenantBtn);
            this.bookStorage.Controls.Add(this.bookBtn);
            this.bookStorage.Controls.Add(this.label4);
            this.bookStorage.Controls.Add(this.label3);
            this.bookStorage.Controls.Add(this.label2);
            this.bookStorage.Controls.Add(this.label1);
            this.bookStorage.Controls.Add(this.ssnSearchTxt);
            this.bookStorage.Controls.Add(this.emailTxt);
            this.bookStorage.Controls.Add(this.phoneNbrTxt);
            this.bookStorage.Controls.Add(this.tenantNameTxt);
            this.bookStorage.Controls.Add(this.searchTenantBtn);
            this.bookStorage.Location = new System.Drawing.Point(4, 22);
            this.bookStorage.Name = "bookStorage";
            this.bookStorage.Padding = new System.Windows.Forms.Padding(3);
            this.bookStorage.Size = new System.Drawing.Size(1106, 626);
            this.bookStorage.TabIndex = 0;
            this.bookStorage.Text = "Book Storage";
            this.bookStorage.UseVisualStyleBackColor = true;
            this.bookStorage.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(333, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Date Selected";
            // 
            // dateTxtBox
            // 
            this.dateTxtBox.Location = new System.Drawing.Point(336, 367);
            this.dateTxtBox.Name = "dateTxtBox";
            this.dateTxtBox.Size = new System.Drawing.Size(100, 20);
            this.dateTxtBox.TabIndex = 29;
            this.dateTxtBox.TextChanged += new System.EventHandler(this.dateTxtBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Select Storage";
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(216, 186);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 27;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            // 
            // comboBoxStorage
            // 
            this.comboBoxStorage.FormattingEnabled = true;
            this.comboBoxStorage.Location = new System.Drawing.Point(216, 153);
            this.comboBoxStorage.Name = "comboBoxStorage";
            this.comboBoxStorage.Size = new System.Drawing.Size(220, 21);
            this.comboBoxStorage.TabIndex = 26;
            this.comboBoxStorage.SelectedIndexChanged += new System.EventHandler(this.comboBoxStorage_SelectedIndexChanged);
            // 
            // deleteBookingBtn
            // 
            this.deleteBookingBtn.Location = new System.Drawing.Point(630, 469);
            this.deleteBookingBtn.Name = "deleteBookingBtn";
            this.deleteBookingBtn.Size = new System.Drawing.Size(100, 23);
            this.deleteBookingBtn.TabIndex = 25;
            this.deleteBookingBtn.Text = "Delete Booking";
            this.deleteBookingBtn.UseVisualStyleBackColor = true;
            this.deleteBookingBtn.Click += new System.EventHandler(this.deleteBookingBtn_Click);
            // 
            // dataGridBookings
            // 
            this.dataGridBookings.AutoGenerateColumns = false;
            this.dataGridBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBookings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ssnDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.phoneNbrDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.storageNbrDataGridViewTextBoxColumn,
            this.rentDateDataGridViewTextBoxColumn,
            this.storageAddressDataGridViewTextBoxColumn});
            this.dataGridBookings.DataSource = this.tenantBindingSource;
            this.dataGridBookings.Location = new System.Drawing.Point(470, 199);
            this.dataGridBookings.Name = "dataGridBookings";
            this.dataGridBookings.Size = new System.Drawing.Size(546, 257);
            this.dataGridBookings.TabIndex = 24;
            this.dataGridBookings.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBookings_CellContentClick);
            // 
            // ssnDataGridViewTextBoxColumn
            // 
            this.ssnDataGridViewTextBoxColumn.DataPropertyName = "ssn";
            this.ssnDataGridViewTextBoxColumn.HeaderText = "ssn";
            this.ssnDataGridViewTextBoxColumn.Name = "ssnDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // phoneNbrDataGridViewTextBoxColumn
            // 
            this.phoneNbrDataGridViewTextBoxColumn.DataPropertyName = "phoneNbr";
            this.phoneNbrDataGridViewTextBoxColumn.HeaderText = "phoneNbr";
            this.phoneNbrDataGridViewTextBoxColumn.Name = "phoneNbrDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // storageNbrDataGridViewTextBoxColumn
            // 
            this.storageNbrDataGridViewTextBoxColumn.DataPropertyName = "storageNbr";
            this.storageNbrDataGridViewTextBoxColumn.HeaderText = "storageNbr";
            this.storageNbrDataGridViewTextBoxColumn.Name = "storageNbrDataGridViewTextBoxColumn";
            // 
            // rentDateDataGridViewTextBoxColumn
            // 
            this.rentDateDataGridViewTextBoxColumn.DataPropertyName = "rentDate";
            this.rentDateDataGridViewTextBoxColumn.HeaderText = "rentDate";
            this.rentDateDataGridViewTextBoxColumn.Name = "rentDateDataGridViewTextBoxColumn";
            // 
            // storageAddressDataGridViewTextBoxColumn
            // 
            this.storageAddressDataGridViewTextBoxColumn.DataPropertyName = "storageAddress";
            this.storageAddressDataGridViewTextBoxColumn.HeaderText = "storageAddress";
            this.storageAddressDataGridViewTextBoxColumn.Name = "storageAddressDataGridViewTextBoxColumn";
            // 
            // tenantBindingSource
            // 
            this.tenantBindingSource.DataMember = "Tenant";
            this.tenantBindingSource.DataSource = this.storeIT2DataSet1;
            // 
            // storeIT2DataSet1
            // 
            this.storeIT2DataSet1.DataSetName = "StoreIT2DataSet1";
            this.storeIT2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProgramKonstruktion.Properties.Resources._86696795_2810123369128020_3283241522694193152_n;
            this.pictureBox1.Location = new System.Drawing.Point(622, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // ssnBookTxt
            // 
            this.ssnBookTxt.Location = new System.Drawing.Point(62, 155);
            this.ssnBookTxt.Name = "ssnBookTxt";
            this.ssnBookTxt.Size = new System.Drawing.Size(130, 20);
            this.ssnBookTxt.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(466, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Current Bookings";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(467, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Social Security Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(58, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Make new Booking";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // errorBoxBooking
            // 
            this.errorBoxBooking.Location = new System.Drawing.Point(62, 433);
            this.errorBoxBooking.Name = "errorBoxBooking";
            this.errorBoxBooking.Size = new System.Drawing.Size(374, 59);
            this.errorBoxBooking.TabIndex = 15;
            this.errorBoxBooking.Text = "";
            // 
            // updateTenantBtn
            // 
            this.updateTenantBtn.Location = new System.Drawing.Point(92, 393);
            this.updateTenantBtn.Name = "updateTenantBtn";
            this.updateTenantBtn.Size = new System.Drawing.Size(100, 23);
            this.updateTenantBtn.TabIndex = 14;
            this.updateTenantBtn.Text = "Update Tenant";
            this.updateTenantBtn.UseVisualStyleBackColor = true;
            this.updateTenantBtn.Click += new System.EventHandler(this.updateTenantBtn_Click);
            // 
            // bookBtn
            // 
            this.bookBtn.Location = new System.Drawing.Point(336, 393);
            this.bookBtn.Name = "bookBtn";
            this.bookBtn.Size = new System.Drawing.Size(100, 23);
            this.bookBtn.TabIndex = 13;
            this.bookBtn.Text = "Book Storage";
            this.bookBtn.UseVisualStyleBackColor = true;
            this.bookBtn.Click += new System.EventHandler(this.bookBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "E-mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tenant Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Social Security Number";
            // 
            // ssnSearchTxt
            // 
            this.ssnSearchTxt.Location = new System.Drawing.Point(470, 170);
            this.ssnSearchTxt.Name = "ssnSearchTxt";
            this.ssnSearchTxt.Size = new System.Drawing.Size(129, 20);
            this.ssnSearchTxt.TabIndex = 8;
            this.ssnSearchTxt.TextChanged += new System.EventHandler(this.ssnSearchTxt_TextChanged);
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(62, 302);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(130, 20);
            this.emailTxt.TabIndex = 7;
            // 
            // phoneNbrTxt
            // 
            this.phoneNbrTxt.Location = new System.Drawing.Point(62, 253);
            this.phoneNbrTxt.Name = "phoneNbrTxt";
            this.phoneNbrTxt.Size = new System.Drawing.Size(130, 20);
            this.phoneNbrTxt.TabIndex = 4;
            // 
            // tenantNameTxt
            // 
            this.tenantNameTxt.Location = new System.Drawing.Point(62, 202);
            this.tenantNameTxt.Name = "tenantNameTxt";
            this.tenantNameTxt.Size = new System.Drawing.Size(130, 20);
            this.tenantNameTxt.TabIndex = 3;
            // 
            // searchTenantBtn
            // 
            this.searchTenantBtn.Location = new System.Drawing.Point(630, 170);
            this.searchTenantBtn.Name = "searchTenantBtn";
            this.searchTenantBtn.Size = new System.Drawing.Size(100, 23);
            this.searchTenantBtn.TabIndex = 0;
            this.searchTenantBtn.Text = "Search Tenant";
            this.searchTenantBtn.UseVisualStyleBackColor = true;
            this.searchTenantBtn.Click += new System.EventHandler(this.searchTenantBtn_Click);
            // 
            // updateStorage
            // 
            this.updateStorage.Controls.Add(this.pictureBox3);
            this.updateStorage.Controls.Add(this.errorBoxUpdateStorages);
            this.updateStorage.Controls.Add(this.storageSearchBtn);
            this.updateStorage.Controls.Add(this.storageNmbrSearch);
            this.updateStorage.Controls.Add(this.label18);
            this.updateStorage.Controls.Add(this.button8);
            this.updateStorage.Controls.Add(this.label17);
            this.updateStorage.Controls.Add(this.updateStorageBtn);
            this.updateStorage.Controls.Add(this.addStorageBtn);
            this.updateStorage.Controls.Add(this.label16);
            this.updateStorage.Controls.Add(this.label15);
            this.updateStorage.Controls.Add(this.label14);
            this.updateStorage.Controls.Add(this.dataGridStorages);
            this.updateStorage.Controls.Add(this.storageLocationTxt);
            this.updateStorage.Controls.Add(this.storagePriceTxt);
            this.updateStorage.Controls.Add(this.storageSizeTxt);
            this.updateStorage.Controls.Add(this.storageNbrTxt);
            this.updateStorage.Controls.Add(this.label13);
            this.updateStorage.Controls.Add(this.label12);
            this.updateStorage.Location = new System.Drawing.Point(4, 22);
            this.updateStorage.Name = "updateStorage";
            this.updateStorage.Padding = new System.Windows.Forms.Padding(3);
            this.updateStorage.Size = new System.Drawing.Size(1106, 626);
            this.updateStorage.TabIndex = 2;
            this.updateStorage.Text = "Update Storage";
            this.updateStorage.UseVisualStyleBackColor = true;
            this.updateStorage.Click += new System.EventHandler(this.updateStorage_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ProgramKonstruktion.Properties.Resources._86696795_2810123369128020_3283241522694193152_n;
            this.pictureBox3.Location = new System.Drawing.Point(622, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(140, 100);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // errorBoxUpdateStorages
            // 
            this.errorBoxUpdateStorages.Location = new System.Drawing.Point(65, 403);
            this.errorBoxUpdateStorages.Name = "errorBoxUpdateStorages";
            this.errorBoxUpdateStorages.Size = new System.Drawing.Size(331, 67);
            this.errorBoxUpdateStorages.TabIndex = 17;
            this.errorBoxUpdateStorages.Text = "";
            // 
            // storageSearchBtn
            // 
            this.storageSearchBtn.Location = new System.Drawing.Point(654, 162);
            this.storageSearchBtn.Name = "storageSearchBtn";
            this.storageSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.storageSearchBtn.TabIndex = 16;
            this.storageSearchBtn.Text = "Search";
            this.storageSearchBtn.UseVisualStyleBackColor = true;
            // 
            // storageNmbrSearch
            // 
            this.storageNmbrSearch.Location = new System.Drawing.Point(466, 164);
            this.storageNmbrSearch.Name = "storageNmbrSearch";
            this.storageNmbrSearch.Size = new System.Drawing.Size(130, 20);
            this.storageNmbrSearch.TabIndex = 15;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(463, 148);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(84, 13);
            this.label18.TabIndex = 14;
            this.label18.Text = "Storage Number";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(638, 455);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(91, 23);
            this.button8.TabIndex = 13;
            this.button8.Text = "Delete Storage";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(446, 68);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(133, 20);
            this.label17.TabIndex = 12;
            this.label17.Text = "Storage Overview";
            // 
            // updateStorageBtn
            // 
            this.updateStorageBtn.Location = new System.Drawing.Point(227, 332);
            this.updateStorageBtn.Name = "updateStorageBtn";
            this.updateStorageBtn.Size = new System.Drawing.Size(75, 23);
            this.updateStorageBtn.TabIndex = 11;
            this.updateStorageBtn.Text = "Update";
            this.updateStorageBtn.UseVisualStyleBackColor = true;
            this.updateStorageBtn.Click += new System.EventHandler(this.updateStorageBtn_Click);
            // 
            // addStorageBtn
            // 
            this.addStorageBtn.Location = new System.Drawing.Point(321, 332);
            this.addStorageBtn.Name = "addStorageBtn";
            this.addStorageBtn.Size = new System.Drawing.Size(75, 23);
            this.addStorageBtn.TabIndex = 10;
            this.addStorageBtn.Text = "Add";
            this.addStorageBtn.UseVisualStyleBackColor = true;
            this.addStorageBtn.Click += new System.EventHandler(this.addStorageBtn_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(263, 148);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 13);
            this.label16.TabIndex = 9;
            this.label16.Text = "Location";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(62, 232);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "Storage Size";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(263, 234);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Storage Price";
            // 
            // dataGridStorages
            // 
            this.dataGridStorages.AutoGenerateColumns = false;
            this.dataGridStorages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStorages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nbrDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dataGridStorages.DataSource = this.storageBindingSource;
            this.dataGridStorages.Location = new System.Drawing.Point(466, 191);
            this.dataGridStorages.Name = "dataGridStorages";
            this.dataGridStorages.Size = new System.Drawing.Size(425, 258);
            this.dataGridStorages.TabIndex = 6;
            this.dataGridStorages.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridStorages_CellContentClick);
            // 
            // nbrDataGridViewTextBoxColumn
            // 
            this.nbrDataGridViewTextBoxColumn.DataPropertyName = "nbr";
            this.nbrDataGridViewTextBoxColumn.HeaderText = "nbr";
            this.nbrDataGridViewTextBoxColumn.Name = "nbrDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "size";
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // storageBindingSource
            // 
            this.storageBindingSource.DataMember = "Storage";
            this.storageBindingSource.DataSource = this.storeIT2DataSet;
            // 
            // storeIT2DataSet
            // 
            this.storeIT2DataSet.DataSetName = "StoreIT2DataSet";
            this.storeIT2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // storageLocationTxt
            // 
            this.storageLocationTxt.Location = new System.Drawing.Point(266, 250);
            this.storageLocationTxt.Name = "storageLocationTxt";
            this.storageLocationTxt.Size = new System.Drawing.Size(130, 20);
            this.storageLocationTxt.TabIndex = 5;
            this.storageLocationTxt.TextChanged += new System.EventHandler(this.storageLocationTxt_TextChanged);
            // 
            // storagePriceTxt
            // 
            this.storagePriceTxt.Location = new System.Drawing.Point(266, 164);
            this.storagePriceTxt.Name = "storagePriceTxt";
            this.storagePriceTxt.Size = new System.Drawing.Size(130, 20);
            this.storagePriceTxt.TabIndex = 4;
            // 
            // storageSizeTxt
            // 
            this.storageSizeTxt.Location = new System.Drawing.Point(65, 250);
            this.storageSizeTxt.Name = "storageSizeTxt";
            this.storageSizeTxt.Size = new System.Drawing.Size(130, 20);
            this.storageSizeTxt.TabIndex = 3;
            // 
            // storageNbrTxt
            // 
            this.storageNbrTxt.Location = new System.Drawing.Point(65, 164);
            this.storageNbrTxt.Name = "storageNbrTxt";
            this.storageNbrTxt.Size = new System.Drawing.Size(130, 20);
            this.storageNbrTxt.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(62, 148);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Storage Number";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(61, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(164, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Update Storage Units";
            // 
            // programkonst2
            // 
            this.programkonst2.Controls.Add(this.numberOfRowsBtn);
            this.programkonst2.Controls.Add(this.allColumnNamesBtn);
            this.programkonst2.Controls.Add(this.dataGridProgram2);
            this.programkonst2.Location = new System.Drawing.Point(4, 22);
            this.programkonst2.Name = "programkonst2";
            this.programkonst2.Size = new System.Drawing.Size(1106, 626);
            this.programkonst2.TabIndex = 3;
            this.programkonst2.Text = "Programkonstruktion 2";
            this.programkonst2.UseVisualStyleBackColor = true;
            // 
            // numberOfRowsBtn
            // 
            this.numberOfRowsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfRowsBtn.Location = new System.Drawing.Point(458, 117);
            this.numberOfRowsBtn.Name = "numberOfRowsBtn";
            this.numberOfRowsBtn.Size = new System.Drawing.Size(150, 25);
            this.numberOfRowsBtn.TabIndex = 2;
            this.numberOfRowsBtn.Text = "Number of Rows";
            this.numberOfRowsBtn.UseVisualStyleBackColor = true;
            // 
            // allColumnNamesBtn
            // 
            this.allColumnNamesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allColumnNamesBtn.Location = new System.Drawing.Point(180, 117);
            this.allColumnNamesBtn.Name = "allColumnNamesBtn";
            this.allColumnNamesBtn.Size = new System.Drawing.Size(150, 25);
            this.allColumnNamesBtn.TabIndex = 1;
            this.allColumnNamesBtn.Text = "All Column Names";
            this.allColumnNamesBtn.UseVisualStyleBackColor = true;
            // 
            // dataGridProgram2
            // 
            this.dataGridProgram2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProgram2.Location = new System.Drawing.Point(83, 172);
            this.dataGridProgram2.Name = "dataGridProgram2";
            this.dataGridProgram2.Size = new System.Drawing.Size(623, 303);
            this.dataGridProgram2.TabIndex = 0;
            // 
            // integration1
            // 
            this.integration1.Location = new System.Drawing.Point(4, 22);
            this.integration1.Name = "integration1";
            this.integration1.Size = new System.Drawing.Size(1106, 626);
            this.integration1.TabIndex = 4;
            this.integration1.Text = "Interaktionsteknologier 1";
            this.integration1.UseVisualStyleBackColor = true;
            // 
            // integrations2
            // 
            this.integrations2.Location = new System.Drawing.Point(4, 22);
            this.integrations2.Name = "integrations2";
            this.integrations2.Size = new System.Drawing.Size(1106, 626);
            this.integrations2.TabIndex = 5;
            this.integrations2.Text = "Interaktionsteknologier 2";
            this.integrations2.UseVisualStyleBackColor = true;
            // 
            // ERP
            // 
            this.ERP.Location = new System.Drawing.Point(4, 22);
            this.ERP.Name = "ERP";
            this.ERP.Size = new System.Drawing.Size(1106, 626);
            this.ERP.TabIndex = 6;
            this.ERP.Text = "ERP";
            this.ERP.UseVisualStyleBackColor = true;
            // 
            // storageTableAdapter
            // 
            this.storageTableAdapter.ClearBeforeFill = true;
            // 
            // tenantTableAdapter
            // 
            this.tenantTableAdapter.ClearBeforeFill = true;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 667);
            this.Controls.Add(this.tabControl1);
            this.Name = "GUI";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GUI_Load);
            this.tabControl1.ResumeLayout(false);
            this.bookStorage.ResumeLayout(false);
            this.bookStorage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBookings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeIT2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.updateStorage.ResumeLayout(false);
            this.updateStorage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStorages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeIT2DataSet)).EndInit();
            this.programkonst2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProgram2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage bookStorage;
        private System.Windows.Forms.Button searchTenantBtn;
        private System.Windows.Forms.TabPage updateStorage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ssnSearchTxt;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox phoneNbrTxt;
        private System.Windows.Forms.TextBox tenantNameTxt;
        private System.Windows.Forms.Button updateTenantBtn;
        private System.Windows.Forms.Button bookBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox errorBoxBooking;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox errorBoxUpdateStorages;
        private System.Windows.Forms.Button storageSearchBtn;
        private System.Windows.Forms.TextBox storageNmbrSearch;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button updateStorageBtn;
        private System.Windows.Forms.Button addStorageBtn;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridStorages;
        private System.Windows.Forms.TextBox storageLocationTxt;
        private System.Windows.Forms.TextBox storagePriceTxt;
        private System.Windows.Forms.TextBox storageSizeTxt;
        private System.Windows.Forms.TextBox storageNbrTxt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ssnBookTxt;
        private System.Windows.Forms.DataGridView dataGridBookings;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TabPage programkonst2;
        private System.Windows.Forms.TabPage integration1;
        private System.Windows.Forms.TabPage integrations2;
        private System.Windows.Forms.TabPage ERP;
        private System.Windows.Forms.Button numberOfRowsBtn;
        private System.Windows.Forms.Button allColumnNamesBtn;
        private System.Windows.Forms.DataGridView dataGridProgram2;
        private System.Windows.Forms.Button deleteBookingBtn;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.ComboBox comboBoxStorage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dateTxtBox;
        private System.Windows.Forms.Label label6;
        private StoreIT2DataSet storeIT2DataSet;
        private System.Windows.Forms.BindingSource storageBindingSource;
        private StoreIT2DataSetTableAdapters.StorageTableAdapter storageTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private StoreIT2DataSet1 storeIT2DataSet1;
        private System.Windows.Forms.BindingSource tenantBindingSource;
        private StoreIT2DataSet1TableAdapters.TenantTableAdapter tenantTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ssnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNbrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storageNbrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storageAddressDataGridViewTextBoxColumn;
    }

   
}




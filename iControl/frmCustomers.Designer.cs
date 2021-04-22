
namespace iControl
{
    partial class frmCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.homebutton = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.streetBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.countryBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.postalCodeBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.phoneNumberBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.TextBox();
            this.productStatus = new System.Windows.Forms.GroupBox();
            this.radioDorment = new System.Windows.Forms.RadioButton();
            this.radioActive = new System.Windows.Forms.RadioButton();
            this.customerID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerStreetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerCountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPostalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPhoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerStatusIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iControlDataSet = new iControl.iControlDataSet();
            this.customersTableAdapter = new iControl.iControlDataSetTableAdapters.CustomersTableAdapter();
            this.placeOrderButton = new System.Windows.Forms.Button();
            this.firstNameSearchBox = new System.Windows.Forms.TextBox();
            this.searchForFirstNameButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.showAllButton = new System.Windows.Forms.Button();
            this.searchByLastNameButton = new System.Windows.Forms.Button();
            this.lastNameSearchBox = new System.Windows.Forms.TextBox();
            this.labelcustomers = new System.Windows.Forms.Label();
            this.productStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iControlDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1293, 97);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Customers";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // homebutton
            // 
            this.homebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.homebutton.AutoSize = true;
            this.homebutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.homebutton.Image = ((System.Drawing.Image)(resources.GetObject("homebutton.Image")));
            this.homebutton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.homebutton.Location = new System.Drawing.Point(0, 710);
            this.homebutton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.homebutton.MaximumSize = new System.Drawing.Size(60, 60);
            this.homebutton.MinimumSize = new System.Drawing.Size(60, 60);
            this.homebutton.Name = "homebutton";
            this.homebutton.Size = new System.Drawing.Size(60, 60);
            this.homebutton.TabIndex = 16;
            this.homebutton.UseVisualStyleBackColor = true;
            this.homebutton.Click += new System.EventHandler(this.homebutton_Click);
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.Color.LightCoral;
            this.delete_button.Enabled = false;
            this.delete_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.delete_button.Location = new System.Drawing.Point(223, 599);
            this.delete_button.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(84, 55);
            this.delete_button.TabIndex = 11;
            this.delete_button.Text = "&DEL";
            this.delete_button.UseVisualStyleBackColor = false;
            // 
            // edit_button
            // 
            this.edit_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.edit_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.edit_button.Location = new System.Drawing.Point(121, 599);
            this.edit_button.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(84, 55);
            this.edit_button.TabIndex = 10;
            this.edit_button.Text = "&EDIT";
            this.edit_button.UseVisualStyleBackColor = false;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.add_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.add_button.Location = new System.Drawing.Point(16, 599);
            this.add_button.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(84, 55);
            this.add_button.TabIndex = 9;
            this.add_button.Text = "&ADD";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.LightCoral;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 770);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1293, 39);
            this.panel2.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "First Name";
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(121, 170);
            this.firstNameBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(148, 25);
            this.firstNameBox.TabIndex = 0;
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(121, 212);
            this.lastNameBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(186, 25);
            this.lastNameBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Last Name";
            // 
            // streetBox
            // 
            this.streetBox.Location = new System.Drawing.Point(121, 254);
            this.streetBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.streetBox.Name = "streetBox";
            this.streetBox.Size = new System.Drawing.Size(186, 25);
            this.streetBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Street";
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(121, 296);
            this.cityBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(186, 25);
            this.cityBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(76, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "City";
            // 
            // countryBox
            // 
            this.countryBox.Location = new System.Drawing.Point(121, 338);
            this.countryBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.countryBox.Name = "countryBox";
            this.countryBox.Size = new System.Drawing.Size(186, 25);
            this.countryBox.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Country";
            // 
            // postalCodeBox
            // 
            this.postalCodeBox.Location = new System.Drawing.Point(121, 380);
            this.postalCodeBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.postalCodeBox.Name = "postalCodeBox";
            this.postalCodeBox.Size = new System.Drawing.Size(186, 25);
            this.postalCodeBox.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "Postal Code";
            // 
            // phoneNumberBox
            // 
            this.phoneNumberBox.Location = new System.Drawing.Point(121, 422);
            this.phoneNumberBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.phoneNumberBox.Name = "phoneNumberBox";
            this.phoneNumberBox.Size = new System.Drawing.Size(186, 25);
            this.phoneNumberBox.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 425);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 17);
            this.label8.TabIndex = 31;
            this.label8.Text = "Phone Number";
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(121, 464);
            this.emailBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(186, 25);
            this.emailBox.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(61, 467);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 17);
            this.label9.TabIndex = 33;
            this.label9.Text = "E-mail";
            // 
            // labelStatus
            // 
            this.labelStatus.Location = new System.Drawing.Point(279, 509);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.ReadOnly = true;
            this.labelStatus.Size = new System.Drawing.Size(29, 25);
            this.labelStatus.TabIndex = 53;
            // 
            // productStatus
            // 
            this.productStatus.Controls.Add(this.radioDorment);
            this.productStatus.Controls.Add(this.radioActive);
            this.productStatus.Location = new System.Drawing.Point(75, 499);
            this.productStatus.Name = "productStatus";
            this.productStatus.Size = new System.Drawing.Size(198, 85);
            this.productStatus.TabIndex = 8;
            this.productStatus.TabStop = false;
            this.productStatus.Text = "Status";
            // 
            // radioDorment
            // 
            this.radioDorment.AutoSize = true;
            this.radioDorment.Location = new System.Drawing.Point(6, 51);
            this.radioDorment.Name = "radioDorment";
            this.radioDorment.Size = new System.Drawing.Size(76, 21);
            this.radioDorment.TabIndex = 45;
            this.radioDorment.TabStop = true;
            this.radioDorment.Text = "dorment";
            this.radioDorment.UseVisualStyleBackColor = true;
            this.radioDorment.CheckedChanged += new System.EventHandler(this.radioDorment_CheckedChanged_1);
            // 
            // radioActive
            // 
            this.radioActive.AutoSize = true;
            this.radioActive.Location = new System.Drawing.Point(6, 24);
            this.radioActive.Name = "radioActive";
            this.radioActive.Size = new System.Drawing.Size(59, 21);
            this.radioActive.TabIndex = 44;
            this.radioActive.TabStop = true;
            this.radioActive.Text = "active";
            this.radioActive.UseVisualStyleBackColor = true;
            this.radioActive.CheckedChanged += new System.EventHandler(this.radioActive_CheckedChanged_1);
            // 
            // customerID
            // 
            this.customerID.Location = new System.Drawing.Point(279, 170);
            this.customerID.Name = "customerID";
            this.customerID.ReadOnly = true;
            this.customerID.Size = new System.Drawing.Size(29, 25);
            this.customerID.TabIndex = 54;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.customerFirstNameDataGridViewTextBoxColumn,
            this.customerLastNameDataGridViewTextBoxColumn,
            this.customerStreetDataGridViewTextBoxColumn,
            this.customerCityDataGridViewTextBoxColumn,
            this.customerCountryDataGridViewTextBoxColumn,
            this.customerPostalCodeDataGridViewTextBoxColumn,
            this.customerPhoneNumberDataGridViewTextBoxColumn,
            this.customerEmailDataGridViewTextBoxColumn,
            this.customerStatusIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customersBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(317, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(964, 484);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "customerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.customerIDDataGridViewTextBoxColumn.Width = 30;
            // 
            // customerFirstNameDataGridViewTextBoxColumn
            // 
            this.customerFirstNameDataGridViewTextBoxColumn.DataPropertyName = "customerFirstName";
            this.customerFirstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.customerFirstNameDataGridViewTextBoxColumn.Name = "customerFirstNameDataGridViewTextBoxColumn";
            this.customerFirstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerFirstNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // customerLastNameDataGridViewTextBoxColumn
            // 
            this.customerLastNameDataGridViewTextBoxColumn.DataPropertyName = "customerLastName";
            this.customerLastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.customerLastNameDataGridViewTextBoxColumn.Name = "customerLastNameDataGridViewTextBoxColumn";
            this.customerLastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerLastNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // customerStreetDataGridViewTextBoxColumn
            // 
            this.customerStreetDataGridViewTextBoxColumn.DataPropertyName = "customerStreet";
            this.customerStreetDataGridViewTextBoxColumn.HeaderText = "Street";
            this.customerStreetDataGridViewTextBoxColumn.Name = "customerStreetDataGridViewTextBoxColumn";
            this.customerStreetDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerStreetDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.customerStreetDataGridViewTextBoxColumn.Width = 150;
            // 
            // customerCityDataGridViewTextBoxColumn
            // 
            this.customerCityDataGridViewTextBoxColumn.DataPropertyName = "customerCity";
            this.customerCityDataGridViewTextBoxColumn.HeaderText = "City";
            this.customerCityDataGridViewTextBoxColumn.Name = "customerCityDataGridViewTextBoxColumn";
            this.customerCityDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerCityDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.customerCityDataGridViewTextBoxColumn.Width = 80;
            // 
            // customerCountryDataGridViewTextBoxColumn
            // 
            this.customerCountryDataGridViewTextBoxColumn.DataPropertyName = "customerCountry";
            this.customerCountryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.customerCountryDataGridViewTextBoxColumn.Name = "customerCountryDataGridViewTextBoxColumn";
            this.customerCountryDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerCountryDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.customerCountryDataGridViewTextBoxColumn.Width = 80;
            // 
            // customerPostalCodeDataGridViewTextBoxColumn
            // 
            this.customerPostalCodeDataGridViewTextBoxColumn.DataPropertyName = "customerPostalCode";
            this.customerPostalCodeDataGridViewTextBoxColumn.HeaderText = "Postal Code";
            this.customerPostalCodeDataGridViewTextBoxColumn.Name = "customerPostalCodeDataGridViewTextBoxColumn";
            this.customerPostalCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerPostalCodeDataGridViewTextBoxColumn.Width = 80;
            // 
            // customerPhoneNumberDataGridViewTextBoxColumn
            // 
            this.customerPhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "customerPhoneNumber";
            this.customerPhoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.customerPhoneNumberDataGridViewTextBoxColumn.Name = "customerPhoneNumberDataGridViewTextBoxColumn";
            this.customerPhoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerPhoneNumberDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // customerEmailDataGridViewTextBoxColumn
            // 
            this.customerEmailDataGridViewTextBoxColumn.DataPropertyName = "customerEmail";
            this.customerEmailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.customerEmailDataGridViewTextBoxColumn.Name = "customerEmailDataGridViewTextBoxColumn";
            this.customerEmailDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerEmailDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.customerEmailDataGridViewTextBoxColumn.Width = 160;
            // 
            // customerStatusIDDataGridViewTextBoxColumn
            // 
            this.customerStatusIDDataGridViewTextBoxColumn.DataPropertyName = "customerStatusID";
            this.customerStatusIDDataGridViewTextBoxColumn.HeaderText = "Status";
            this.customerStatusIDDataGridViewTextBoxColumn.Name = "customerStatusIDDataGridViewTextBoxColumn";
            this.customerStatusIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerStatusIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.customerStatusIDDataGridViewTextBoxColumn.Width = 70;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.iControlDataSet;
            // 
            // iControlDataSet
            // 
            this.iControlDataSet.DataSetName = "iControlDataSet";
            this.iControlDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // placeOrderButton
            // 
            this.placeOrderButton.BackColor = System.Drawing.Color.PaleGreen;
            this.placeOrderButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeOrderButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.placeOrderButton.Location = new System.Drawing.Point(1038, 662);
            this.placeOrderButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.placeOrderButton.Name = "placeOrderButton";
            this.placeOrderButton.Size = new System.Drawing.Size(231, 58);
            this.placeOrderButton.TabIndex = 15;
            this.placeOrderButton.Text = "&Place Order for Current Customer";
            this.placeOrderButton.UseVisualStyleBackColor = false;
            this.placeOrderButton.Click += new System.EventHandler(this.placeOrderButton_Click);
            // 
            // firstNameSearchBox
            // 
            this.firstNameSearchBox.Location = new System.Drawing.Point(589, 137);
            this.firstNameSearchBox.Name = "firstNameSearchBox";
            this.firstNameSearchBox.Size = new System.Drawing.Size(158, 25);
            this.firstNameSearchBox.TabIndex = 12;
            // 
            // searchForFirstNameButton
            // 
            this.searchForFirstNameButton.Location = new System.Drawing.Point(482, 137);
            this.searchForFirstNameButton.Name = "searchForFirstNameButton";
            this.searchForFirstNameButton.Size = new System.Drawing.Size(101, 25);
            this.searchForFirstNameButton.TabIndex = 58;
            this.searchForFirstNameButton.Text = "first name:";
            this.searchForFirstNameButton.UseVisualStyleBackColor = true;
            this.searchForFirstNameButton.Click += new System.EventHandler(this.searchForFirstNameButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(313, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 21);
            this.label10.TabIndex = 59;
            this.label10.Text = "Quick Search by -->";
            // 
            // showAllButton
            // 
            this.showAllButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.showAllButton.Location = new System.Drawing.Point(1194, 122);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(75, 41);
            this.showAllButton.TabIndex = 14;
            this.showAllButton.Text = "&Show All";
            this.showAllButton.UseVisualStyleBackColor = false;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click_1);
            // 
            // searchByLastNameButton
            // 
            this.searchByLastNameButton.Location = new System.Drawing.Point(784, 137);
            this.searchByLastNameButton.Name = "searchByLastNameButton";
            this.searchByLastNameButton.Size = new System.Drawing.Size(101, 25);
            this.searchByLastNameButton.TabIndex = 62;
            this.searchByLastNameButton.Text = "last name:";
            this.searchByLastNameButton.UseVisualStyleBackColor = true;
            this.searchByLastNameButton.Click += new System.EventHandler(this.searchByLastNameButton_Click);
            // 
            // lastNameSearchBox
            // 
            this.lastNameSearchBox.Location = new System.Drawing.Point(891, 137);
            this.lastNameSearchBox.Name = "lastNameSearchBox";
            this.lastNameSearchBox.Size = new System.Drawing.Size(158, 25);
            this.lastNameSearchBox.TabIndex = 13;
            // 
            // labelcustomers
            // 
            this.labelcustomers.AutoSize = true;
            this.labelcustomers.BackColor = System.Drawing.Color.LightCoral;
            this.labelcustomers.Image = ((System.Drawing.Image)(resources.GetObject("labelcustomers.Image")));
            this.labelcustomers.Location = new System.Drawing.Point(5, 9);
            this.labelcustomers.MinimumSize = new System.Drawing.Size(80, 80);
            this.labelcustomers.Name = "labelcustomers";
            this.labelcustomers.Size = new System.Drawing.Size(80, 80);
            this.labelcustomers.TabIndex = 63;
            // 
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 809);
            this.Controls.Add(this.labelcustomers);
            this.Controls.Add(this.searchByLastNameButton);
            this.Controls.Add(this.lastNameSearchBox);
            this.Controls.Add(this.showAllButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.searchForFirstNameButton);
            this.Controls.Add(this.firstNameSearchBox);
            this.Controls.Add(this.placeOrderButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.customerID);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.productStatus);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.phoneNumberBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.postalCodeBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.countryBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.streetBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.homebutton);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iControl - Customers";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.productStatus.ResumeLayout(false);
            this.productStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iControlDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button homebutton;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox streetBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox countryBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox postalCodeBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox phoneNumberBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox labelStatus;
        private System.Windows.Forms.GroupBox productStatus;
        private System.Windows.Forms.RadioButton radioDorment;
        private System.Windows.Forms.RadioButton radioActive;
        private System.Windows.Forms.TextBox customerID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private iControlDataSet iControlDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private iControlDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.Button placeOrderButton;
        private System.Windows.Forms.TextBox firstNameSearchBox;
        private System.Windows.Forms.Button searchForFirstNameButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button showAllButton;
        private System.Windows.Forms.Button searchByLastNameButton;
        private System.Windows.Forms.TextBox lastNameSearchBox;
        private System.Windows.Forms.Label labelcustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerStreetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerCountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPostalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPhoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerStatusIDDataGridViewTextBoxColumn;
    }
}
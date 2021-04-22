
namespace iControl
{
    partial class frmOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrders));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.homeButton = new System.Windows.Forms.Button();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.customerIDBox = new System.Windows.Forms.TextBox();
            this.labelProducts = new System.Windows.Forms.Label();
            this.iControlDataSet = new iControl.iControlDataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new iControl.iControlDataSetTableAdapters.CustomersTableAdapter();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelStreet = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelCountry = new System.Windows.Forms.Label();
            this.labelPostalCode = new System.Windows.Forms.Label();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.streetBox = new System.Windows.Forms.TextBox();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.countryBox = new System.Windows.Forms.TextBox();
            this.postalCodeBox = new System.Windows.Forms.TextBox();
            this.phoneNumberBox3 = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerStreet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPostalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPhoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.searchByLastNameButton = new System.Windows.Forms.Button();
            this.showAllButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.searchForFirstNameButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchByIDbutton = new System.Windows.Forms.Button();
            this.searchByPhoneNumberButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new iControl.iControlDataSetTableAdapters.OrdersTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productMaximumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productMinimumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productStatusIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCategoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productSupplierIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new iControl.iControlDataSetTableAdapters.ProductsTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.productSearchByID = new System.Windows.Forms.Button();
            this.productShowAllButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.productSearchByName = new System.Windows.Forms.Button();
            this.productSearchBox = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesTableAdapter = new iControl.iControlDataSetTableAdapters.CategoriesTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.saveOrderButton = new System.Windows.Forms.Button();
            this.placeOrderButton = new System.Windows.Forms.Button();
            this.labelCategory = new System.Windows.Forms.TextBox();
            this.productsOrderProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderProductsTableAdapter = new iControl.iControlDataSetTableAdapters.OrderProductsTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.orderingListTable = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productListTable = new System.Windows.Forms.DataGridView();
            this.addToOrderButton = new System.Windows.Forms.Button();
            this.selectQuantityBox = new System.Windows.Forms.TextBox();
            this.deleteRowButton = new System.Windows.Forms.Button();
            this.labelTax = new System.Windows.Forms.Label();
            this.labelSubtotal = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelSubtotalSum = new System.Windows.Forms.Label();
            this.labelTaxSum = new System.Windows.Forms.Label();
            this.labelTotalSum = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.toolTipSaveOrder = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipAddToOrder = new System.Windows.Forms.ToolTip(this.components);
            this.viewOrdersButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.productTemporaryList = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.orderIDTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.iControlDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsOrderProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderingListTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productListTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTemporaryList)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(1379, 93);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manage Orders";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCoral;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 861);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1379, 23);
            this.panel2.TabIndex = 20;
            // 
            // homeButton
            // 
            this.homeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.homeButton.Location = new System.Drawing.Point(0, 797);
            this.homeButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.homeButton.MaximumSize = new System.Drawing.Size(60, 60);
            this.homeButton.MinimumSize = new System.Drawing.Size(60, 60);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(60, 60);
            this.homeButton.TabIndex = 19;
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click_1);
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.BackColor = System.Drawing.Color.Linen;
            this.labelCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCustomer.Location = new System.Drawing.Point(5, 97);
            this.labelCustomer.MinimumSize = new System.Drawing.Size(510, 280);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(510, 280);
            this.labelCustomer.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Linen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Customer Information";
            // 
            // customerIDBox
            // 
            this.customerIDBox.Location = new System.Drawing.Point(205, 104);
            this.customerIDBox.Name = "customerIDBox";
            this.customerIDBox.ReadOnly = true;
            this.customerIDBox.Size = new System.Drawing.Size(40, 20);
            this.customerIDBox.TabIndex = 25;
            // 
            // labelProducts
            // 
            this.labelProducts.AutoSize = true;
            this.labelProducts.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelProducts.Location = new System.Drawing.Point(5, 384);
            this.labelProducts.MinimumSize = new System.Drawing.Size(510, 300);
            this.labelProducts.Name = "labelProducts";
            this.labelProducts.Size = new System.Drawing.Size(510, 300);
            this.labelProducts.TabIndex = 26;
            // 
            // iControlDataSet
            // 
            this.iControlDataSet.DataSetName = "iControlDataSet";
            this.iControlDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.iControlDataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.BackColor = System.Drawing.Color.Linen;
            this.labelFirstName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.Location = new System.Drawing.Point(11, 144);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(74, 17);
            this.labelFirstName.TabIndex = 27;
            this.labelFirstName.Text = "First Name:";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.BackColor = System.Drawing.Color.Linen;
            this.labelLastName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.Location = new System.Drawing.Point(260, 145);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(66, 15);
            this.labelLastName.TabIndex = 28;
            this.labelLastName.Text = "Last Name:";
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.BackColor = System.Drawing.Color.Linen;
            this.labelStreet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStreet.Location = new System.Drawing.Point(45, 175);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(40, 15);
            this.labelStreet.TabIndex = 29;
            this.labelStreet.Text = "Street:";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.BackColor = System.Drawing.Color.Linen;
            this.labelCity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCity.Location = new System.Drawing.Point(54, 204);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(31, 15);
            this.labelCity.TabIndex = 30;
            this.labelCity.Text = "City:";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.BackColor = System.Drawing.Color.Linen;
            this.labelCountry.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountry.Location = new System.Drawing.Point(32, 233);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(53, 15);
            this.labelCountry.TabIndex = 31;
            this.labelCountry.Text = "Country:";
            // 
            // labelPostalCode
            // 
            this.labelPostalCode.AutoSize = true;
            this.labelPostalCode.BackColor = System.Drawing.Color.Linen;
            this.labelPostalCode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPostalCode.Location = new System.Drawing.Point(255, 201);
            this.labelPostalCode.Name = "labelPostalCode";
            this.labelPostalCode.Size = new System.Drawing.Size(73, 15);
            this.labelPostalCode.TabIndex = 32;
            this.labelPostalCode.Text = "Postal Code:";
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.BackColor = System.Drawing.Color.Linen;
            this.labelPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhoneNumber.Location = new System.Drawing.Point(41, 262);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(44, 15);
            this.labelPhoneNumber.TabIndex = 33;
            this.labelPhoneNumber.Text = "Phone:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Linen;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(41, 291);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(44, 15);
            this.labelEmail.TabIndex = 34;
            this.labelEmail.Text = "E-mail:";
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(92, 141);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.ReadOnly = true;
            this.firstNameBox.Size = new System.Drawing.Size(153, 20);
            this.firstNameBox.TabIndex = 35;
            // 
            // lastNameBox
            // 
            this.lastNameBox.BackColor = System.Drawing.SystemColors.Control;
            this.lastNameBox.Location = new System.Drawing.Point(335, 141);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.ReadOnly = true;
            this.lastNameBox.Size = new System.Drawing.Size(164, 20);
            this.lastNameBox.TabIndex = 36;
            // 
            // streetBox
            // 
            this.streetBox.Location = new System.Drawing.Point(92, 171);
            this.streetBox.Name = "streetBox";
            this.streetBox.ReadOnly = true;
            this.streetBox.Size = new System.Drawing.Size(153, 20);
            this.streetBox.TabIndex = 37;
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(92, 201);
            this.cityBox.Name = "cityBox";
            this.cityBox.ReadOnly = true;
            this.cityBox.Size = new System.Drawing.Size(153, 20);
            this.cityBox.TabIndex = 38;
            // 
            // countryBox
            // 
            this.countryBox.Location = new System.Drawing.Point(92, 231);
            this.countryBox.Name = "countryBox";
            this.countryBox.ReadOnly = true;
            this.countryBox.Size = new System.Drawing.Size(153, 20);
            this.countryBox.TabIndex = 39;
            // 
            // postalCodeBox
            // 
            this.postalCodeBox.Location = new System.Drawing.Point(335, 197);
            this.postalCodeBox.Name = "postalCodeBox";
            this.postalCodeBox.ReadOnly = true;
            this.postalCodeBox.Size = new System.Drawing.Size(83, 20);
            this.postalCodeBox.TabIndex = 40;
            // 
            // phoneNumberBox3
            // 
            this.phoneNumberBox3.Location = new System.Drawing.Point(92, 261);
            this.phoneNumberBox3.Name = "phoneNumberBox3";
            this.phoneNumberBox3.ReadOnly = true;
            this.phoneNumberBox3.Size = new System.Drawing.Size(153, 20);
            this.phoneNumberBox3.TabIndex = 41;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(92, 291);
            this.emailBox.Name = "emailBox";
            this.emailBox.ReadOnly = true;
            this.emailBox.Size = new System.Drawing.Size(153, 20);
            this.emailBox.TabIndex = 42;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.customerFirstNameDataGridViewTextBoxColumn,
            this.customerLastNameDataGridViewTextBoxColumn,
            this.customerStreet,
            this.customerCity,
            this.customerCountry,
            this.customerPostalCode,
            this.customerPhoneNumberDataGridViewTextBoxColumn,
            this.customerEmailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customersBindingSource1;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(523, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(835, 233);
            this.dataGridView1.TabIndex = 43;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "customerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerIDDataGridViewTextBoxColumn.Width = 30;
            // 
            // customerFirstNameDataGridViewTextBoxColumn
            // 
            this.customerFirstNameDataGridViewTextBoxColumn.DataPropertyName = "customerFirstName";
            this.customerFirstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.customerFirstNameDataGridViewTextBoxColumn.Name = "customerFirstNameDataGridViewTextBoxColumn";
            this.customerFirstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerLastNameDataGridViewTextBoxColumn
            // 
            this.customerLastNameDataGridViewTextBoxColumn.DataPropertyName = "customerLastName";
            this.customerLastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.customerLastNameDataGridViewTextBoxColumn.Name = "customerLastNameDataGridViewTextBoxColumn";
            this.customerLastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerStreet
            // 
            this.customerStreet.DataPropertyName = "customerStreet";
            this.customerStreet.HeaderText = "Street";
            this.customerStreet.Name = "customerStreet";
            this.customerStreet.ReadOnly = true;
            // 
            // customerCity
            // 
            this.customerCity.DataPropertyName = "customerCity";
            this.customerCity.HeaderText = "City";
            this.customerCity.Name = "customerCity";
            this.customerCity.ReadOnly = true;
            // 
            // customerCountry
            // 
            this.customerCountry.DataPropertyName = "customerCountry";
            this.customerCountry.HeaderText = "Country";
            this.customerCountry.Name = "customerCountry";
            this.customerCountry.ReadOnly = true;
            // 
            // customerPostalCode
            // 
            this.customerPostalCode.DataPropertyName = "customerPostalCode";
            this.customerPostalCode.HeaderText = "Postal Code";
            this.customerPostalCode.Name = "customerPostalCode";
            this.customerPostalCode.ReadOnly = true;
            // 
            // customerPhoneNumberDataGridViewTextBoxColumn
            // 
            this.customerPhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "customerPhoneNumber";
            this.customerPhoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone Number";
            this.customerPhoneNumberDataGridViewTextBoxColumn.Name = "customerPhoneNumberDataGridViewTextBoxColumn";
            this.customerPhoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerEmailDataGridViewTextBoxColumn
            // 
            this.customerEmailDataGridViewTextBoxColumn.DataPropertyName = "customerEmail";
            this.customerEmailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.customerEmailDataGridViewTextBoxColumn.Name = "customerEmailDataGridViewTextBoxColumn";
            this.customerEmailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customersBindingSource1
            // 
            this.customersBindingSource1.DataMember = "Customers";
            this.customersBindingSource1.DataSource = this.iControlDataSet;
            this.customersBindingSource1.Filter = "customerStatusID=1";
            // 
            // searchByLastNameButton
            // 
            this.searchByLastNameButton.Location = new System.Drawing.Point(727, 118);
            this.searchByLastNameButton.Name = "searchByLastNameButton";
            this.searchByLastNameButton.Size = new System.Drawing.Size(64, 20);
            this.searchByLastNameButton.TabIndex = 68;
            this.searchByLastNameButton.Text = "last name";
            this.searchByLastNameButton.UseVisualStyleBackColor = true;
            this.searchByLastNameButton.Click += new System.EventHandler(this.searchByLastNameButton_Click);
            // 
            // showAllButton
            // 
            this.showAllButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.showAllButton.Location = new System.Drawing.Point(933, 97);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(63, 44);
            this.showAllButton.TabIndex = 66;
            this.showAllButton.Text = "Show &All";
            this.showAllButton.UseVisualStyleBackColor = false;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(521, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 17);
            this.label10.TabIndex = 65;
            this.label10.Text = "Quick Search by -->";
            // 
            // searchForFirstNameButton
            // 
            this.searchForFirstNameButton.Location = new System.Drawing.Point(654, 118);
            this.searchForFirstNameButton.Name = "searchForFirstNameButton";
            this.searchForFirstNameButton.Size = new System.Drawing.Size(69, 20);
            this.searchForFirstNameButton.TabIndex = 64;
            this.searchForFirstNameButton.Text = "first name";
            this.searchForFirstNameButton.UseVisualStyleBackColor = true;
            this.searchForFirstNameButton.Click += new System.EventHandler(this.searchForFirstNameButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(524, 118);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(126, 20);
            this.searchBox.TabIndex = 63;
            // 
            // searchByIDbutton
            // 
            this.searchByIDbutton.Location = new System.Drawing.Point(795, 118);
            this.searchByIDbutton.Name = "searchByIDbutton";
            this.searchByIDbutton.Size = new System.Drawing.Size(64, 20);
            this.searchByIDbutton.TabIndex = 69;
            this.searchByIDbutton.Text = "ID";
            this.searchByIDbutton.UseVisualStyleBackColor = true;
            this.searchByIDbutton.Click += new System.EventHandler(this.searchByIDbutton_Click);
            // 
            // searchByPhoneNumberButton
            // 
            this.searchByPhoneNumberButton.Location = new System.Drawing.Point(863, 118);
            this.searchByPhoneNumberButton.Name = "searchByPhoneNumberButton";
            this.searchByPhoneNumberButton.Size = new System.Drawing.Size(64, 20);
            this.searchByPhoneNumberButton.TabIndex = 70;
            this.searchByPhoneNumberButton.Text = "Phone";
            this.searchByPhoneNumberButton.UseVisualStyleBackColor = true;
            this.searchByPhoneNumberButton.Click += new System.EventHandler(this.searchByPhoneNumberButton_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(653, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 13);
            this.label3.TabIndex = 71;
            this.label3.Text = "Enter keyword and click the button";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 72;
            this.label4.Text = "Products";
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.iControlDataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView2.AutoGenerateColumns = false;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView2.ColumnHeadersHeight = 31;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.productDescriptionDataGridViewTextBoxColumn,
            this.productQuantityDataGridViewTextBoxColumn,
            this.productMaximumDataGridViewTextBoxColumn,
            this.productMinimumDataGridViewTextBoxColumn,
            this.productPriceDataGridViewTextBoxColumn,
            this.productStatusIDDataGridViewTextBoxColumn,
            this.productCategoryIDDataGridViewTextBoxColumn,
            this.productSupplierIDDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.productsBindingSource;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(524, 437);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(834, 202);
            this.dataGridView2.TabIndex = 73;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "productID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIDDataGridViewTextBoxColumn.Width = 30;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "productName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.productNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // productDescriptionDataGridViewTextBoxColumn
            // 
            this.productDescriptionDataGridViewTextBoxColumn.DataPropertyName = "productDescription";
            this.productDescriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.productDescriptionDataGridViewTextBoxColumn.Name = "productDescriptionDataGridViewTextBoxColumn";
            this.productDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.productDescriptionDataGridViewTextBoxColumn.Width = 230;
            // 
            // productQuantityDataGridViewTextBoxColumn
            // 
            this.productQuantityDataGridViewTextBoxColumn.DataPropertyName = "productQuantity";
            this.productQuantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.productQuantityDataGridViewTextBoxColumn.Name = "productQuantityDataGridViewTextBoxColumn";
            this.productQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.productQuantityDataGridViewTextBoxColumn.Width = 50;
            // 
            // productMaximumDataGridViewTextBoxColumn
            // 
            this.productMaximumDataGridViewTextBoxColumn.DataPropertyName = "productMaximum";
            this.productMaximumDataGridViewTextBoxColumn.HeaderText = "Max";
            this.productMaximumDataGridViewTextBoxColumn.Name = "productMaximumDataGridViewTextBoxColumn";
            this.productMaximumDataGridViewTextBoxColumn.ReadOnly = true;
            this.productMaximumDataGridViewTextBoxColumn.Width = 40;
            // 
            // productMinimumDataGridViewTextBoxColumn
            // 
            this.productMinimumDataGridViewTextBoxColumn.DataPropertyName = "productMinimum";
            this.productMinimumDataGridViewTextBoxColumn.HeaderText = "Min";
            this.productMinimumDataGridViewTextBoxColumn.Name = "productMinimumDataGridViewTextBoxColumn";
            this.productMinimumDataGridViewTextBoxColumn.ReadOnly = true;
            this.productMinimumDataGridViewTextBoxColumn.Width = 40;
            // 
            // productPriceDataGridViewTextBoxColumn
            // 
            this.productPriceDataGridViewTextBoxColumn.DataPropertyName = "productPrice";
            this.productPriceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.productPriceDataGridViewTextBoxColumn.Name = "productPriceDataGridViewTextBoxColumn";
            this.productPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.productPriceDataGridViewTextBoxColumn.Width = 80;
            // 
            // productStatusIDDataGridViewTextBoxColumn
            // 
            this.productStatusIDDataGridViewTextBoxColumn.DataPropertyName = "productStatusID";
            this.productStatusIDDataGridViewTextBoxColumn.HeaderText = "StatusID";
            this.productStatusIDDataGridViewTextBoxColumn.Name = "productStatusIDDataGridViewTextBoxColumn";
            this.productStatusIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.productStatusIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // productCategoryIDDataGridViewTextBoxColumn
            // 
            this.productCategoryIDDataGridViewTextBoxColumn.DataPropertyName = "productCategoryID";
            this.productCategoryIDDataGridViewTextBoxColumn.HeaderText = "CategoryID";
            this.productCategoryIDDataGridViewTextBoxColumn.Name = "productCategoryIDDataGridViewTextBoxColumn";
            this.productCategoryIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.productCategoryIDDataGridViewTextBoxColumn.Width = 70;
            // 
            // productSupplierIDDataGridViewTextBoxColumn
            // 
            this.productSupplierIDDataGridViewTextBoxColumn.DataPropertyName = "productSupplierID";
            this.productSupplierIDDataGridViewTextBoxColumn.HeaderText = "SupplierID";
            this.productSupplierIDDataGridViewTextBoxColumn.Name = "productSupplierIDDataGridViewTextBoxColumn";
            this.productSupplierIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.productSupplierIDDataGridViewTextBoxColumn.Width = 70;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.iControlDataSet;
            this.productsBindingSource.Filter = "productStatusID=1";
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(655, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 13);
            this.label5.TabIndex = 80;
            this.label5.Text = "Enter keyword and click the button";
            // 
            // productSearchByID
            // 
            this.productSearchByID.Location = new System.Drawing.Point(730, 410);
            this.productSearchByID.Name = "productSearchByID";
            this.productSearchByID.Size = new System.Drawing.Size(64, 20);
            this.productSearchByID.TabIndex = 79;
            this.productSearchByID.Text = "ID";
            this.productSearchByID.UseVisualStyleBackColor = true;
            this.productSearchByID.Click += new System.EventHandler(this.productSearchByID_Click);
            // 
            // productShowAllButton
            // 
            this.productShowAllButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.productShowAllButton.Location = new System.Drawing.Point(1295, 389);
            this.productShowAllButton.Name = "productShowAllButton";
            this.productShowAllButton.Size = new System.Drawing.Size(63, 44);
            this.productShowAllButton.TabIndex = 77;
            this.productShowAllButton.Text = "Show All";
            this.productShowAllButton.UseVisualStyleBackColor = false;
            this.productShowAllButton.Click += new System.EventHandler(this.productShowAllButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(523, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 17);
            this.label6.TabIndex = 76;
            this.label6.Text = "Quick Search by -->";
            // 
            // productSearchByName
            // 
            this.productSearchByName.Location = new System.Drawing.Point(656, 410);
            this.productSearchByName.Name = "productSearchByName";
            this.productSearchByName.Size = new System.Drawing.Size(69, 20);
            this.productSearchByName.TabIndex = 75;
            this.productSearchByName.Text = "Name";
            this.productSearchByName.UseVisualStyleBackColor = true;
            this.productSearchByName.Click += new System.EventHandler(this.productSearchByName_Click);
            // 
            // productSearchBox
            // 
            this.productSearchBox.Location = new System.Drawing.Point(526, 410);
            this.productSearchBox.Name = "productSearchBox";
            this.productSearchBox.Size = new System.Drawing.Size(126, 20);
            this.productSearchBox.TabIndex = 74;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(1247, 646);
            this.labelDate.MinimumSize = new System.Drawing.Size(150, 20);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(150, 20);
            this.labelDate.TabIndex = 82;
            this.labelDate.Text = "Date";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DataSource = this.categoriesBindingSource;
            this.categoryComboBox.DisplayMember = "categoryName";
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(901, 409);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.categoryComboBox.TabIndex = 83;
            this.categoryComboBox.Tag = "";
            this.categoryComboBox.ValueMember = "categoryID";
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.iControlDataSet;
            this.categoriesBindingSource.Sort = "categoryName";
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(849, 415);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 84;
            this.label7.Text = "Category";
            // 
            // saveOrderButton
            // 
            this.saveOrderButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.saveOrderButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.saveOrderButton.Location = new System.Drawing.Point(311, 647);
            this.saveOrderButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveOrderButton.Name = "saveOrderButton";
            this.saveOrderButton.Size = new System.Drawing.Size(96, 32);
            this.saveOrderButton.TabIndex = 86;
            this.saveOrderButton.Text = "&SAVE ORDER";
            this.toolTipSaveOrder.SetToolTip(this.saveOrderButton, "Saving the order will save your ordering list as well as the customer \r\nassociate" +
        "d with it. The order status will be saved as pending until\r\nyou change it on the" +
        " View Orders screen");
            this.saveOrderButton.UseVisualStyleBackColor = false;
            this.saveOrderButton.Click += new System.EventHandler(this.saveOrderButton_Click);
            // 
            // placeOrderButton
            // 
            this.placeOrderButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.placeOrderButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.placeOrderButton.Location = new System.Drawing.Point(413, 647);
            this.placeOrderButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.placeOrderButton.Name = "placeOrderButton";
            this.placeOrderButton.Size = new System.Drawing.Size(97, 32);
            this.placeOrderButton.TabIndex = 87;
            this.placeOrderButton.Text = "&PLACE ORDER";
            this.placeOrderButton.UseVisualStyleBackColor = false;
            this.placeOrderButton.Click += new System.EventHandler(this.placeOrderButton_Click);
            // 
            // labelCategory
            // 
            this.labelCategory.Location = new System.Drawing.Point(1028, 410);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.ReadOnly = true;
            this.labelCategory.Size = new System.Drawing.Size(33, 20);
            this.labelCategory.TabIndex = 88;
            // 
            // productsOrderProductsBindingSource
            // 
            this.productsOrderProductsBindingSource.DataMember = "ProductsOrderProducts";
            this.productsOrderProductsBindingSource.DataSource = this.productsBindingSource;
            // 
            // orderProductsTableAdapter
            // 
            this.orderProductsTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(528, 658);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 90;
            this.label8.Text = "Select quantity:";
            // 
            // orderingListTable
            // 
            this.orderingListTable.AllowUserToAddRows = false;
            this.orderingListTable.AllowUserToDeleteRows = false;
            this.orderingListTable.AllowUserToResizeColumns = false;
            this.orderingListTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.ControlLight;
            this.orderingListTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.orderingListTable.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderingListTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.orderingListTable.ColumnHeadersHeight = 31;
            this.orderingListTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.orderingListTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.productName,
            this.productQuantity,
            this.productPrice,
            this.productTotalPrice});
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.orderingListTable.DefaultCellStyle = dataGridViewCellStyle19;
            this.orderingListTable.EnableHeadersVisualStyles = false;
            this.orderingListTable.Location = new System.Drawing.Point(14, 418);
            this.orderingListTable.Name = "orderingListTable";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderingListTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.orderingListTable.RowHeadersVisible = false;
            this.orderingListTable.RowTemplate.ReadOnly = true;
            this.orderingListTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.orderingListTable.Size = new System.Drawing.Size(496, 221);
            this.orderingListTable.TabIndex = 93;
            this.orderingListTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderingListTable_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // productName
            // 
            this.productName.HeaderText = "Product Name";
            this.productName.Name = "productName";
            // 
            // productQuantity
            // 
            this.productQuantity.HeaderText = "Quantity";
            this.productQuantity.Name = "productQuantity";
            // 
            // productPrice
            // 
            this.productPrice.HeaderText = "Unit Price";
            this.productPrice.Name = "productPrice";
            // 
            // productTotalPrice
            // 
            this.productTotalPrice.HeaderText = "Total Price";
            this.productTotalPrice.Name = "productTotalPrice";
            // 
            // productListTable
            // 
            this.productListTable.Location = new System.Drawing.Point(0, 0);
            this.productListTable.Name = "productListTable";
            this.productListTable.Size = new System.Drawing.Size(240, 150);
            this.productListTable.TabIndex = 0;
            // 
            // addToOrderButton
            // 
            this.addToOrderButton.BackColor = System.Drawing.Color.GreenYellow;
            this.addToOrderButton.Location = new System.Drawing.Point(756, 652);
            this.addToOrderButton.Name = "addToOrderButton";
            this.addToOrderButton.Size = new System.Drawing.Size(103, 23);
            this.addToOrderButton.TabIndex = 94;
            this.addToOrderButton.Text = "&ADD TO ORDER";
            this.toolTipAddToOrder.SetToolTip(this.addToOrderButton, "Add selected product to the \r\norder with the selected quantity.");
            this.addToOrderButton.UseVisualStyleBackColor = false;
            this.addToOrderButton.Click += new System.EventHandler(this.addToOrderButton_Click);
            // 
            // selectQuantityBox
            // 
            this.selectQuantityBox.Location = new System.Drawing.Point(611, 653);
            this.selectQuantityBox.Name = "selectQuantityBox";
            this.selectQuantityBox.Size = new System.Drawing.Size(100, 20);
            this.selectQuantityBox.TabIndex = 95;
            // 
            // deleteRowButton
            // 
            this.deleteRowButton.BackColor = System.Drawing.Color.LightCoral;
            this.deleteRowButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.deleteRowButton.Location = new System.Drawing.Point(14, 641);
            this.deleteRowButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteRowButton.Name = "deleteRowButton";
            this.deleteRowButton.Size = new System.Drawing.Size(65, 22);
            this.deleteRowButton.TabIndex = 96;
            this.deleteRowButton.Text = "&delete row";
            this.deleteRowButton.UseVisualStyleBackColor = false;
            this.deleteRowButton.Click += new System.EventHandler(this.deleteRowButton_Click);
            // 
            // labelTax
            // 
            this.labelTax.AutoSize = true;
            this.labelTax.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTax.Location = new System.Drawing.Point(1069, 764);
            this.labelTax.Name = "labelTax";
            this.labelTax.Size = new System.Drawing.Size(43, 25);
            this.labelTax.TabIndex = 97;
            this.labelTax.Text = "Tax:";
            // 
            // labelSubtotal
            // 
            this.labelSubtotal.AutoSize = true;
            this.labelSubtotal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubtotal.Location = new System.Drawing.Point(1026, 730);
            this.labelSubtotal.Name = "labelSubtotal";
            this.labelSubtotal.Size = new System.Drawing.Size(86, 25);
            this.labelSubtotal.TabIndex = 98;
            this.labelSubtotal.Text = "Subtotal:";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(1045, 804);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(67, 30);
            this.labelTotal.TabIndex = 99;
            this.labelTotal.Text = "Total:";
            // 
            // labelSubtotalSum
            // 
            this.labelSubtotalSum.AutoSize = true;
            this.labelSubtotalSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubtotalSum.Location = new System.Drawing.Point(1118, 731);
            this.labelSubtotalSum.Name = "labelSubtotalSum";
            this.labelSubtotalSum.Size = new System.Drawing.Size(45, 24);
            this.labelSubtotalSum.TabIndex = 100;
            this.labelSubtotalSum.Text = "0.00";
            // 
            // labelTaxSum
            // 
            this.labelTaxSum.AutoSize = true;
            this.labelTaxSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTaxSum.Location = new System.Drawing.Point(1118, 765);
            this.labelTaxSum.Name = "labelTaxSum";
            this.labelTaxSum.Size = new System.Drawing.Size(45, 24);
            this.labelTaxSum.TabIndex = 101;
            this.labelTaxSum.Text = "0.00";
            // 
            // labelTotalSum
            // 
            this.labelTotalSum.AutoSize = true;
            this.labelTotalSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalSum.Location = new System.Drawing.Point(1118, 799);
            this.labelTotalSum.Name = "labelTotalSum";
            this.labelTotalSum.Size = new System.Drawing.Size(80, 37);
            this.labelTotalSum.TabIndex = 102;
            this.labelTotalSum.Text = "0.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1262, 807);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 24);
            this.label9.TabIndex = 103;
            this.label9.Text = "CAD";
            // 
            // toolTipSaveOrder
            // 
            this.toolTipSaveOrder.ToolTipTitle = "Save Order";
            // 
            // toolTipAddToOrder
            // 
            this.toolTipAddToOrder.ToolTipTitle = "Add To Order";
            // 
            // viewOrdersButton
            // 
            this.viewOrdersButton.BackColor = System.Drawing.Color.SkyBlue;
            this.viewOrdersButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewOrdersButton.Location = new System.Drawing.Point(581, 804);
            this.viewOrdersButton.Name = "viewOrdersButton";
            this.viewOrdersButton.Size = new System.Drawing.Size(164, 39);
            this.viewOrdersButton.TabIndex = 104;
            this.viewOrdersButton.Text = "&View All Orders";
            this.viewOrdersButton.UseVisualStyleBackColor = false;
            this.viewOrdersButton.Click += new System.EventHandler(this.viewOrdersButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.LightCoral;
            this.label11.Image = ((System.Drawing.Image)(resources.GetObject("label11.Image")));
            this.label11.Location = new System.Drawing.Point(5, 7);
            this.label11.MinimumSize = new System.Drawing.Size(80, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 80);
            this.label11.TabIndex = 105;
            // 
            // productTemporaryList
            // 
            this.productTemporaryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productTemporaryList.Location = new System.Drawing.Point(155, 693);
            this.productTemporaryList.Name = "productTemporaryList";
            this.productTemporaryList.Size = new System.Drawing.Size(240, 150);
            this.productTemporaryList.TabIndex = 106;
            this.productTemporaryList.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(410, 392);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 107;
            this.label12.Text = "Order ID:";
            // 
            // orderIDTextBox
            // 
            this.orderIDTextBox.Location = new System.Drawing.Point(467, 387);
            this.orderIDTextBox.Name = "orderIDTextBox";
            this.orderIDTextBox.ReadOnly = true;
            this.orderIDTextBox.Size = new System.Drawing.Size(43, 20);
            this.orderIDTextBox.TabIndex = 108;
            // 
            // frmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 884);
            this.Controls.Add(this.orderIDTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.productTemporaryList);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.viewOrdersButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelTotalSum);
            this.Controls.Add(this.labelTaxSum);
            this.Controls.Add(this.labelSubtotalSum);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelSubtotal);
            this.Controls.Add(this.labelTax);
            this.Controls.Add(this.deleteRowButton);
            this.Controls.Add(this.selectQuantityBox);
            this.Controls.Add(this.addToOrderButton);
            this.Controls.Add(this.orderingListTable);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.placeOrderButton);
            this.Controls.Add(this.saveOrderButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.productSearchByID);
            this.Controls.Add(this.productShowAllButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.productSearchByName);
            this.Controls.Add(this.productSearchBox);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchByPhoneNumberButton);
            this.Controls.Add(this.searchByIDbutton);
            this.Controls.Add(this.searchByLastNameButton);
            this.Controls.Add(this.showAllButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.searchForFirstNameButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.phoneNumberBox3);
            this.Controls.Add(this.postalCodeBox);
            this.Controls.Add(this.countryBox);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.streetBox);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.labelPostalCode);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelStreet);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelProducts);
            this.Controls.Add(this.customerIDBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCustomer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iControl - Orders";
            this.Load += new System.EventHandler(this.Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iControlDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsOrderProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderingListTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productListTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTemporaryList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Label labelCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customerIDBox;
        private System.Windows.Forms.Label labelProducts;
        private iControlDataSet iControlDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private iControlDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Label labelPostalCode;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox streetBox;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.TextBox countryBox;
        private System.Windows.Forms.TextBox postalCodeBox;
        private System.Windows.Forms.TextBox phoneNumberBox3;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource customersBindingSource1;
        private System.Windows.Forms.Button searchByLastNameButton;
        private System.Windows.Forms.Button showAllButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button searchForFirstNameButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchByIDbutton;
        private System.Windows.Forms.Button searchByPhoneNumberButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerStreet;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPostalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPhoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private iControlDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private iControlDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button productSearchByID;
        private System.Windows.Forms.Button productShowAllButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button productSearchByName;
        private System.Windows.Forms.TextBox productSearchBox;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private iControlDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button saveOrderButton;
        private System.Windows.Forms.Button placeOrderButton;
        private System.Windows.Forms.TextBox labelCategory;
        private System.Windows.Forms.BindingSource productsOrderProductsBindingSource;
        private iControlDataSetTableAdapters.OrderProductsTableAdapter orderProductsTableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView orderingListTable;
        private System.Windows.Forms.DataGridView productListTable;
        private System.Windows.Forms.Button addToOrderButton;
        private System.Windows.Forms.TextBox selectQuantityBox;
        private System.Windows.Forms.Button deleteRowButton;
        private System.Windows.Forms.Label labelTax;
        private System.Windows.Forms.Label labelSubtotal;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelSubtotalSum;
        private System.Windows.Forms.Label labelTaxSum;
        private System.Windows.Forms.Label labelTotalSum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolTip toolTipSaveOrder;
        private System.Windows.Forms.ToolTip toolTipAddToOrder;
        private System.Windows.Forms.Button viewOrdersButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productMaximumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productMinimumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productStatusIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCategoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productSupplierIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn productTotalPrice;
        private System.Windows.Forms.DataGridView productTemporaryList;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox orderIDTextBox;
    }
}
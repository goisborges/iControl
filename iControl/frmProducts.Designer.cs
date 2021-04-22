
namespace iControl
{
    partial class frmProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducts));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.homebutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.productId = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.iControlDataSet = new iControl.iControlDataSet();
            this.delete_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.productName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.productsTableAdapter = new iControl.iControlDataSetTableAdapters.ProductsTableAdapter();
            this.productDescription = new System.Windows.Forms.TextBox();
            this.productQuantity = new System.Windows.Forms.TextBox();
            this.productMin = new System.Windows.Forms.TextBox();
            this.productMax = new System.Windows.Forms.TextBox();
            this.productPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.radioActive = new System.Windows.Forms.RadioButton();
            this.radioDiscontinued = new System.Windows.Forms.RadioButton();
            this.productCategories = new System.Windows.Forms.ComboBox();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesTableAdapter = new iControl.iControlDataSetTableAdapters.CategoriesTableAdapter();
            this.productSuppliers = new System.Windows.Forms.ComboBox();
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suppliersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.suppliersTableAdapter = new iControl.iControlDataSetTableAdapters.SuppliersTableAdapter();
            this.productStatus = new System.Windows.Forms.GroupBox();
            this.labelCategory = new System.Windows.Forms.TextBox();
            this.labelSupplier = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.TextBox();
            this.iControlDataSet1 = new iControl.iControlDataSet();
            this.toolTipSupplier = new System.Windows.Forms.ToolTip(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iControlDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource1)).BeginInit();
            this.productStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iControlDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // homebutton
            // 
            this.homebutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.homebutton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.homebutton.Image = ((System.Drawing.Image)(resources.GetObject("homebutton.Image")));
            this.homebutton.Location = new System.Drawing.Point(0, 592);
            this.homebutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.homebutton.MaximumSize = new System.Drawing.Size(58, 65);
            this.homebutton.MinimumSize = new System.Drawing.Size(58, 65);
            this.homebutton.Name = "homebutton";
            this.homebutton.Size = new System.Drawing.Size(58, 65);
            this.homebutton.TabIndex = 13;
            this.homebutton.UseVisualStyleBackColor = true;
            this.homebutton.Click += new System.EventHandler(this.homebutton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "ID";
            // 
            // productId
            // 
            this.productId.Enabled = false;
            this.productId.Location = new System.Drawing.Point(285, 194);
            this.productId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.productId.Name = "productId";
            this.productId.ReadOnly = true;
            this.productId.Size = new System.Drawing.Size(33, 25);
            this.productId.TabIndex = 25;
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
            this.dataGridView1.DataSource = this.productsBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(358, 152);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(683, 412);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "productID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.productIDDataGridViewTextBoxColumn.Width = 40;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "productName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.productNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // productDescriptionDataGridViewTextBoxColumn
            // 
            this.productDescriptionDataGridViewTextBoxColumn.DataPropertyName = "productDescription";
            this.productDescriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.productDescriptionDataGridViewTextBoxColumn.Name = "productDescriptionDataGridViewTextBoxColumn";
            this.productDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.productDescriptionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.productDescriptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // productQuantityDataGridViewTextBoxColumn
            // 
            this.productQuantityDataGridViewTextBoxColumn.DataPropertyName = "productQuantity";
            this.productQuantityDataGridViewTextBoxColumn.HeaderText = "Quant";
            this.productQuantityDataGridViewTextBoxColumn.Name = "productQuantityDataGridViewTextBoxColumn";
            this.productQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.productQuantityDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.productQuantityDataGridViewTextBoxColumn.Width = 50;
            // 
            // productMaximumDataGridViewTextBoxColumn
            // 
            this.productMaximumDataGridViewTextBoxColumn.DataPropertyName = "productMaximum";
            this.productMaximumDataGridViewTextBoxColumn.HeaderText = "prod max";
            this.productMaximumDataGridViewTextBoxColumn.Name = "productMaximumDataGridViewTextBoxColumn";
            this.productMaximumDataGridViewTextBoxColumn.ReadOnly = true;
            this.productMaximumDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.productMaximumDataGridViewTextBoxColumn.Width = 50;
            // 
            // productMinimumDataGridViewTextBoxColumn
            // 
            this.productMinimumDataGridViewTextBoxColumn.DataPropertyName = "productMinimum";
            this.productMinimumDataGridViewTextBoxColumn.HeaderText = "prod min";
            this.productMinimumDataGridViewTextBoxColumn.Name = "productMinimumDataGridViewTextBoxColumn";
            this.productMinimumDataGridViewTextBoxColumn.ReadOnly = true;
            this.productMinimumDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.productMinimumDataGridViewTextBoxColumn.Width = 50;
            // 
            // productPriceDataGridViewTextBoxColumn
            // 
            this.productPriceDataGridViewTextBoxColumn.DataPropertyName = "productPrice";
            this.productPriceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.productPriceDataGridViewTextBoxColumn.Name = "productPriceDataGridViewTextBoxColumn";
            this.productPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.productPriceDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.productPriceDataGridViewTextBoxColumn.Width = 60;
            // 
            // productStatusIDDataGridViewTextBoxColumn
            // 
            this.productStatusIDDataGridViewTextBoxColumn.DataPropertyName = "productStatusID";
            this.productStatusIDDataGridViewTextBoxColumn.HeaderText = "Status";
            this.productStatusIDDataGridViewTextBoxColumn.Name = "productStatusIDDataGridViewTextBoxColumn";
            this.productStatusIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.productStatusIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.productStatusIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // productCategoryIDDataGridViewTextBoxColumn
            // 
            this.productCategoryIDDataGridViewTextBoxColumn.DataPropertyName = "productCategoryID";
            this.productCategoryIDDataGridViewTextBoxColumn.HeaderText = "Categ";
            this.productCategoryIDDataGridViewTextBoxColumn.Name = "productCategoryIDDataGridViewTextBoxColumn";
            this.productCategoryIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.productCategoryIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.productCategoryIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // productSupplierIDDataGridViewTextBoxColumn
            // 
            this.productSupplierIDDataGridViewTextBoxColumn.DataPropertyName = "productSupplierID";
            this.productSupplierIDDataGridViewTextBoxColumn.HeaderText = "Supplier";
            this.productSupplierIDDataGridViewTextBoxColumn.Name = "productSupplierIDDataGridViewTextBoxColumn";
            this.productSupplierIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.productSupplierIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.productSupplierIDDataGridViewTextBoxColumn.Width = 70;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.iControlDataSet;
            // 
            // iControlDataSet
            // 
            this.iControlDataSet.DataSetName = "iControlDataSet";
            this.iControlDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.Color.LightCoral;
            this.delete_button.Enabled = false;
            this.delete_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.delete_button.Location = new System.Drawing.Point(280, 522);
            this.delete_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(72, 42);
            this.delete_button.TabIndex = 11;
            this.delete_button.Text = "&DEL";
            this.delete_button.UseVisualStyleBackColor = false;
            // 
            // edit_button
            // 
            this.edit_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.edit_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.edit_button.Location = new System.Drawing.Point(193, 522);
            this.edit_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(72, 42);
            this.edit_button.TabIndex = 10;
            this.edit_button.Text = "&EDIT";
            this.edit_button.UseVisualStyleBackColor = false;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.add_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.add_button.Location = new System.Drawing.Point(103, 522);
            this.add_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(72, 42);
            this.add_button.TabIndex = 9;
            this.add_button.Text = "&ADD";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(103, 194);
            this.productName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(136, 25);
            this.productName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "To add a new product: Insert data and click ADD";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCoral;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 657);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1080, 30);
            this.panel2.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 89);
            this.panel1.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Image = ((System.Drawing.Image)(resources.GetObject("label13.Image")));
            this.label13.Location = new System.Drawing.Point(5, 5);
            this.label13.MinimumSize = new System.Drawing.Size(80, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 80);
            this.label13.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1080, 89);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Products";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // productDescription
            // 
            this.productDescription.Location = new System.Drawing.Point(103, 227);
            this.productDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.productDescription.Multiline = true;
            this.productDescription.Name = "productDescription";
            this.productDescription.Size = new System.Drawing.Size(215, 66);
            this.productDescription.TabIndex = 1;
            // 
            // productQuantity
            // 
            this.productQuantity.Location = new System.Drawing.Point(103, 301);
            this.productQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.productQuantity.Name = "productQuantity";
            this.productQuantity.Size = new System.Drawing.Size(87, 25);
            this.productQuantity.TabIndex = 2;
            // 
            // productMin
            // 
            this.productMin.Location = new System.Drawing.Point(262, 301);
            this.productMin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.productMin.Name = "productMin";
            this.productMin.Size = new System.Drawing.Size(56, 25);
            this.productMin.TabIndex = 4;
            // 
            // productMax
            // 
            this.productMax.Location = new System.Drawing.Point(198, 301);
            this.productMax.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.productMax.Name = "productMax";
            this.productMax.Size = new System.Drawing.Size(56, 25);
            this.productMax.TabIndex = 3;
            // 
            // productPrice
            // 
            this.productPrice.Location = new System.Drawing.Point(103, 334);
            this.productPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(151, 25);
            this.productPrice.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 38;
            this.label6.Text = "Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 17);
            this.label7.TabIndex = 39;
            this.label7.Text = "Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(260, 337);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 21);
            this.label9.TabIndex = 40;
            this.label9.Text = "CAD";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 457);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 17);
            this.label11.TabIndex = 42;
            this.label11.Text = "Category";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 490);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 17);
            this.label12.TabIndex = 43;
            this.label12.Text = "Supplier";
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
            this.radioActive.CheckedChanged += new System.EventHandler(this.radioActive_CheckedChanged);
            // 
            // radioDiscontinued
            // 
            this.radioDiscontinued.AutoSize = true;
            this.radioDiscontinued.Location = new System.Drawing.Point(6, 51);
            this.radioDiscontinued.Name = "radioDiscontinued";
            this.radioDiscontinued.Size = new System.Drawing.Size(100, 21);
            this.radioDiscontinued.TabIndex = 45;
            this.radioDiscontinued.TabStop = true;
            this.radioDiscontinued.Text = "discontinued";
            this.radioDiscontinued.UseVisualStyleBackColor = true;
            this.radioDiscontinued.CheckedChanged += new System.EventHandler(this.radioDiscontinued_CheckedChanged);
            // 
            // productCategories
            // 
            this.productCategories.DataSource = this.categoriesBindingSource;
            this.productCategories.DisplayMember = "categoryName";
            this.productCategories.FormattingEnabled = true;
            this.productCategories.Location = new System.Drawing.Point(103, 457);
            this.productCategories.Name = "productCategories";
            this.productCategories.Size = new System.Drawing.Size(151, 25);
            this.productCategories.TabIndex = 7;
            this.productCategories.ValueMember = "categoryID";
            this.productCategories.SelectedIndexChanged += new System.EventHandler(this.productCategories_SelectedIndexChanged);
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
            // productSuppliers
            // 
            this.productSuppliers.DataSource = this.suppliersBindingSource;
            this.productSuppliers.DisplayMember = "supplierName";
            this.productSuppliers.FormattingEnabled = true;
            this.productSuppliers.Location = new System.Drawing.Point(103, 490);
            this.productSuppliers.Name = "productSuppliers";
            this.productSuppliers.Size = new System.Drawing.Size(151, 25);
            this.productSuppliers.TabIndex = 8;
            this.toolTipSupplier.SetToolTip(this.productSuppliers, "Only active suppliers can be selected\r\nIf your desired supplier is not here, \r\ngo" +
        " to the suppliers screen and change it \r\nfrom dorment to active.");
            this.productSuppliers.ValueMember = "supplierID";
            this.productSuppliers.SelectedIndexChanged += new System.EventHandler(this.productSuppliers_SelectedIndexChanged);
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataMember = "Suppliers";
            this.suppliersBindingSource.DataSource = this.iControlDataSet;
            this.suppliersBindingSource.Filter = "supplierStatusID = 1";
            this.suppliersBindingSource.Sort = "supplierName";
            // 
            // suppliersBindingSource1
            // 
            this.suppliersBindingSource1.DataMember = "Suppliers";
            this.suppliersBindingSource1.DataSource = this.iControlDataSet;
            // 
            // suppliersTableAdapter
            // 
            this.suppliersTableAdapter.ClearBeforeFill = true;
            // 
            // productStatus
            // 
            this.productStatus.Controls.Add(this.radioDiscontinued);
            this.productStatus.Controls.Add(this.radioActive);
            this.productStatus.Location = new System.Drawing.Point(103, 366);
            this.productStatus.Name = "productStatus";
            this.productStatus.Size = new System.Drawing.Size(198, 85);
            this.productStatus.TabIndex = 6;
            this.productStatus.TabStop = false;
            this.productStatus.Text = "Status";
            // 
            // labelCategory
            // 
            this.labelCategory.Location = new System.Drawing.Point(260, 457);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.ReadOnly = true;
            this.labelCategory.Size = new System.Drawing.Size(92, 25);
            this.labelCategory.TabIndex = 49;
            // 
            // labelSupplier
            // 
            this.labelSupplier.Location = new System.Drawing.Point(260, 490);
            this.labelSupplier.Name = "labelSupplier";
            this.labelSupplier.ReadOnly = true;
            this.labelSupplier.Size = new System.Drawing.Size(92, 25);
            this.labelSupplier.TabIndex = 50;
            // 
            // labelStatus
            // 
            this.labelStatus.Location = new System.Drawing.Point(307, 376);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.ReadOnly = true;
            this.labelStatus.Size = new System.Drawing.Size(29, 25);
            this.labelStatus.TabIndex = 51;
            // 
            // iControlDataSet1
            // 
            this.iControlDataSet1.DataSetName = "iControlDataSet";
            this.iControlDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolTipSupplier
            // 
            this.toolTipSupplier.IsBalloon = true;
            this.toolTipSupplier.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipSupplier.ToolTipTitle = "Supplier Info";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 142);
            this.label8.MaximumSize = new System.Drawing.Size(300, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(287, 34);
            this.label8.TabIndex = 11;
            this.label8.Text = "To edit an existing product: click on product on table, edit it\'s values and clic" +
    "k EDIT";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 316);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 11);
            this.label10.TabIndex = 52;
            this.label10.Text = "Total / Max / Min";
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 687);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelSupplier);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.productStatus);
            this.Controls.Add(this.productSuppliers);
            this.Controls.Add(this.productCategories);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.productPrice);
            this.Controls.Add(this.productMax);
            this.Controls.Add(this.productMin);
            this.Controls.Add(this.productQuantity);
            this.Controls.Add(this.productDescription);
            this.Controls.Add(this.homebutton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.productId);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iControl - Manage Products";
            this.Load += new System.EventHandler(this.Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iControlDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource1)).EndInit();
            this.productStatus.ResumeLayout(false);
            this.productStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iControlDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button homebutton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox productId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private iControlDataSet iControlDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private iControlDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.TextBox productDescription;
        private System.Windows.Forms.TextBox productQuantity;
        private System.Windows.Forms.TextBox productMin;
        private System.Windows.Forms.TextBox productMax;
        private System.Windows.Forms.TextBox productPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton radioActive;
        private System.Windows.Forms.RadioButton radioDiscontinued;
        private System.Windows.Forms.ComboBox productCategories;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private iControlDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.ComboBox productSuppliers;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private iControlDataSetTableAdapters.SuppliersTableAdapter suppliersTableAdapter;
        private System.Windows.Forms.GroupBox productStatus;
        private System.Windows.Forms.TextBox labelCategory;
        private System.Windows.Forms.TextBox labelSupplier;
        private System.Windows.Forms.TextBox labelStatus;
        private iControlDataSet iControlDataSet1;
        private System.Windows.Forms.ToolTip toolTipSupplier;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
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
        private System.Windows.Forms.BindingSource suppliersBindingSource1;
    }
}
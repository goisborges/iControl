
namespace iControl
{
    partial class frmViewOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewOrders));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.orderStatusComboBox = new System.Windows.Forms.ComboBox();
            this.orderStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iControlDataSet = new iControl.iControlDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.orderStatusTableAdapter = new iControl.iControlDataSetTableAdapters.OrderStatusTableAdapter();
            this.searchByLastNameButton = new System.Windows.Forms.Button();
            this.showAllButton = new System.Windows.Forms.Button();
            this.searchByFirstNameButton = new System.Windows.Forms.Button();
            this.filterSearchBox = new System.Windows.Forms.TextBox();
            this.placeOrderButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iControlDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.LightCoral;
            this.label11.Image = ((System.Drawing.Image)(resources.GetObject("label11.Image")));
            this.label11.Location = new System.Drawing.Point(5, 6);
            this.label11.MinimumSize = new System.Drawing.Size(80, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 80);
            this.label11.TabIndex = 107;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(773, 93);
            this.label1.TabIndex = 106;
            this.label1.Text = "View Orders";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.AllowUserToAddRows = false;
            this.dataGridViewOrders.AllowUserToDeleteRows = false;
            this.dataGridViewOrders.AllowUserToResizeColumns = false;
            this.dataGridViewOrders.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOrders.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewOrders.EnableHeadersVisualStyles = false;
            this.dataGridViewOrders.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewOrders.Location = new System.Drawing.Point(12, 147);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.ReadOnly = true;
            this.dataGridViewOrders.RowHeadersVisible = false;
            this.dataGridViewOrders.Size = new System.Drawing.Size(678, 387);
            this.dataGridViewOrders.TabIndex = 108;
            this.dataGridViewOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrders_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCoral;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 707);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(773, 23);
            this.panel2.TabIndex = 109;
            // 
            // orderStatusComboBox
            // 
            this.orderStatusComboBox.DataSource = this.orderStatusBindingSource;
            this.orderStatusComboBox.DisplayMember = "orderStatusName";
            this.orderStatusComboBox.FormattingEnabled = true;
            this.orderStatusComboBox.Location = new System.Drawing.Point(15, 120);
            this.orderStatusComboBox.Name = "orderStatusComboBox";
            this.orderStatusComboBox.Size = new System.Drawing.Size(121, 21);
            this.orderStatusComboBox.TabIndex = 110;
            this.orderStatusComboBox.ValueMember = "orderStatusID";
            this.orderStatusComboBox.SelectedIndexChanged += new System.EventHandler(this.orderStatusComboBox_SelectedIndexChanged);
            // 
            // orderStatusBindingSource
            // 
            this.orderStatusBindingSource.DataMember = "OrderStatus";
            this.orderStatusBindingSource.DataSource = this.iControlDataSet;
            // 
            // iControlDataSet
            // 
            this.iControlDataSet.DataSetName = "iControlDataSet";
            this.iControlDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 111;
            this.label2.Text = "Filter by order status:";
            // 
            // orderStatusTableAdapter
            // 
            this.orderStatusTableAdapter.ClearBeforeFill = true;
            // 
            // searchByLastNameButton
            // 
            this.searchByLastNameButton.Location = new System.Drawing.Point(556, 121);
            this.searchByLastNameButton.Name = "searchByLastNameButton";
            this.searchByLastNameButton.Size = new System.Drawing.Size(64, 20);
            this.searchByLastNameButton.TabIndex = 115;
            this.searchByLastNameButton.Text = "last name";
            this.searchByLastNameButton.UseVisualStyleBackColor = true;
            this.searchByLastNameButton.Click += new System.EventHandler(this.searchByLastNameButton_Click);
            // 
            // showAllButton
            // 
            this.showAllButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.showAllButton.Location = new System.Drawing.Point(627, 96);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(63, 44);
            this.showAllButton.TabIndex = 114;
            this.showAllButton.Text = "Show &All";
            this.showAllButton.UseVisualStyleBackColor = false;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // searchByFirstNameButton
            // 
            this.searchByFirstNameButton.Location = new System.Drawing.Point(482, 121);
            this.searchByFirstNameButton.Name = "searchByFirstNameButton";
            this.searchByFirstNameButton.Size = new System.Drawing.Size(69, 20);
            this.searchByFirstNameButton.TabIndex = 113;
            this.searchByFirstNameButton.Text = "first name";
            this.searchByFirstNameButton.UseVisualStyleBackColor = true;
            this.searchByFirstNameButton.Click += new System.EventHandler(this.searchByFirstNameButton_Click);
            // 
            // filterSearchBox
            // 
            this.filterSearchBox.Location = new System.Drawing.Point(351, 121);
            this.filterSearchBox.Name = "filterSearchBox";
            this.filterSearchBox.Size = new System.Drawing.Size(126, 20);
            this.filterSearchBox.TabIndex = 112;
            // 
            // placeOrderButton
            // 
            this.placeOrderButton.BackColor = System.Drawing.Color.YellowGreen;
            this.placeOrderButton.Location = new System.Drawing.Point(12, 540);
            this.placeOrderButton.Name = "placeOrderButton";
            this.placeOrderButton.Size = new System.Drawing.Size(124, 44);
            this.placeOrderButton.TabIndex = 116;
            this.placeOrderButton.Text = "PLACE &ORDER";
            this.placeOrderButton.UseVisualStyleBackColor = false;
            this.placeOrderButton.Click += new System.EventHandler(this.placeOrderButton_Click);
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.LightSalmon;
            this.printButton.Location = new System.Drawing.Point(566, 540);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(124, 44);
            this.printButton.TabIndex = 117;
            this.printButton.Text = "&PRINT INVOICE";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.editButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.editButton.Location = new System.Drawing.Point(142, 540);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(124, 44);
            this.editButton.TabIndex = 118;
            this.editButton.Text = "&EDIT ORDER";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.homeButton.Location = new System.Drawing.Point(0, 647);
            this.homeButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.homeButton.MaximumSize = new System.Drawing.Size(60, 60);
            this.homeButton.MinimumSize = new System.Drawing.Size(60, 60);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(60, 60);
            this.homeButton.TabIndex = 119;
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(66, 667);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 32);
            this.button1.TabIndex = 120;
            this.button1.Text = "&Back to Orders";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmViewOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 730);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.placeOrderButton);
            this.Controls.Add(this.searchByLastNameButton);
            this.Controls.Add(this.showAllButton);
            this.Controls.Add(this.searchByFirstNameButton);
            this.Controls.Add(this.filterSearchBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.orderStatusComboBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridViewOrders);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmViewOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iControl - View Orders";
            this.Load += new System.EventHandler(this.frmViewOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iControlDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox orderStatusComboBox;
        private System.Windows.Forms.Label label2;
        private iControlDataSet iControlDataSet;
        private System.Windows.Forms.BindingSource orderStatusBindingSource;
        private iControlDataSetTableAdapters.OrderStatusTableAdapter orderStatusTableAdapter;
        private System.Windows.Forms.Button searchByLastNameButton;
        private System.Windows.Forms.Button showAllButton;
        private System.Windows.Forms.Button searchByFirstNameButton;
        private System.Windows.Forms.TextBox filterSearchBox;
        private System.Windows.Forms.Button placeOrderButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button button1;
    }
}
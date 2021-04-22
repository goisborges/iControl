using System.Data.OleDb;

namespace iControl
{
    partial class frmSuppliers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuppliers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.delete_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.supplierid = new System.Windows.Forms.TextBox();
            this.suppliername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.homebutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.supplierIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierPhoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierWebsiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierStatusIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iControlDataSet = new iControl.iControlDataSet();
            this.suppliersTableAdapter = new iControl.iControlDataSetTableAdapters.SuppliersTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.supplieremail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.supplierphone = new System.Windows.Forms.TextBox();
            this.websitelabel = new System.Windows.Forms.Label();
            this.supplierwebsite = new System.Windows.Forms.TextBox();
            this.labelwebsite = new System.Windows.Forms.Label();
            this.supplierstatus = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.toolTipStatusId = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipPhone = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iControlDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(933, 89);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Suppliers";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 89);
            this.panel1.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.Location = new System.Drawing.Point(4, 5);
            this.label9.MinimumSize = new System.Drawing.Size(80, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 80);
            this.label9.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(933, 89);
            this.label2.TabIndex = 1;
            this.label2.Text = "Manage Suppliers";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.Color.LightCoral;
            this.delete_button.Enabled = false;
            this.delete_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.delete_button.Location = new System.Drawing.Point(152, 430);
            this.delete_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(65, 30);
            this.delete_button.TabIndex = 7;
            this.delete_button.Text = "&DEL";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.edit_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.edit_button.Location = new System.Drawing.Point(81, 430);
            this.edit_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(59, 30);
            this.edit_button.TabIndex = 6;
            this.edit_button.Text = "&EDIT";
            this.edit_button.UseVisualStyleBackColor = false;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click_1);
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.add_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.add_button.Location = new System.Drawing.Point(9, 430);
            this.add_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(61, 30);
            this.add_button.TabIndex = 5;
            this.add_button.Text = "&ADD";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "ID";
            // 
            // supplierid
            // 
            this.supplierid.Enabled = false;
            this.supplierid.Location = new System.Drawing.Point(74, 155);
            this.supplierid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.supplierid.Name = "supplierid";
            this.supplierid.ReadOnly = true;
            this.supplierid.Size = new System.Drawing.Size(34, 25);
            this.supplierid.TabIndex = 18;
            // 
            // suppliername
            // 
            this.suppliername.Location = new System.Drawing.Point(74, 190);
            this.suppliername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.suppliername.Name = "suppliername";
            this.suppliername.Size = new System.Drawing.Size(143, 25);
            this.suppliername.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Insert new data or edit existing data";
            // 
            // homebutton
            // 
            this.homebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.homebutton.AutoSize = true;
            this.homebutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.homebutton.Image = ((System.Drawing.Image)(resources.GetObject("homebutton.Image")));
            this.homebutton.Location = new System.Drawing.Point(9, 515);
            this.homebutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.homebutton.MaximumSize = new System.Drawing.Size(50, 50);
            this.homebutton.MinimumSize = new System.Drawing.Size(50, 50);
            this.homebutton.Name = "homebutton";
            this.homebutton.Size = new System.Drawing.Size(50, 50);
            this.homebutton.TabIndex = 9;
            this.homebutton.UseVisualStyleBackColor = true;
            this.homebutton.Click += new System.EventHandler(this.homebutton_Click_1);
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
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supplierIDDataGridViewTextBoxColumn,
            this.supplierNameDataGridViewTextBoxColumn,
            this.supplierEmailDataGridViewTextBoxColumn,
            this.supplierPhoneNumberDataGridViewTextBoxColumn,
            this.supplierWebsiteDataGridViewTextBoxColumn,
            this.supplierStatusIDDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.DataSource = this.suppliersBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(236, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(663, 339);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // supplierIDDataGridViewTextBoxColumn
            // 
            this.supplierIDDataGridViewTextBoxColumn.DataPropertyName = "supplierID";
            this.supplierIDDataGridViewTextBoxColumn.Frozen = true;
            this.supplierIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.supplierIDDataGridViewTextBoxColumn.Name = "supplierIDDataGridViewTextBoxColumn";
            this.supplierIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.supplierIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.supplierIDDataGridViewTextBoxColumn.Width = 30;
            // 
            // supplierNameDataGridViewTextBoxColumn
            // 
            this.supplierNameDataGridViewTextBoxColumn.DataPropertyName = "supplierName";
            this.supplierNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.supplierNameDataGridViewTextBoxColumn.Name = "supplierNameDataGridViewTextBoxColumn";
            this.supplierNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.supplierNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.supplierNameDataGridViewTextBoxColumn.Width = 130;
            // 
            // supplierEmailDataGridViewTextBoxColumn
            // 
            this.supplierEmailDataGridViewTextBoxColumn.DataPropertyName = "supplierEmail";
            this.supplierEmailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.supplierEmailDataGridViewTextBoxColumn.Name = "supplierEmailDataGridViewTextBoxColumn";
            this.supplierEmailDataGridViewTextBoxColumn.ReadOnly = true;
            this.supplierEmailDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.supplierEmailDataGridViewTextBoxColumn.Width = 160;
            // 
            // supplierPhoneNumberDataGridViewTextBoxColumn
            // 
            this.supplierPhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "supplierPhoneNumber";
            this.supplierPhoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone #";
            this.supplierPhoneNumberDataGridViewTextBoxColumn.Name = "supplierPhoneNumberDataGridViewTextBoxColumn";
            this.supplierPhoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.supplierPhoneNumberDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // supplierWebsiteDataGridViewTextBoxColumn
            // 
            this.supplierWebsiteDataGridViewTextBoxColumn.DataPropertyName = "supplierWebsite";
            this.supplierWebsiteDataGridViewTextBoxColumn.HeaderText = "Website";
            this.supplierWebsiteDataGridViewTextBoxColumn.Name = "supplierWebsiteDataGridViewTextBoxColumn";
            this.supplierWebsiteDataGridViewTextBoxColumn.ReadOnly = true;
            this.supplierWebsiteDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.supplierWebsiteDataGridViewTextBoxColumn.Width = 180;
            // 
            // supplierStatusIDDataGridViewTextBoxColumn
            // 
            this.supplierStatusIDDataGridViewTextBoxColumn.DataPropertyName = "supplierStatusID";
            this.supplierStatusIDDataGridViewTextBoxColumn.HeaderText = "Status";
            this.supplierStatusIDDataGridViewTextBoxColumn.Name = "supplierStatusIDDataGridViewTextBoxColumn";
            this.supplierStatusIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.supplierStatusIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.supplierStatusIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataMember = "Suppliers";
            this.suppliersBindingSource.DataSource = this.iControlDataSet;
            // 
            // iControlDataSet
            // 
            this.iControlDataSet.DataSetName = "iControlDataSet";
            this.iControlDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // suppliersTableAdapter
            // 
            this.suppliersTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "E-mail";
            // 
            // supplieremail
            // 
            this.supplieremail.Location = new System.Drawing.Point(74, 230);
            this.supplieremail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.supplieremail.Name = "supplieremail";
            this.supplieremail.Size = new System.Drawing.Size(143, 25);
            this.supplieremail.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Phone";
            // 
            // supplierphone
            // 
            this.supplierphone.Location = new System.Drawing.Point(74, 269);
            this.supplierphone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.supplierphone.Name = "supplierphone";
            this.supplierphone.Size = new System.Drawing.Size(143, 25);
            this.supplierphone.TabIndex = 2;
            this.toolTipPhone.SetToolTip(this.supplierphone, "Format as: 555-555-5555");
            // 
            // websitelabel
            // 
            this.websitelabel.AutoSize = true;
            this.websitelabel.Location = new System.Drawing.Point(15, 311);
            this.websitelabel.Name = "websitelabel";
            this.websitelabel.Size = new System.Drawing.Size(54, 17);
            this.websitelabel.TabIndex = 26;
            this.websitelabel.Text = "Website";
            // 
            // supplierwebsite
            // 
            this.supplierwebsite.Location = new System.Drawing.Point(74, 308);
            this.supplierwebsite.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.supplierwebsite.Name = "supplierwebsite";
            this.supplierwebsite.Size = new System.Drawing.Size(143, 25);
            this.supplierwebsite.TabIndex = 3;
            // 
            // labelwebsite
            // 
            this.labelwebsite.AutoSize = true;
            this.labelwebsite.Location = new System.Drawing.Point(9, 355);
            this.labelwebsite.Name = "labelwebsite";
            this.labelwebsite.Size = new System.Drawing.Size(59, 17);
            this.labelwebsite.TabIndex = 28;
            this.labelwebsite.Text = "Status ID";
            // 
            // supplierstatus
            // 
            this.supplierstatus.Location = new System.Drawing.Point(74, 352);
            this.supplierstatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.supplierstatus.Name = "supplierstatus";
            this.supplierstatus.Size = new System.Drawing.Size(143, 25);
            this.supplierstatus.TabIndex = 4;
            this.toolTipStatusId.SetToolTip(this.supplierstatus, "1 for Active or 2 for Dorment");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(76, 381);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "1 for Active, 2 for Dorment ";
            // 
            // toolTipStatusId
            // 
            this.toolTipStatusId.IsBalloon = true;
            this.toolTipStatusId.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipStatusId.ToolTipTitle = "Status ID Info";
            // 
            // toolTipPhone
            // 
            this.toolTipPhone.IsBalloon = true;
            this.toolTipPhone.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipPhone.ToolTipTitle = "Phone Format Tip";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.LightCoral;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 566);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(933, 23);
            this.panel2.TabIndex = 31;
            // 
            // frmSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 589);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.supplierstatus);
            this.Controls.Add(this.labelwebsite);
            this.Controls.Add(this.supplierwebsite);
            this.Controls.Add(this.websitelabel);
            this.Controls.Add(this.supplierphone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.supplieremail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.homebutton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.supplierid);
            this.Controls.Add(this.suppliername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmSuppliers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iControl - Suppliers";
            this.Load += new System.EventHandler(this.Suppliers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iControlDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox supplierid;
        private System.Windows.Forms.TextBox suppliername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button homebutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private iControlDataSet iControlDataSet;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private iControlDataSetTableAdapters.SuppliersTableAdapter suppliersTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox supplieremail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox supplierphone;
        private System.Windows.Forms.Label websitelabel;
        private System.Windows.Forms.TextBox supplierwebsite;
        private System.Windows.Forms.Label labelwebsite;
        private System.Windows.Forms.TextBox supplierstatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolTip toolTipStatusId;
        private System.Windows.Forms.ToolTip toolTipPhone;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierPhoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierWebsiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierStatusIDDataGridViewTextBoxColumn;
    }
}
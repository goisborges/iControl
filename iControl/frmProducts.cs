/* This will be the Products form for our iControl application.
 * 
 * @author Andrew Morrison
 * @verison: 20 Mar 21 - initial build
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Text.RegularExpressions;

namespace iControl
{
    public partial class frmProducts : Form
    {
        OleDbConnection vcon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\iControl.accdb");
        //Create OleDb connection : need to import System.Data.OleDb first!
        //OleDbConnection vcon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\goisb\Documents\GitHub\iControl\database\iControl.accdb");

        //Andrew's connection
        //OleDbConnection vcon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Andrew School\Dropbox\COMP1098-.NetC#\Project\iControl\database\iControl.accdb");
        public frmProducts()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iControlDataSet1.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.iControlDataSet.Suppliers);
            // TODO: This line of code loads data into the 'iControlDataSet.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.iControlDataSet.Suppliers);
            // TODO: This line of code loads data into the 'iControlDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.iControlDataSet.Categories);
            // TODO: This line of code loads data into the 'iControlDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.iControlDataSet.Products);
            //open the connection
            vcon.Open();
        }

        //Home button - opens Home window
        private void homebutton_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            this.Visible = false;
            home.ShowDialog();
            this.Close();
        }

        //clear fields after clicking on add, edit or delete
        void clearFields()
        {
            productName.Text = "";
            productId.Text = "";
            productDescription.Text = "";
            productQuantity.Text = "";
            productMax.Text = "";
            productMin.Text = "";
            productPrice.Text = "";
            productStatus.Text = "";
            productCategories.Text = "";
            productSuppliers.Text = "";
            
        }

        //create a auto-refresh method to show data on the table after inserting or editing data
        void refresh()
        {
            string vsql = "SELECT * FROM products";
            OleDbCommand vcom = new OleDbCommand(vsql, vcon);
            DataSet vds = new DataSet();
            OleDbDataAdapter vda = new OleDbDataAdapter(vcom);
            vda.Fill(vds, "res");
            dataGridView1.DataSource = vds.Tables["res"];
            vda.Dispose();
            vcom.Dispose();
        }

        //when the user clicks on a row, it will populate the fields with the information
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //name of the field.Text = name of table.CurrentRow.Cells[index of desired column]
            productName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            productId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            productDescription.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            productQuantity.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            productMax.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            productMin.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            productPrice.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            labelStatus.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            labelCategory.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            labelSupplier.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
   
            retrieveCategory();
            retrieveCategory2();
            populateRadioBox();

        }

        //After clicking on a row, populate the label with the category ID and use this ID to populate the
        //combobox with the correspondent category name
        void retrieveCategory()
        {
            
            OleDbCommand command = new OleDbCommand("SELECT categoryName FROM categories WHERE categoryID = "+labelCategory.Text+"", vcon);
            OleDbDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
               
                productCategories.Text = reader.GetValue(0).ToString();
                
            }
  
        }

        //When selescting a value from the combobox, populate the label with the correspondent categoryID
        private void productCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            int selectedValue = (int)cmb.SelectedValue;
            labelCategory.Text = selectedValue.ToString();
        }

        //method to be called when clicking on an item of the table. Method will get supplierID that will be populated
        //inside the labelSupplier, will query the database for the correspondent supplierName and fill the combobox
        //with the supplier name. This way, the combo box and label will always have right information.
        void retrieveCategory2()
        {

            OleDbCommand com = new OleDbCommand("SELECT supplierName FROM suppliers WHERE supplierID = " + labelSupplier.Text + "", vcon);
            OleDbDataReader reader2 = com.ExecuteReader();
            if (reader2.Read())
            {

                productSuppliers.Text = reader2.GetValue(0).ToString();

            }

        }
        //same for suppliers combo box
        //When selescting a value from the combobox, populate the label with the correspondent supplierID
        
        private void productSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ComboBox cmb3 = (ComboBox)sender;
                int selectedValue2 = (int)cmb3.SelectedValue;
                labelSupplier.Text = selectedValue2.ToString();
            }
            catch(Exception) 
            {
                
            }
        }




        //method that will recognize the product status (1 for active or 3 for discontinued) and will populate the correct radio box
        void populateRadioBox()
        {
            if(labelStatus.Text == "1")
            {
                radioActive.Checked = true;
            }
            else
            {
                radioDiscontinued.Checked = true;
            }
        }

        //If user select an option for a new product or edit an existing product
        //when selecting the radio button, automatically change the productStatusID
        //1 for active or 3 for discontinued
        private void radioActive_CheckedChanged(object sender, EventArgs e)
        {
            if(radioActive.Checked == true)
            {
                labelStatus.Text = "1";
            }
        }

        private void radioDiscontinued_CheckedChanged(object sender, EventArgs e)
        {
            if (radioDiscontinued.Checked == true)
            {
                labelStatus.Text = "3";
            }
        }

        //EDIT button - validate and push all fields into database and refresh the table
        private void edit_button_Click(object sender, EventArgs e)
        {
            bool fieldEmpty = productName.Text == "" || productDescription.Text == "" || productQuantity.Text == "" ||
                productMax.Text == "" || productMin.Text == "" || productPrice.Text == "" || labelStatus.Text == "" ||
                labelCategory.Text == "" || labelSupplier.Text == "" ;
            bool priceHasString = Regex.IsMatch(productPrice.Text, @"^[a-zA-Z]+$");
            bool quantityHasString = Regex.IsMatch(productQuantity.Text, @"^[a-zA-Z]+$");
            bool maxHasString = Regex.IsMatch(productMax.Text, @"^[a-zA-Z]+$");
            bool minHasString = Regex.IsMatch(productMin.Text, @"^[a-zA-Z]+$");

            if (!fieldEmpty)
            {
                if (priceHasString == true || quantityHasString == true || maxHasString == true || minHasString == true)
                {
                    MessageBox.Show("Please check your entries. Some fields should only contain numbers", "Error!");
                }
                else
                {

                    string vsql = string.Format("UPDATE products SET productName = '" + productName.Text + "', productDescription = '" + productDescription.Text + "', productQuantity = '" + productQuantity.Text + "', productMaximum = '" + productMax.Text + "', productMinimum = '" + productMin.Text + "', productPrice = '" + productPrice.Text + "', productStatusID = " + labelStatus.Text + ", productCategoryID = " + labelCategory.Text + ", productSupplierID = " + labelSupplier.Text + " WHERE productID = " + productId.Text + "  ");
                    OleDbCommand vcom = new OleDbCommand(vsql, vcon);
                    vcom.ExecuteNonQuery();
                    MessageBox.Show("Existing product successfully modified", "Congrats");
                    vcom.Dispose();
                    refresh();
                    clearFields();
                }
            }
            else
            {
                MessageBox.Show("All fields required", "OOPS!");
            }
        }

        //ADD button event. Adding a new product. Check if fields are all filled. Add to the database, refresh table and clear fields.
        private void add_button_Click(object sender, EventArgs e)
        {
            bool fieldEmpty = productName.Text == "" || productDescription.Text == "" || productQuantity.Text == "" ||
                productMax.Text == "" || productMin.Text == "" || productPrice.Text == "" || labelStatus.Text == "" ||
                labelCategory.Text == "" || labelSupplier.Text == "";
            bool priceHasString = Regex.IsMatch(productPrice.Text, @"^[a-zA-Z]+$");
            bool quantityHasString = Regex.IsMatch(productQuantity.Text, @"^[a-zA-Z]+$");
            bool maxHasString = Regex.IsMatch(productMax.Text, @"^[a-zA-Z]+$");
            bool minHasString = Regex.IsMatch(productMin.Text, @"^[a-zA-Z]+$");

            if (!fieldEmpty)
            {
                if (priceHasString == true || quantityHasString == true || maxHasString == true || minHasString == true)
                {
                    MessageBox.Show("Please check your entries. Some fields should only contain numbers", "Error!");
                }
                else
                {

                    string vsql = string.Format("INSERT INTO products (productName, productDescription, productQuantity, productMaximum, productMinimum, productPrice, productStatusID, productCategoryID, productSupplierID) " +
               "VALUES ('" + productName.Text + "', '" + productDescription.Text + "', '" + productQuantity.Text + "', '" + productMax.Text + "', '" + productMin.Text + "', '" + productPrice.Text + "', " + labelStatus.Text + ", " + labelCategory.Text + ", " + labelSupplier.Text + ")");
                    OleDbCommand vcom = new OleDbCommand(vsql, vcon);
                    vcom.ExecuteNonQuery();
                    MessageBox.Show("Data Successfully Inserted.", "New Product Added");
                    vcom.Dispose();
                    refresh();
                    clearFields();
                }
            }
            else
            {
                MessageBox.Show("All fields required", "OOPS!");
            }
        }
    }
}

/* This will be the Orders form for our iControl application.
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

namespace iControl
{
    public partial class frmOrders : Form
    {
        OleDbConnection vcon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\iControl.accdb");

        //Create OleDb connection : need to import System.Data.OleDb first!
        //OleDbConnection vcon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\goisb\Documents\GitHub\iControl\database\iControl.accdb");
        
        //Andrew's connection
        //OleDbConnection vcon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Andrew School\Dropbox\COMP1098-.NetC#\Project\iControl\database\iControl.accdb");
    
        public frmOrders()
        {
            InitializeComponent();
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iControlDataSet.OrderProducts' table. You can move, or remove it, as needed.
            this.orderProductsTableAdapter.Fill(this.iControlDataSet.OrderProducts);
            // TODO: This line of code loads data into the 'iControlDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.iControlDataSet.Categories);
            // TODO: This line of code loads data into the 'iControlDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.iControlDataSet.Products);
            // TODO: This line of code loads data into the 'iControlDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.iControlDataSet.Orders);
            // TODO: This line of code loads data into the 'iControlDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.iControlDataSet.Customers);
            vcon.Open();
            customerIDBox.Text = frmCustomers.customerIDToOrders;
            firstNameBox.Text = frmCustomers.customerFirstNameToOrders;
            lastNameBox.Text = frmCustomers.customerLastNameToOrders;
            streetBox.Text = frmCustomers.customerStreetToOrders;
            cityBox.Text = frmCustomers.customerCityToOrders;
            countryBox.Text = frmCustomers.customerCountryToOrders;
            postalCodeBox.Text = frmCustomers.customerPostalCodeToOrders;
            phoneNumberBox3.Text = frmCustomers.customerPhoneNumberToOrders;
            emailBox.Text = frmCustomers.customerEmailToOrders;

            //Load Date and Time - Will feed the orderDate field of Orders table when placing or saving an order
            DateTime now = DateTime.Today;
            labelDate.Text = now.ToString("yyyy-MM-dd");

            if(frmViewOrders.orderIDGlobal != "")
            {
                string vsql = "SELECT c.* FROM customers AS c INNER JOIN Orders AS o ON o.orderCustomerID = c.customerID WHERE o.orderID = " + frmViewOrders.orderIDGlobal + "; ";
                OleDbCommand vcom = new OleDbCommand(vsql, vcon);
                DataSet vds = new DataSet();
                OleDbDataAdapter vda = new OleDbDataAdapter(vcom);
                vda.Fill(vds, "res");
                dataGridView1.DataSource = vds.Tables["res"];
                vda.Dispose();
                vcom.Dispose();
                customerIDBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                firstNameBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                lastNameBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                streetBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                cityBox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                countryBox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                postalCodeBox.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                phoneNumberBox3.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                emailBox.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();

                //populate the ordering list
                string vsql2 = "SELECT p.productID AS ID, p.productName AS 'Product Name', o.orderProductQuantity AS Quantity, p.productPrice AS 'Unit Price', (o.orderProductQuantity * p.productPrice) AS 'Total Price' FROM products AS p INNER JOIN orderProducts AS o ON o.orderProductProductID = p.productID WHERE o.orderProductOrderID = " + frmViewOrders.orderIDGlobal + "; ";
                orderIDTextBox.Text = frmViewOrders.orderIDGlobal;
                frmViewOrders.orderIDGlobal = "";
                OleDbCommand vcom2 = new OleDbCommand(vsql2, vcon);
                DataSet vds2 = new DataSet();
                OleDbDataAdapter vda2 = new OleDbDataAdapter(vcom2);
                vda2.Fill(vds2, "res");
                
                productTemporaryList.DataSource = vds2.Tables["res"];

                //Console.WriteLine("Starting foreach loop");
                Console.WriteLine(productTemporaryList.Rows.Count);
                foreach (DataGridViewRow row in productTemporaryList.Rows)
                {
                    try
                    {
                        orderingListTable.Rows.Add(Convert.ToInt32(row.Cells[0].Value.ToString()), row.Cells[1].Value.ToString(), Convert.ToDecimal(row.Cells[2].Value.ToString()), Convert.ToDecimal(row.Cells[3].Value.ToString()), Convert.ToDecimal(row.Cells[4].Value.ToString()));
                        //Console.WriteLine(row.Cells[0].Value.ToString() + ", " + row.Cells[1].Value.ToString() + ", " + row.Cells[2].Value.ToString() + ", " + row.Cells[3].Value.ToString() + ", " + row.Cells[4].Value.ToString());
                        totalPrice = Convert.ToDecimal(row.Cells[4].Value.ToString());
                        calculateTotalCharges();
                    }
                    catch (Exception)
                    {

                    }
                }

                //Console.WriteLine("Ending foreach loop");


                vda2.Dispose();
                vcom2.Dispose();


            }

        }


        //Home button - go to main screen
        private void homeButton_Click_1(object sender, EventArgs e)
        {
            frmHome frm = new frmHome();
            this.Visible = false;
            frm.ShowDialog();
            this.Close();
        }

        //SEARCH BUTTONS - CUSTOMERS
        //Search for first name
        private void searchForFirstNameButton_Click(object sender, EventArgs e)
        {
            string vsql = "SELECT * FROM customers WHERE customerFirstName = '" + searchBox.Text + "' ";
            OleDbCommand vcom = new OleDbCommand(vsql, vcon);
            DataSet vds = new DataSet();
            OleDbDataAdapter vda = new OleDbDataAdapter(vcom);
            vda.Fill(vds, "res");
            dataGridView1.DataSource = vds.Tables["res"];
            vda.Dispose();
            vcom.Dispose();
        }

        //search by last name
        private void searchByLastNameButton_Click(object sender, EventArgs e)
        {
            string vsql = "SELECT * FROM customers WHERE customerLastName = '" + searchBox.Text + "' ";
            OleDbCommand vcom = new OleDbCommand(vsql, vcon);
            DataSet vds = new DataSet();
            OleDbDataAdapter vda = new OleDbDataAdapter(vcom);
            vda.Fill(vds, "res");
            dataGridView1.DataSource = vds.Tables["res"];
            vda.Dispose();
            vcom.Dispose();
        }

        //search by ID
        private void searchByIDbutton_Click(object sender, EventArgs e)
        {
            string vsql = "SELECT * FROM customers WHERE customerID = " + searchBox.Text + " ";
            OleDbCommand vcom = new OleDbCommand(vsql, vcon);
            DataSet vds = new DataSet();
            OleDbDataAdapter vda = new OleDbDataAdapter(vcom);
            vda.Fill(vds, "res");
            dataGridView1.DataSource = vds.Tables["res"];
            vda.Dispose();
            vcom.Dispose();
        }

        //search by phone number
        private void searchByPhoneNumberButton_Click_1(object sender, EventArgs e)
        {
            string vsql = "SELECT * FROM customers WHERE customerPhoneNumber = '" + searchBox.Text + "' ";
            OleDbCommand vcom = new OleDbCommand(vsql, vcon);
            DataSet vds = new DataSet();
            OleDbDataAdapter vda = new OleDbDataAdapter(vcom);
            vda.Fill(vds, "res");
            dataGridView1.DataSource = vds.Tables["res"];
            vda.Dispose();
            vcom.Dispose();
        }

        //Show all customer entries
        private void showAllButton_Click(object sender, EventArgs e)
        {
            string vsql = "SELECT * FROM customers";
            OleDbCommand vcom = new OleDbCommand(vsql, vcon);
            DataSet vds = new DataSet();
            OleDbDataAdapter vda = new OleDbDataAdapter(vcom);
            vda.Fill(vds, "res");
            dataGridView1.DataSource = vds.Tables["res"];
            vda.Dispose();
            vcom.Dispose();
        }

        //Customers data grid - when click, populate fields
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //name of the field.Text = name of table.CurrentRow.Cells[index of desired column]
            customerIDBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            firstNameBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            lastNameBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            streetBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cityBox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            countryBox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            postalCodeBox.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            phoneNumberBox3.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            emailBox.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            
        }


        //PRODUCTS
        //Show All button
        private void productShowAllButton_Click(object sender, EventArgs e)
        {
            string vsql = "SELECT * FROM products";
            OleDbCommand vcom = new OleDbCommand(vsql, vcon);
            DataSet vds = new DataSet();
            OleDbDataAdapter vda = new OleDbDataAdapter(vcom);
            vda.Fill(vds, "res");
            dataGridView2.DataSource = vds.Tables["res"];
            vda.Dispose();
            vcom.Dispose();
        }


        //SEARCH BUTTONS - CUSTOMERS
        //Search products by first name
        private void productSearchByName_Click(object sender, EventArgs e)
        {
                string vsql = "SELECT * FROM products WHERE productName = '" + productSearchBox.Text + "' ";
                OleDbCommand vcom = new OleDbCommand(vsql, vcon);
                DataSet vds = new DataSet();
                OleDbDataAdapter vda = new OleDbDataAdapter(vcom);
                vda.Fill(vds, "res");
                dataGridView2.DataSource = vds.Tables["res"];
                vda.Dispose();
                vcom.Dispose();
            
        }

        //Search product by ID number
        private void productSearchByID_Click(object sender, EventArgs e)
        {
            string vsql = "SELECT * FROM products WHERE productID = " + productSearchBox.Text + "  ";
            OleDbCommand vcom = new OleDbCommand(vsql, vcon);
            DataSet vds = new DataSet();
            OleDbDataAdapter vda = new OleDbDataAdapter(vcom);
            vda.Fill(vds, "res");
            dataGridView2.DataSource = vds.Tables["res"];
            vda.Dispose();
            vcom.Dispose();
        }

        //Search by category trough combo box
        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //retrieve category ID from table after selecting a category on combo box
            ComboBox cmb = (ComboBox)sender;
            int selectedValue = (int)cmb.SelectedValue;
            labelCategory.Text = selectedValue.ToString();
            
            string vsql = "SELECT * FROM products WHERE productCategoryID = " + labelCategory.Text + "  ";
            OleDbCommand vcom = new OleDbCommand(vsql, vcon);
            DataSet vds = new DataSet();
            OleDbDataAdapter vda = new OleDbDataAdapter(vcom);
            vda.Fill(vds, "res");
            dataGridView2.DataSource = vds.Tables["res"];
            vda.Dispose();
            vcom.Dispose();
            
        }

        //declare global variables. When click on a product, store the necessary values inside these variables.
        int productIDToOrder;
        string productNameToOrder;
        decimal productPriceToOrder;
        decimal selectedQuantity;
        decimal totalPrice;
        int getProductQuantity;

        //flag that will tell us if there is no product selected on the products data grid view
        int flag = 0;

        //When clicking on the products gridview
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Assign the values of the clicked product to the variables
            productIDToOrder = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString());
            productNameToOrder = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            productPriceToOrder = Convert.ToDecimal(dataGridView2.CurrentRow.Cells[6].Value.ToString());
            getProductQuantity = Convert.ToInt32(dataGridView2.CurrentRow.Cells[3].Value.ToString());

            //modify flag that confirms a product is selected
            flag = 1;
        }


        
        //What happens when user clicks on the ADD TO ORDER button
        private void addToOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                //user needs to select a quantity. If not, show error message and break
                if (selectQuantityBox.Text == "")
                {
                    MessageBox.Show("Please select quantity", "Error!");
                    return;
                }

                //user needs to select a product. If not, show error message and break
                if (flag == 0)
                {
                    MessageBox.Show("Please select a product from the table", "No product selected");
                    return;
                }

                //check if user entered an integer number
                int n = 0;
                bool isNumberInteger = int.TryParse(selectQuantityBox.Text, out n);
                if (!isNumberInteger || Convert.ToInt32(selectQuantityBox.Text) < 1 )
                {
                    MessageBox.Show("Please enter only round numbers higher than 0", "Error!");
                    return;
                }

                //If the orderingTable is empty, there is no need to check if product already exists on the ordering list
                //But we check if the selected quantity is not a bigger number than the actual product stock
                //Allow user to add rows needs to be false . This is important. If it's set to true the Rows.Count does not work
                if (orderingListTable.Rows.Count == 0 || orderingListTable.Rows == null)
                {
                    //if there is not enough stock, error message
                    if (Convert.ToInt32(selectQuantityBox.Text) > getProductQuantity)
                    {
                        MessageBox.Show("There is not enough stock for this product. Please verify stock and change the desired quantity", "OOPS!");
                    }
                    //If we have enough stock, insert the product to the ordering list table
                    else
                    {
                        selectedQuantity = Convert.ToDecimal(selectQuantityBox.Text);
                        totalPrice = selectedQuantity * Convert.ToDecimal(productPriceToOrder);
                        orderingListTable.Rows.Add(productIDToOrder, productNameToOrder, selectedQuantity, productPriceToOrder, totalPrice);
                        selectQuantityBox.Text = "";
                        calculateTotalCharges();
                    }
                }

                //If the ordering list table is not empty, reiterate the list to find an equal product id. 
                else
                {
                    //boolean that is a flag to check if product is already inside the ordering list. 
                    bool productExists = false;

                    foreach (DataGridViewRow row in orderingListTable.Rows)
                    {
                        //if the productID is already on the ordering list, tell user the product is already there. We can't add the same product more than once
                        if (productIDToOrder == Convert.ToInt32(row.Cells[0].Value.ToString()))
                        {
                            //MessageBox.Show("This product is already added to the ordering list", "Attention A!");
                            productExists = true;

                        }

                    }

                    //If the code gets to here, it means the product is new to the ordering list and we can add it
                    if(productExists == true)
                    {
                        MessageBox.Show("The selected product is already in the list", "Error");
                        return;
                    }
                    if (Convert.ToInt32(selectQuantityBox.Text) < getProductQuantity)
                    {
                        selectedQuantity = Convert.ToDecimal(selectQuantityBox.Text);
                        totalPrice = selectedQuantity * Convert.ToDecimal(productPriceToOrder);
                        orderingListTable.Rows.Add(productIDToOrder, productNameToOrder, selectedQuantity, productPriceToOrder, totalPrice);
                        calculateTotalCharges();
                    }
                    else 
                    {
                        MessageBox.Show("There are not enough products in stock. Please modify your quantity", "Error!");
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please insert numbers only", "ERROR");
            }
        }

        //method that will calculate subtotal, tax and total after adding a new product to the orderingListTable
        decimal subtotal;
        decimal tax;
        decimal total;
        void calculateTotalCharges()
        {
            
            //calculate subtotal
            //orderingListTable - Total Price column
            subtotal += totalPrice;
            labelSubtotalSum.Text = subtotal.ToString();
            tax = Convert.ToDecimal(string.Format("{0:0.00}", (subtotal * 13) / 100));
            labelTaxSum.Text = tax.ToString();
            total = tax + subtotal;
            labelTotalSum.Text = total.ToString();
        }

        //recalculate the charges after deleting a row
        void calculateTotalChargesDelete()
        {
            subtotal -= totalPrice;
            labelSubtotalSum.Text = subtotal.ToString();
            tax = Convert.ToDecimal(string.Format("{0:0.00}", (subtotal * 13) / 100));
            labelTaxSum.Text = tax.ToString();
            total = tax + subtotal;
            labelTotalSum.Text = total.ToString();
        }



        //Create a variable of the selected row on the ordering list table
        DataGridViewRow row;

        //When user clicks on a product on the ordering list table, it assigns the row information to the variable
        private void orderingListTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            row = orderingListTable.CurrentRow;
            totalPrice = Convert.ToDecimal(orderingListTable.CurrentRow.Cells[4].Value.ToString());
        }

        //When user clicks on the delete button, it deletes the selected row. If no row selected, catch the error and send a message
        private void deleteRowButton_Click(object sender, EventArgs e)
        {
            try
            {
                orderingListTable.Rows.Remove(row);
                calculateTotalChargesDelete();
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a row to be deleted", "ERROR");
            }
        }

        //create a auto-refresh method to show data on the table after inserting or editing data
        void refresh()
        {
            string vsql = "SELECT * FROM products";
            OleDbCommand vcom = new OleDbCommand(vsql, vcon);
            DataSet vds = new DataSet();
            OleDbDataAdapter vda = new OleDbDataAdapter(vcom);
            vda.Fill(vds, "res");
            dataGridView2.DataSource = vds.Tables["res"];
            vda.Dispose();
            vcom.Dispose();
        }

        //clear the orderingListTable / after placing or saving an order
        void clearOrderingList()
        {
            orderingListTable.Rows.Clear();
        }

        //Clear the subtotal, tax and total / after placing or saving an order
        void clearCharges()
        {
            labelSubtotalSum.Text = "0.00";
            labelTaxSum.Text = "0.00";
            labelTotalSum.Text = "0.00"; 
        }


        //when user clicks de Place Order Button - places an order
        private void placeOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                string lastOrderID;
                //Check if orderID exists on the orders table
                //if exists, update the order, if not create a new order
                if (orderIDTextBox.Text != "")
                {
                    lastOrderID = orderIDTextBox.Text;
                    string vsql0 = string.Format("DELETE FROM orderProducts WHERE orderProductOrderID = " + Convert.ToInt32(lastOrderID) + "");
                    OleDbCommand vcom0 = new OleDbCommand(vsql0, vcon);
                    vcom0.ExecuteNonQuery();
                    vcom0.Dispose();

                    //UPDATE the table
                    string vsql1 = string.Format("UPDATE orders SET orderTotalAmount = " + Convert.ToDecimal(labelTotalSum.Text) + ", orderStatusID = 2 WHERE orderID = " + Convert.ToInt32(lastOrderID) + "");
                    OleDbCommand vcom1 = new OleDbCommand(vsql1, vcon);
                    vcom1.ExecuteNonQuery();
                    vcom1.Dispose();
                }
                else
                {
                    //INSERT INTO orders table, orderCustomerID from customerIDBox, orderDate from labelDate and orderStatusID as 2 (completed)
                    //table will auto generate a orderID
                    string vsql = string.Format("INSERT INTO orders (orderCustomerID, orderDate, orderStatusID, orderTotalAmount) VALUES (" + customerIDBox.Text + ", '" + labelDate.Text + "', 2, " + Convert.ToDecimal(labelTotalSum.Text) + ")");
                    OleDbCommand vcom = new OleDbCommand(vsql, vcon);
                    vcom.ExecuteNonQuery();
                    vcom.Dispose();

                    //retrieve the orderID created on the orders table and add data to OrderProducts   
                    string vsql2 = "SELECT TOP 1 orderID FROM orders ORDER BY orderID DESC; ";
                    OleDbCommand vcom2 = new OleDbCommand(vsql2, vcon);
                    var theIDIWant = vcom2.ExecuteScalar();
                    lastOrderID = Convert.ToString(theIDIWant);
                }
                
                

                //lastOrderID is the orderProductOrderID (foreign key)
                //iterate trough orderingListTable, retrieve product information and send the info to the OrderProducts table
                foreach (DataGridViewRow row in orderingListTable.Rows)
                {
                    try
                    {

                        //Insert ordering list information into OrderProducts table
                        string vsql3 = string.Format("INSERT INTO OrderProducts (orderProductOrderID, orderProductProductID, orderProductQuantity) VALUES (" + Convert.ToInt32(lastOrderID) + " , " + Convert.ToInt32(row.Cells[0].Value.ToString()) + ", " + Convert.ToInt32(row.Cells[2].Value.ToString()) + ")");

                        OleDbCommand vcom3 = new OleDbCommand(vsql3, vcon);
                        vcom3.ExecuteNonQuery();
                        vcom3.Dispose();

                        //update product quantity on Products table. While looping, get the productID and product quantity and subtract the quantity amount on that productID
                        string vsqlUpdateQuantity = string.Format("UPDATE products SET productQuantity = productQuantity - " + Convert.ToInt32(row.Cells[2].Value.ToString()) + " WHERE productID = " + Convert.ToInt32(row.Cells[0].Value.ToString()) + " ");

                        OleDbCommand vcom4 = new OleDbCommand(vsqlUpdateQuantity, vcon);
                        vcom4.ExecuteNonQuery();
                        vcom4.Dispose();
                    }
                    catch (Exception)
                    {

                    }
   
                }
                //refresh the products table as the quantity was modified
                refresh();
                clearOrderingList();
                clearCharges();
                MessageBox.Show("Please access View Orders page to view the order", "Order successfully placed");

                //At this point, the order is entered on the Orders and OrderProducts tables as completed
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
                MessageBox.Show("Please make sure you have a customer and products selected", "Missing information");
            }
            

        }

        //when user saves an order
        private void saveOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                string lastOrderID;
                //Check if orderID exists on the orders table
                //if exists, update the order, if not create a new order
                if (orderIDTextBox.Text != "")
                {
                    lastOrderID = orderIDTextBox.Text;
                    string vsql0 = string.Format("DELETE FROM orderProducts WHERE orderProductOrderID = " + Convert.ToInt32(lastOrderID) + "");
                    OleDbCommand vcom0 = new OleDbCommand(vsql0, vcon);
                    vcom0.ExecuteNonQuery();
                    vcom0.Dispose();

                    //UPDATE the table
                    string vsql1 = string.Format("UPDATE orders SET orderTotalAmount = "+Convert.ToDecimal(labelTotalSum.Text)+" WHERE orderID = " + Convert.ToInt32(lastOrderID) + "");
                    OleDbCommand vcom1 = new OleDbCommand(vsql1, vcon);
                    vcom1.ExecuteNonQuery();
                    vcom1.Dispose();

                }
                else
                {
                    //INSERT INTO orders table, orderCustomerID from customerIDBox, orderDate from labelDate and orderStatusID as 2 (completed)
                    //table will auto generate a orderID
                    string vsql = string.Format("INSERT INTO orders (orderCustomerID, orderDate, orderStatusID, orderTotalAmount) VALUES (" + customerIDBox.Text + ", '" + labelDate.Text + "', 1, " + Convert.ToDecimal(labelTotalSum.Text) + ")");
                    OleDbCommand vcom = new OleDbCommand(vsql, vcon);
                    vcom.ExecuteNonQuery();
                    vcom.Dispose();

                    //retrieve the orderID created on the orders table and add data to OrderProducts   
                    string vsql2 = "SELECT TOP 1 orderID FROM orders ORDER BY orderID DESC; ";
                    OleDbCommand vcom2 = new OleDbCommand(vsql2, vcon);
                    var theIDIWant = vcom2.ExecuteScalar();
                    lastOrderID = Convert.ToString(theIDIWant);
                }
                


                //lastOrderID is the orderProductOrderID (foreign key)
                //iterate trough orderingListTable, retrieve product information and send the info to the OrderProducts table
               
                foreach (DataGridViewRow row in orderingListTable.Rows)
                {
                    try
                    {
                        //Insert ordering list information into OrderProducts table
                        string vsql3 = string.Format("INSERT INTO OrderProducts (orderProductOrderID, orderProductProductID, orderProductQuantity) VALUES (" + Convert.ToInt32(lastOrderID) + " , " + Convert.ToInt32(row.Cells[0].Value.ToString()) + ", " + Convert.ToInt32(row.Cells[2].Value.ToString()) + ")");
                        OleDbCommand vcom3 = new OleDbCommand(vsql3, vcon);
                        vcom3.ExecuteNonQuery();
                        vcom3.Dispose();

                        //update product quantity on Products table. While looping, get the productID and product quantity and subtract the quantity amount on that productID
                        string vsqlUpdateQuantity = string.Format("UPDATE products SET productQuantity = productQuantity - " + Convert.ToInt32(row.Cells[2].Value.ToString()) + " WHERE productID = " + Convert.ToInt32(row.Cells[0].Value.ToString()) + " ");

                        OleDbCommand vcom4 = new OleDbCommand(vsqlUpdateQuantity, vcon);
                        vcom4.ExecuteNonQuery();
                        vcom4.Dispose();
                    }
                    catch (Exception)
                    {

                    }

                }
                //refresh the products table with the updated products quantity
                refresh();
                clearOrderingList();
                clearCharges();

                
                //At this point, the order is entered on the Orders and OrderProducts tables as pending
            }
            catch (Exception Exc1)
            {
                MessageBox.Show("Please make sure you have a customer and products selected", "Missing information");
                Console.WriteLine(Exc1);
            }

            MessageBox.Show("Please access View Orders page to view or modify the order", "Order successfully saved");

        }

        private void viewOrdersButton_Click(object sender, EventArgs e)
        {
            frmViewOrders viewOrdersForm = new frmViewOrders();
            this.Visible = false;
            viewOrdersForm.ShowDialog();
            this.Close();
        }

        private void productsOrderProductsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}

/* This will be the Customers form for our iControl application.
 * 
 * @author Marcos de Gois Borges
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

    public partial class frmCustomers : Form 
    {

        OleDbConnection vcon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\iControl.accdb");
        //Create OleDb connection : need to import System.Data.OleDb first!
        //OleDbConnection vcon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\goisb\Documents\GitHub\iControl\database\iControl.accdb");

        //Andrew's connection
        //OleDbConnection vcon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Andrew School\Dropbox\COMP1098-.NetC#\Project\iControl\database\iControl.accdb");



        public frmCustomers()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            
            // TODO: This line of code loads data into the 'iControlDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.iControlDataSet.Customers);
            vcon.Open();
        }

        //clear fields after clicking on add, edit or delete
        void clearFields()
        {
            firstNameBox.Text = "";
            lastNameBox.Text = "";
            streetBox.Text = "";
            cityBox.Text = "";
            countryBox.Text = "";
            postalCodeBox.Text = "";
            phoneNumberBox.Text = "";
            emailBox.Text = "";
            labelStatus.Text = "";
            customerID.Text = "";

        }

        //create a auto-refresh method to show data on the table after inserting or editing data
        void refresh()
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

        //home button - go to main menu
        private void homebutton_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            this.Visible = false;
            home.ShowDialog();
            this.Close();
        }

        //ADD button event. Adding a new customer. Check if fields are all filled. Add to the database, refresh table and clear fields.
        private void add_button_Click(object sender, EventArgs e)
        {

            //zipCodePattern is for CA only.
            string emailPattern = @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$"; // Email address pattern  
            string phonePattern = @"^[2-9]\d{2}-\d{3}-\d{4}$"; // US Phone number pattern   
            string zipCodePattern = @"^([ABCEGHJKLMNPRSTVXY]\d[ABCEGHJKLMNPRSTVWXYZ])\ {0,1}(\d[ABCEGHJKLMNPRSTVWXYZ]\d)$";
            // Create a bool variable and use the Regex.IsMatch static method which returns true if a specific value matches a specific pattern  

            bool isEmailValid = Regex.IsMatch(emailBox.Text, emailPattern);
            bool isPhoneValid = Regex.IsMatch(phoneNumberBox.Text, phonePattern);
            bool isZipValid = Regex.IsMatch(postalCodeBox.Text, zipCodePattern);

            bool fieldEmpty = firstNameBox.Text == "" || lastNameBox.Text == "" || streetBox.Text == "" ||
               cityBox.Text == "" || countryBox.Text == "" || postalCodeBox.Text == "" || phoneNumberBox.Text == "" ||
               emailBox.Text == "" || labelStatus.Text == "";
            

            if (!fieldEmpty)
            {
                if (isPhoneValid && isEmailValid && isZipValid)
                {

                    string vsql = string.Format("INSERT INTO customers (customerFirstName, customerLastName, customerStreet, customerCity, customerCountry, customerPostalCode, customerPhoneNumber, customerEmail, customerStatusID) " +
               "VALUES ('" + firstNameBox.Text + "', '" + lastNameBox.Text + "', '" + streetBox.Text + "', '" + cityBox.Text + "', '" + countryBox.Text + "', '" + postalCodeBox.Text + "', '" + phoneNumberBox.Text + "', '" + emailBox.Text + "', " + labelStatus.Text + ")");
                    OleDbCommand vcom = new OleDbCommand(vsql, vcon);
                    vcom.ExecuteNonQuery();
                    MessageBox.Show("Data Successfully Inserted.", "New Customer Added");
                    vcom.Dispose();
                    refresh();
                    clearFields();
                }
                else if (!isPhoneValid)
                {
                    MessageBox.Show("Please enter a valid phone number (XXX-XXX-XXXX)", "Invalid phone format");
                }
                else if (!isEmailValid)
                {
                    MessageBox.Show("Please enter a valid e-mail address (xxxxx@xxxx.com)", "Invalid e-mail format");
                }
                else if (!isZipValid)
                {
                    MessageBox.Show("Canadian zip code format only: A1B 2C3", "Invalid zip code format");
                }
            }
            else
            {
                MessageBox.Show("All fields required", "OOPS!");
            }
        }

        //method that will recognize the product status (1 for active or 3 for discontinued) and will populate the correct radio box
        void populateRadioBox()
        {
            if (labelStatus.Text == "1")
            {
                radioActive.Checked = true;
            }
            else
            {
                radioDorment.Checked = true;
            }
        }

        //If user select an option for a new customer or edit an existing customer
        //when selecting the radio button, automatically change the customerStatusID
        //1 for active or 2 for dorment

        private void radioActive_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioActive.Checked == true)
            {
                labelStatus.Text = "1";
            }
        }

        private void radioDorment_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioDorment.Checked == true)
            {
                labelStatus.Text = "2";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //name of the field.Text = name of table.CurrentRow.Cells[index of desired column]
            customerID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            firstNameBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            lastNameBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            streetBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cityBox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            countryBox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            postalCodeBox.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            phoneNumberBox.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            emailBox.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            labelStatus.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
           

            populateRadioBox();
        }

        //EDIT button. Validate fields (no empty field, correct email address format, correct phone format)
        private void edit_button_Click(object sender, EventArgs e)
        {
            //zipCodePattern is for CA only.
            string emailPattern = @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$"; // Email address pattern  
            string phonePattern = @"^[2-9]\d{2}-\d{3}-\d{4}$"; // US Phone number pattern   
            string zipCodePattern = @"^([ABCEGHJKLMNPRSTVXY]\d[ABCEGHJKLMNPRSTVWXYZ])\ {0,1}(\d[ABCEGHJKLMNPRSTVWXYZ]\d)$";
            // Create a bool variable and use the Regex.IsMatch static method which returns true if a specific value matches a specific pattern  

            bool isEmailValid = Regex.IsMatch(emailBox.Text, emailPattern);
            bool isPhoneValid = Regex.IsMatch(phoneNumberBox.Text, phonePattern);
            bool isZipValid = Regex.IsMatch(postalCodeBox.Text, zipCodePattern);

            bool fieldEmpty = firstNameBox.Text == "" || lastNameBox.Text == "" || streetBox.Text == "" ||
               cityBox.Text == "" || countryBox.Text == "" || postalCodeBox.Text == "" || phoneNumberBox.Text == "" ||
               emailBox.Text == "" || labelStatus.Text == "";


            if (!fieldEmpty)
            {
                if (isPhoneValid && isEmailValid && isZipValid)
                {

                    string vsql = string.Format("UPDATE customers SET customerFirstName = '" + firstNameBox.Text + "', customerLastName = '" + lastNameBox.Text + "', customerStreet = '" + streetBox.Text + "', customerCity = '" + cityBox.Text + "', customerCountry = '" + countryBox.Text + "', customerPostalCode = '" + postalCodeBox.Text + "', customerPhoneNumber = '" + phoneNumberBox.Text + "', customerEmail = '" + emailBox.Text + "', customerStatusID = " + labelStatus.Text + " WHERE customerID = " + customerID.Text + " ");
               
                    OleDbCommand vcom = new OleDbCommand(vsql, vcon);
                    vcom.ExecuteNonQuery();
                    MessageBox.Show("Data Successfully Edited.", "Existing customer changed");
                    vcom.Dispose();
                    refresh();
                    clearFields();
                }
                else if (!isPhoneValid)
                {
                    MessageBox.Show("Please enter a valid phone number (XXX-XXX-XXXX)", "Invalid phone format");
                }
                else if (!isEmailValid)
                {
                    MessageBox.Show("Please enter a valid e-mail address (xxxxx@xxxx.com)", "Invalid e-mail format");
                }
                else if (!isZipValid)
                {
                    MessageBox.Show("Canadian zip code format only: A1B 2C3", "Invalid zip code format");
                }
            }
            else
            {
                MessageBox.Show("All fields required", "OOPS!");
            }
        }

        //placeOrderButton will store the customer variable and pass it to the Orders Form
        //It will make it easier to place an order when adding a new customer
        public static string customerIDToOrders;
        public static string customerFirstNameToOrders;
        public static string customerLastNameToOrders;
        public static string customerStreetToOrders;
        public static string customerCityToOrders;
        public static string customerCountryToOrders;
        public static string customerPostalCodeToOrders;
        public static string customerPhoneNumberToOrders;
        public static string customerEmailToOrders;

        private void placeOrderButton_Click(object sender, EventArgs e)
        {
            customerIDToOrders = customerID.Text;
            customerLastNameToOrders = lastNameBox.Text;
            customerFirstNameToOrders = firstNameBox.Text;
            customerStreetToOrders = streetBox.Text;
            customerCityToOrders = cityBox.Text;
            customerCountryToOrders = countryBox.Text;
            customerPostalCodeToOrders = postalCodeBox.Text;
            customerPhoneNumberToOrders = phoneNumberBox.Text;
            customerEmailToOrders = emailBox.Text;
            frmOrders frmOrder = new frmOrders();
            this.Visible = false;
            frmOrder.ShowDialog();
            this.Close();
        }

        //search for first name
        private void searchForFirstNameButton_Click(object sender, EventArgs e)
        {
            string vsql = "SELECT * FROM customers WHERE customerFirstName = '" + firstNameSearchBox.Text + "' ";
            OleDbCommand vcom = new OleDbCommand(vsql, vcon);
            DataSet vds = new DataSet();
            OleDbDataAdapter vda = new OleDbDataAdapter(vcom);
            vda.Fill(vds, "res");
            dataGridView1.DataSource = vds.Tables["res"];
            vda.Dispose();
            vcom.Dispose();
        }

        //Show all button will reset table and show all entries again
        private void showAllButton_Click_1(object sender, EventArgs e)
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

        //Search for last name button
        private void searchByLastNameButton_Click(object sender, EventArgs e)
        {
            string vsql = "SELECT * FROM customers WHERE customerLastName = '" + lastNameSearchBox.Text + "' ";
            OleDbCommand vcom = new OleDbCommand(vsql, vcon);
            DataSet vds = new DataSet();
            OleDbDataAdapter vda = new OleDbDataAdapter(vcom);
            vda.Fill(vds, "res");
            dataGridView1.DataSource = vds.Tables["res"];
            vda.Dispose();
            vcom.Dispose();
        }
    }
}

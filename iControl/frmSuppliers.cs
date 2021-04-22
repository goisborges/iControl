/* This will be the Suppliers form for our iControl application.
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
    public partial class frmSuppliers : Form {
        OleDbConnection vcon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\iControl.accdb");
        //Create OleDb connection : need to import System.Data.OleDb first!
        //OleDbConnection vcon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\goisb\Documents\GitHub\iControl\database\iControl.accdb");
        
        //Andrew's connection
        //OleDbConnection vcon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Andrew School\Dropbox\COMP1098-.NetC#\Project\iControl\database\iControl.accdb");
    
        public frmSuppliers()
        {
            InitializeComponent();
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iControlDataSet.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.iControlDataSet.Suppliers);
            //open the connection
            vcon.Open();
        }

        //clear fields after clicking on add, edit or delete
        void clearFields()
        {
            supplierid.Text = "";
            suppliername.Text = "";
            supplieremail.Text = "";
            supplierphone.Text = "";
            supplierwebsite.Text = "";
            supplierstatus.Text = "";
        }

        //create a auto-refresh method to show data on the table after inserting or editing data
        void refresh()
        {
            string vsql = "SELECT * FROM suppliers";
            OleDbCommand vcom = new OleDbCommand(vsql, vcon);
            DataSet vds = new DataSet();
            OleDbDataAdapter vda = new OleDbDataAdapter(vcom);
            vda.Fill(vds, "res");
            dataGridView1.DataSource = vds.Tables["res"];
            vda.Dispose();
            vcom.Dispose();
        }

        //ADD button: validate fields and add supplier
        private void add_button_Click(object sender, EventArgs e)
        {
            // Create string variables that contain the patterns   
            string emailPattern = @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$"; // Email address pattern  
            string phonePattern = @"^[2-9]\d{2}-\d{3}-\d{4}$"; // US Phone number pattern   

            // Create a bool variable and use the Regex.IsMatch static method which returns true if a specific value matches a specific pattern  
            bool isEmailValid = Regex.IsMatch(supplieremail.Text, emailPattern);
            bool isPhoneValid = Regex.IsMatch(supplierphone.Text, phonePattern);
            bool fieldEmpty = suppliername.Text == "" || supplieremail.Text == "" || supplierphone.Text == "" || supplierphone.Text == "" || supplierstatus.Text == "";
            bool isStatusValid = supplierstatus.Text == "1" || supplierstatus.Text == "2";

            if (!fieldEmpty)
            {
                if(isPhoneValid && isEmailValid && isStatusValid)
                {
                    string vsql = string.Format("INSERT INTO suppliers (supplierName, supplierEmail, supplierPhoneNumber, supplierWebsite, supplierStatusID) " +
              "VALUES ('" + suppliername.Text + "', '" + supplieremail.Text + "', '" + supplierphone.Text + "', '" + supplierwebsite.Text + "', '" + supplierstatus.Text + "')");
                    OleDbCommand vcom = new OleDbCommand(vsql, vcon);
                    vcom.ExecuteNonQuery();
                    MessageBox.Show("Data Successfully Inserted. There is a new supplier.");
                    vcom.Dispose();
                    refresh();
                    clearFields();
                }
                else if (!isPhoneValid)
                {
                    MessageBox.Show("Please enter a valid phone number (XXX-XXX-XXXX");
                }
                else if (!isEmailValid)
                {
                    MessageBox.Show("Please enter a valid e-mail address (xxxxx@xxxx.com)");
                }
                else if (!isStatusValid)
                {
                    MessageBox.Show("Please enter a valid status (1 for ACTIVE or 2 for DORMENT)");
                }
            }
            else
            {
                MessageBox.Show("All fields required");
            }

 
        }

        

        //Edit information
        //Select the desired row, it populates the fields, the user modifies the values and click edit
        //if field category name is empty, show error message

        private void edit_button_Click_1(object sender, EventArgs e)
        {
            // Create string variables that contain the patterns   
            string emailPattern = @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$"; // Email address pattern  
            string phonePattern = @"^[2-9]\d{2}-\d{3}-\d{4}$"; // US Phone number pattern   

            // Create a bool variable and use the Regex.IsMatch static method which returns true if a specific value matches a specific pattern  
            bool isEmailValid = Regex.IsMatch(supplieremail.Text, emailPattern);
            bool isPhoneValid = Regex.IsMatch(supplierphone.Text, phonePattern);
            bool fieldEmpty = suppliername.Text == "" || supplieremail.Text == "" || supplierphone.Text == "" || supplierwebsite.Text == "" || supplierstatus.Text == "";
            bool isStatusValid = supplierstatus.Text == "1" || supplierstatus.Text == "2";

            if (!fieldEmpty)
            {
                if (isPhoneValid && isEmailValid && isStatusValid)
                {
                    string vsql = string.Format("UPDATE suppliers SET supplierName = '" + suppliername.Text + "', supplierEmail = '" + supplieremail.Text + "', supplierPhoneNumber = '" + supplierphone.Text + "', supplierWebsite = '" + supplierwebsite.Text + "', supplierStatusID = " + supplierstatus.Text + " WHERE supplierID = " + supplierid.Text + "  ");
                    OleDbCommand vcom = new OleDbCommand(vsql, vcon);
                    vcom.ExecuteNonQuery();
                    MessageBox.Show("Data Successfully Modified for selected supplier");
                    vcom.Dispose();
                    refresh();
                    clearFields();
                }
                else if (!isPhoneValid)
                {
                    MessageBox.Show("Please enter a valid phone number (XXX-XXX-XXXX");
                }
                else if (!isEmailValid)
                {
                    MessageBox.Show("Please enter a valid e-mail address (xxxxx@xxxx.com)");
                }
                else if (!isStatusValid)
                {
                    MessageBox.Show("Please enter a valid status (1 for ACTIVE or 2 for DORMENT)");
                }
            }
            else
            {
                MessageBox.Show("All fields required");
            }


        }

        // function for the delete button if needed. Will delete the selected row
        private void delete_button_Click(object sender, EventArgs e)
        {
            if (suppliername.Text == "")
            {
                MessageBox.Show("Please enter a supplier name to be deleted");
            }
            else
            {

                string deleteQuery = "DELETE FROM suppliers WHERE supplierName= '" + suppliername.Text + "';";
                OleDbCommand cmd = new OleDbCommand(deleteQuery, vcon);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Supplier Successfully Deleted");
                refresh();
                clearFields();
            }
        }

        //when the user clicks on a row, it will populate the fields with the information
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            supplierid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            suppliername.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            supplieremail.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            supplierphone.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            supplierwebsite.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            supplierstatus.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        //home button will take user back to home screen
        private void homebutton_Click_1(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            this.Visible = false;
            home.ShowDialog();
            this.Close();
        }

    }
}

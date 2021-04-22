/* This will be the Categories form for our iControl application.
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

namespace iControl
{
    public partial class frmCategories : Form
    {
        OleDbConnection vcon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\iControl.accdb");
        //Create OleDb connection : need to import System.Data.OleDb first!
        //OleDbConnection vcon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\goisb\Documents\GitHub\iControl\database\iControl.accdb");

        //Andrew's connection
        //OleDbConnection vcon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Andrew School\Dropbox\COMP1098-.NetC#\Project\iControl\database\iControl.accdb");

        public frmCategories()
        {
            InitializeComponent();
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iControlDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.iControlDataSet.Categories);

            //Andrew's connection
            //this.categoriesTableAdapter.Fill(this.iControlDataSet1.Categories); 

            //open the connection
            vcon.Open();

        }

        //clear fields after clicking on add, edit or delete
        void clearFields()
        {
            categorydescription.Text = "";
            categoryname.Text = "";
            categoryId.Text = "";
        }


        //create a auto-refresh method to show data on the table after inserting or editing data
        void refresh()
        {
            string vsql = "SELECT * FROM categories";
            OleDbCommand vcom = new OleDbCommand(vsql, vcon);
            DataSet vds = new DataSet();
            OleDbDataAdapter vda = new OleDbDataAdapter(vcom);
            vda.Fill(vds, "res");
            dataGridView1.DataSource = vds.Tables["res"];
            vda.Dispose();
            vcom.Dispose();
        }

        //When add button pressed, insert the values from the fields into the table, then refresh the table
        //Check if category name field is empty
        private void add_button_Click(object sender, EventArgs e)
        {
            bool fieldEmpty = categoryname.Text == "" || categorydescription.Text == "";

            if (!fieldEmpty)
            {
               
                    string vsql = string.Format("INSERT INTO categories (categoryName, categoryDescription) " +
               "VALUES ('" + categoryname.Text + "', '" + categorydescription.Text + "')");
                    OleDbCommand vcom = new OleDbCommand(vsql, vcon);
                    vcom.ExecuteNonQuery();
                    MessageBox.Show("Data Successfully Inserted. There is a new supplier.");
                    vcom.Dispose();
                    refresh();
                    clearFields();    
            }
            else
            {
                MessageBox.Show("All fields required");
            }

           
        }


        //Edit information
        //Select the desired row, it populates the fields, the user modifies the values and click edit
        //if field category name is empty, show error message
        private void edit_button_Click(object sender, EventArgs e)
        {

            bool fieldEmpty = categoryname.Text == "" || categorydescription.Text == "";

            if (!fieldEmpty)
            {

                string vsql = string.Format("UPDATE categories SET categoryName = '" + categoryname.Text + "', categoryDescription = '" + categorydescription.Text + "' WHERE categoryID = " + categoryId.Text + "  ");
                OleDbCommand vcom = new OleDbCommand(vsql, vcon);
                vcom.ExecuteNonQuery();
                MessageBox.Show("Existing supplier successfully modified");
                vcom.Dispose();
                refresh();
                clearFields();
            }
            else
            {
                MessageBox.Show("All fields required");
            }
           
        }



        // function for the delete button if needed. Will delete the selected row
        private void delete_button_Click(object sender, EventArgs e)
        {
            if(categoryname.Text == "")
            {
                MessageBox.Show("Please enter a category name to be deleted");
            }
            else
            {
                
                string deleteQuery = "DELETE FROM categories WHERE categoryName= '" + categoryname.Text + "';";
                OleDbCommand cmd = new OleDbCommand(deleteQuery, vcon);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Entry Successfully Deleted");
                refresh();
                clearFields();
            }
        }

        //when the user clicks on a row, it will populate the fields with the information
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //name of the field.Text = name of table.CurrentRow.Cells[index of desired column]
            categoryname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            categorydescription.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            categoryId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        //home button will take user back to home screen
        private void homebutton_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            this.Visible = false;
            home.ShowDialog();
            this.Close();
        }

    }
}

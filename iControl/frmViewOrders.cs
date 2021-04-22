/* This will be the Orders form for our iControl application.
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
    public partial class frmViewOrders : Form
    {
        OleDbConnection vcon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\iControl.accdb");
        //Create OleDb connection : need to import System.Data.OleDb first!
        //OleDbConnection vcon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\goisb\Documents\GitHub\iControl\database\iControl.accdb");

        //Andrew's connection
        //OleDbConnection vcon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Andrew School\Dropbox\COMP1098-.NetC#\Project\iControl\database\iControl.accdb");
        public frmViewOrders()
        {
            vcon.Open();
            InitializeComponent();
            refreshViewOrders();
        }

        private void frmViewOrders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iControlDataSet.OrderStatus' table. You can move, or remove it, as needed.
            this.orderStatusTableAdapter.Fill(this.iControlDataSet.OrderStatus);

        }

        //method to show all orders - no filter
        void refreshViewOrders()
        {
            string vsql = "SELECT Orders.orderID AS Order_ID, Orders.orderDate AS Order_Date, Customers.customerFirstName AS First_Name, Customers.customerLastName AS Last_Name, OrderStatus.orderStatusName AS Status, Orders.orderTotalAmount AS Total_Amount FROM Customers INNER JOIN(OrderStatus INNER JOIN Orders ON OrderStatus.orderStatusID = Orders.orderStatusID) ON Customers.customerID = Orders.orderCustomerID; ";
            OleDbCommand vcom = new OleDbCommand(vsql, vcon);
            DataSet vds = new DataSet();
            OleDbDataAdapter vda = new OleDbDataAdapter(vcom);
            vda.Fill(vds, "res");
            dataGridViewOrders.DataSource = vds.Tables["res"];
            vda.Dispose();
            vcom.Dispose();
        }

        //ComboBox Order Status - Filter table by Order Status (Pending or Completed)
        private void orderStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //retrieve orderStatus from table after selecting a status on the combo box
            ComboBox cmb = (ComboBox)sender;
            int selectedValue = (int)cmb.SelectedValue;
            string statusValue = selectedValue.ToString();

            string vsql = "SELECT Orders.orderID AS Order_ID, Orders.orderDate AS Order_Date, Customers.customerFirstName AS First_Name, Customers.customerLastName AS Last_Name, OrderStatus.orderStatusName AS Status, Orders.orderTotalAmount AS Total_Amount FROM Customers INNER JOIN(OrderStatus INNER JOIN Orders ON OrderStatus.orderStatusID = Orders.orderStatusID) ON Customers.customerID = Orders.orderCustomerID WHERE Orders.orderStatusID = " + statusValue+"; ";
            OleDbCommand vcom = new OleDbCommand(vsql, vcon);
            DataSet vds = new DataSet();
            OleDbDataAdapter vda = new OleDbDataAdapter(vcom);
            vda.Fill(vds, "res");
            dataGridViewOrders.DataSource = vds.Tables["res"];
            vda.Dispose();
            vcom.Dispose();
        }

        //Reset table to show all orders - no filter
        private void showAllButton_Click(object sender, EventArgs e)
        {
            refreshViewOrders();
        }

        //Search field - Search by customer's first name
        private void searchByFirstNameButton_Click(object sender, EventArgs e)
        {
            string vsql = "SELECT Orders.orderID AS Order_ID, Orders.orderDate AS Order_Date, Customers.customerFirstName AS First_Name, Customers.customerLastName AS Last_Name, OrderStatus.orderStatusName AS Status, Orders.orderTotalAmount AS Total_Amount FROM Customers INNER JOIN(OrderStatus INNER JOIN Orders ON OrderStatus.orderStatusID = Orders.orderStatusID) ON Customers.customerID = Orders.orderCustomerID WHERE Customers.customerFirstName = '" + filterSearchBox.Text + "' ";
            OleDbCommand vcom = new OleDbCommand(vsql, vcon);
            DataSet vds = new DataSet();
            OleDbDataAdapter vda = new OleDbDataAdapter(vcom);
            vda.Fill(vds, "res");
            dataGridViewOrders.DataSource = vds.Tables["res"];
            vda.Dispose();
            vcom.Dispose();
        }

        //Search by customer's last name
        private void searchByLastNameButton_Click(object sender, EventArgs e)
        {
            string vsql = "SELECT Orders.orderID AS Order_ID, Orders.orderDate AS Order_Date, Customers.customerFirstName AS First_Name, Customers.customerLastName AS Last_Name, OrderStatus.orderStatusName AS Status, Orders.orderTotalAmount AS Total_Amount FROM Customers INNER JOIN(OrderStatus INNER JOIN Orders ON OrderStatus.orderStatusID = Orders.orderStatusID) ON Customers.customerID = Orders.orderCustomerID WHERE Customers.customerLastName = '" + filterSearchBox.Text + "' ";
            OleDbCommand vcom = new OleDbCommand(vsql, vcon);
            DataSet vds = new DataSet();
            OleDbDataAdapter vda = new OleDbDataAdapter(vcom);
            vda.Fill(vds, "res");
            dataGridViewOrders.DataSource = vds.Tables["res"];
            vda.Dispose();
            vcom.Dispose();
        }

        string orderIDVariable = "";
        public static string orderIDGlobal = "";
        private void dataGridViewOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            orderIDVariable = dataGridViewOrders.CurrentRow.Cells[4].Value.ToString();
            orderIDGlobal = dataGridViewOrders.CurrentRow.Cells[0].Value.ToString();
        }


        //Place order button - will update the order from pending to complete
        //First will check if the variable is null (no row was selected) or 2 (already a completed order)
        private void placeOrderButton_Click(object sender, EventArgs e)
        {

            if (orderIDVariable == "")
            {
                MessageBox.Show("Please select a pending entry to be modified", "Attention!");
            }
            else if (orderIDVariable == "Completed")
            {
                MessageBox.Show("This order is already completed", "OOPS!!!");
            }
            else
            {
                string vsql = string.Format("UPDATE orders SET orderStatusID = 2 WHERE orderID = " + dataGridViewOrders.CurrentRow.Cells[0].Value.ToString() + " ");
                OleDbCommand vcom = new OleDbCommand(vsql, vcon);
                vcom.ExecuteNonQuery();
                MessageBox.Show("Order Successfully Edited.", "Order is now completed");
                vcom.Dispose();
                refreshViewOrders();

                //reset orderIDVariable. User has to click on table again to retrieve the new orderID.
                orderIDVariable = "";
            }
            
            
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            if (orderIDVariable == "")
            {
                MessageBox.Show("Please select an order to print", "Attention!");
            }
            else if (orderIDVariable == "Completed" || orderIDVariable == "Pending")
            {
                frmPrintScreen printInvoice = new frmPrintScreen();
                printInvoice.ShowDialog();
            }
            
        }

        private void editButton_Click(object sender, EventArgs e)
        {
 
            if (orderIDVariable == "Pending")
            {
          
                 frmOrders frm = new frmOrders();
                 this.Visible = false;
                 frm.ShowDialog();
                 this.Close();
            }
            else
            {
                MessageBox.Show("Please select a Pending Order to Edit");
                frmViewOrders frm = new frmViewOrders();
                this.Visible = false;
                frm.ShowDialog();
                this.Close();
            }
   
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            frmHome frm = new frmHome();
            this.Visible = false;
            frm.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmOrders frm = new frmOrders();
            this.Visible = false;
            frm.ShowDialog();
            this.Close();
        }
    }
}

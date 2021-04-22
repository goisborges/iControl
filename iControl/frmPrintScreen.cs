/* This will be the View Orders form for our iControl application.
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
using System.Collections;

namespace iControl
{
    public partial class frmPrintScreen : Form {
        OleDbConnection vcon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\iControl.accdb");
        //Create OleDb connection : need to import System.Data.OleDb first!
        //OleDbConnection vcon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\goisb\Documents\GitHub\iControl\database\iControl.accdb");

        //Andrew's connection
        //OleDbConnection vcon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Andrew School\Dropbox\COMP1098-.NetC#\Project\iControl\database\iControl.accdb");
    
        public frmPrintScreen()
        {
            InitializeComponent();
            vcon.Open();
        }

        private void frmPrintScreen_Load(object sender, EventArgs e)
        {
            //retrieve the orderID as order number
            invoiceNumberLabel.Text = frmViewOrders.orderIDGlobal;

            //use the orderID to retrieve the customerID
            OleDbCommand com = new OleDbCommand("SELECT orderCustomerID FROM orders WHERE orderID = " + invoiceNumberLabel.Text + "", vcon);
            OleDbDataReader reader2 = com.ExecuteReader();
            if (reader2.Read())
            {

                customerIDLabel.Text = reader2.GetValue(0).ToString();

            }

            //use the customerID to retrieve all the customer info
            OleDbCommand com2 = new OleDbCommand("SELECT customerFirstName, customerLastName, customerStreet, customerCity, customerCountry, customerPostalCode, customerPhoneNumber, customerEmail FROM customers WHERE customerID = " + customerIDLabel.Text + "", vcon);
            OleDbDataReader reader3 = com2.ExecuteReader();
            if (reader3.Read())
            {

                fullNameLabel.Text = reader3.GetValue(0).ToString() + " " + reader3.GetValue(1).ToString();
                customerStreetLabel.Text = reader3.GetValue(2).ToString() + ", " + reader3.GetValue(3).ToString();
                countryLabel.Text = reader3.GetValue(4).ToString() + ", " + reader3.GetValue(5).ToString();
                phoneNumberLabel.Text = reader3.GetValue(6).ToString();
                emailLabel.Text = reader3.GetValue(7).ToString();
            }

            //use the orderID to retrieve orderDate
            OleDbCommand com3 = new OleDbCommand("SELECT orderDate, orderTotalAmount FROM orders WHERE orderID = " + invoiceNumberLabel.Text + "", vcon);
            OleDbDataReader reader4 = com3.ExecuteReader();
            if (reader4.Read())
            {
                dateLabel.Text = reader4.GetValue(0).ToString();
                totalAmountLabel.Text = reader4.GetValue(1).ToString();

            }

            //use the orderID to retrieve the ordered products
            OleDbCommand com4 = new OleDbCommand("SELECT Products.productID AS ID, Products.productName AS Product, OrderProducts.orderProductQuantity AS Quantity, Products.productPrice AS Unit_Price,  OrderProducts.orderProductQuantity * Products.productPrice AS Total_Price FROM Orders INNER JOIN(Products INNER JOIN OrderProducts ON Products.productID = OrderProducts.orderProductProductID) ON Orders.orderID = OrderProducts.orderProductOrderID WHERE orderProductOrderID = " + invoiceNumberLabel.Text + "", vcon);
            OleDbDataReader reader5 = com4.ExecuteReader();
            if (reader5.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader5);
                dataGridView1.DataSource = dt;

            }


        }

        //SETTING UP THE PRINT WITH PREVIEW FUNCTION
        Bitmap memoryImage;
        
        private void printButton_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
                printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument1_PrintPage_1);
            }
        }
        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void CaptureScreen()
        {
            //trying to print all items. Make DataGridView height same as items
            int height = dataGridView1.Height;
            dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
            dataGridView1.Height = height;
            //end of trying

            
            printButton.Visible = false;
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
            printButton.Visible = true;
            
        }

        //END OF PRINT FUNCTION
    }
}

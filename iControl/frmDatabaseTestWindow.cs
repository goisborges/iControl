using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iControl
{
    public partial class frmDatabaseTestWindow : Form
    {
        public frmDatabaseTestWindow()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iControlDataSet.queryOrderProductsOrderID' table. You can move, or remove it, as needed.
            //this.queryOrderProductsOrderIDTableAdapter.Fill(this.iControlDataSet.queryOrderProductsOrderID);
            // TODO: This line of code loads data into the 'iControlDataSet.Products' table. You can move, or remove it, as needed.
            //this.productsTableAdapter.Fill(this.iControlDataSet.Products);
            // TODO: This line of code loads data into the 'iControlDataSet.OrderProducts' table. You can move, or remove it, as needed.
            //this.orderProductsTableAdapter.Fill(this.iControlDataSet.OrderProducts);
            // TODO: This line of code loads data into the 'iControlDataSet.Orders' table. You can move, or remove it, as needed.
            //this.ordersTableAdapter.Fill(this.iControlDataSet.Orders);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            frmHome frm = new frmHome();
            this.Visible = false;
            frm.ShowDialog();
            this.Close();
        }
    }
}

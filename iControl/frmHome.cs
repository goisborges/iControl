/* This will be the Main/Home form for our iControl application.
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

namespace iControl
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonOpenDBTestWindow_Click(object sender, EventArgs e)
        {
            frmDatabaseTestWindow frm = new frmDatabaseTestWindow();
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

        private void customersButton_Click(object sender, EventArgs e)
        {
            frmCustomers frm = new frmCustomers();
            this.Visible = false;
            frm.ShowDialog();
            this.Close();
        }

        private void categoriesButton_Click(object sender, EventArgs e)
        {
            frmCategories frm = new frmCategories();
            this.Visible = false;
            frm.ShowDialog();
            this.Close();
        }

        private void button_suppliers_Click(object sender, EventArgs e)
        {
            frmSuppliers frm = new frmSuppliers();
            this.Visible = false;
            frm.ShowDialog();
            this.Close();
        }

        private void button_products_Click(object sender, EventArgs e)
        {
            frmProducts frm = new frmProducts();
            this.Visible = false;
            frm.ShowDialog();
            this.Close();
        }
    }
}

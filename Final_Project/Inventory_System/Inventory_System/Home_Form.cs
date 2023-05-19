using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_System
{
    public partial class Home_Form : Form
    {
        public Home_Form()
        {
            InitializeComponent();
        }

        private void Exit_Btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Customer_Icon_Click(object sender, EventArgs e)
        {
            ManageClients clients = new ManageClients();
            clients.Show();
            this.Hide();
        }

        private void Supplier_Icon_Click(object sender, EventArgs e)
        {
            ManageSupplier Supp = new ManageSupplier();
            Supp.Show();
            this.Hide();
        }

        private void Warehouse_Icon_Click(object sender, EventArgs e)
        {
            ManageWarehouse WH = new ManageWarehouse();
            WH.Show();
            this.Hide();
        }

        private void Product_Icon_Click(object sender, EventArgs e)
        {
            ManageProduct Product = new ManageProduct();
            Product.Show();
            this.Hide();
        }

        private void Request_Icon_Click(object sender, EventArgs e)
        {
            ManageRequests Req = new ManageRequests();
            Req.Show();
            this.Hide();
        }

        private void Reports_Icon_Click(object sender, EventArgs e)
        {
            ManageReports MR = new ManageReports();
            MR.Show();
            this.Hide();
        }
    }
}

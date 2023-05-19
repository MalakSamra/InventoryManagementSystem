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
    public partial class TransferRequest : Form
    {
        Inventory_Entity Ent;
        public TransferRequest()
        {
            InitializeComponent();
            Ent = new Inventory_Entity();
        }

        private void Transfer_Btn_Click(object sender, EventArgs e)
        {
            if(Quant_Txt_Box_Trans.Text != "" && Prod_dateTimePicker.Text !="" && Exp_dateTimePicker.Text!=""&& From_WH_ComboBox.Text!=""&& To_WH_ComboBox.Text != "" && Supplier_comboBox.Text != "")
            {
                if(From_WH_ComboBox.Text != To_WH_ComboBox.Text)
                {
                    Product P = Ent.Products.Find(int.Parse(Code_Txt_Box_Trans.Text));
                    if(int.Parse(Quant_Txt_Box_Trans.Text) <= int.Parse(Avilable_Q_Txt_Box.Text))
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show($"Not Enough Quantity. The Product's Quantity is {Avilable_Q_Txt_Box.Text}");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Enter Different Warehouses.");
                }
            }
            else
            {
                MessageBox.Show("Enter Full data");
            }
        }

        private void Cancel_Btn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void TransferRequest_Load(object sender, EventArgs e)
        {
            Date_dateTimePicker.Enabled = false;
            Code_Txt_Box_Trans.Enabled = false;
            Avilable_Q_Txt_Box.Enabled = false;
            ManageProduct MP = new ManageProduct();
            Date_dateTimePicker.Value = DateTime.Now;
            int Code = int.Parse(Code_Txt_Box_Trans.Text);
            var WHs = (from w in Ent.WH_Prod
                      where w.Product_Code == Code
                      select w).ToList();
            foreach (WH_Prod w in WHs)
            {
                From_WH_ComboBox.Items.Add(w.WH_Name);
            }
            foreach (Warehouse WH in Ent.Warehouses)
            {
                To_WH_ComboBox.Items.Add( WH.Name );
            }
            foreach(Supplier S in Ent.Suppliers)
            {
                Supplier_comboBox.Items.Add(S.Name);
            }
            Prod_dateTimePicker.Value = new DateTime(2022, 01, 01);
            Exp_dateTimePicker.Value = new DateTime(2022, 01, 01);
        }
        public DateTime Date
        { 
            set { Date_dateTimePicker.Value = value; }
            get { return Date_dateTimePicker.Value; }
        }
        public string Prod_Code
        {
            set { Code_Txt_Box_Trans.Text = value; }
            get { return Code_Txt_Box_Trans.Text; }
        }
        public string From_WH
        {
            set { From_WH_ComboBox.Text = value; }
            get { return From_WH_ComboBox.Text; }
        }
        public string To_WH
        {
            set { To_WH_ComboBox.Text = value; }
            get { return To_WH_ComboBox.Text; }
        }
        public string Quantity
        {
            set 
            {
                Quant_Txt_Box_Trans.Text = value;
            }
            get { return Quant_Txt_Box_Trans.Text; }
        }
        public DateTime Prod_Date
        {
            set { Prod_dateTimePicker.Value = value; }
            get { return Prod_dateTimePicker.Value; }
        }
        public DateTime Exp_Date
        {
            set { Exp_dateTimePicker.Value = value; }
            get { return Exp_dateTimePicker.Value; }
        }
        public string Supplier
        {
            set { Supplier_comboBox.Text = value; }
            get { return Supplier_comboBox.Text; }
        }

        private void From_WH_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int code = int.Parse(Code_Txt_Box_Trans.Text);
            var WHS = from w in Ent.WH_Prod
                      where w.Product_Code == code && w.WH_Name == From_WH_ComboBox.Text
                      select w;
            foreach (WH_Prod w in WHS)
            {
                Avilable_Q_Txt_Box.Text = w.Available_Quantity.ToString();
            }

        }
    }
}

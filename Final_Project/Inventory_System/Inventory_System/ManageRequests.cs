using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inventory_System
{
    public partial class ManageRequests : Form
    {
        Inventory_Entity Ent;
        Request Req;
        int code;
        public ManageRequests()
        {
            InitializeComponent();
            Ent = new Inventory_Entity();
            Req = new Request();
        }
        private void ManageRequests_Load(object sender, EventArgs e)
        {
            Request_GB.Visible = false;
            Add_Req_Btn.Visible = false;
            ID_Txt_Box.Enabled = false;
            Req_Type_combo_box.Enabled = false;
            Combo_Box_Fill();
            Data_Grid_Display();
        }
        public void Combo_Box_Fill()
        {
            foreach (Request R in Ent.Requests)
            {
                Req_ID_comboBox.Items.Add(R.Req_ID);
            }
            Req_ID_comboBox.Items.Add("All");
            GB_ComboBox_Fill();
        }
        public void Data_Grid_Display()
        {
            Request_Datagrid_View.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Teal;
            Request_Datagrid_View.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            if (Req_ID_comboBox.Text == "" || Req_ID_comboBox.Text == "All")
            {
                var Requests = Ent.Requests
                    .Select(R => new { R.Req_ID, R.Type, R.Date, R.Product_Code}).ToList();
                Request_Datagrid_View.DataSource = Requests;
            }
            else
            {
                int ID = int.Parse(Req_ID_comboBox.Text);
                var Requests = Ent.Requests
                    .Where(R => R.Req_ID == ID)
                    .Select(R => new { R.Req_ID, R.Type, R.Date, R.Product_Code}).ToList();
                Request_Datagrid_View.DataSource = Requests;
            }
        }
        private void Go_To_Data_Btn_Click(object sender, EventArgs e)
        {
            Request_GB.Visible = true;
            if(Req_ID_comboBox.Text == "" || Req_ID_comboBox.Text == "All")
            {
                ID_Txt_Box.Text = Req_Type_combo_box.Text = Prod_code_comboBox.Text = Supp_comboBox.Text = WH_comboBox.Text = Quant_Txt_Box.Text = Validation_Period_Txt_Box.Text = "";
                Req_Date.Visible = false;
                Prod_dateTimePicker.Visible = false;
            }
            else
            {
                ID_Txt_Box.Text = Req_ID_comboBox.Text;
                Req_Date.Visible = true;
                ID_Txt_Box.Enabled = false;
                
            }
        }
        public void Display_Data()
        {
            if (Req_ID_comboBox.Text != "All")
            {
                Req_Date.Visible = true;
                Prod_dateTimePicker.Visible = true;
                
                int ID = int.Parse(Req_ID_comboBox.Text);
                var RQ = from r in Ent.Requests
                         where r.Req_ID == ID
                         select r;
                foreach(Request r in RQ)
                {
                    Prod_code_comboBox.Text = r.Product_Code.ToString();
                    Supp_comboBox.Text = r.Supplier_Name.ToString();
                    WH_comboBox.Text = r.WH_Name.ToString();
                }
                
                Request R = Ent.Requests.Find(ID, int.Parse(Prod_code_comboBox.Text), Supp_comboBox.Text, WH_comboBox.Text);
                ID_Txt_Box.Text = R.Req_ID.ToString();
                Req_Type_combo_box.Text = R.Type;
                Req_Date.Value = R.Date;
                Quant_Txt_Box.Text = R.Quantity.ToString();
                Prod_dateTimePicker.Value = R.Production_Date;
                Validation_Period_Txt_Box.Text = R.Validity_Period;
            }
            else if (Req_ID_comboBox.Text == "" || Req_ID_comboBox.Text == "All")
            {
                ID_Txt_Box.Text = Req_Type_combo_box.Text = Prod_code_comboBox.Text = Supp_comboBox.Text = WH_comboBox.Text = Quant_Txt_Box.Text = Validation_Period_Txt_Box.Text ="";
                Req_Date.Visible = false;
                Prod_dateTimePicker.Visible = false;
            }
        }
        public void GB_ComboBox_Fill()
        {
            Req_Type_combo_box.Items.Add("Export");
            Req_Type_combo_box.Items.Add("Import");
            foreach (Product P in Ent.Products)
            {
                Prod_code_comboBox.Items.Add(P.Code);
            }
            foreach (Supplier S in Ent.Suppliers)
            {
                Supp_comboBox.Items.Add(S.Name);
            }
            if (Prod_code_comboBox.Text == "")
            {
                foreach (Warehouse W in Ent.Warehouses)
                {
                    WH_comboBox.Items.Add(W.Name);
                }
            }
            else
            {
                code = int.Parse(Prod_code_comboBox.Text);
                var WH = from w in Ent.WH_Prod
                         where w.Product_Code == int.Parse(Prod_code_comboBox.Text)
                         select w;
                foreach (WH_Prod W in WH)
                {
                    WH_comboBox.Items.Add(W.WH_Name);
                }
            }
        }
        private void Req_ID_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Display_Data();
            Data_Grid_Display();
            Add_Req_Btn.Visible = false;
            Add_Btn.Visible = true;
            Upd_R_Btn.Visible = true;
        }
        private void Display_All_Btn_Click(object sender, EventArgs e)
        {
            Req_ID_comboBox.Text = "All";
        }
        private void Request_Datagrid_View_MouseClick(object sender, MouseEventArgs e)
        {
            if (Request_Datagrid_View.SelectedRows.Count > 0)
            {
                string ID = (Request_Datagrid_View.SelectedRows[0].Cells[0].Value).ToString();
                Req_ID_comboBox.Text = ID;
            }
        }
        private void Add_Btn_Click(object sender, EventArgs e)
        {
            ID_Txt_Box.Text = Req_Type_combo_box.Text = Prod_code_comboBox.Text = Supp_comboBox.Text = WH_comboBox.Text = Quant_Txt_Box.Text = Validation_Period_Txt_Box.Text = "";
            Upd_R_Btn.Visible = false;
            Add_Btn.Visible = false;
            Add_Req_Btn.Visible = true;
            ID_Txt_Box.Enabled = true;
            Req_Type_combo_box.Enabled = true;
            Req_Date.Visible = true;
            Prod_dateTimePicker.Visible = true;
            Req_Date.Value = DateTime.Now;
            Prod_dateTimePicker.Value = DateTime.Now;
        }
        private void Add_Req_Btn_Click(object sender, EventArgs e)
        {
            if (ID_Txt_Box.Text != "" && Req_Type_combo_box.Text != "" && Prod_code_comboBox.Text != "" && Prod_dateTimePicker.Text != "" &&
                Validation_Period_Txt_Box.Text != "" && Supp_comboBox.Text != "" && WH_comboBox.Text != "" && Req_Date.Text != "" && Quant_Txt_Box.Text != "")
            {
                Request R = Ent.Requests.Find(int.Parse(ID_Txt_Box.Text), int.Parse(Prod_code_comboBox.Text), Supp_comboBox.Text, WH_comboBox.Text);
                if (R == null)
                {
                    Req.Req_ID = int.Parse(ID_Txt_Box.Text);
                    Req.Type = Req_Type_combo_box.Text;
                    Req.Product_Code = int.Parse(Prod_code_comboBox.Text);
                    Req.Supplier_Name = Supp_comboBox.Text;
                    Req.WH_Name = WH_comboBox.Text;
                    Req.Date = Req_Date.Value;
                    Req.Quantity = int.Parse(Quant_Txt_Box.Text);
                    Req.Production_Date = Prod_dateTimePicker.Value;
                    Req.Validity_Period = Validation_Period_Txt_Box.Text;
                    Ent.Requests.Add(Req);
                    Ent.SaveChanges();
                    if(Req_Type_combo_box.Text == "Import")
                    {
                        WH_Prod WP = Ent.WH_Prod.Find(WH_comboBox.Text,int.Parse(Prod_code_comboBox.Text));
                        if (WP == null)
                        {
                            WP = new WH_Prod();
                            WP.Product_Code = int.Parse(Prod_code_comboBox.Text);
                            WP.WH_Name = WH_comboBox.Text;
                            WP.Available_Quantity = int.Parse(Quant_Txt_Box.Text);
                            Ent.WH_Prod.Add(WP);
                        }
                        else
                        {
                            WP.Available_Quantity += int.Parse(Quant_Txt_Box.Text);
                        }
                        Ent.SaveChanges();
                    }
                    else if(Req_Type_combo_box.Text == "Export")
                    {
                        WH_Prod WP = Ent.WH_Prod.Find(WH_comboBox.Text, int.Parse(Prod_code_comboBox.Text));
                        if(WP == null || WP.Available_Quantity < int.Parse(Quant_Txt_Box.Text))
                        {
                            MessageBox.Show("Not Enough Quantity in Warehouse");
                        }
                        else if (WP.Available_Quantity >= int.Parse(Quant_Txt_Box.Text))
                        {
                            WP.Available_Quantity -= int.Parse(Quant_Txt_Box.Text);
                        }
                        Ent.SaveChanges();
                    }
                    ID_Txt_Box.Text = Req_Type_combo_box.Text = Prod_code_comboBox.Text = Supp_comboBox.Text = WH_comboBox.Text = Quant_Txt_Box.Text = Validation_Period_Txt_Box.Text = "";
                    Req_Date.Visible = false;
                    Prod_dateTimePicker.Visible = false;
                    MessageBox.Show("Request Added Successfully");
                    Req_ID_comboBox.Items.Clear();
                    Req_Type_combo_box.Items.Clear();
                    Prod_code_comboBox.Items.Clear();
                    Supp_comboBox.Items.Clear();
                    WH_comboBox.Items.Clear();
                    Combo_Box_Fill();
                    Data_Grid_Display();
                    Req_ID_comboBox.Text = "All";
                    Add_Btn.Visible = true;
                    Upd_R_Btn.Visible = true;
                    Add_Req_Btn.Visible = false;
                    ID_Txt_Box.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Request With The Same ID Already Exists.");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Required Data.");
            }
        }
        private void Upd_R_Btn_Click(object sender, EventArgs e)
        {
            if (ID_Txt_Box.Text != "" && Req_Type_combo_box.Text != "" && Prod_code_comboBox.Text != "" && Prod_dateTimePicker.Text != "" &&
                 Validation_Period_Txt_Box.Text != "" && Supp_comboBox.Text != "" && WH_comboBox.Text != "" && Req_Date.Text != "" && Quant_Txt_Box.Text != "")
            {
                Request R = Ent.Requests.Find(int.Parse(ID_Txt_Box.Text), int.Parse(Prod_code_comboBox.Text), Supp_comboBox.Text, WH_comboBox.Text);
                if (R != null)  
                {
                    int Old_Quantity = R.Quantity;
                    if (ID_Txt_Box.Text != "" && Req_Type_combo_box.Text != "" && Prod_code_comboBox.Text != "" && Prod_dateTimePicker.Text != "" &&
                        Validation_Period_Txt_Box.Text != "" && Supp_comboBox.Text != "" && WH_comboBox.Text != "" && Req_Date.Text != "" && Quant_Txt_Box.Text != "")
                    {
                        R.Type = Req_Type_combo_box.Text;
                        R.Date = Req_Date.Value;
                        R.Quantity = int.Parse(Quant_Txt_Box.Text);
                        R.Production_Date = Prod_dateTimePicker.Value;
                        R.Validity_Period = Validation_Period_Txt_Box.Text;
                        Ent.SaveChanges();
                        if(Req_Type_combo_box.Text == "Import")
                        {
                            WH_Prod WP = Ent.WH_Prod.Find(WH_comboBox.Text, int.Parse(Prod_code_comboBox.Text));
                            if (WP == null)
                            {
                                WP = new WH_Prod();
                                WP.Product_Code = int.Parse(Prod_code_comboBox.Text);
                                WP.WH_Name = WH_comboBox.Text;
                                WP.Available_Quantity = int.Parse(Quant_Txt_Box.Text);
                                Ent.WH_Prod.Add(WP);
                            }
                            else
                            {
                                WP.Available_Quantity += (int.Parse(Quant_Txt_Box.Text) - Old_Quantity);
                            }
                            Ent.SaveChanges();
                        }
                        else if (Req_Type_combo_box.Text == "Export")
                        {
                            WH_Prod WP = Ent.WH_Prod.Find(WH_comboBox.Text, int.Parse(Prod_code_comboBox.Text));
                            if (WP == null || WP.Available_Quantity < int.Parse(Quant_Txt_Box.Text))
                            {
                                MessageBox.Show("Not Enough Quantity in Warehouse");
                            }
                            else if (WP.Available_Quantity >= int.Parse(Quant_Txt_Box.Text))
                            {
                                WP.Available_Quantity -= Old_Quantity - int.Parse(Quant_Txt_Box.Text);
                            }
                            Ent.SaveChanges();
                        }
                        ID_Txt_Box.Text = Req_Type_combo_box.Text = Prod_code_comboBox.Text = Supp_comboBox.Text = WH_comboBox.Text = Quant_Txt_Box.Text = Validation_Period_Txt_Box.Text = "";
                        Req_Date.Visible = false;
                        Prod_dateTimePicker.Visible = false;
                        MessageBox.Show("Request Updated Successfully");
                        Data_Grid_Display();
                        Req_ID_comboBox.Text = "All";
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Required Data.");
                    }
                }
            }
            else
            {
                MessageBox.Show("No Client is Selected");
            }
        }
        private void Exit_Btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home_Form HM = new Home_Form();
            HM.Show();
            this.Close();
        }
    }
}

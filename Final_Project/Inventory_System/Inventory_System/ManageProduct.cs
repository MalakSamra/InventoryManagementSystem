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
    public partial class ManageProduct : Form
    {
        Inventory_Entity Ent;
        Product product;
        Measurment measurment;
        Transfer_History TH;
        WH_Prod WH_P;
        int Total;
        public ManageProduct()
        {
            InitializeComponent();
            Ent = new Inventory_Entity();
            product = new Product();
            measurment = new Measurment();
            TH = new Transfer_History();
            WH_P = new WH_Prod();
            
        }
        public int FindTotal(string s1, string s2)
        {
            int WH1_Quantity = 0;
            int WH2_Quantity = 0;
            if(s1 == "" && s2 == "")
            {
                return 0;
            }
            else if (s1 != "" && s2 == "")
            {
                WH1_Quantity = int.Parse(s1);
                return WH1_Quantity;
            }
            else if (s1 == "" && s2 != "")
            {
                WH2_Quantity = int.Parse(s2);
                return WH2_Quantity;
            }
            else if (s1 != "" && s2 != "")
            {
                WH1_Quantity = int.Parse(s1);
                WH2_Quantity = int.Parse(s2);
                return WH1_Quantity + WH2_Quantity;
            }
            return 0;
        }
        private void ManageProduct_Load(object sender, EventArgs e)
        {
            Product_GB.Visible = false;
            Code_Txt_Box_Prod.Enabled = false;
            Add_Prod_Btn.Visible = false;
            pictureBox2.Visible = false;
            MU_Txt_Box_Product.Enabled = false;
            MU_Txt_Box_Product2.Enabled = false;
            MU_Txt_Box_Product2.Visible = false;
            pictureBox3.Visible = false;
            Wh2_Quantity_Txt_Box.Visible = false;
            WH_Comb0Box.Enabled = false;
            WH_Comb0Box2.Enabled = false;
            WH_Comb0Box2.Visible = false;
            Combo_Box_Fill();
            Data_Grid_Display();
        }
        public void Combo_Box_Fill()
        {
            foreach (Product P in Ent.Products)
            {
                Prod_Code_ComboBox.Items.Add(P.Code);
            }
            Prod_Code_ComboBox.Items.Add("All");
            foreach (Warehouse WH in Ent.Warehouses)
            {
                WH_Comb0Box.Items.Add(WH.Name);
                WH_Comb0Box2.Items.Add(WH.Name);
            }
        }
        public void Data_Grid_Display()
        {
            Product_Datagrid_View.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Teal;
            Product_Datagrid_View.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            if (Prod_Code_ComboBox.Text == "" || Prod_Code_ComboBox.Text == "All")
            {
                var Products = Ent.Products
                    .Select(P => new { P.Code, P.Name}).ToList();
                Product_Datagrid_View.DataSource = Products;
            }
            else
            {
                int Code = int.Parse(Prod_Code_ComboBox.Text);
                var Products = Ent.Products
                    .Where(P => P.Code == Code)
                    .Select(P => new { P.Code, P.Name}).ToList();
                Product_Datagrid_View.DataSource = Products;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MU_Txt_Box_Product2.Visible = true;
        }

        private void Go_To_Prod_Data_Btn_Click(object sender, EventArgs e)
        {
            Product_GB.Visible = true;
            if (Prod_Code_ComboBox.Text == "" || Prod_Code_ComboBox.Text == "All")
            {
                Code_Txt_Box_Prod.Text = Name_Txt_Box_Prod.Text = MU_Txt_Box_Product.Text = MU_Txt_Box_Product2.Text = Quantity_Txt_Box.Text = Wh_Quantity_Txt_Box.Text = Wh2_Quantity_Txt_Box.Text = WH_Comb0Box.Text = WH_Comb0Box2.Text = "";
            }
            else
            {
                Code_Txt_Box_Prod.Text = Prod_Code_ComboBox.Text;
                Code_Txt_Box_Prod.Enabled = false;
                Display_Data();
            }
        }
        public void Display_Data()
        {
            if (Prod_Code_ComboBox.Text != "All")
            {
                int Code = int.Parse(Prod_Code_ComboBox.Text);
                Product P = Ent.Products.Find(Code);
                Code_Txt_Box_Prod.Text = P.Code.ToString();
                Name_Txt_Box_Prod.Text = P.Name;
                Quantity_Txt_Box.Text = P.Quantity.ToString();
                var Msr = (from m in P.Measurments
                          where m.Prod_Code == Code
                          select m).ToList();
                if(Msr.Count == 1)
                {
                    MU_Txt_Box_Product2.Visible = false;
                    MU_Txt_Box_Product.Text = Msr[0].Measurment_Unit;
                }
                else if(Msr.Count > 1)
                {
                    MU_Txt_Box_Product2.Visible = true;
                    MU_Txt_Box_Product.Text = Msr[0].Measurment_Unit;
                    MU_Txt_Box_Product2.Text = Msr[1].Measurment_Unit;
                }
                var WH_P = (from w in P.WH_Prod
                            where w.Product_Code == P.Code
                            select w).ToList();
                if (WH_P.Count == 1)
                {
                    WH_Comb0Box2.Visible = false;
                    Wh2_Quantity_Txt_Box.Visible = false;
                    WH_Comb0Box.Text = WH_P[0].WH_Name;
                    Wh_Quantity_Txt_Box.Text = WH_P[0].Available_Quantity.ToString();
                }
                else if (WH_P.Count == 2)
                {
                    Wh2_Quantity_Txt_Box.Visible = true;
                    WH_Comb0Box2.Visible = true;
                    WH_Comb0Box.Text = WH_P[0].WH_Name;
                    Wh_Quantity_Txt_Box.Text = WH_P[0].Available_Quantity.ToString();
                    WH_Comb0Box2.Text = WH_P[1].WH_Name;
                    Wh2_Quantity_Txt_Box.Text = WH_P[1].Available_Quantity.ToString();
                }
            }
            else if (Prod_Code_ComboBox.Text == "" || Prod_Code_ComboBox.Text == "All")
            {
                Code_Txt_Box_Prod.Text = Name_Txt_Box_Prod.Text = MU_Txt_Box_Product.Text = MU_Txt_Box_Product2.Text = Quantity_Txt_Box.Text = Wh_Quantity_Txt_Box.Text = Wh2_Quantity_Txt_Box.Text = WH_Comb0Box.Text = WH_Comb0Box2.Text = "";
            }
        }
        private void Display_All_WH_Btn_Click(object sender, EventArgs e)
        {
            Prod_Code_ComboBox.Text = "All";
        }
        private void Prod_Code_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Display_Data();
            Data_Grid_Display();
            Add_Prod_Btn.Visible = false;
            Add_Btn.Visible = true;
            Upd_Prod_Btn.Visible = true;
        }
        private void Product_Datagrid_View_MouseClick(object sender, MouseEventArgs e)
        {
            if (Product_Datagrid_View.SelectedRows.Count > 0)
            {
                string code = (Product_Datagrid_View.SelectedRows[0].Cells[0].Value).ToString();
                Prod_Code_ComboBox.Text = code;
            }
        }
        private void Add_Btn_Click(object sender, EventArgs e)
        {
            Code_Txt_Box_Prod.Text = Name_Txt_Box_Prod.Text = MU_Txt_Box_Product.Text = MU_Txt_Box_Product2.Text = Quantity_Txt_Box.Text = Wh_Quantity_Txt_Box.Text = Wh2_Quantity_Txt_Box.Text = WH_Comb0Box.Text = WH_Comb0Box2.Text = "";
            Upd_Prod_Btn.Visible = false;
            Add_Btn.Visible = false;
            Add_Prod_Btn.Visible = true;
            pictureBox2.Visible = true;
            Code_Txt_Box_Prod.Enabled = true;
            MU_Txt_Box_Product.Enabled = true;
            MU_Txt_Box_Product2.Enabled = true;
            MU_Txt_Box_Product2.Visible = false;
            pictureBox3.Visible = true;
            WH_Comb0Box.Enabled = true;
            WH_Comb0Box2.Enabled = true;
            Wh_Quantity_Txt_Box.Enabled = true;
            Wh2_Quantity_Txt_Box.Enabled = true;
            WH_Comb0Box2.Visible = false;
            Wh2_Quantity_Txt_Box.Visible = false;
        }
        private void Add_Prod_Btn_Click(object sender, EventArgs e)
        {
            if (Code_Txt_Box_Prod.Text != "" && Name_Txt_Box_Prod.Text != "" && MU_Txt_Box_Product.Text != "")
            {
                Total = FindTotal(Wh_Quantity_Txt_Box.Text, Wh2_Quantity_Txt_Box.Text);
                if(Total <= int.Parse(Quantity_Txt_Box.Text))
                {
                    Product P = Ent.Products.Find(int.Parse(Code_Txt_Box_Prod.Text));
                    if (P == null)
                    {
                        product.Code = int.Parse(Code_Txt_Box_Prod.Text);
                        product.Name = Name_Txt_Box_Prod.Text;
                        product.Quantity = int.Parse(Quantity_Txt_Box.Text);
                        measurment.Prod_Code = product.Code;
                        measurment.Measurment_Unit = MU_Txt_Box_Product.Text;
                        if (MU_Txt_Box_Product2.Text != "")
                        {
                            Measurment MS = new Measurment();
                            MS.Prod_Code = product.Code;
                            MS.Measurment_Unit = MU_Txt_Box_Product2.Text;
                            Ent.Measurments.Add(MS);
                        }
                        WH_P.Product_Code = product.Code;
                        WH_P.WH_Name = WH_Comb0Box.Text;
                        WH_P.Available_Quantity = int.Parse(Wh_Quantity_Txt_Box.Text);
                        if (Wh2_Quantity_Txt_Box.Text != "")
                        {
                            WH_Prod W = new WH_Prod();
                            W.Product_Code = product.Code;
                            W.WH_Name = WH_Comb0Box2.Text;
                            W.Available_Quantity = int.Parse(Wh2_Quantity_Txt_Box.Text);
                            Ent.WH_Prod.Add(W);
                        }
                        Ent.Products.Add(product);
                        Ent.Measurments.Add(measurment);
                        Ent.WH_Prod.Add(WH_P);
                        Ent.SaveChanges();
                        Code_Txt_Box_Prod.Text = Name_Txt_Box_Prod.Text = MU_Txt_Box_Product.Text = MU_Txt_Box_Product2.Text = Quantity_Txt_Box.Text =Wh_Quantity_Txt_Box.Text = Wh2_Quantity_Txt_Box.Text = WH_Comb0Box.Text = WH_Comb0Box2.Text ="";
                        MessageBox.Show("Product Added Successfully");
                        Prod_Code_ComboBox.Items.Clear();
                        Combo_Box_Fill();
                        Data_Grid_Display();
                        Add_Btn.Visible = true;
                        Upd_Prod_Btn.Visible = true;
                        Add_Prod_Btn.Visible = false;
                        pictureBox2.Visible = false;
                        Code_Txt_Box_Prod.Enabled = false;
                        MU_Txt_Box_Product.Enabled = false;
                        MU_Txt_Box_Product2.Enabled = false;
                        pictureBox3.Visible = false;
                        WH_Comb0Box.Enabled = false;
                        Wh_Quantity_Txt_Box.Enabled = false;
                        WH_Comb0Box2.Enabled = false;
                        Wh2_Quantity_Txt_Box.Enabled = false;
                        Wh2_Quantity_Txt_Box.Visible = false;
                        WH_Comb0Box2.Visible = false;
                        Prod_Code_ComboBox.Text = "All";
                    }
                    else
                    {
                        MessageBox.Show("Product With The Same Code Already Exists.");
                    }
                }
                else
                {
                    MessageBox.Show("Quantities More than the Total Quantity of the Product");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Required Data.");
            }
        }
        private void Upd_Prod_Btn_Click(object sender, EventArgs e)
        {
            if (Code_Txt_Box_Prod.Text != "" && Name_Txt_Box_Prod.Text != "" && MU_Txt_Box_Product.Text != "" && Quantity_Txt_Box.Text != "")
            {
                Total = FindTotal(Wh_Quantity_Txt_Box.Text, Wh2_Quantity_Txt_Box.Text);
                if (Total <= int.Parse(Quantity_Txt_Box.Text))
                {
                    Product P = Ent.Products.Find(int.Parse(Prod_Code_ComboBox.Text));
                    if (P != null)
                    {
                        if (Code_Txt_Box_Prod.Text != "" && Name_Txt_Box_Prod.Text != "" && MU_Txt_Box_Product.Text != "" && Quantity_Txt_Box.Text != "")
                        {
                            P.Name = Name_Txt_Box_Prod.Text;
                            P.Quantity = int.Parse(Quantity_Txt_Box.Text);
                            var WH_P = (from w in P.WH_Prod
                                        where w.Product_Code == P.Code
                                        select w).ToList();
                            if (WH_P.Count == 1)
                            {
                                WH_P[0].Available_Quantity = int.Parse(Wh_Quantity_Txt_Box.Text);
                            }
                            else if (WH_P.Count == 2)
                            {
                                WH_P[0].Available_Quantity = int.Parse(Wh_Quantity_Txt_Box.Text);
                                WH_P[1].Available_Quantity = int.Parse(Wh2_Quantity_Txt_Box.Text);
                            }
                            Ent.SaveChanges();
                            Code_Txt_Box_Prod.Text = Name_Txt_Box_Prod.Text = MU_Txt_Box_Product.Text = MU_Txt_Box_Product2.Text = Wh_Quantity_Txt_Box.Text = Wh2_Quantity_Txt_Box.Text = "";
                            MessageBox.Show("Product Updated Successfully");
                            Data_Grid_Display();
                            Prod_Code_ComboBox.Text = "All";
                        }
                        else
                        {
                            MessageBox.Show("Please Enter Required Data.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Product Not Found");
                    }
                }
                else
                {
                    MessageBox.Show("Quantities More than the Total Quantity of the Product");
                }
            }
            else
            {
                MessageBox.Show("No Client is Selected");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(Code_Txt_Box_Prod.Text != "")
            {
                TransferRequest TR = new TransferRequest();
                DialogResult Dlg_Result;
                TR.Prod_Code = Code_Txt_Box_Prod.Text;
                Dlg_Result = TR.ShowDialog();
                if (Dlg_Result == DialogResult.OK)
                {
                    TH.Transaction_Date = TR.Date;
                    TH.Product_Code = int.Parse(TR.Prod_Code);
                    TH.Product_Name = Name_Txt_Box_Prod.Text;
                    TH.Production_Date = TR.Prod_Date;
                    TH.Exp_Date = TR.Exp_Date;
                    TH.From_WH = TR.From_WH;
                    TH.To_WH = TR.To_WH;
                    TH.Supplier_Name = TR.Supplier;
                    TH.Quantity = int.Parse(TR.Quantity);
                    var SourceWH = Ent.WH_Prod.FirstOrDefault(wp => wp.Product_Code == TH.Product_Code && wp.WH_Name == TH.From_WH);
                    if(SourceWH != null)
                    {
                        if(SourceWH.Available_Quantity == TH.Quantity)
                        {
                            Ent.WH_Prod.Remove(SourceWH);
                        }
                        else
                        {
                            SourceWH.Available_Quantity -= TH.Quantity; 
                        }
                    }
                    var DestWH = Ent.WH_Prod.FirstOrDefault(wp => wp.Product_Code == TH.Product_Code && wp.WH_Name == TH.To_WH);
                    if(DestWH != null)
                    {
                        DestWH.Available_Quantity += TH.Quantity;
                    }
                    else
                    {
                        var New_WH_P = new WH_Prod
                        {
                            Product_Code = TH.Product_Code,
                            WH_Name = TH.To_WH,
                            Available_Quantity = TH.Quantity,
                        };
                        Ent.WH_Prod.Add(New_WH_P);
                    }
                    Ent.Transfer_History.Add(TH);
                    Ent.SaveChanges();
                    MessageBox.Show("Transfer Done Successfully.");
                    Prod_Code_ComboBox.Text = "All";
                }
            }
            else
            {
                MessageBox.Show("No Product Selected");
            }
        }
        private void Exit_Btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WH_Comb0Box2.Visible = true;
            Wh2_Quantity_Txt_Box.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home_Form HM = new Home_Form();
            HM.Show();
            this.Close();
        }
    }
}

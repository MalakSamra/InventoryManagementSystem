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
    public partial class ManageSupplier : Form
    {
        Inventory_Entity Ent;
        Supplier Supp;
        public ManageSupplier()
        {
            InitializeComponent();
            Ent = new Inventory_Entity();
            Supp = new Supplier();
        }
        private void ManageSupplier_Load(object sender, EventArgs e)
        {
            Supplier_GB.Visible = false;
            Add_Supp_Btn.Visible = false;
            Name_Txt_Box_Supplier.Enabled = false;
            Combo_Box_Fill();
            Data_Grid_Display();
        }
        private void Supp_Name_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Display_Data();
            Data_Grid_Display();
            Add_Supp_Btn.Visible = false;
            Add_Btn.Visible = true;
            Upd_S_Btn.Visible = true;
        }
        private void Supplier_Datagrid_View_MouseClick(object sender, MouseEventArgs e)
        {
            if (Supplier_Datagrid_View.SelectedRows.Count > 0)
            {
                string Name = (Supplier_Datagrid_View.SelectedRows[0].Cells[0].Value).ToString();
                Supp_Name_ComboBox.Text = Name;
            }
        }
        private void Go_To_Sup_Data_Btn_Click(object sender, EventArgs e)
        {
            Supplier_GB.Visible = true;
            if (Supp_Name_ComboBox.Text == "" || Supp_Name_ComboBox.Text == "All")
            {
                Name_Txt_Box_Supplier.Text = Mob_Num_Txt_Box_Supplier.Text = Work_Num_Txt_Box_Supplier.Text = Fax_Txt_Box_Supplier.Text = Email_Txt_Box_Supplier.Text = Website_Txt_Box_Supplier.Text = "";
            }
            else
            {
                Name_Txt_Box_Supplier.Text = Supp_Name_ComboBox.Text;
                Name_Txt_Box_Supplier.Enabled = false;
                Display_Data();
            }
        }
        private void Display_All_Supp_Btn_Click(object sender, EventArgs e)
        {
            Supp_Name_ComboBox.Text = "All";
        }
        //Function to Fill The Combo Box
        public void Combo_Box_Fill()
        {
            foreach (Supplier S in Ent.Suppliers)
            {
                Supp_Name_ComboBox.Items.Add(S.Name);
            }
            Supp_Name_ComboBox.Items.Add("All");
        }
        public void Display_Data()
        {
            if (Supp_Name_ComboBox.Text != "All")
            {
                string Name = Supp_Name_ComboBox.Text;
                Supplier S = Ent.Suppliers.Find(Name);
                Name_Txt_Box_Supplier.Text = S.Name;
                Mob_Num_Txt_Box_Supplier.Text = S.Call_Center;
                Work_Num_Txt_Box_Supplier.Text = S.Work_Number;
                Fax_Txt_Box_Supplier.Text = S.Fax;
                Email_Txt_Box_Supplier.Text = S.Email;
                Website_Txt_Box_Supplier.Text = S.Website;
            }
            else if (Supp_Name_ComboBox.Text == "" || Supp_Name_ComboBox.Text == "All")
            {
                Name_Txt_Box_Supplier.Text = Mob_Num_Txt_Box_Supplier.Text = Work_Num_Txt_Box_Supplier.Text = Fax_Txt_Box_Supplier.Text = Email_Txt_Box_Supplier.Text = Website_Txt_Box_Supplier.Text = "";
            }
        }
        public void Data_Grid_Display()
        {
            Supplier_Datagrid_View.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Teal;
            Supplier_Datagrid_View.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            if (Supp_Name_ComboBox.Text == "" || Supp_Name_ComboBox.Text == "All")
            {
                var Suppliers = Ent.Suppliers
                    .Select(S => new { S.Name, S.Work_Number, S.Email }).ToList();
                Supplier_Datagrid_View.DataSource = Suppliers;
            }
            else
            {
                string Name = Supp_Name_ComboBox.Text;
                var Suppliers = Ent.Suppliers
                    .Where(S => S.Name == Name)
                    .Select(S => new { S.Name, S.Work_Number, S.Email }).ToList();
                Supplier_Datagrid_View.DataSource = Suppliers;
            }
        }
        private void Add_Btn_Click(object sender, EventArgs e)
        {
            Name_Txt_Box_Supplier.Text = Mob_Num_Txt_Box_Supplier.Text = Work_Num_Txt_Box_Supplier.Text = Fax_Txt_Box_Supplier.Text = Email_Txt_Box_Supplier.Text = Website_Txt_Box_Supplier.Text = "";
            Upd_S_Btn.Visible = false;
            Add_Btn.Visible = false;
            Add_Supp_Btn.Visible = true;
            Name_Txt_Box_Supplier.Enabled = true;
        }
        private void Add_Supp_Btn_Click(object sender, EventArgs e)
        {
            if (Name_Txt_Box_Supplier.Text != "" && Mob_Num_Txt_Box_Supplier.Text != "" && Fax_Txt_Box_Supplier.Text != "" &&
                    Work_Num_Txt_Box_Supplier.Text != "" && Email_Txt_Box_Supplier.Text != "" && Website_Txt_Box_Supplier.Text != "")
            {
                Supplier S = Ent.Suppliers.Find(Name_Txt_Box_Supplier.Text);
                if (S == null)
                {
                    Supp.Name = Name_Txt_Box_Supplier.Text;
                    Supp.Call_Center = Mob_Num_Txt_Box_Supplier.Text;
                    Supp.Work_Number = Work_Num_Txt_Box_Supplier.Text;
                    Supp.Fax = Fax_Txt_Box_Supplier.Text;
                    Supp.Email = Email_Txt_Box_Supplier.Text;
                    Supp.Website = Website_Txt_Box_Supplier.Text;
                    Ent.Suppliers.Add(Supp);
                    Ent.SaveChanges();
                    Name_Txt_Box_Supplier.Text = Mob_Num_Txt_Box_Supplier.Text = Work_Num_Txt_Box_Supplier.Text = Fax_Txt_Box_Supplier.Text = Email_Txt_Box_Supplier.Text = Website_Txt_Box_Supplier.Text = "";
                    MessageBox.Show("Supplier Added Successfully");
                    Supp_Name_ComboBox.Items.Clear();
                    Combo_Box_Fill();
                    Data_Grid_Display();
                    Add_Btn.Visible = true;
                    Upd_S_Btn.Visible = true;
                    Add_Supp_Btn.Visible = false;
                    Name_Txt_Box_Supplier.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Supplier With The Same Name Already Exists.");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Required Data.");
            }
        }
        private void Upd_S_Btn_Click(object sender, EventArgs e)
        {
            if (Name_Txt_Box_Supplier.Text != "" && Mob_Num_Txt_Box_Supplier.Text != "" && Fax_Txt_Box_Supplier.Text != "" &&
                    Work_Num_Txt_Box_Supplier.Text != "" && Email_Txt_Box_Supplier.Text != "" && Website_Txt_Box_Supplier.Text != "")
            {
                Supplier S = Ent.Suppliers.Find(Supp_Name_ComboBox.Text);
                if (S != null)
                {
                    if (Name_Txt_Box_Supplier.Text != "" && Mob_Num_Txt_Box_Supplier.Text != "" && Fax_Txt_Box_Supplier.Text != "" &&
                        Work_Num_Txt_Box_Supplier.Text != "" && Email_Txt_Box_Supplier.Text != "" && Website_Txt_Box_Supplier.Text != "")
                    {
                        S.Call_Center = Mob_Num_Txt_Box_Supplier.Text;
                        S.Work_Number = Work_Num_Txt_Box_Supplier.Text;
                        S.Fax = Fax_Txt_Box_Supplier.Text;
                        S.Email = Email_Txt_Box_Supplier.Text;
                        S.Website = Website_Txt_Box_Supplier.Text;
                        Ent.SaveChanges();
                        Name_Txt_Box_Supplier.Text = Mob_Num_Txt_Box_Supplier.Text = Work_Num_Txt_Box_Supplier.Text = Fax_Txt_Box_Supplier.Text = Email_Txt_Box_Supplier.Text = Website_Txt_Box_Supplier.Text = "";
                        MessageBox.Show("Supplier Updated Successfully");
                        Data_Grid_Display();
                        Supp_Name_ComboBox.Text = "All";
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

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
    public partial class ManageWarehouse : Form
    {
        Inventory_Entity Ent;
        Warehouse WH;
        public ManageWarehouse()
        {
            InitializeComponent();
            Ent = new Inventory_Entity();
            WH = new Warehouse();
        }

        private void ManageWarehouse_Load(object sender, EventArgs e)
        {
            WH_GB.Visible = false;
            Add_WH_Btn.Visible = false;
            Name_Txt_Box_WH.Enabled = false;
            Combo_Box_Fill();
            Data_Grid_Display();
        }
        public void Combo_Box_Fill()
        {
            foreach (Warehouse W in Ent.Warehouses)
            {
                WH_Name_ComboBox.Items.Add(W.Name);
            }
            WH_Name_ComboBox.Items.Add("All");
        }
        private void Display_All_Btn_Click(object sender, EventArgs e)
        {
            WH_Name_ComboBox.Text = "All";
        }
        public void Display_Data()
        {
            if (WH_Name_ComboBox.Text != "All")
            {
                string Name = WH_Name_ComboBox.Text;
                Warehouse W = Ent.Warehouses.Find(Name);
                Name_Txt_Box_WH.Text = W.Name;
                Manager_Txt_Box_WH.Text = W.Manager;
                Address_Txt_Box_WH.Text = W.Address;
            }
            else if (WH_Name_ComboBox.Text == "" || WH_Name_ComboBox.Text == "All")
            {
                Name_Txt_Box_WH.Text = Manager_Txt_Box_WH.Text = Address_Txt_Box_WH.Text = "";
            }
        }
        public void Data_Grid_Display()
        {
            WH_Datagrid_View.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Teal;
            WH_Datagrid_View.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            if (WH_Name_ComboBox.Text == "" || WH_Name_ComboBox.Text == "All")
            {
                var WHs = Ent.Warehouses
                    .Select(W => new { W.Name, W.Manager, W.Address }).ToList();
                WH_Datagrid_View.DataSource = WHs;
            }
            else
            {
                string Name = WH_Name_ComboBox.Text;
                var WHs = Ent.Warehouses
                    .Where(W => W.Name == Name)
                    .Select(W => new { W.Name, W.Manager, W.Address }).ToList();
                WH_Datagrid_View.DataSource = WHs;
            }
        }

        private void Go_To_WH_Data_Btn_Click(object sender, EventArgs e)
        {
            WH_GB.Visible = true;
            if (WH_Name_ComboBox.Text == "" || WH_Name_ComboBox.Text == "All")
            {
                Name_Txt_Box_WH.Text = Manager_Txt_Box_WH.Text = Address_Txt_Box_WH.Text = "";
            }
            else
            {
                Name_Txt_Box_WH.Text = WH_Name_ComboBox.Text;
                Name_Txt_Box_WH.Enabled = false;
                Display_Data();
            }
        }

        private void WH_Name_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Display_Data();
            Data_Grid_Display();
            Add_WH_Btn.Visible = false;
            Add_Btn.Visible = true;
            Upd_WH_Btn.Visible = true;
        }

        private void Display_All_WH_Btn_Click(object sender, EventArgs e)
        {
            WH_Name_ComboBox.Text = "All";
        }

        private void WH_Datagrid_View_MouseClick(object sender, MouseEventArgs e)
        {
            if (WH_Datagrid_View.SelectedRows.Count > 0)
            {
                string Name = (WH_Datagrid_View.SelectedRows[0].Cells[0].Value).ToString();
                WH_Name_ComboBox.Text = Name;
            }
        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            Name_Txt_Box_WH.Text = Manager_Txt_Box_WH.Text = Address_Txt_Box_WH.Text = "";
            Upd_WH_Btn.Visible = false;
            Add_Btn.Visible = false;
            Add_WH_Btn.Visible = true;
            Name_Txt_Box_WH.Enabled = true;
        }

        private void Add_WH_Btn_Click(object sender, EventArgs e)
        {
            if (Name_Txt_Box_WH.Text != "" && Manager_Txt_Box_WH.Text != "" && Address_Txt_Box_WH.Text != "")
            {
                Warehouse W = Ent.Warehouses.Find(Name_Txt_Box_WH.Text);
                if (W == null)
                {
                    WH.Name = Name_Txt_Box_WH.Text;
                    WH.Manager = Manager_Txt_Box_WH.Text;
                    WH.Address = Address_Txt_Box_WH.Text;
                    Ent.Warehouses.Add(WH);
                    Ent.SaveChanges();
                    Name_Txt_Box_WH.Text = Manager_Txt_Box_WH.Text = Address_Txt_Box_WH.Text = "";
                    MessageBox.Show("Warehouse Added Successfully");
                    WH_Name_ComboBox.Items.Clear();
                    Combo_Box_Fill();
                    Data_Grid_Display();
                    Add_Btn.Visible = true;
                    Upd_WH_Btn.Visible = true;
                    Add_WH_Btn.Visible = false;
                    Name_Txt_Box_WH.Enabled = false;
                    WH_Name_ComboBox.Text = "All";
                }
                else
                {
                    MessageBox.Show("Warehouse With The Same Name Already Exists.");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Required Data.");
            }
        }

        private void Upd_WH_Btn_Click(object sender, EventArgs e)
        {
            if (Name_Txt_Box_WH.Text != "" && Manager_Txt_Box_WH.Text != "" && Address_Txt_Box_WH.Text != "")
            {
                Warehouse W = Ent.Warehouses.Find(WH_Name_ComboBox.Text);
                if (W != null)
                {
                    if (Name_Txt_Box_WH.Text != "" && Manager_Txt_Box_WH.Text != "" && Address_Txt_Box_WH.Text != "")
                    {
                        W.Manager = Manager_Txt_Box_WH.Text;
                        W.Address = Address_Txt_Box_WH.Text;
                        Ent.SaveChanges();
                        Name_Txt_Box_WH.Text = Manager_Txt_Box_WH.Text = Address_Txt_Box_WH.Text = "";
                        MessageBox.Show("Warehouse Updated Successfully");
                        Data_Grid_Display();
                        WH_Name_ComboBox.Text = "All";
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Required Data.");
                    }
                }
            }
            else
            {
                MessageBox.Show("No Warehouse is Selected");
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

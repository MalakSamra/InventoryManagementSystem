using Guna.UI.WinForms;
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
    public partial class ManageClients : Form
    {
        Inventory_Entity Ent;
        Client Cust;
        public ManageClients()
        {
            InitializeComponent();
            Ent = new Inventory_Entity();
            Cust = new Client();
        }
        private void User_Application_Load(object sender, EventArgs e)
        { 
            Client_GB.Visible = false;
            Add_Client_Btn.Visible = false;
            ID_Txt_Box.Enabled = false;
            Combo_Box_Fill();
            Data_Grid_Display();
        }
        //Function to Fill The Combo Box
        public void Combo_Box_Fill()
        {
            foreach(Client C in Ent.Clients)
            {
                comboBox1.Items.Add(C.ID);
            }
            comboBox1.Items.Add("All");
        }
        private void Go_To_Data_Btn_Click(object sender, EventArgs e)
        {
            Client_GB.Visible = true;
            if(comboBox1.Text == "" || comboBox1.Text == "All")
            {
                ID_Txt_Box.Text = Name_Txt_Box.Text = Mob_Num_Txt_Box.Text = Work_Num_Txt_Box.Text = Fax_Txt_Box.Text = Email_Txt_Box.Text = Website_Txt_Box.Text = "";
            }
            else
            {
                ID_Txt_Box.Text = comboBox1.Text;
                ID_Txt_Box.Enabled = false;
                Display_Data();
            }
        }
        private void Display_All_Btn_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "All";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Display_Data();
            Data_Grid_Display();
            Add_Client_Btn.Visible = false;
            Add_Btn.Visible = true;
            Upd_C_Btn.Visible = true;
        }
        public void Display_Data()
        {
            if(comboBox1.Text != "All")
            {
                int ID = int.Parse(comboBox1.Text);
                Client C = Ent.Clients.Find(ID);
                ID_Txt_Box.Text = C.ID.ToString();
                Name_Txt_Box.Text = C.Name;
                Mob_Num_Txt_Box.Text = C.Mobile_Number.ToString();
                Work_Num_Txt_Box.Text = C.Work_Number.ToString();
                Fax_Txt_Box.Text = C.Fax.ToString();
                Email_Txt_Box.Text = C.Email;
                Website_Txt_Box.Text = C.Website;
            }
            else if (comboBox1.Text == "" || comboBox1.Text == "All")
            {
                ID_Txt_Box.Text = Name_Txt_Box.Text = Mob_Num_Txt_Box.Text = Work_Num_Txt_Box.Text = Fax_Txt_Box.Text = Email_Txt_Box.Text = Website_Txt_Box.Text = "";
            }
        }
        public void Data_Grid_Display()
        {
            Client_Datagrid_View.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Teal;
            Client_Datagrid_View.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            if (comboBox1.Text == "" || comboBox1.Text == "All")
            {
                var Clients = Ent.Clients
                    .Select(C => new { C.ID, C.Name, C.Mobile_Number }).ToList();
                Client_Datagrid_View.DataSource = Clients;
            }
            else
            {
                int ID = int.Parse(comboBox1.Text);
                var Clients = Ent.Clients
                    .Where(C => C.ID == ID)
                    .Select(C => new { C.ID, C.Name, C.Mobile_Number }).ToList();
                Client_Datagrid_View.DataSource = Clients;
            }
        }
        private void Client_Datagrid_View_MouseClick(object sender, MouseEventArgs e)
        {
            if (Client_Datagrid_View.SelectedRows.Count > 0)
            {
                string ID = (Client_Datagrid_View.SelectedRows[0].Cells[0].Value).ToString();
                comboBox1.Text = ID;
            }
        }
        private void Add_Btn_Click(object sender, EventArgs e)
        {
            ID_Txt_Box.Text = Name_Txt_Box.Text = Mob_Num_Txt_Box.Text = Work_Num_Txt_Box.Text = Fax_Txt_Box.Text = Email_Txt_Box.Text = Website_Txt_Box.Text = "";
            Upd_C_Btn.Visible = false;
            Add_Btn.Visible = false;
            Add_Client_Btn.Visible = true;
            ID_Txt_Box.Enabled = true;
        }
        private void Add_Client_Btn_Click(object sender, EventArgs e)
        {
            if (ID_Txt_Box.Text != "" && Name_Txt_Box.Text != "" && Mob_Num_Txt_Box.Text != "" &&
                    Work_Num_Txt_Box.Text != "" && Fax_Txt_Box.Text != "" && Email_Txt_Box.Text != "" && Website_Txt_Box.Text != "")
            {
                Client C = Ent.Clients.Find(int.Parse(ID_Txt_Box.Text));
                if (C == null)
                {
                    Cust.ID = int.Parse(ID_Txt_Box.Text);
                    Cust.Name = Name_Txt_Box.Text;
                    Cust.Mobile_Number = int.Parse(Mob_Num_Txt_Box.Text);
                    Cust.Work_Number = int.Parse(Work_Num_Txt_Box.Text);
                    Cust.Fax = int.Parse(Fax_Txt_Box.Text);
                    Cust.Email = Email_Txt_Box.Text;
                    Cust.Website = Website_Txt_Box.Text;
                    Ent.Clients.Add(Cust);
                    Ent.SaveChanges();
                    ID_Txt_Box.Text = Name_Txt_Box.Text = Mob_Num_Txt_Box.Text = Work_Num_Txt_Box.Text = Fax_Txt_Box.Text = Email_Txt_Box.Text = Website_Txt_Box.Text = "";
                    MessageBox.Show("Client Added Successfully");
                    comboBox1.Items.Clear();
                    Combo_Box_Fill();
                    Data_Grid_Display();
                    Add_Btn.Visible = true;
                    Upd_C_Btn.Visible = true;
                    Add_Client_Btn.Visible = false;
                    ID_Txt_Box.Enabled = false;
                    comboBox1.Text = "All";
                }
                else
                {
                    MessageBox.Show("Client With The Same ID Already Exists.");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Required Data.");
            }
        }
        private void Upd_C_Btn_Click(object sender, EventArgs e)
        {
            if (ID_Txt_Box.Text != "" && Name_Txt_Box.Text != "" && Mob_Num_Txt_Box.Text != "" && Work_Num_Txt_Box.Text != "" &&
                    Fax_Txt_Box.Text != "" && Email_Txt_Box.Text != "" && Website_Txt_Box.Text != "")
            {
                Client C = Ent.Clients.Find(int.Parse(comboBox1.Text));
                if (C != null)
                {
                    if (ID_Txt_Box.Text != "" && Name_Txt_Box.Text != "" && Mob_Num_Txt_Box.Text != "" && Work_Num_Txt_Box.Text != "" &&
                        Fax_Txt_Box.Text != "" && Email_Txt_Box.Text != "" && Website_Txt_Box.Text != "")
                    {
                        C.Name = Name_Txt_Box.Text;
                        C.Mobile_Number = int.Parse(Mob_Num_Txt_Box.Text);
                        C.Work_Number = int.Parse(Work_Num_Txt_Box.Text);
                        C.Fax = int.Parse(Fax_Txt_Box.Text);
                        C.Email = Email_Txt_Box.Text;
                        C.Website = Website_Txt_Box.Text;
                        Ent.SaveChanges();
                        Name_Txt_Box.Text = Mob_Num_Txt_Box.Text = Work_Num_Txt_Box.Text = Fax_Txt_Box.Text = Email_Txt_Box.Text = Website_Txt_Box.Text = "";
                        MessageBox.Show("Client Updated Successfully");
                        Data_Grid_Display();
                        comboBox1.Text = "All";
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

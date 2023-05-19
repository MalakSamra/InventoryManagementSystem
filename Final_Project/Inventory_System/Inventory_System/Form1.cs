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
    public partial class Form1 : Form
    {
        Inventory_Entity Ent;
        User Usr;
        public Form1()
        {
            InitializeComponent();
            Pass_Txt_Box.PasswordChar = '*';
            Ent= new Inventory_Entity();
            Usr = new User();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                Pass_Txt_Box.PasswordChar = '*';
            }
            else
            {
                Pass_Txt_Box.PasswordChar = '\0';
            }
        }

        private void Sign_In_Btn_Click(object sender, EventArgs e)
        {
            string UserName = UserName_Txt_Box.Text;
            string Password = Pass_Txt_Box.Text;
            var user = (from s in Ent.Users
                       where s.User_Name.Trim() == UserName
                       select s).FirstOrDefault();
            if (user != null)
            {
                if (user.Password.Trim() == Password)
                {
                    Home_Form HM = new Home_Form();
                    HM.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect Password.");
                }
            }
            else
            {
                MessageBox.Show("Incorrect UserName.");
            }
        }
    }
}

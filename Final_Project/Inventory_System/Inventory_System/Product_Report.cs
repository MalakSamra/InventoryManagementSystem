using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Inventory_System
{
    public partial class Product_Report : Form
    {
        Inventory_Entity Ent;
        public Product_Report()
        {
            InitializeComponent();
            Ent = new Inventory_Entity();
        }

        private void Product_Report_Load(object sender, EventArgs e)
        {
            Combo_Box_Fill();
            Prod_Datagrid_View.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Teal;
            Prod_Datagrid_View.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
        }
        public void Combo_Box_Fill()
        {
            foreach (Product P in Ent.Products)
            {
                Prod_code_ComboBox.Items.Add(P.Code);
            }
        }

        private void Prod_code_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int code = int.Parse(Prod_code_ComboBox.Text);
            Product P = Ent.Products.Find(code);
            if (P != null)
            {
                Prod_Name_Txt_Box.Text = P.Name;
            }
            else
            {
                Prod_Name_Txt_Box.Text = "";
            }
            var WHS = from W in Ent.WH_Prod
                      where W.Product_Code == code
                      select W;
            flowLayoutPanel1.Controls.Clear();
            foreach (WH_Prod w in WHS)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Text = w.WH_Name;
                checkBox.ForeColor = Color.DarkSlateGray;
                checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14);
                flowLayoutPanel1.Controls.Add(checkBox);
            }
        }

        private void Exit_Btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Go_To_Prod_Data_Btn_Click(object sender, EventArgs e)
        {
            List<string> Selected_WH = new List<string>();
            foreach (CheckBox C in flowLayoutPanel1.Controls.OfType<CheckBox>())
            {
                if (C.Checked)
                {
                    Selected_WH.Add(C.Text);
                }
            }
            int Selected_Code = int.Parse(Prod_code_ComboBox.Text);
            var Products = from r in Ent.Requests
                           join w in Ent.Warehouses on r.WH_Name equals w.Name
                           join p in Ent.Products on r.Product_Code equals p.Code
                           where Selected_WH.Contains(w.Name) && p.Code == Selected_Code
                                 && r.Date >= From_DatetimePicker.Value.Date &&
                                    r.Date <= To_DatetimePicker.Value.Date
                           select new
                           {
                               Code = p.Code,
                               Name = p.Name,
                               WH = w.Name,
                               Prod_Supplier = r.Supplier_Name,
                               Quantity = r.Quantity
                           };


            Prod_Datagrid_View.DataSource = Products.ToList();
        }
        private void ExportToPdf(DataGridView DGV, string FilePath, string Report_Tilte)
        {
            Document Doc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
            try
            {
                PdfWriter.GetInstance(Doc, new FileStream(FilePath, FileMode.Create));
                Doc.Open();
                iTextSharp.text.Font Title_Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.UNDEFINED, 20, iTextSharp.text.Font.BOLD, BaseColor.GRAY);
                Paragraph Title = new Paragraph(Report_Tilte, Title_Font);
                Title.Alignment = Element.ALIGN_CENTER;
                Title.SpacingAfter = 25f;
                Doc.Add(Title);
                PdfPTable Table = new PdfPTable(DGV.ColumnCount);
                foreach (DataGridViewColumn Col in DGV.Columns)
                {
                    PdfPCell Cell = new PdfPCell(new Phrase(Col.HeaderText));
                    Cell.BackgroundColor = new BaseColor(DGV.ColumnHeadersDefaultCellStyle.BackColor);
                    Cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    Cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                    Table.AddCell(Cell);
                }
                foreach (DataGridViewRow Row in DGV.Rows)
                {
                    foreach (DataGridViewCell Cell in Row.Cells)
                    {
                        Table.AddCell(Cell.Value.ToString());
                    }
                }
                Doc.Add(Table);
            }
            catch
            {

            }
            finally
            {
                Doc.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FilePath = "D:\\ITI\\Programming Data\\Entity_Final_Project\\Prod_Report.pdf";
            string Report_Title = $"{Prod_code_ComboBox.Text.Trim()}: {Prod_Name_Txt_Box.Text.Trim()} Product Report";
            ExportToPdf(Prod_Datagrid_View, FilePath, Report_Title);
            Process.Start(FilePath);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ManageReports MR = new ManageReports();
            MR.Show();
            this.Hide();
        }
    }
}

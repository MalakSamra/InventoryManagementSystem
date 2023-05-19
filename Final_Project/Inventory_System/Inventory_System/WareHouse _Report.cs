using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Inventory_System
{
    public partial class WareHouse__Report : Form
    {
        Inventory_Entity Ent;
        public WareHouse__Report()
        {
            InitializeComponent();
            Ent = new Inventory_Entity();
        }

        private void WareHouse__Report_Load(object sender, EventArgs e)
        {
            Combo_Box_Fill();
            WH_Datagrid_View.Visible = false;
            WH_Datagrid_View.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Teal;
            WH_Datagrid_View.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
        }
        public void Combo_Box_Fill()
        {
            foreach (Warehouse W in Ent.Warehouses)
            {
                WH_Name_ComboBox.Items.Add(W.Name);
            }
            WH_Name_ComboBox.Items.Add("All");
        }

        private void Go_To_Prod_Data_Btn_Click(object sender, EventArgs e)
        {
            if(WH_Name_ComboBox.Text == "All")
            {
                MessageBox.Show("Please Choose a Specific Warehouse");
            }
            else
            {
                WH_Datagrid_View.Visible = true;
                var Data = from r in Ent.Requests
                           join w in Ent.Warehouses on r.WH_Name equals w.Name
                           join p in Ent.Products on r.Product_Code equals p.Code
                           where w.Name == WH_Name_ComboBox.Text &&
                                r.Date >= From_DatetimePicker.Value.Date &&
                                r.Date <= To_DatetimePicker.Value.Date
                           select new
                           {
                               Warehouse_Name = w.Name,
                               Manager = w.Manager,
                               Address = w.Address,
                               Product_Name = p.Name,
                               Request_Date = r.Date,
                               Quantity = r.Quantity
                           };
                WH_Datagrid_View.DataSource = Data.ToList();
            }
        }

        private void Exit_Btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FilePath = "D:\\ITI\\Programming Data\\Entity_Final_Project\\WH_Report.pdf";
            string Report_Title = $"{WH_Name_ComboBox.Text.Trim()} Warehouse Report";
            ExportToPdf(WH_Datagrid_View, FilePath, Report_Title);
            Process.Start(FilePath);
        }
        private void ExportToPdf (DataGridView DGV, string FilePath, string Report_Tilte)
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
                    Cell.BackgroundColor = new BaseColor (DGV.ColumnHeadersDefaultCellStyle.BackColor);
                    Cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    Cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                    Table.AddCell(Cell);
                }
                foreach (DataGridViewRow Row in DGV.Rows)
                {
                    foreach(DataGridViewCell Cell in Row.Cells)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ManageReports MR = new ManageReports();
            MR.Show();
            this.Hide();
        }
    }
}

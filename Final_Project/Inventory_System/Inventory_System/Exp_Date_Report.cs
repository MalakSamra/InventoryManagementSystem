using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.SqlServer;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Inventory_System
{
    public partial class Exp_Date_Report : Form
    {
        Inventory_Entity Ent;
        public Exp_Date_Report()
        {
            InitializeComponent();
            Ent = new Inventory_Entity();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ManageReports MR = new ManageReports();
            MR.Show();
            this.Hide();
        }

        private void Exit_Btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Go_To_Prod_Data_Btn_Click(object sender, EventArgs e)
        {
            DateTime Today = DateTime.Now;
            string input = textBox1.Text.Trim();
            if (int.TryParse(input, out int months))
            {
                DateTime Exp = DateTime.Now.AddMonths(months);
                var Data = from r in Ent.Requests
                           join p in Ent.Products on r.Product_Code equals p.Code
                           let Expiry = DbFunctions.AddMonths(r.Production_Date, p.Validity_Period)
                           where  Expiry < DbFunctions.AddMonths(Today, months)
                           select new
                           {
                               Product_Code = p.Code,
                               Product_Name = p.Name,
                               WH = r.WH_Name,
                               Production_Date = r.Production_Date,
                               Validtity_Period = r.Validity_Period,
                               Exp_Date = Expiry
                           };
                Rec_Datagrid_View.DataSource = Data.ToList();
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid number of months.");
            }
        }

        private void Exp_Date_Report_Load(object sender, EventArgs e)
        {
            Rec_Datagrid_View.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Teal;
            Rec_Datagrid_View.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
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
            string FilePath = "D:\\ITI\\Programming Data\\Entity_Final_Project\\Exp_Date_Report.pdf";
            string Report_Title = $"Products that will be expired in {textBox1.Text} months";
            ExportToPdf(Rec_Datagrid_View, FilePath, Report_Title);
            Process.Start(FilePath);
        }
    }
}

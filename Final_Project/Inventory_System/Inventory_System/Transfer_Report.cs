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
    public partial class Transfer_Report : Form
    {
        Inventory_Entity Ent;
        public Transfer_Report()
        {
            InitializeComponent();
            Ent = new Inventory_Entity();
        }

        private void Transfer_Report_Load(object sender, EventArgs e)
        {
            var WHS = from W in Ent.Warehouses
                      select W;
            foreach(Warehouse w in WHS)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Text = w.Name;
                checkBox.ForeColor = Color.DarkSlateGray;
                checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14);
                flowLayoutPanel1.Controls.Add(checkBox);
            }
            Records_Datagrid_View.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Teal;
            Records_Datagrid_View.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
        }

        private void Exit_Btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ManageReports MR = new ManageReports();
            MR.Show();
            this.Hide();
        }

        private void Go_To_Prod_Data_Btn_Click(object sender, EventArgs e)
        {
            List<string> Selected_WH = new List<string>();
            foreach(CheckBox C in flowLayoutPanel1.Controls.OfType<CheckBox>())
            {
                if (C.Checked)
                {
                    Selected_WH.Add(C.Text);
                }
            }
            var Data = from t in Ent.Transfer_History
                       where (Selected_WH.Contains(t.From_WH) || Selected_WH.Contains(t.To_WH)) &&
                       t.Transaction_Date >= From_DatetimePicker.Value.Date &&
                       t.Transaction_Date <= To_DatetimePicker.Value.Date
                       select new
                       {
                           Product_Code = t.Product_Code,
                           Product_Name = t.Product_Name,
                           Quantity = t.Quantity,
                           From_WH = t.From_WH,
                           To_WH = t.To_WH,
                           Transaction_Date = t.Transaction_Date
                       };
            Records_Datagrid_View.DataSource = Data.ToList();
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
            string FilePath = "D:\\ITI\\Programming Data\\Entity_Final_Project\\Transfer_Report.pdf";
            string Report_Title = $"Transfer Record ";
            ExportToPdf(Records_Datagrid_View, FilePath, Report_Title);
            Process.Start(FilePath);
        }
    }
}

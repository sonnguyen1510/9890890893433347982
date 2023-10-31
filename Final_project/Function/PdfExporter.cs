using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows.Forms;

namespace Bán_Hàng_Onl_WinForm.Function
{
    public class PdfExporter
    {
        public static void ExportDataTableToPdf(DataTable dataTable)
        {
            // Create an Input Dialog to get the desired file name
            string suggestedFileName = "Inventory.pdf"; // Default file name
            string userEnteredFileName = PromptForFileName(suggestedFileName);

            if (userEnteredFileName != null)
            {
                Document document = new Document(PageSize.A4);
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(userEnteredFileName, FileMode.Create));

                document.Open();


                // Create a title
                Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 24, BaseColor.BLACK);
                Paragraph title = new Paragraph("Inventory Report", titleFont);
                title.Alignment = Element.ALIGN_CENTER;
                title.SpacingAfter = 20f;

                document.Add(title);

                // Create a table for the inventory data
                PdfPTable inventoryTable = new PdfPTable(dataTable.Columns.Count);
                 // Adjust column widths as needed

                // Table headers
                Font headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12, BaseColor.WHITE);
                PdfPCell headerCell;

                foreach (DataColumn column in dataTable.Columns)
                {
                    headerCell = new PdfPCell(new Phrase(column.ColumnName, headerFont));
                    headerCell.BackgroundColor = BaseColor.DARK_GRAY;
                    headerCell.HorizontalAlignment = Element.ALIGN_CENTER;
                    headerCell.VerticalAlignment = Element.ALIGN_CENTER;
                    headerCell.FixedHeight = 20f; // Fixed row height
                    
                
                    inventoryTable.AddCell(headerCell);
                }

                Font dataFont = FontFactory.GetFont(FontFactory.HELVETICA, 10, BaseColor.BLACK);
                PdfPCell dataCell;

                foreach (DataRow row in dataTable.Rows)
                {
                    foreach (object item in row.ItemArray)
                    {
                        dataCell = new PdfPCell(new Phrase(item.ToString(), dataFont));
                        dataCell.HorizontalAlignment = Element.ALIGN_CENTER;
                        dataCell.FixedHeight = 30f;
                        dataCell.VerticalAlignment = Element.ALIGN_CENTER;
                        inventoryTable.AddCell(dataCell);
                    }
                }

                document.Add(inventoryTable);

                document.Close();

                MessageBox.Show("DataTable exported to PDF successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private static string PromptForFileName(string suggestedFileName)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files|*.pdf";
            saveFileDialog.Title = "Save PDF File";
            saveFileDialog.FileName = suggestedFileName;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                return saveFileDialog.FileName;
            }

            return null; // Return null if the user cancels the save dialog
        }
    }
}

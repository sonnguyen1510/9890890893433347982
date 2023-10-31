using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bán_Hàng_Onl_WinForm.Function
{
    internal class ExcelExporter
    {
        public void XP(DataGridView GV)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.InitialDirectory = "C:";
            saveFileDialog1.Filter = "Execl file (*.xlsx)|*.xlsx | Excel 2007 (*.xls) | *.xls ";
            saveFileDialog1.FileName = "";
            saveFileDialog1.Title = "Xuất file thống kê";
            //saveFileDialog1.FilterIndex = 1;
            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                ExcelApp.Application.Workbooks.Add(Type.Missing);

                ExcelApp.Columns.ColumnWidth = 15;

                for (int i = 1; i < GV.Columns.Count + 1; i++)
                {
                    ExcelApp.Cells[1, i] = GV.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < GV.Rows.Count; i++)
                {
                    for (int j = 0; j < GV.Columns.Count; j++)
                    {
                        ExcelApp.Cells[i + 2, j + 1] = GV.Rows[i].Cells[j].Value.ToString();
                    }
                }

                ExcelApp.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName.ToString());
                ExcelApp.ActiveWorkbook.Saved = true;
                ExcelApp.Quit();
            }
        }
    }
}

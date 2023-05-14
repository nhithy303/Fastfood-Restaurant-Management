using DAL;
using Excel = Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ExcelBLL
    {
        ExcelDAL excel_dal = new ExcelDAL();

        public bool Import(string filepath, string tablename)
        {
            return excel_dal.Import(filepath, tablename);
        }

        public DataTable ReadToDataTable(string filepath)
        {
            return excel_dal.ReadToDataTable(filepath);
        }

        public bool Export(DataTable table, string filepath)
        {
            try
            {
                Excel.Application app = new Excel.Application();
                app.Application.Workbooks.Add(Type.Missing);
                for (int i = 0; i < table.Columns.Count; i++)
                {
                    app.Cells[1, i + 1] = table.Columns[i].ColumnName;
                }
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    for (int j = 0; j < table.Columns.Count; j++)
                    {
                        app.Cells[i + 2, j + 1] = table.Rows[i][j];
                    }
                }
                app.Columns.AutoFit();
                app.ActiveWorkbook.SaveCopyAs(filepath);
                app.ActiveWorkbook.Saved = true;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

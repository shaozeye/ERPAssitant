using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using NPOI;
using NPOI.HSSF.UserModel;
using NPOI.OpenXmlFormats.Wordprocessing;
using NPOI.POIFS.FileSystem;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace ERPAssitant.Service
{
    public static class NPOIService
    {
        static NPOIService()
        {

        }
        public static DataTable ExcelToDataTable(string ExcelPath)
        {
            DataTable table = new DataTable();
            IWorkbook workbook = null;
            string extension = Path.GetExtension(ExcelPath).ToLower();
            FileStream fs = new FileStream(ExcelPath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            if (extension==".xls")
            {

                workbook = new HSSFWorkbook(fs);
            }
            else if (extension==".xlsx")
            {
                workbook = new XSSFWorkbook(fs);
            }
            else
            {
                MessageBox.Show("Not the correct excel file");
            }
            fs.Close();
            ISheet sheet = workbook.GetSheetAt(0);
              
            return table;

        }
        public static bool DataTableToExcel(DataTable table)
        {
            return false;
        }
    }
}

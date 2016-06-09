using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraSpreadsheet;
using DevExpress.Spreadsheet;

namespace ProjectQuanLyDangVien.Libs
{
    /// <summary>
    /// Hỗ trợ đọc file Excel chuyển thành DataTable
    /// </summary>
    public class ExcelDataBaseHelper
    {
        public static object OpenFile(string fileName, string sheetName)
        {
            try
            {
                var fullFileName = fileName;
                
                if (!File.Exists(fullFileName))
                {
                    System.Windows.Forms.MessageBox.Show("File not found");
                    return null;
                }
                var connectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0; data source={0}; Extended Properties=Excel 8.0;", fullFileName);
                var adapter = new OleDbDataAdapter(String.Format("select * from [{0}$]", sheetName), connectionString);
                var ds = new DataSet();
                string tableName = "excelData";
                adapter.Fill(ds, tableName);
                DataTable data = ds.Tables[tableName];
                return data;
            }catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                return null;
            }
        }

        public static string CreateTempFile_MemberList(SpreadsheetControl spreadSheet)
        {
            IWorkbook workbook = spreadSheet.Document;
            string tempPath = "Temp\\temp.xls";
            using (FileStream stream = new FileStream(tempPath, FileMode.Create, FileAccess.ReadWrite))
            {
                workbook.SaveDocument(stream, DocumentFormat.Xls);
            }
            return tempPath;
        }
    }
}

using System;

namespace CrownUITest.Utilities
{
    public class WriteToExcelFile
    {
        //public static void WriteToExcelFiles(string fpath, string fname, string resutlToWrite, int cellrow, int cellcolumn)
        //{
        //    string myPath = @fpath + @"\" + fname;
        //    Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
        //    Microsoft.Office.Interop.Excel.Workbook workbook = excelApp.Workbooks.Open(myPath);
        //    System.Threading.Thread.Sleep(2000);
        //    excelApp.Cells[cellrow, cellcolumn] = resutlToWrite;
        //    excelApp.Visible = false;
        //    excelApp.ActiveWorkbook.Save();
        //    System.Threading.Thread.Sleep(2000);
        //    workbook.Close(false, Type.Missing, Type.Missing);
        //    excelApp.Workbooks.Close();
        //    System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
        //    excelApp.Quit();
        //    GC.Collect();
        //    System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
        //}
    }
}

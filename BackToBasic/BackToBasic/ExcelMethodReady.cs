using System;
using System.Configuration;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Data.OleDb;
using System.IO;
using WindowsInput;
using WGSHelper;
using CommonLibrary;
namespace BackToBasic
{
    public class ExcelMethodReady
    {
        Excel.Application xlApp;
        Excel.Workbook xlWorkBook;
        Excel.Worksheet xlWorkSheet;
        Excel.Range range;
        static string ExcelFilePath = @"C:\Users\vincent.lee.c.flores\Desktop\test\test.xlsx";






        private static void rowNum(WindowsInput.Native.VirtualKeyCode x)
        {
            var simulator = new InputSimulator();

            simulator.Keyboard.TextEntry('a');
            simulator.Keyboard.KeyPress(x);
            simulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.TAB);

            simulator.Keyboard.TextEntry('b');
            simulator.Keyboard.KeyPress(x);
            simulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.TAB);

            simulator.Keyboard.TextEntry('c');
            simulator.Keyboard.KeyPress(x);
            simulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.TAB);

            simulator.Keyboard.TextEntry('d');
            simulator.Keyboard.KeyPress(x);
            simulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.TAB);

            simulator.Keyboard.TextEntry('e');
            simulator.Keyboard.KeyPress(x);
            simulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.TAB);

            simulator.Keyboard.TextEntry('f');
            simulator.Keyboard.KeyPress(x);
            simulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.TAB);

            simulator.Keyboard.TextEntry('g');
            simulator.Keyboard.KeyPress(x);
            simulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.TAB);

            //simulator.Keyboard.TextEntry('h');
            //simulator.Keyboard.KeyPress(x);
            //simulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.TAB);

            //simulator.Keyboard.TextEntry('i');
            //simulator.Keyboard.KeyPress(x);
            //simulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.TAB);

            //simulator.Keyboard.TextEntry('j');
            //simulator.Keyboard.KeyPress(x);
            //simulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.TAB);
            
        }

        private static void rowNum(string x)
        {
            var simulator = new InputSimulator();

            simulator.Keyboard.TextEntry("a" + x);
            simulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.TAB);

            simulator.Keyboard.TextEntry("b" + x);
            simulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.TAB);

            simulator.Keyboard.TextEntry("c" + x);
            simulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.TAB);

            simulator.Keyboard.TextEntry("d" + x);
            simulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.TAB);

            simulator.Keyboard.TextEntry("e" + x);
            simulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.TAB);

            simulator.Keyboard.TextEntry("f" + x);
            simulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.TAB);

            simulator.Keyboard.TextEntry("g" + x);
            simulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.TAB);

            //simulator.Keyboard.TextEntry("h" + x);
            //simulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.TAB);

            //simulator.Keyboard.TextEntry("i" + x);
            //simulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.TAB);

            //simulator.Keyboard.TextEntry("j" + x);
            //simulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.TAB);
            
        }

        
        public static void Main()
        {
 
            ExcelMethodReady x = new ExcelMethodReady();
            x.GetExcelData();

 
            MainframeHelper xxxx = new MainframeHelper();
            xxxx.GetScreenHelper(@"C:\Users\vincent.lee.c.flores\Downloads\Installer\Docu Installer\EDP\WGS.edp");
            xxxx.Sendkeys(StringEnum.GetStringValue(CommonEnum.keys.F3));
            xxxx.Sendkeys("<PF3>");

 
            System.Threading.Thread.Sleep(5000);
            #region PopulateTempalte


            rowNum(WindowsInput.Native.VirtualKeyCode.NUMPAD1);
            rowNum(WindowsInput.Native.VirtualKeyCode.NUMPAD2);
            rowNum(WindowsInput.Native.VirtualKeyCode.NUMPAD3);
            rowNum(WindowsInput.Native.VirtualKeyCode.NUMPAD4);
            rowNum(WindowsInput.Native.VirtualKeyCode.NUMPAD5);
            rowNum(WindowsInput.Native.VirtualKeyCode.NUMPAD6);
            rowNum(WindowsInput.Native.VirtualKeyCode.NUMPAD7);
            rowNum(WindowsInput.Native.VirtualKeyCode.NUMPAD8);
            rowNum(WindowsInput.Native.VirtualKeyCode.NUMPAD9);
            rowNum("10");
            rowNum("11");
            rowNum("12");






            
            #endregion
 
        }

        public void GetExcelData()
        {

            //string dcn;
            //string unit;
            //int rCnt;
            //int rw = 0;
            //int cl = 0;


            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(ExcelFilePath, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

          

            DataTable dtSourceFile = new DataTable();
            dtSourceFile.Columns.Add("col1", typeof(string));
            dtSourceFile.Columns.Add("col2", typeof(string));
            dtSourceFile.Columns.Add("col3", typeof(string));





            //range = xlWorkSheet.UsedRange;
            range = xlWorkSheet.get_Range("A1", Missing.Value);
            range = range.get_End(Excel.XlDirection.xlToRight);
            range = range.get_End(Excel.XlDirection.xlDown);
            //string downAddress = range.get_Address(false, false, Excel.XlReferenceStyle.xlA1,Type.Missing, Type.Missing);
            Excel.Range last = xlWorkSheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell, Type.Missing);
            range = xlWorkSheet.get_Range("A1", last);
            


            //range = xlWorkSheet.get_Range("A1", "C100165");
            object[,] values = (object[,])range.Value2;
            int NumRow = 1;
            //int NumCols = 3;
                 
            
 
            while (NumRow < values.GetLength(0))
            {
                //for (int i = 1; i < NumCols; i++)
                //{

                //}
                string v1 = Convert.ToString(values[NumRow, 1]);
                string v2 = Convert.ToString(values[NumRow, 2]);
                string v3 = Convert.ToString(values[NumRow, 3]);
                dtSourceFile.Rows.Add(v1, v2, v3);

                xlWorkSheet.Cells[NumRow, 5] = v1;
                NumRow++;
            }

            xlApp.Visible = true;
            //xlWorkBook.Save();

            //range = null;
            //xlWorkSheet = null;
            //if(xlWorkBook != null)
            //    xlWorkBook.Close(true, Missing.Value, Missing.Value);
            //xlWorkBook = null;
            //if(xlApp !=null)
            //    xlApp.Quit();
            //xlApp = null;


            //Marshal.ReleaseComObject(xlWorkSheet);
            //Marshal.ReleaseComObject(xlWorkBook);
            //Marshal.ReleaseComObject(xlApp);

        }
    }
}

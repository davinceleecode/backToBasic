using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace BackToBasic
{
    public class DefaultMessage
    {


    }

    public class RandomNumberGenerator : DefaultMessage
    {





        public static void Main(string[] args)
        {













            ReadExistingExcel();

            //Enumerable.Range(0, 100).OrderBy(x => Guid.NewGuid()).Take(20);

            //Enumerable.Range(0,100).OrderBy(x => random.Next()).Take(20);


            //List<string> b = new List<string>();
            //for (int i = 0; i < 999999; i++)
            //{
            //    var s = i.ToString().PadLeft(6, '0');
            //    b.Add(s);
            //    Console.WriteLine(s);
            //}

            //Console.ReadLine();

            //List<MyItemOne> myItemOne = new List<MyItemOne>();
            //List<MyItemTwo> myItemTwo = new List<MyItemTwo>();


            //myItemOne.Add(new MyItemOne() { id = 1, name = "Vincent" });
            //myItemOne.Add(new MyItemOne() { id = 2, name = "Lee" });
            //myItemOne.Add(new MyItemOne() { id = 3, name = "Flores" });

            //myItemTwo.Add(new MyItemTwo() { id = 1, name = "Romeo" });
            //myItemTwo.Add(new MyItemTwo() { id = 2, name = "Patindol" });
            //myItemTwo.Add(new MyItemTwo() { id = 4, name = "Gwapo" });


            //var r = myItemOne.Where(x => myItemTwo.Any(y => y.id == x.id)).ToList();



            //List<string> x = new List<string>() { "Vincent", "Lee", "Flores", "Mirakuru", "YouCrackedMeUp" };
            //Random r = new Random();

            //var xx = r.Next(0, 4);

            //var m = x[2];

            //Console.ReadLine();

        }


        public class MyItemOne
        {
            public int id { get; set; }
            public string name { get; set; }
        }

        public class MyItemTwo
        {
            public int id { get; set; }
            public string name { get; set; }
        }






        private static Microsoft.Office.Interop.Excel.Workbook mWorkBook;
        private static Microsoft.Office.Interop.Excel.Sheets mWorkSheets;
        private static Microsoft.Office.Interop.Excel.Worksheet mWSheet1;
        private static Microsoft.Office.Interop.Excel.Application oXL;
        public static void ReadExistingExcel()
        {
            string path = @"C:\Tool\Reports1.xls";
            oXL = new Microsoft.Office.Interop.Excel.Application();
            oXL.Visible = true;
            oXL.DisplayAlerts = false;
            mWorkBook = oXL.Workbooks.Open(path, 0, false, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            //Get all the sheets in the workbook
            mWorkSheets = mWorkBook.Worksheets;
            //Get the allready exists sheet
            mWSheet1 = (Microsoft.Office.Interop.Excel.Worksheet)mWorkSheets.get_Item("Sheet1");
            Microsoft.Office.Interop.Excel.Range range = mWSheet1.UsedRange;
            int colCount = range.Columns.Count;
            int rowCount = range.Rows.Count;
            for (int index = 1; index < 15; index++)
            {
                mWSheet1.Cells[rowCount + index, 1] = rowCount + index;
                mWSheet1.Cells[rowCount + index, 2] = "New Item" + index;
            }


            mWorkBook.SaveAs(path, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal,
            Missing.Value, Missing.Value, Missing.Value, Missing.Value, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive,
            Missing.Value, Missing.Value, Missing.Value,
            Missing.Value, Missing.Value);
            mWorkBook.Close(Missing.Value, Missing.Value, Missing.Value);
            mWSheet1 = null;
            mWorkBook = null;
            oXL.Quit();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
}

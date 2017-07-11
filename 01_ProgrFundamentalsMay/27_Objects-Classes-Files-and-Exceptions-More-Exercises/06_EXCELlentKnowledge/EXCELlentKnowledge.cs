using System; 
using System.IO;

using System.Runtime.InteropServices;  
using Excel = Microsoft.Office.Interop.Excel;       //Microsoft Excel 14 object in references-> COM tab

namespace _06_EXCELlentKnowledge
{
    public class EXCELlentKnowledge
    {
        public static void Main()
        {

            Excel.Application xlApp = new Excel.Application();
            //Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"..\..\..\resources\sample_table.xlsx");
           // Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"sample_table.xlsx");
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"D:\_SoftUni_Projects\SoftUniProjects\01_ProgrFundamentalsMay\27_Objects-Classes-Files-and-Exceptions-More-Exercises\resources\sample_table.xlsx");
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;
            //int rowCount = 10;
            //int colCount = 10;

            string text = String.Empty;

            //iterate over the rows and columns and print to the console as it appears in the file
            //excel is not zero based!!
            for (int i = 1; i <= rowCount; i++)
            {
                for (int j = 1; j <= colCount; j++)
                {
                    //new line
                    if (j == 1)
                    {
                        text += Environment.NewLine;
                        Console.Write(Environment.NewLine);
                    }
                    //write the value to the console
                    if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                    {
                        Console.Write(xlRange.Cells[i, j].Value2.ToString() + "|"); //\t
                        text += xlRange.Cells[i, j].Value2.ToString() + "|";
                    } 
                    //add useful things here!   
                }
            }

            Console.WriteLine();
            text += Environment.NewLine;
            File.WriteAllText(@"..\..\..\resources\output-sample06.txt", text);
            //cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();

            //rule of thumb for releasing com objects:
            //  never use two dots, all COM objects must be referenced and released individually
            //  ex: [somthing].[something].[something] is bad

            //release com objects to fully kill excel process from running in the background
            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);

            //close and release
            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);

            //quit and release
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);
        }
    }
}

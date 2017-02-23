using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace framework.New
{
    /// <summary>
    /// 
    /// </summary>
    class ExcelFile
    {
        public string JournalTitle { get; private set; }
        public List<Colomn> Colomns { get; private set; }

        public ExcelFile()
        {

        }

        public ExcelFile(String fileName)
        {
            Colomns = new List<Colomn>();
            readFile(fileName);

        }

        private void readFile(string fileNamme)
        {
            Application ObjExcel = new Application();
            //Открываем книгу.                                                                                                                                                        
            Workbook ObjWorkBook = ObjExcel.Workbooks.Open(fileNamme);
            //Выбираем таблицу(лист).
            Worksheet ObjWorkSheet;
            Colomn cl;
            for (int j = 1; j < 5; j++)
            {
                ObjWorkSheet = (Worksheet)ObjWorkBook.Sheets[j];
                JournalTitle = ObjWorkSheet.Name.ToString();

                int i = 1;
                while (ObjWorkSheet.Cells[2, i].Value != null)
                {

                    cl = new Colomn(ObjWorkSheet.Cells[2, i].Text);
                    int k = 3;
                    while (ObjWorkSheet.Cells[k, i].Value != null)
                    {
                        cl.coloms.Add(ObjWorkSheet.Cells[k, i].Text);
                        ++k;
                    }
                    Colomns.Add(cl);
                    ++i;
                }

            }
            ObjWorkBook.Close(false, Type.Missing, Type.Missing);
            ObjExcel.Quit();
        }
    }
}


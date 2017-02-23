using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace framework.New
{
    class GettingJournalInfo
    {
        public void readFile(string fileNamme, Journal journal)
        {
            Application ObjExcel = new Application();
            //Открываем книгу.                                                                                                                                                        
            Workbook ObjWorkBook = ObjExcel.Workbooks.Open(fileNamme);
            //Выбираем таблицу(лист).
            Worksheet ObjWorkSheet;
            Colomn colomn;
            
            MenuElement menuItem;
            for (int j = 1; j < 2; j++)
            {
                ObjWorkSheet = (Worksheet)ObjWorkBook.Sheets[j];
                menuItem = new MenuElement(ObjWorkSheet.Name.ToString());
                int i = 1;
                while (ObjWorkSheet.Cells[2, i].Value != null)
                {

                    colomn = new Colomn(ObjWorkSheet.Cells[2, i].Text);
                    int k = 3;
                    while (ObjWorkSheet.Cells[k, i].Value != null)
                    {
                        colomn.coloms.Add(ObjWorkSheet.Cells[k, i].Text);
                        ++k;
                    }
                    menuItem.Colomns.Add(colomn);
                    ++i;
                }
                journal.JournalInfo.Add(menuItem);
            }
            ObjWorkBook.Close(false, Type.Missing, Type.Missing);
            ObjExcel.Quit();
           // return journal;
        }
    }
}

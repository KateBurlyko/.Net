using framework.Journal1;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;

namespace framework.BatchInfo
{
    class GettingNavigInfo
    {
        public List<Journal> GetNavigInfo(List<Journal> journal)
        {
            Application ObjExcel = new Application();
            //Открываем книгу.                                                                                                                                                        
            Workbook ObjWorkBook = ObjExcel.Workbooks.Open(Data.Default.pathBatchHome);
            //Выбираем таблицу(лист).
            Worksheet ObjWorkSheet;
            Menies menies;
            Navigation navigation = new Navigation();
           // List<Journal> journal = new List<Journal>();
            for (int j = 1; j < 2; j++)
            {
                ObjWorkSheet = (Worksheet)ObjWorkBook.Sheets[j];
               
                int i = 1;
                //List<Navigation> navigat = new List<Navigation>();
                while (ObjWorkSheet.Cells[2, i].Value != null)
                {

                    menies = new Menies(ObjWorkSheet.Cells[2, i].Text);
                    int k = 3;
                    while (ObjWorkSheet.Cells[k, i].Value != null)
                    {
                        SubMenu su = new SubMenu();
                        menies.subMenu.Add(new SubMenu() { Name = ObjWorkSheet.Cells[k, i].Text });
                        ++k;
                    }
                  navigation.menies.Add(menies);
                    ++i;
                }
                Journal jou = new Journal(ObjWorkSheet.Name.ToString(), navigation);
                journal.Add(jou);
            }
            //  }
            //foreach (BatchContent p in list)
            //{
            //    Console.WriteLine(p.jurnalName);
            //    Console.WriteLine(p.jurmalNavig);
            //    Console.WriteLine(p.jurnalClick);
            //}

            // Console.ReadKey();
            ObjWorkBook.Close(false, Type.Missing, Type.Missing);
            ObjExcel.Quit();
            return journal;
        }
    }
}

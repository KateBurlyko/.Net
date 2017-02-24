using framework.JournalItem;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace framework.ParseExcel
{
    class GettingJournalInfo
    {
        /// <summary>
        /// get jurnal information from batch file
        /// </summary>
        /// <param name="ObjWorkBook">WorkBook object</param>
        /// <param name="ObjWorkSheet">WorkSheet object</param>
        /// <param name="journal">Journal class obgect </param>
        public void GetInfo(Workbook ObjWorkBook, Worksheet ObjWorkSheet, Journal journal)
        {
            Colomn colomn;
            MenuElement menuItem;

            for (int j = 1; j < ObjWorkBook.Sheets.Count; j++)
            {
                ObjWorkSheet = (Worksheet)ObjWorkBook.Sheets[j];
                menuItem = new MenuElement(ObjWorkSheet.Name.ToString());
                int row = 1;
                while (ObjWorkSheet.Cells[2, row].Value != null)
                {
                    colomn = new Colomn(ObjWorkSheet.Cells[2, row].Text);
                    int column = 3;
                    while (ObjWorkSheet.Cells[column, row].Value != null)
                    {
                        colomn.coloms.Add(ObjWorkSheet.Cells[column, row].Text);
                        ++column;
                    }
                    menuItem.Colomns.Add(colomn);
                    ++row;
                }
                journal.JournalInfo.Add(menuItem);
            }
        }

        /// <summary>
        /// get jurnal information from batch file
        /// </summary>
        /// <param name="ObjWorkBook">WorkBook object</param>
        /// <param name="ObjWorkSheet">WorkSheet object</param>
        /// <param name="journal">Journal class obgect </param>
        /// <param name="journalName">var with name and path of file</param>
        public void GetInfo(Workbook ObjWorkBook, Worksheet ObjWorkSheet, Journal journal, string journalName)
        {
            Colomn colomn;
            MenuElement menuItem;


            ObjWorkSheet = (Worksheet)ObjWorkBook.Sheets[journalName];
            menuItem = new MenuElement(ObjWorkSheet.Name.ToString());
            int row = 1;
            while (ObjWorkSheet.Cells[2, row].Value != null)
            {

                colomn = new Colomn(ObjWorkSheet.Cells[2, row].Text);
                int column = 3;
                while (ObjWorkSheet.Cells[column, row].Value != null)
                {
                    colomn.coloms.Add(ObjWorkSheet.Cells[column, row].Text);
                    ++column;
                }
                menuItem.Colomns.Add(colomn);
                ++row;
            }
            journal.JournalInfo.Add(menuItem);
            //  return journal.JournalInfo;
        }
    }
}

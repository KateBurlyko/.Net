using framework.JournalItem;
using framework.ParseExcel;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.IO;

namespace framework
{
    class WorkingWithExcel
    {
        GettingJournalInfo qwe;

        public WorkingWithExcel()
        {
            qwe = new GettingJournalInfo();
        }

        /// <summary>
        /// get information about each journal
        /// </summary>
        /// <param name="fileNamme">name and path of file</param>
        /// <param name="journal">Journal class object</param>
        public List<Journal> GetJournalInfo(AllJournals allJournals, string fileNamme, Journal journal)
        {
            Application ObjExcel = new Application();
            //Открываем книгу.                                                                                                                                                        
            Workbook ObjWorkBook = ObjExcel.Workbooks.Open(fileNamme);
            //Выбираем таблицу(лист).
            Worksheet ObjWorkSheet = new Worksheet();

            qwe.GetInfo(ObjWorkBook, ObjWorkSheet, journal);

            ObjWorkBook.Close(false, Type.Missing, Type.Missing);
            ObjExcel.Quit();
            allJournals.AllJournal.Add(journal);
            return allJournals.AllJournal;
        }

        /// <summary>
        /// get information about one journal
        /// </summary>
        /// <param name="fileNamme">name and path of file</param>
        /// <param name="journal">Journal class object</param>
        /// <param name="journalName">path and name of Journal</param>
        /// <returns></returns>
        public List<Journal> GetJournalInfo(AllJournals allJournals, string fileNamme, Journal journal, string journalName)
        {
            Application ObjExcel = new Application();
            //Открываем книгу.                                                                                                                                                        
            Workbook ObjWorkBook = ObjExcel.Workbooks.Open(fileNamme);
            //Выбираем таблицу(лист).
            Worksheet ObjWorkSheet = new Worksheet();

            qwe.GetInfo(ObjWorkBook, ObjWorkSheet, journal, journalName);
            
            ObjWorkBook.Close(false, Type.Missing, Type.Missing);
            ObjExcel.Quit();
            allJournals.AllJournal.Add(journal);
            return allJournals.AllJournal;
        }

        /// <summary>
        /// get info from all batches
        /// </summary>
        /// <param name="allJournals">object of class AllJournals</param>
        /// <param name="journal">object of class Journal</param>
        /// <param name="folderPath">path to all batches</param>
        /// <returns>list with info from all batches</returns>
        public List<Journal> GetJournalInfo(AllJournals allJournals, Journal journal, string folderPath)
        {
            foreach (string batch in Directory.GetFiles(folderPath))
            {
                Application ObjExcel = new Application();
                //Открываем книгу.                                                                                                                                                        
                Workbook ObjWorkBook = ObjExcel.Workbooks.Open(batch);
                //Выбираем таблицу(лист).
                Worksheet ObjWorkSheet = new Worksheet();

                qwe.GetInfo(ObjWorkBook, ObjWorkSheet, journal);

                allJournals.AllJournal.Add(journal);
                ObjWorkBook.Close(false, Type.Missing, Type.Missing);
                ObjExcel.Quit();
                allJournals.AllJournal.Add(journal);
            }
            return allJournals.AllJournal;
        }
    }
}
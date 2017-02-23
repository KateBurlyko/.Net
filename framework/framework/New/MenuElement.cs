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
    class MenuElement
    {
        public string JournalTitle { get; private set; }
        public List<Colomn> Colomns { get; private set; }

        

        public MenuElement(string journalTitle)
        {
            JournalTitle= journalTitle;
            Colomns = new List<Colomn>();
          
        }

        
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace framework.JournalItem
{
    class AllJournals
    {
        public List<Journal> AllJournal { get; private set; }

        public AllJournals()
        {
            AllJournal = new List<Journal>();
        }
    }
}

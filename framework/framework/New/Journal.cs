using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace framework.New
{
    class Journal
    {
        public List<MenuElement> JournalInfo { get; private set; }

        public Journal()
        {          
            JournalInfo = new List<MenuElement>();         
        }
    }
}

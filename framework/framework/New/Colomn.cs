using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace framework.New
{
    class Colomn
    {
        public string MenuItem { get; private set; }
       
        public List<string> coloms { get; private set; }

        public Colomn(string clTitle)
        {
             MenuItem=clTitle;
            coloms = new List<string>();
        }

        
    }
}

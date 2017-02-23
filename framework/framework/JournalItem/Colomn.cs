using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace framework
{
    /// <summary>
    /// 
    /// </summary>
    class Colomn
    {
        
        public string MenuTitle { get; private set; }
       
        public List<string> coloms { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="menuTitle"> </param>
        public Colomn(string menuTitle)
        {
             MenuTitle=menuTitle;
            coloms = new List<string>();
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace framework.BatchInfo
{
    class BatchContent
    {
        //public string jurnalName { get; set; }
        //public string jurmalNavig { get; set; }
        //public string jurnalClick { get; set; }

        private string jurnalName;
        private string jurnalNavig;
        private string jurnalClick;

        public BatchContent(string jurnalName, string jurnalNavig, string jurnalClick)
        {
            this.jurnalName = jurnalName;
            this.jurnalNavig = jurnalNavig;
            this.jurnalClick = jurnalClick;
        }

        public string JurnalName
        {
            get { return jurnalName; }
            set { jurnalName = value; }
        }

        public string JurnalNavig
        {
            get { return jurnalNavig; }
            set { jurnalNavig = value; }
        }

        public string JurnalClick
        {
            get { return jurnalClick; }
            set { jurnalClick = value; }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace framework.Search
{
    class AdvansedSearch
    {
        public Dictionary<string, string> Keywords { get; private set; }
        public Dictionary<string, string> KeywordsContent { get; private set; }
        public Dictionary<bool, string> ContentTypes { get; private set; }
        public Dictionary<bool, string> PublicationDates { get; private set; }

        public AdvansedSearch()
        {
            Keywords = new Dictionary<string, string>();
            KeywordsContent = new Dictionary<string, string>();
            ContentTypes = new Dictionary<bool, string>();
            PublicationDates = new Dictionary<bool, string>();
        }
    }
}

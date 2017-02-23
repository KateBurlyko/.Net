using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace framework.Search
{
    class BaseSearch
    {
        public string Query { get; private set; }
        public string Expected { get; private set; }

        public BaseSearch(string query, string expected)
        {
            Query = query;
            Expected = expected;
        }
    }
}

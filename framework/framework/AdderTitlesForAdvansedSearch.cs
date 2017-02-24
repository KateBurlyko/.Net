using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace framework
{
    class TitlesForAdvansedSearch
    {
        string Title { get; set; }
        int IdTitle { get; set; }

        public TitlesForAdvansedSearch(string title, int id)
        {
            Title = title;
            IdTitle = id;
        }
    }

    class Addertitles
    {
        List<TitlesForAdvansedSearch> items { get; set; }

        public Addertitles()
        {
            items = new List<TitlesForAdvansedSearch>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace framework.DeserealizationData.AdvansedSearch
{
    class ContentItems
    {
        public string TypesAndLimits { get; set; }

        public ContentItems(string types)
        {
            TypesAndLimits = types;
        }
    }

    class ListOfTypes
    {
        List<ContentItems> items { get; set; }
        public ListOfTypes()
        {
            items = new List<ContentItems>();
        }
    }

    class AdderTypesAndLimits
    {
        public List<ContentItems> AddTitles(List<ContentTypes> types)
        {
            List<ContentItems> tit = new List<ContentItems>();
            foreach (ContentTypes ct in types)
            {
                if (!ct.Articles.Equals(null)) tit.Add(new ContentItems(ct.Articles));
                if (!ct.Blogs.Equals(null)) tit.Add(new ContentItems(ct.Blogs));
                if (!ct.Images.Equals(null)) tit.Add(new ContentItems(ct.Images));
                if (!ct.Podcast.Equals(null)) tit.Add(new ContentItems(ct.Podcast));
                if (!ct.Videos.Equals(null)) tit.Add(new ContentItems(ct.Videos));
            }
            return tit;
        }

        public List<ContentItems> AddLimits(List<ContentTypes> types)
        {
            List<ContentItems> tit = new List<ContentItems>();
            foreach (ContentTypes ki in types)
            {
                foreach(LimitToContentWith qw in ki.ContentLimits)
                {
                    if (!qw.CmeCE.Equals(null)) tit.Add(new ContentItems(qw.CmeCE));
                    if (!qw.SDC.Equals(null)) tit.Add(new ContentItems(qw.SDC));
                }
            }
            return tit;
        }
    }
}

using System;
using System.Collections.Generic;

namespace framework.DataDeserialize.AdvansedSearchItems
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
                if (String.IsNullOrEmpty(ct.Articles)) tit.Add(new ContentItems(ct.Articles = "Article"));
                if (!String.IsNullOrEmpty(ct.Blogs)) tit.Add(new ContentItems(ct.Blogs));
                if (!String.IsNullOrEmpty(ct.Images)) tit.Add(new ContentItems(ct.Images));
                if (!String.IsNullOrEmpty(ct.Podcast)) tit.Add(new ContentItems(ct.Podcast));
                if (!String.IsNullOrEmpty(ct.Videos)) tit.Add(new ContentItems(ct.Videos));
            }
            return tit;
        }

        public List<ContentItems> AddLimits(List<ContentTypes> types)
        {
            List<ContentItems> tit = new List<ContentItems>();
            foreach (ContentTypes ki in types)
            {
                foreach (LimitToContentWith qw in ki.ContentLimits)
                {
                    if (!String.IsNullOrEmpty(qw.CmeCE)) tit.Add(new ContentItems(qw.CmeCE));
                    if (!String.IsNullOrEmpty(qw.SDC)) tit.Add(new ContentItems(qw.SDC));
                }
            }
            return tit;
        }
    }
}

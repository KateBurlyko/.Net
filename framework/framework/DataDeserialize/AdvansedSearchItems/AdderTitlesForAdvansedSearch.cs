using System;
using System.Collections.Generic;

namespace framework.DataDeserialize.AdvansedSearchItems
{
    class TitleItems
    {
        public string Title { get; set; }
        public string IdTitle { get; set; }
        public TitleItems(string title, string id)
        {
            Title = title;
            IdTitle = id;
        }
    }

    class ListOfTitles
    {
        List<TitleItems> items { get; set; }
        public ListOfTitles()
        {
            items = new List<TitleItems>();
        }
    }

    class AdderTitles
    {
        public List<TitleItems> AddTitles(List<Keywords> titles)
        {
            List<TitleItems> tit = new List<TitleItems>();
            foreach (Keywords ki in titles)
            {
                if (!String.IsNullOrEmpty(ki.Abstract) && !String.IsNullOrEmpty(ki.IDAbstract)) tit.Add(new TitleItems(ki.Abstract, ki.IDAbstract));
                if (!String.IsNullOrEmpty(ki.AllFields) && !String.IsNullOrEmpty(ki.IDAllFields)) tit.Add(new TitleItems(ki.AllFields, ki.IDAllFields));
                if (!String.IsNullOrEmpty(ki.Author) && !String.IsNullOrEmpty(ki.IDAuthor)) tit.Add(new TitleItems(ki.Author, ki.IDAuthor));
                if (!String.IsNullOrEmpty(ki.FullText) && !String.IsNullOrEmpty(ki.IDFullText)) tit.Add(new TitleItems(ki.FullText, ki.IDFullText));
                if (String.IsNullOrEmpty(ki.Issue) == false && !String.IsNullOrEmpty(ki.IDIssue)) tit.Add(new TitleItems(ki.Issue, ki.IDIssue));
                if (!String.IsNullOrEmpty(ki.Title) && !String.IsNullOrEmpty(ki.IDTitle)) tit.Add(new TitleItems(ki.Title, ki.IDTitle));
                if (!String.IsNullOrEmpty(ki.Volume) && !String.IsNullOrEmpty(ki.IDVolume)) tit.Add(new TitleItems(ki.Volume, ki.IDVolume));
            }
            return tit;
        }
    }
}

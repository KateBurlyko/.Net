using framework.DeserealizationData.AdvansedSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace framework
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
                if (!ki.Abstract.Equals(null) && ki.IDAbstract.Equals(null)) tit.Add(new TitleItems(ki.Abstract, ki.IDAbstract));
                if (!ki.AllFields.Equals(null) && ki.IDAllFields.Equals(null)) tit.Add(new TitleItems(ki.AllFields, ki.IDAllFields));
                if (!ki.Author.Equals(null) && ki.IDAuthor.Equals(null)) tit.Add(new TitleItems(ki.Author, ki.IDAuthor));
                if (!ki.FullText.Equals(null) && ki.IDFullText.Equals(null)) tit.Add(new TitleItems(ki.FullText, ki.IDFullText));
                if (!ki.Issue.Equals(null) && ki.IDIssue.Equals(null)) tit.Add(new TitleItems(ki.Issue, ki.IDIssue));
                if (!ki.Title.Equals(null) && ki.IDTitle.Equals(null)) tit.Add(new TitleItems(ki.Title, ki.IDTitle));
                if (!ki.Volume.Equals(null) && ki.IDVolume.Equals(null)) tit.Add(new TitleItems(ki.Volume, ki.IDVolume));
            }
            return tit;
        }
    }
}

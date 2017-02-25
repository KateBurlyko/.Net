using framework.DataDeserialize.AdvansedSearchItems;
using System;
using System.Collections.Generic;

namespace framework.DataDeserialize.AdvansedSearchItemsItems
{
    class DateItems
    {
        public string Date { get; set; }
        public DateItems(string date)
        {
            Date = date;
        }
    }

    class ListOfDate
    {
        List<DateItems> items { get; set; }
        public ListOfDate()
        {
            items = new List<DateItems>();
        }
    }

    class AdderDates
    {
        public List<DateItems> AddDates(List<PublicationDates> types)
        {
            List<DateItems> tit = new List<DateItems>();
            foreach (PublicationDates ct in types)
            {
                if (!String.IsNullOrEmpty(ct.AllDates)) tit.Add(new DateItems(ct.AllDates));
                if (!String.IsNullOrEmpty(ct.EightYears)) tit.Add(new DateItems(ct.EightYears));
                if (!String.IsNullOrEmpty(ct.FiveYears)) tit.Add(new DateItems(ct.FiveYears));
                if (!String.IsNullOrEmpty(ct.ThreeYears)) tit.Add(new DateItems(ct.ThreeYears));
                if (!String.IsNullOrEmpty(ct.TwelveMounth)) tit.Add(new DateItems(ct.TwelveMounth));
            }
            return tit;
        }
    }
}
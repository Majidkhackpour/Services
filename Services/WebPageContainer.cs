using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Services
{
    public class WebPageContainer<T> where T : class, new()
    {
        public int TotalItems { get; set; }
        public int TotalPages { get; set; }
        public int CurrentPageCount { get; set; }
        public int EachPageCount { get; set; }
        public int CurrentPageNumber { get; set; }
        public List<NumberContainer<T>> Items { get; set; }
        [JsonIgnore] public List<T> OrginItems { get; set; }

        public static WebPageContainer<T> GeneratePageItems(List<T> items, int eachPageCount, int currentPageNumber)
        {
            WebPageContainer<T> ret = null;
            if (eachPageCount <= 0) throw new ArgumentException($"value {eachPageCount} for {nameof(eachPageCount)} is wrong");
            if (items == null) throw new ArgumentException($"{nameof(eachPageCount)} is null or empty");
            if (currentPageNumber < 0) throw new ArgumentException($"value {currentPageNumber} for {nameof(currentPageNumber)} is less than zero");
            try
            {
                if (currentPageNumber <= 0) currentPageNumber = 1; 
                var startIndex = eachPageCount * (currentPageNumber - 1);
                var endIndex = eachPageCount * currentPageNumber;
                if (endIndex > items.Count())
                    endIndex = items.Count();

                ret = new WebPageContainer<T>()
                {
                    EachPageCount = eachPageCount,
                    CurrentPageCount = endIndex - startIndex,
                    Items = new List<NumberContainer<T>>(),
                    TotalItems = items.Count,
                    TotalPages = (int)Math.Ceiling(items.Count / (float)eachPageCount),
                    CurrentPageNumber = currentPageNumber,
                };
                if (items.Count > 0 && ret.TotalPages <= 0)
                    ret.TotalPages = 1;

                ret.OrginItems = new List<T>();
                for (var i = startIndex; i < endIndex; i++)
                {
                    ret.OrginItems.Add(items[i]);
                    ret.Items.Add(new NumberContainer<T>()
                    {
                        Item = items[i],
                        RowNumber = i
                    });
                }
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
            return ret;
        }
    }

    public class NumberContainer<T>
    {
        public int RowNumber { get; set; }
        public T Item { get; set; }
    }
}

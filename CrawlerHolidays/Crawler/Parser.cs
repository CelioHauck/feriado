using HtmlAgilityPack;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlerHolidays.Crawler
{
    public class Parser
    {
        public HtmlDocument HtmlDocument { get; set; }

        public Parser(string html)
        {
            this.HtmlDocument = new HtmlDocument();
            this.HtmlDocument.LoadHtml(html);
        }

        internal List<Holiday> ParseNationalHolidays()
        {
            var jsonArray = JArray.Parse(this.HtmlDocument.DocumentNode.OuterHtml);
            var holidayList = new List<Holiday>();

            foreach(var json in jsonArray)
            {
                var dateText = json["date"].ToObject<string>();
                var name = json["name"].ToObject<string>();

                var date = DateTime.ParseExact(dateText, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                holidayList.Add(new Holiday
                {
                    Date = date,
                    Name = name
                });
            }

            return holidayList;
        }
    }
}

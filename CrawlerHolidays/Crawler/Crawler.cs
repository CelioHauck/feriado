using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlerHolidays.Crawler
{
    public class Crawler
    {
        public Parser Parser { get; set; }
        public HttpClient HttpClient { get; set; }

        public Crawler()
        {
            this.HttpClient = new HttpClient();
        }

        public List<Holiday> GetNationalHolidays()
        {
            var html = this.HttpClient.Get(string.Format("https://api.calendario.com.br/?json=true&ano={0}&ibge=3550308&token=={1}", ConfigurationSettings.AppSettings["Year"],ConfigurationSettings.AppSettings["Token"]));

            var parser = new Parser(html);

            return parser.ParseNationalHolidays();
        }
    }
}

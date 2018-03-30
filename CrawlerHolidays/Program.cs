using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlerHolidays
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new HolidaysDbContext();
            var crawler = new Crawler.Crawler();

            var holidays = crawler.GetNationalHolidays();

            var region = new Region
            {
                Holidays = holidays,
            };

            foreach(var holiday in holidays)
            {
                if (!db.Holidays.Where(x => x.Name.Equals(holiday.Name) && x.Date == holiday.Date).Any())
                    db.Holidays.Add(holiday);
            }

            db.SaveChanges();
        }
    }
}

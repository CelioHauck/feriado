using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlerHolidays
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Region Region { get; set; }
        public List<Holiday> Holidays { get; set; }
    }
}

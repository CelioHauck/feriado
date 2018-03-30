using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlerHolidays
{
    public class Region
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sigla { get; set; }
        public List<City> Cities { get; set; }
        public List<Holiday> Holidays { get; set; }
    }
}

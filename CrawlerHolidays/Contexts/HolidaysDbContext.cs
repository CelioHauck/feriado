using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlerHolidays
{
    public class HolidaysDbContext : DbContext
    {
        public HolidaysDbContext() : base("HolidaysDb")
        {
        }

        public DbSet<Holiday> Holidays { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}

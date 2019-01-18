using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace TradingSimulator.Classes
{
    public class TradingContext : DbContext
    {
        public DbSet<ItemCategory> ItemCategories { get; set; }






        public TradingContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = trading.db");

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace TradingSimulator.Classes
{
   public class TradingContext:DbContext
    {
        public DbSet<ItemCategory> itemCategories { get; set; }
        public DbSet<Item> items { get; set; }
        public DbSet<Order> orders { get; set; }

        public DbSet<Trader> traders { get; set; }


        public TradingContext()
            : base("DbConnection")
        {
        }



    }
}
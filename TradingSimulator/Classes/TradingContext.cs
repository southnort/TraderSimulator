using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;



namespace TradingSimulator.Classes
{
   public class TradingContext:DbContext
    {
        public DbSet<ItemCategory> itemCategories { get; set; }
        public DbSet<Item> items { get; set; }
        public DbSet<BuyOrder> buyOrders { get; set; }
        public DbSet<SellOrder> sellOrders { get; set; }
        public DbSet<Trader> traders { get; set; }
        public DbSet<HistoryNode> HistoryNodes { get; set; }


        public TradingContext()
            : base("DbConnection")
        {
           
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

    }
}

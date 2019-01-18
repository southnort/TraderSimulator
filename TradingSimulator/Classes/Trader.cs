using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TradingSimulator.Classes
{
   public  class Trader
    {
        public int id { get; set; }
        public string name { get; set; }
        public ICollection<Item> Items { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TradingSimulator.Classes
{
    public class Item
    {
        public int id { get; set; }
        public string name { get; set; }
        public int rarity { get; set; }

        public int categoryId { get; set; }
        public virtual ItemCategory Category { get; set; }
    }
}
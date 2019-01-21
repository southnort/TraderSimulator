using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TradingSimulator.Classes
{
    public class ItemCategory
    {
        public int id { get; set; }
        public string name { get; set; }

        public ICollection<Item> Items { get; set; }



        public ItemCategory()
        {
            Items = new List<Item>();
        }
        public override string ToString()
        {
            return name;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingSimulator.Classes
{
    public class Cargo
    {
        public int id { get; set; }

        public int itemId { get; set; }
        public Item Item { get; set; }
        public int count { get; set; }

        public int traderId { get; set; }
        public Trader Trader { get; set; }

    }
}

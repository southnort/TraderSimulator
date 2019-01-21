using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingSimulator.Classes
{
    public class Cargo
    {
        public int itemId { get; set; }
        public virtual Item Item { get; set; }
        public int count { get; set; }

        public int traderId { get; set; }
        public virtual Trader Trader { get; set; }

    }
}

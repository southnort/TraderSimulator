using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingSimulator.Classes
{
    public class BuyOrder
    {
        public int id { get; set; }
        public virtual Trader Trader { get; set; }
        public int TraderID { get; set; }

        public int itemID { get; set; }
        public virtual Item Item { get; set; }
        public decimal price { get; set; }
        public int count { get; set; }

        public long expireTime { get; set; }
        public long allowChangeTime { get; set; }
    }
}

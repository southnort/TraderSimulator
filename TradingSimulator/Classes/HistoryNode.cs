using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingSimulator.Classes
{
    public class HistoryNode
    {
        public int Id { get; set; }
        public long DateTime { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }

        public virtual Trader Seller { get; set; }
        public int SellerId { get; set; }
        public virtual Trader Buyer { get; set; }
        public int BuyerId { get; set; }


    }
}

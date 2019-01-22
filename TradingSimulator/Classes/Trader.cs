using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TradingSimulator.Classes
{
    public class Trader
    {
        public int id { get; set; }
        public string name { get; set; }

        public float money { get; set; }

        public ICollection<Cargo> Cargohold { get; set; }
        public ICollection<BuyOrder> BuyOrders { get; set; }
        public ICollection<SellOrder> SellOrders { get; set; }


        public int maxBuyOrders { get; set; }
        public int maxSellOrders { get; set; }

        


        public Trader()
        {
            Cargohold = new List<Cargo>();
            BuyOrders = new List<BuyOrder>();
            SellOrders = new List<SellOrder>();
            money = 200;
            maxBuyOrders = 5;
            maxSellOrders = 5;
            
        }

    }
}
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
        public ICollection<Order> BuyOrders { get; set; }
        public ICollection<Order> SellOrders { get; set; }

        


        public Trader()
        {
            Cargohold = new List<Cargo>();
            BuyOrders = new List<Order>();
            SellOrders = new List<Order>();
            money = 200;
            
        }

    }
}
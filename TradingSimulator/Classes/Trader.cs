using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TradingSimulator.Classes
{
    public class Trader : IBuyerSeller
    {
        public int id { get; set; }
        public string name { get; set; }

        public decimal Money { get; set; }

        public ICollection<Cargo> Cargos { get; set; }
        public ICollection<BuyOrder> BuyOrders { get; set; }
        public ICollection<SellOrder> SellOrders { get; set; }


        public int maxBuyOrders { get; set; }
        public int maxSellOrders { get; set; }




        public Trader()
        {
            Cargos = new List<Cargo>();
            BuyOrders = new List<BuyOrder>();
            SellOrders = new List<SellOrder>();
            Money = 200;
            maxBuyOrders = 5;
            maxSellOrders = 5;

        }

    }
}
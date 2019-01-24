using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingSimulator.Classes;

namespace TradingSimulator.Controllers
{
    public class TradersController
    {
        public void Tick()
        {
            CreateRandomBuyOrders();
        }



        private void CreateRandomBuyOrders()
        {
            foreach (var tr in GetRandomTraders())
                CreateRandomBuyOrder(tr);
        }

        private void CreateRandomBuyOrder(Trader trader)
        {
            if (trader.BuyOrders.Count >= trader.maxBuyOrders) return;

            BuyOrder order = new BuyOrder { Trader = trader };

            Item item = Extensions.GetRandomItemFrom(Program.dataBase.items.ToList());

            int count = 5;
            int price = ((int)(trader.money / trader.maxBuyOrders) / count);
            long changeTime = DateTime.Now.AddMinutes(5).DateToLong();
            long expireTime = DateTime.Now.AddDays(3).DateToLong();


            order.Item = item;
            order.price = price;
            order.count = count;
            order.allowChangeTime = changeTime;
            order.expireTime = expireTime;

            trader.money -= (price * count);
            Program.dataBase.buyOrders.Add(order);
            Program.dataBase.SaveChanges();

        }



        private List<Trader> GetRandomTraders()
        {
            var result = new List<Trader>();
            Random rand = new Random();
            foreach (var tr in Program.dataBase.traders.ToList())
            {
                if (rand.NextDouble() < 0.31)
                    result.Add(tr);
            }

            return result;
        }
        
    }


}

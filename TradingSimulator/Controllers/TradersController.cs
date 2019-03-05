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
        private Random rand = new Random();

        public void Tick()
        {
          //  CreateRandomBuyOrders();
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

            var items = Program.dataBase.items.ToList();
            if (items.Count > 0)
            {
                int num = rand.Next(0, items.Count);
                Item item = items[num];

                int count = 5;
                int price = ((int)(trader.Money / trader.maxBuyOrders) / count);
                long changeTime = DateTime.Now.AddMinutes(5).DateToLong();
                long expireTime = DateTime.Now.AddDays(3).DateToLong();


                order.Item = item;
                order.price = price;
                order.count = count;
                order.allowChangeTime = changeTime;
                order.expireTime = expireTime;

                trader.Money -= (price * count);
                Program.dataBase.buyOrders.Add(order);
                Program.dataBase.SaveChanges();
            }

        }



        private List<Trader> GetRandomTraders()
        {
            var result = new List<Trader>();
            Random rand = new Random();
            foreach (var tr in Program.dataBase.traders.ToList())
            {
                if (tr != Program.player)
                    if (rand.NextDouble() < 0.31)
                        result.Add(tr);
            }

            return result;
        }

    }


}

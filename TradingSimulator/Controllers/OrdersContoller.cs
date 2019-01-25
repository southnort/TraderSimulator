using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingSimulator.Classes;

namespace TradingSimulator.Controllers
{
    public class OrdersContoller
    {
        public string TryBuy(Trader buyer, Item item, int count, decimal price)
        {
            var list = Program.dataBase.sellOrders;

            Order sellOrder = list.Aggregate((i1, i2) => i1.price > i2.price ? i1 : i2);

            return sellOrder.price.ToMoney();


        }

        public string TrySell(Trader seller, Item item, int count, decimal price)
        {
            var list = Program.dataBase.buyOrders;

            Order buyOrder = list.Aggregate((i1, i2) => i1.price < i2.price ? i1 : i2);

            return buyOrder.price.ToMoney();



        }


    }
}

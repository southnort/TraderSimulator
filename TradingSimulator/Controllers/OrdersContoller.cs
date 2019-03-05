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
        private enum DealResult { Success, Partial, Failed };

        public string TryBuy(IBuyerSeller buyer, Item item, int count, decimal price)
        {
            var list = Program.dataBase.sellOrders;
            Order sellOrder = list.Aggregate((i1, i2) => i1.price > i2.price ? i1 : i2);



            return sellOrder.price.ToMoney();


        }

        public int TrySell(IBuyerSeller seller, Item item, int count, decimal price)
        {
            DealResult result = DealResult.Success;

            var list = Program.dataBase.buyOrders;
            BuyOrder buyOrder = list.Aggregate((i1, i2) => i1.price < i2.price ? i1 : i2);

            if (count > buyOrder.count)
            {
                count = buyOrder.count;
                result = DealResult.Partial;
            }

            decimal summ = price * count;
            seller.Money += summ;

            Cargo cargo =
                 buyOrder.Trader.Cargos.FirstOrDefault(c => c.itemId == item.id);
            cargo.count += count;


            buyOrder.count -= count;
            if (buyOrder.count == 0)
            {
                buyOrder.Trader.BuyOrders.Remove(buyOrder);
                Program.dataBase.buyOrders.Remove(buyOrder);
            }

            Program.dataBase.SaveChanges();

            return (int)result;

        }




    }
}

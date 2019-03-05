using System.Collections.Generic;
using System.Linq;

namespace TradingSimulator.Classes
{
    public class TradingShip:IBuyerSeller
    {
        public decimal Money { get; set; }
        public Dictionary<Item, int> wishList;
        public Dictionary<Item, int> itemsInCargo;


        public TradingShip()
        {
            wishList = new Dictionary<Item, int>();
            itemsInCargo = new Dictionary<Item, int>();
        }


        public void Tick()
        {        
            SellAll();
            BuyAll();
        }

        private void SellAll()
        {
            foreach (var cargo in itemsInCargo)
            {
                var list = Program.dataBase.buyOrders;
                Order buyOrder = list.Aggregate((i1, i2) => i1.price < i2.price ? i1 : i2);

                Program.ordersContoller.TrySell(this, cargo.Key, cargo.Value, buyOrder.price);

            }

        }

        private void BuyAll()
        {
            foreach (var wish in wishList)
            {
                var list = Program.dataBase.sellOrders;
                Order sellOrder = list.Aggregate((i1, i2) => i1.price < i2.price ? i1 : i2);

                Program.ordersContoller.TryBuy(this, wish.Key, wish.Value, sellOrder.price);

            }
        }
    }
}

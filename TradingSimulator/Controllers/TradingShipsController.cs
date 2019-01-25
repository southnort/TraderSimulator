using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingSimulator.Classes;

namespace TradingSimulator.Controllers
{
    public class TradingShipsController
    {
        public void Tick()
        {

        }

        private void ShipIsCome()
        {
            var ship = NewShip();   

        }

        private TradingShip NewShip()
        {
            TradingShip ship = new TradingShip();
            ship.Money = 2000;
            ship.wishList = GetDictionary();
            ship.itemsInCargo = GetDictionary();



            return ship;
        }

        private Dictionary<Item, int> GetDictionary()
        {
            Random rand = new Random();
            int countOfItems = rand.Next(0, 6);

            Dictionary<Item, int> result = new Dictionary<Item, int>();

            while (countOfItems > 0)
            {
                var item = Extensions.GetRandomItemFrom(Program.dataBase.items.ToList());
                int count = rand.Next(1, 30);

                if (!result.ContainsKey(item))
                    result.Add(item, 0);

                result[item] += count;
            }

            return result;
        }




    }
}

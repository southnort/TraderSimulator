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
        private int maxShipCount = 2;
        private Random rand = new Random();

        public void Tick()
        {
            var ships = new List<TradingShip>();

            for (int i = 0; i < rand.Next(0, maxShipCount); i++)
            {
                ships.Add(NewShip());

            }
            foreach (var ship in ships)
            {
                ship.Tick();
            }
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
                var list = Program.dataBase.items.ToList();
                if (list.Count > 0)
                {
                    int num = rand.Next(0, list.Count);
                    var item = list[num];
                    int count = rand.Next(1, 30);

                    if (!result.ContainsKey(item))
                        result.Add(item, 0);

                    result[item] += count;
                }
            }

            return result;
        }




    }
}

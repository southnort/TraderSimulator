using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingSimulator.Classes
{
    public class TradingShip
    {
        public decimal Money;
        public Dictionary<Item, int> wishList;
        public Dictionary<Item, int> itemsInCargo;


        public TradingShip()
        {
            wishList = new Dictionary<Item, int>();
            itemsInCargo = new Dictionary<Item, int>();
        }

    }
}

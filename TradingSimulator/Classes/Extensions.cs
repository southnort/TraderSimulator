using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingSimulator.Classes
{
   public static class Extensions
    {
        public static string ToMoney(this float money)
        {
            return money.ToString("### ### #### ### ### ### ### ###.00 $");
        }

    }
}

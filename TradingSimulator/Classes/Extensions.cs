using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingSimulator.Classes
{
    public static class Extensions
    {
        public static string ToMoney(this decimal money)
        {
            return money.ToString("### ### ### ### ###.00");
        }

        public static long DateToLong(this DateTime dateTime)
        {
            return dateTime.Ticks;
        }

        public static string LongDateToString(this long ticks)
        {
            DateTime dateTime = new DateTime(ticks);
            return dateTime.ToString("HH:mm dd.MM.yyyy");
        }

        public static string TimeRemains(this long ticks)
        {
            DateTime time = new DateTime(ticks);
            var result = time - DateTime.Now;


            if (result.Hours > 0)
                return $"{result.Hours} ч. {result.Minutes} мин.";
            else if (result.Minutes > 0)
                return $"{result.Minutes} мин. {result.Seconds} сек.";
            else
                return $"{result.Seconds} сек.";

        }       
    }
}

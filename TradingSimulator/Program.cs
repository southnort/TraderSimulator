using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingSimulator.Classes;
using TradingSimulator.Forms;

namespace TradingSimulator
{
    class Program
    {
        
        static void Main(string[] args)
        {
            using (TradingContext dataBase = new TradingContext())
            {
                
                foreach (var item in dataBase.itemCategories)
                {
                    Console.WriteLine(item.name);
                }

                Console.WriteLine("All");
                Console.Read();
            }
        }


    }
}

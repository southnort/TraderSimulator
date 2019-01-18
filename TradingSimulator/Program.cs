using System;
using Microsoft.EntityFrameworkCore;
using TradingSimulator.Classes;
using System.Collections.Generic;
using System.Linq;


namespace TradingSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            using (TradingContext db = new TradingContext())
            {
                ItemCategory cat1 = new ItemCategory { Name = "Руда" };

                // db.ItemCategories.Add(cat1);
                                
                db.SaveChanges();

                Console.WriteLine("Список объектов:");


                var list = db.ItemCategories;
                foreach (var item in list)
                {
                    Console.WriteLine(item.Name);
                }
            }


            Console.Read();
        }

       
    }
}

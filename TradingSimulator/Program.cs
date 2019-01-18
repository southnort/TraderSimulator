using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TradingSimulator.Classes;
using System.Data.Entity;

namespace TradingSimulator
{
    static class Program
    {     
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {            
            UpdateDataBase();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);  
            Application.Run(new Form1());
        }

        static void UpdateDataBase()
        {
            using ()
            {

                
                dataBase.itemCategories.Add(new ItemCategory { name = "Минералы" });
                dataBase.itemCategories.Add(new ItemCategory { name = "Металлы" });


                dataBase.items.Add(new Item
                {
                    name = "Бистит",
                    rarity = 0,
                    categoryId = 0,
                });

                dataBase.items.Add(new Item
                {
                    name = "Конкрит",
                    rarity = 0,
                    categoryId = 0,
                });


                dataBase.items.Add(new Item
                {
                    name = "Железо",
                    rarity = 0,
                    categoryId = 1,
                });

                dataBase.items.Add(new Item
                {
                    name = "Свинец",
                    rarity = 0,
                    categoryId = 1,
                });

                dataBase.SaveChanges();

            }
        }

    }
}

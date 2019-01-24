using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingSimulator.Classes;
using TradingSimulator.Forms;
using System.Threading;
using System.Timers;
using TradingSimulator.Controllers;
using System.Windows.Forms;


namespace TradingSimulator
{
    class Program
    {
        public static TradingContext dataBase;
        public static Trader player;


        private static TradersController tradersController = new TradersController();



        static void Main(string[] args)
        {
            using (TradingContext context = new TradingContext())
            {
                dataBase = context;

                if (dataBase.traders.ToList().Count == 0)
                {
                    InitializeDb();

                }

                else
                    player = dataBase.traders.First(tr => tr.name == "Player");


                MainForm form = new MainForm();
                form.ShowDialog();


                // Application.Run();
            }
        }

        private static void InitializeDb()
        {
            Trader playerTrader = dataBase.traders.Add
                         (new Trader { name = "Player" });
            player = playerTrader;

            dataBase.itemCategories.Add(new ItemCategory { name = "Руда" });
            dataBase.itemCategories.Add(new ItemCategory { name = "Металлы" });
            dataBase.SaveChanges();

            dataBase.items.Add(new Item { name = "Бистот", ItemCategoryId = 1 });
            dataBase.items.Add(new Item { name = "Крокит", ItemCategoryId = 1 });
            dataBase.SaveChanges();

            dataBase.items.Add(new Item { name = "Железо", ItemCategoryId = 2 });
            dataBase.items.Add(new Item { name = "Титан", ItemCategoryId = 2 });
            dataBase.SaveChanges();


            for (int i = 0; i < 5; i++)
            {
                dataBase.traders.Add(new Trader { name = Guid.NewGuid().ToString() });
                dataBase.SaveChanges();
            }

        }



        public static void TradeSystemTick()
        {            
            tradersController.Tick();

        }


    }


}

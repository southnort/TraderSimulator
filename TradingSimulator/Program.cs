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
        public static OrdersContoller ordersContoller;


        private static TradersController tradersController = new TradersController();
        private static TradingShipsController tradingShipsController = new TradingShipsController();



        static void Main(string[] args)
        {
            using (TradingContext context = new TradingContext())
            {
                dataBase = context;
                ordersContoller = new OrdersContoller();

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



        public static void GameTick()
        {
            try
            {
                tradersController.Tick();
                tradingShipsController.Tick();
                ClearDataBase();
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n\n#################################\n\n");
                Console.WriteLine(ex.ToString());
            }

        }

        private static void ClearDataBase()
        {
            foreach (var order in dataBase.sellOrders)
            {
                if (order.count < 1)
                    dataBase.sellOrders.Remove(order);
                dataBase.SaveChanges();
            }

            foreach (var order in dataBase.buyOrders)
            {
                if (order.count < 1)
                    dataBase.buyOrders.Remove(order);
                dataBase.SaveChanges();
            }
        }


    }


}

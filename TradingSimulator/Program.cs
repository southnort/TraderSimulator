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
        public static TradingContext dataBase;
        public static Trader player;


        static void Main(string[] args)
        {
            using (TradingContext context = new TradingContext())
            {
                dataBase = context;

                if (dataBase.traders.ToList().Count == 0)
                {
                    Trader playerTrader = dataBase.traders.Add
                         (new Trader { name = "Player" });
                    player = playerTrader;

                    for (int i = 0; i < 5; i++)
                    {
                        dataBase.traders.Add(new Trader { name = Guid.NewGuid().ToString() });
                        dataBase.itemCategories.Add(new ItemCategory { name = "руда" });
                        dataBase.items.Add(new Item { name = "Железо", categoryId = 1 });
                        dataBase.items.Add(new Item { name = "Титан", categoryId = 1 });


                        player.Cargos.Add(new Cargo { itemId = 1, count = i });
                       
                    }

                }

                else

                    player = dataBase.traders.First(tr => tr.name == "Player");


                for (int i = 0; i < 15; i++)
                {
                    
                    player.Cargos.Add(new Cargo { itemId = 1, count = i });

                }

                MainForm form = new MainForm();
                form.ShowDialog();

            }
        }
    }
}

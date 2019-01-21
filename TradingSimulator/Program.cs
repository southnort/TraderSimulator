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
                if (dataBase.traders.Count()==0)
                {
                    dataBase.traders.Add(new Trader { name = "Player" });

                    for (int i = 0; i < 20; i++)
                    {
                        dataBase.traders.Add(new Trader { name = Guid.NewGuid().ToString() });
                    }

                }

                player = dataBase.traders.FirstOrDefault(t => t.id == 1);


                MainForm form = new MainForm();
                form.ShowDialog();

            }
        }
    }
}

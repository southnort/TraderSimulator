using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.Entity;
using TradingSimulator.Classes;


namespace TradingSimulator.Forms
{
    public partial class TradingForm : __BaseForm
    {
        private Item currentItem;

        public TradingForm() : base()
        {
            InitializeComponent();

            ReloadForm();
            ReloadItemsCategories();
        }

        private void ReloadForm()
        {
            playerMoneyLabel.Text = Program.player.money.ToMoney();

        }


        private void ReloadItemsCategories()
        {
            var categories = Program.dataBase.itemCategories;
            var items = Program.dataBase.items.ToList();


            var treeNodes = new List<TreeNode>();
            var childNodes = new List<TreeNode>();




            foreach (var category in categories.Include(c => c.Items))
            {
                TreeNode mainNode = new TreeNode(category.name);

                foreach (var item in category.Items)
                {
                    TreeNode newNode = new TreeNode(item.name);
                    newNode.Tag = item;

                    mainNode.Nodes.Add(newNode);

                }


                treeView1.Nodes.Add(mainNode);

            }


        }

    

        private void LoadBuyOrders(Item item)
        {
            var orders = Program.dataBase.buyOrders.Where(o => o.itemID == item.id);
            buyOrdersDataGridView.DataSource = orders.ToList();

        }

        private void LoadSellOrders(Item item)
        {
            var orders = Program.dataBase.sellOrders.Where(o => o.itemID == item.id);
            sellOrdersDataGridView.DataSource = orders.ToList();

        }





        private void treeView1_NodeMouseClick(object sender,
            TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag != null)
            {
                Item item = (Item)e.Node.Tag;

                itemNameLabel.Text = item.Category.name + " / " + item.name;

                currentItem = item;

                LoadBuyOrders(item);
                LoadSellOrders(item);

            }


        }

        private void newBuyOrderButton_Click(object sender, EventArgs e)
        {
            BuyOrder order = new BuyOrder { Item = currentItem, Trader = Program.player  };
            BuyOrderForm form = new BuyOrderForm(order);

            if (form.ShowDialog() == DialogResult.OK)
            {
                Program.dataBase.buyOrders.Add(form.order);
                Program.dataBase.SaveChanges();
            }

            LoadBuyOrders(currentItem);
            LoadSellOrders(currentItem);
            ReloadForm();

        }
    }
}

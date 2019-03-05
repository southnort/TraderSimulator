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

        public TradingForm(Item item) : base()
        {
            InitializeComponent();

            currentItem = item;

            ReloadForm();
            ReloadItemsCategories();

            itemNameLabel.Text = item.ItemCategory.name + " / " + item.name;
            ReloadOrders();
        }

        private void ReloadForm()
        {
            playerMoneyLabel.Text = Program.player.Money.ToMoney();

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

        private void ReloadOrders()
        {
            LoadBuyOrders(currentItem);
            LoadSellOrders(currentItem);
        }

        private void LoadBuyOrders(Item item)
        {
            buyOrdersDataGridView.Rows.Clear();
            var orders = Program.dataBase.buyOrders.Where(o => o.itemID == item.id);
            orders = orders.OrderByDescending(o => o.price);

            foreach (var order in orders)
            {
                int rowNum = buyOrdersDataGridView.Rows.Add();
                var row = buyOrdersDataGridView.Rows[rowNum];

                row.Cells["price"].Value = order.price.ToMoney();
                row.Cells["count"].Value = order.count;
                row.Cells["expireTime"].Value = order.expireTime.TimeRemains();

                if (order.Trader == Program.player)
                {
                    row.DefaultCellStyle.BackColor = Color.LightBlue;

                }
            }


        }

        private void LoadSellOrders(Item item)
        {
            sellOrdersDataGridView.Rows.Clear();
            var orders = Program.dataBase.sellOrders.Where(o => o.itemID == item.id);
            orders = orders.OrderBy(o => o.price);

            foreach (var order in orders)
            {
                int rowNum = sellOrdersDataGridView.Rows.Add();
                var row = sellOrdersDataGridView.Rows[rowNum];

                row.Cells["price"].Value = order.price.ToMoney();
                row.Cells["count"].Value = order.count;
                row.Cells["expireTime"].Value = order.expireTime.TimeRemains();

                if (order.Trader == Program.player)
                {
                    row.DefaultCellStyle.BackColor = Color.LightBlue;

                }
            }

        }





        private void treeView1_NodeMouseClick(object sender,
            TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag != null)
            {
                Item item = (Item)e.Node.Tag;

                itemNameLabel.Text = item.ItemCategory.name + " / " + item.name;

                currentItem = item;
                newBuyOrderButton.Enabled = true;   

                ReloadOrders();

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

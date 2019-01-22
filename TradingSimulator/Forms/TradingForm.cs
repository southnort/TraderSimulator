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
    public partial class TradingForm : Form
    {
        public TradingForm()
        {
            InitializeComponent();

            ReloadItemsCategories();
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
            var orders = Program.dataBase.buyOrders.Where(o => o.Item == item);
            buyOrdersDataGridView.DataSource = orders;

        }

        private void LoadSellOrders(Item item)
        {
            var orders = Program.dataBase.sellOrders.Where(o => o.Item == item);
            sellOrdersDataGridView.DataSource = orders;

        }





        private void treeView1_NodeMouseClick(object sender, 
            TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag != null)
            {
                Item item = (Item)e.Node.Tag;


            }

              
        }

        
    }
}

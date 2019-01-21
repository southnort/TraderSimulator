using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TradingSimulator.Classes;

namespace TradingSimulator.Forms
{
    public partial class ItemsForm : Form
    {
        public ItemsForm()
        {
            InitializeComponent();

            RefreshTable();
        }

        private void RefreshTable()
        {
            var context = Program.dataBase;
            itemsDataGridView.DataSource = context.items.ToList();

        }

        private void itemsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (itemsDataGridView.CurrentRow != null)
            {
                int id = int.Parse(
                    itemsDataGridView.CurrentRow.Cells["id"]
                    .Value.ToString());


                var context = Program.dataBase;
                Item item = context.items.FirstOrDefault(i => i.id == id);
                ItemForm form = new ItemForm(item);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    item = form.item;
                    context.SaveChanges();
                }

                RefreshTable();
            }
        }

        private void addNewItemButton_Click(object sender, EventArgs e)
        {

            Item item = new Item();

            ItemForm form = new ItemForm(item);

            if (form.ShowDialog() == DialogResult.OK)
            {
                var context = Program.dataBase;
                context.items.Add(item);
                context.SaveChanges();
            }

            RefreshTable();
        }
    }
}


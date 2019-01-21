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
    public partial class MainForm : Form
    {


        public MainForm()
        {
            InitializeComponent();

            RefreshTable();
        }

        private void RefreshTable()
        {
            moneyLabel.Text = Program.player.money.ToMoney();
        }

        private void categoryButton_Click(object sender, EventArgs e)
        {
            CategoriesForm form = new CategoriesForm();
            form.ShowDialog();
        }

        private void itemsButton_Click(object sender, EventArgs e)
        {
            ItemsForm form = new ItemsForm();
            form.ShowDialog();
        }
    }
}

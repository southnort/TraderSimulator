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
    public partial class BuyOrderForm : __BaseForm
    {
        public BuyOrder order;

        public BuyOrderForm(BuyOrder order) : base()
        {
            InitializeComponent();
            this.order = order;

            LoadFields();
        }

        private void LoadFields()
        {
            itemNameLabel.Text = order.Item.name;
            priceNumericUpDown.Value = order.price;
            countNumericUpDown.Value = order.count;            
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            var player = Program.player;
            decimal summ = order.price * order.count;
            if (player.money < summ)
            {
                MessageBox.Show("Недостаточно денег");
            }
            else
            {
                player.money -= summ;
                DialogResult = DialogResult.OK;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void priceNumericUpDown_KeyUp(object sender, KeyEventArgs e)
        {
            order.price = ((NumericUpDown)sender).Value;
            totalSummLabel.Text = (order.price * order.count).ToMoney();
        }

        private void countNumericUpDown_KeyPress(object sender, KeyPressEventArgs e)
        {
            order.count = (int)((NumericUpDown)sender).Value;
            totalSummLabel.Text = (order.price * order.count).ToMoney();
        }
    }
}

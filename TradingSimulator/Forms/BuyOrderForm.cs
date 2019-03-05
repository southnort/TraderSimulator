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
            if (player.Money < summ)
            {
                MessageBox.Show("Недостаточно денег");
            }

            else if (order.count < 1)
            {
                MessageBox.Show("Укажите количество");
            }

            else
            {
                player.Money -= summ;
                long changeTime = DateTime.Now.AddMinutes(5).DateToLong();
                long expireTime = DateTime.Now.AddDays(3).DateToLong();

                order.allowChangeTime = changeTime;
                order.expireTime = expireTime;
                DialogResult = DialogResult.OK;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void priceNumericUpDown_KeyUp(object sender, KeyEventArgs e)
        {
            order.price = priceNumericUpDown.Value;
            order.count = (int)countNumericUpDown.Value;
           
            totalSummLabel.Text = (order.price * order.count).ToMoney();
        }

        private void countNumericUpDown_KeyPress(object sender, KeyPressEventArgs e)
        {
            order.price = priceNumericUpDown.Value;
            order.count = (int)countNumericUpDown.Value;

            totalSummLabel.Text = (order.price * order.count).ToMoney();
        }
    }
}

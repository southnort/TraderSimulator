using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TradingSimulator.Classes;

namespace TradingSimulator.Forms
{
    public partial class CargoView : UserControl
    {
        private Cargo cargo;

        public CargoView(Cargo cargo)
        {
            InitializeComponent();

            this.cargo = cargo;
            itemNameLabel.Text = cargo.Item.name;
            itemCountLabel.Text = "x " + cargo.count;
        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            TradingForm form = new TradingForm(cargo.Item);
            form.ShowDialog();
            ((Panel)Parent).Size = ((Panel)Parent).Size;
        }

        private void dropButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                $"Выбросить {cargo.Item.name} x {cargo.count}?",
                "Удалить",
                MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                Program.player.Cargos.Remove(cargo);
                Hide();
            }

        }

        
    }
}

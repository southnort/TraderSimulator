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
        public CargoView(Cargo cargo)
        {
            InitializeComponent();

            itemNameLabel.Text = cargo.Item.name;
            itemCountLabel.Text = "x " + cargo.count;
        }
    }
}

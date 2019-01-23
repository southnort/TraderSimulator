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
    public partial class StorageForm : __BaseForm
    {
        private int iconOffset = 15; //расстояние между плитками
        private int iconWidth = 140;
        private int iconHeight = 100;


        public StorageForm() : base()
        {
            InitializeComponent();
            ReloadPanel();
        }

        private void ReloadPanel()
        {
            ClearPanel();
            LoadPanel(Program.player.Cargos.ToList());
        }


        private void ClearPanel()
        {
            storagePanel.Controls.Clear();
        }

        private void LoadPanel(List<Cargo> list)
        {
            int rowCount = storagePanel.Width /
                (iconOffset + iconWidth);

    здесь

        }

    }
}

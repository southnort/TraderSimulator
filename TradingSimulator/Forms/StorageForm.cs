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

            for (int i = 0; i < list.Count; i++)
            {
                CargoView view = new CargoView(list[i]);
                int x = i % rowCount * (iconOffset + iconWidth);
                int y = i / rowCount * (iconOffset + iconHeight);
                storagePanel.Controls.Add(view);

                view.Location = new Point(x, y);
            }

        }

        private void storagePanel_SizeChanged(object sender, EventArgs e)
        {
            ReloadPanel();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradingSimulator.Forms
{
    public partial class __BaseForm : Form
    {
        public __BaseForm()
        {
            KeyPreview = true;
            KeyUp += EscapeKeyPressed;
            InitializeComponent();
        }


        protected virtual void EscapeKeyPressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
            }            
        }
        
    }
}

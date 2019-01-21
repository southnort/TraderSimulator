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
    public partial class CategoriesForm : Form
    {
        
        public CategoriesForm()
        {
            InitializeComponent();

            

        }

        private void RefreshTable(List<ItemCategory> list)
        {
           

            categoriesDataGridView.DataSource =
                list;
        }

        private void addCategoryButton_Click(object sender, EventArgs e)
        {
            AddNewForm form = new AddNewForm();


            if (form.ShowDialog() == DialogResult.OK)
            {

                var category = new ItemCategory { name = form.field1 };
               



               

            }



        }
    }
}

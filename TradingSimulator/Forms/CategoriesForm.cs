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
    public partial class CategoriesForm : __BaseForm
    {

        public CategoriesForm() : base()
        {
            InitializeComponent();

            RefreshTable();

        }

        private void RefreshTable()
        {

            categoriesDataGridView.DataSource =
               Program.dataBase.itemCategories.ToList();

        }

        private void addCategoryButton_Click(object sender, EventArgs e)
        {
            AddNewCategoryForm form = new AddNewCategoryForm();


            if (form.ShowDialog() == DialogResult.OK)
            {
                var category = new ItemCategory { name = form.field1 };

                var context = Program.dataBase;

                context.itemCategories.Add(category);
                context.SaveChanges();

                RefreshTable();

            }

        }




    }
}

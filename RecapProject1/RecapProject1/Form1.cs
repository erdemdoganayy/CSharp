using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapProject1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListProducts();
            ListCategories();
        }
        private void ListProducts()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dgwProduct.DataSource = context.Products.ToList();
            }
        }

        private void ListCategories()
        {

            using (NorthwindContext context = new NorthwindContext())
            {
                cbxCategory.DataSource = context.Categories.ToList();
                cbxCategory.ValueMember = "CategoryId";
                cbxCategory.DisplayMember = "CategoryName";
            }

        }

        private void ListProductsByCategory(int categoryId)
        {

            using (NorthwindContext context = new NorthwindContext())
            {
                dgwProduct.DataSource = context.Products.Where(p=>p.CategoryId==categoryId).ToList();
            }

        }
        private void ListSearchProductName(string key, int categoryId)
        {

            using (NorthwindContext context = new NorthwindContext())
            {
                dgwProduct.DataSource = context.Products.Where(p => p.ProductName.ToLower().Contains(key.ToLower())).Where(p=>p.CategoryId == categoryId).ToList();
            }

        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch
            {
            }
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            string key = txbSearch.Text;
            int categoryId = Convert.ToInt16(cbxCategory.SelectedValue);
            if (string.IsNullOrEmpty(key))
            {
                ListProducts();
            }
            else
            {
                ListSearchProductName(key, categoryId);
            }
        }
    }
}

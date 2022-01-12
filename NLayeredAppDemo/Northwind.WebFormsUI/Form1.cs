using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
            _categoryService = new CategoryManager(new EfCategoryDal());
        }
        private IProductService _productService;
        private ICategoryService _categoryService;
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
        }

        private void LoadCategories()
        {
            cbxCategories.DataSource = _categoryService.GetAll();
            cbxCategories.DisplayMember = "CategoryName";
            cbxCategories.ValueMember = "CategoryId";

            //Form yüklenirken ekleme combo box otomatik dolu gelsin diye eklendi
            cbxCategoryAdd.DataSource = _categoryService.GetAll();
            cbxCategoryAdd.DisplayMember = "CategoryName";
            cbxCategoryAdd.ValueMember = "CategoryId";

            //Form yüklenirken güncelleme combo box otomatik dolu gelsin diye eklendi
            cbxCategoryUpdate.DataSource = _categoryService.GetAll();
            cbxCategoryUpdate.DisplayMember = "CategoryName";
            cbxCategoryUpdate.ValueMember = "CategoryId";
        }

        public void LoadProducts()
        {
            dgwProducts.DataSource = _productService.GetAll();
        }

        private void cbxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProducts.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategories.SelectedValue));
            }
            catch
            {


            }
        }

        private void tbxProductName_TextChanged(object sender, EventArgs e)
        {
            if (tbxProductName.Text == "")
            {
                LoadProducts();
            }
            else
            {
                dgwProducts.DataSource = _productService.GetProductsByProductName(tbxProductName.Text);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productService.Add(new Product
            {
                CategoryId = Convert.ToInt32(cbxCategoryAdd.SelectedValue),
                ProductName = tbxProductNameAdd.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPriceAdd.Text),
                QuantityPerUnit = tbxQuantityPerUnitAdd.Text,
                UnitsInStock = Convert.ToInt16(tbxStockAmountAdd.Text),

            });
            LoadProducts();
            MessageBox.Show("Ürün Eklendi !");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productService.Update(new Product
            {
                ProductId = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                CategoryId = Convert.ToInt32(dgwProducts.CurrentRow.Cells[1].Value),
                ProductName = tbxProductNameUpdate.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text),
                QuantityPerUnit = tbxQuantityPerUnitUpdate.Text,
                UnitsInStock = Convert.ToInt16(tbxStockAmountUpdate.Text),
            });
            LoadProducts();
            MessageBox.Show("Ürün Güncellendi !");
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxProductNameUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            cbxCategoryUpdate.SelectedValue = dgwProducts.CurrentRow.Cells[1].Value;
            tbxUnitPriceUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
            tbxStockAmountUpdate.Text = dgwProducts.CurrentRow.Cells[4].Value.ToString();
            tbxQuantityPerUnitUpdate.Text = dgwProducts.CurrentRow.Cells[5].Value.ToString();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgwProducts.CurrentRow != null)
            {
                _productService.Delete(new Product { ProductId = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value) });
            }

            LoadProducts();
            MessageBox.Show("Ürün Silindi !");
        }
    }
}

using IFSPStore.App.Base;
using IFSPStore.App.ViewModel;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validators;
using System;
using System.Xml.Linq;

namespace IFSPStore.App.Register
{
    public partial class ProductForm : BaseForm
    {
        private IBaseService<Product> _productService;
        private IBaseService<Category> _categoryService;
        private List<ProductViewModel>? products;
        public ProductForm(IBaseService<Product> productService, IBaseService<Category> categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
            InitializeComponent();
            LoadCategories();
        }

        private void LoadCategories()
        {
            txtCategory.ValueMember = "Id";
            txtCategory.DisplayMember = "Name";
            txtCategory.DataSource = _categoryService.Get<CategoryViewModel>().ToList();
        }

        private void FormToObject(Product product)
        {
            product.Name = txtName.Text;
            product.Price = Decimal.Parse(txtPrice.Text);
            product.Quantity = Int32.Parse(txtQuantity.Text);
            product.PurchaseDate = DateTime.Now;
            product.SalesUnit = txtSalesUnit.Text;

            if (int.TryParse(txtCategory.SelectedValue!.ToString(), out var idGroup))
            {
                var category = _categoryService.GetById<Category>(idGroup);
                product.Category = category;
            }
        }
        protected override void Save()
        {
            try
            {
                if (IsEditMode)
                {
                    int.TryParse(txtId.Text, out int id);
                    var product = _productService.GetById<Product>(id);
                    FormToObject(product);
                    product = _productService.Update<Product, Product, ProductValidator>(product);
                }
                else
                {
                    var product = new Product();
                    FormToObject(product);
                    _productService.Add<Product, Product, ProductValidator>(product);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                @"IFSP Store", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        protected override void Delete(int id)
        {
            try
            {
                _productService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                @"IFSP Store", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        protected override void PopulateGrid()
        {
            products = _productService.Get<ProductViewModel>().ToList();
            dataGridViewList.DataSource = products;
            dataGridViewList.Columns["Name"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewList.Columns["IdCategory"]!.Visible = false;
        }

        protected override void GridToForm(DataGridViewRow? record)
        {
            txtId.Text = record!.Cells["Id"].Value.ToString();
            txtName.Text = record.Cells["Name"].Value.ToString();
            txtPrice.Text = record.Cells["Price"].Value.ToString();
            txtQuantity.Text = record.Cells["Quantity"].Value.ToString();
            txtSalesUnit.Text = record.Cells["SalesUnit"].Value.ToString();
            txtCategory.SelectedValue = record.Cells["IdCategory"].Value.ToString();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {

        }
    }
}
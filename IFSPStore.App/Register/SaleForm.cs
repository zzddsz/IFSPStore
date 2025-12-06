using IFSPStore.App.Base;
using IFSPStore.App.ViewModel;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validators;
using MySqlX.XDevAPI;
using System.Globalization;

namespace IFSPStore.App.Register
{
    public partial class SaleForm : BaseForm
    {
        private List<SaleItemViewModel> _saleItems;
        private readonly IBaseService<Sale> _saleService;
        private readonly IBaseService<User> _userService;
        private readonly IBaseService<Costumer> _customerService;
        private readonly IBaseService<Product> _productService;
        private List<SaleViewModel>? sales;

        public SaleForm(IBaseService<Sale> saleService, IBaseService<User> userService, IBaseService<Costumer> customerService, IBaseService<Product> productService)
        {
            _saleService = saleService;
            _userService = userService;
            _customerService = customerService;
            _productService = productService;
            _saleItems = new List<SaleItemViewModel>();
            InitializeComponent();
            LoadCombo();
            PopulateGridItemsSale();
            New();
        }

        private void LoadCombo()
        {
            txtUser.ValueMember = "Id";
            txtUser.DisplayMember = "Name";
            txtUser.DataSource = _userService.Get<User>().ToList();

            txtCustomer.ValueMember = "Id";
            txtCustomer.DisplayMember = "Name";
            txtCustomer.DataSource = _customerService.Get<Costumer>().ToList();

            txtProduct.ValueMember = "Id";
            txtProduct.DisplayMember = "Name";
            txtProduct.DataSource = _productService.Get<Product>().ToList();
        }

        private void FormToObject(Sale sale)
        {
            sale.SaleDate = DateTime.Now;

            if (int.TryParse(txtUser.SelectedValue!.ToString(), out var idUser))
            {
                var user = _userService.GetById<User>(idUser);
                sale.Salesman = user;
            }

            if (int.TryParse(txtCustomer.SelectedValue!.ToString(), out var idCustomer))
            {
                var customer = _customerService.GetById<Costumer>(idCustomer);
                sale.Customer = customer;
            }
            sale.SaleTotal = _saleItems.Sum(x => x.TotalPrice);

            foreach (var item in _saleItems)
            {
                var itemSale = new SaleItem
                {
                    Sale = sale,
                    Product = _productService.GetById<Product>(item.IdProduct),
                    UnitPrice = item.UnitPrice,
                    Quantity = item.Quantity,
                    TotalPrice = item.TotalPrice
                };

                sale.SaleItens.Add(itemSale);
            }

        }

        protected override void New()
        {
            base.New();
            _saleItems.Clear();
            PopulateGridItemsSale();
            txtDateSale.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        protected override void Save()
        {
            try
            {
                if (IsEditMode)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var sale = _saleService.GetById<Sale>(id);
                        FormToObject(sale);
                        sale = _saleService.Update<Sale, Sale, SaleValidator>(sale);
                    }
                }
                else
                {
                    var sale = new Sale();
                    FormToObject(sale);
                    sale = _saleService.Add<Sale, Sale, SaleValidator>(sale);
                }

                tabControlRegister.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Delete(int id)
        {
            try
            {
                _saleService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void PopulateGrid()
        {
            var includes = new List<string>() { "Customer", "Salesman" };
            sales = _saleService.Get<SaleViewModel>(includes).ToList();
            dataGridViewList.DataSource = sales;
            dataGridViewList.Columns["IdSalesman"]!.Visible = false;
            dataGridViewList.Columns["IdCustomer"]!.Visible = false;
            dataGridViewList.Columns["SaleTotal"].DefaultCellStyle.Format = "C2";
            dataGridViewList.Columns["SaleTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        protected override void GridToForm(DataGridViewRow? record)
        {
            int.TryParse(record?.Cells["Id"].Value.ToString(), out var id);
            txtId.Text = record?.Cells["Id"].Value.ToString();
            txtUser.SelectedValue = record?.Cells["IdSalesman"].Value;
            txtCustomer.SelectedValue = record?.Cells["IdCustomer"].Value;
            txtDateSale.Text = DateTime.TryParse(record?.Cells["SaleDate"].Value.ToString(), out var dataC)
               ? dataC.ToString("g")
               : "";

            var includes = new List<string>() { "Customer", "User", "Items", "Items.Product" };
            var sale = _saleService.GetById<Sale>(id);
            _saleItems = new List<SaleItemViewModel>();
            foreach (var item in sale.SaleItens)
            {
                var saleItem = new SaleItemViewModel
                {
                    Id = item.Id,
                    IdProduct = item.Product!.Id,
                    Product = item.Product!.Name,
                    TotalPrice = item.TotalPrice,
                    Quantity = item.Quantity,
                    UnitPrice = item.UnitPrice
                };
                _saleItems.Add(saleItem);
            }
            PopulateGridItemsSale();

        }

        private void PopulateGridItemsSale()
        {
            var source = new BindingSource();
            source.DataSource = _saleItems.ToArray();
            dataGridViewItems.DataSource = source;
            dataGridViewItems.Columns["Id"]!.Visible = false;
            dataGridViewItems.Columns["IdProduct"]!.HeaderText = @"Id.Product";
            dataGridViewItems.Columns["UnitPrice"]!.DefaultCellStyle.Format = "C2";
            dataGridViewItems.Columns["UnitPrice"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewItems.Columns["TotalPrice"]!.DefaultCellStyle.Format = "C2";
            dataGridViewItems.Columns["TotalPrice"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewItems.Columns["Quantity"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidaItem())
            {
                var saleItem = new SaleItemViewModel();
                if (int.TryParse(txtProduct.SelectedValue.ToString(), out var idProduct))
                {
                    var product = _productService.GetById<Product>(idProduct);
                    saleItem.IdProduct = product.Id;
                    saleItem.Product = product.Name;
                }

                if (decimal.TryParse(txtUnitValue.Text, NumberStyles.Currency, CultureInfo.CurrentCulture.NumberFormat, out var UnitValue))
                {
                    saleItem.UnitPrice = UnitValue;
                }
                if (int.TryParse(txtQuantity.Text, out var qtd))
                {
                    saleItem.Quantity = qtd;
                }

                saleItem.TotalPrice = saleItem.Quantity * saleItem.UnitPrice;

                _saleItems.Add(saleItem);
                CalcTotalSale();
                PopulateGridItemsSale();
            }
        }

        private bool ValidaItem()
        {
            return true;
        }

        private void txtUnitValue_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(txtUnitValue.Text, out double value))
                txtUnitValue.Text = string.Format(CultureInfo.CurrentCulture, @"{0:C2}", value);
            else
                txtUnitValue.Text = string.Empty;

            CalcTotalItems();
        }

        private void CalcTotalItems()
        {
            var convVlr = float.TryParse(txtUnitValue.Text, NumberStyles.Currency, CultureInfo.CurrentCulture.NumberFormat, out float UnitValue);
            var convQtd = int.TryParse(txtQuantity.Text, out int quantidade);
            if (convVlr && convQtd)
            {
                var valorTotal = quantidade * UnitValue;
                txtTotalValue.Text = string.Format(CultureInfo.CurrentCulture, "{0:C2}", valorTotal);
            }
        }

        private void CalcTotalSale()
        {
            lblValue.Text = $@"Total Value: {string.Format(CultureInfo.CurrentCulture, "{0:C2}", _saleItems.Sum(x => x.TotalPrice))}";
            lblQuantityItems.Text = $@"Products: {_saleItems.Sum(x => x.Quantity)}";
        }

        private void txtQuantity_Leave(object sender, EventArgs e)
        {
            CalcTotalItems();
        }
    }
}
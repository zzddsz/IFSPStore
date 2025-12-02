using IFSPStore.App.Base;
using IFSPStore.App.ViewModel;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validators;
using System.Globalization;

namespace IFSPStore.App.Register
{
    public partial class SaleForm : BaseForm
    {
        private List<SaleItemViewModel> _saleItems;
        private readonly IBaseService<Sale> _saleService;
        private readonly IBaseService<User> _userService;
        private readonly IBaseService<Costumer> _customerService; // Mantido Costumer conforme sua Entidade
        private readonly IBaseService<Product> _productService;
        private List<SaleViewModel>? sales;

        public SaleForm(IBaseService<Sale> saleService,
                        IBaseService<User> userService,
                        IBaseService<Costumer> customerService,
                        IBaseService<Product> productService)
        {
            _saleService = saleService;
            _userService = userService;
            _customerService = customerService;
            _productService = productService;
            _saleItems = new List<SaleItemViewModel>();

            InitializeComponent();
        }

        private void LoadCombo()
        {
            // Carrega usuários
            var users = _userService.Get<User>().ToList();
            txtUser.ValueMember = "Id";
            txtUser.DisplayMember = "Name";
            txtUser.DataSource = users;

            // Carrega clientes
            var customers = _customerService.Get<Costumer>().ToList();
            txtCustomer.ValueMember = "Id";
            txtCustomer.DisplayMember = "Name";
            txtCustomer.DataSource = customers;

            // Carrega produtos
            var products = _productService.Get<Product>().ToList();
            txtProduct.ValueMember = "Id";
            txtProduct.DisplayMember = "Name";
            txtProduct.DataSource = products;
        }

        private void FormToObject(Sale sale)
        {
            sale.SaleDate = DateTime.Now;

            // Proteção para evitar crash se nada estiver selecionado
            if (txtUser.SelectedValue != null && int.TryParse(txtUser.SelectedValue.ToString(), out var idUser))
            {
                var user = _userService.GetById<User>(idUser);
                sale.Salesman = user;
            }

            if (txtCustomer.SelectedValue != null && int.TryParse(txtCustomer.SelectedValue.ToString(), out var idCustomer))
            {
                var customer = _customerService.GetById<Costumer>(idCustomer);
                sale.Costomer = customer; // Mantido Costomer (erro de digitação da entidade original)
            }

            // Mapeia os itens da tela para a Entidade
            // Nota: Em cenários reais de Edição, é ideal limpar os itens antigos do banco ou fazer merge.
            // Aqui, estamos recriando a lista baseada na tela.
            sale.SaleItems = new List<SaleItem>();
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
                sale.SaleItems.Add(itemSale);
            }

            sale.SaleTotal = _saleItems.Sum(x => x.TotalPrice);
        }

        protected override void New()
        {
            base.New();
            _saleItems.Clear();
            PopulateGridItemsSale();
            txtDateSale.Text = DateTime.Now.ToString("dd/MM/yyyy");
            CalcTotalSale(); // Reseta os labels de total
            LoadCombo(); // Garante que combos estão recarregados
        }

        protected override void Save()
        {
            try
            {
                // Validação básica antes de tentar salvar
                if (txtUser.SelectedValue == null)
                {
                    MessageBox.Show("Selecione um Vendedor.", "IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtCustomer.SelectedValue == null)
                {
                    MessageBox.Show("Selecione um Cliente.", "IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (_saleItems.Count == 0)
                {
                    MessageBox.Show("A venda precisa ter pelo menos um item.", "IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (IsEditMode)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var sale = _saleService.GetById<Sale>(id);
                        if (sale != null)
                        {
                            FormToObject(sale);
                            _saleService.Update<Sale, Sale, SaleValidator>(sale);
                        }
                    }
                }
                else
                {
                    var sale = new Sale();
                    FormToObject(sale);
                    _saleService.Add<Sale, Sale, SaleValidator>(sale);
                }

                tabControlRegister.SelectedIndex = 1;
                PopulateGrid(); // Atualiza a grid principal após salvar
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
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void PopulateGrid()
        {
            try
            {
                // Verifica o nome correto das propriedades de navegação na sua Entidade Sale
                var includes = new List<string>() { "Costomer", "Salesman" };
                sales = _saleService.Get<SaleViewModel>(includes).ToList();
                dataGridViewList.DataSource = sales;

                // Oculta colunas de ID e formata moeda
                if (dataGridViewList.Columns["IdSalesman"] != null) dataGridViewList.Columns["IdSalesman"].Visible = false;
                if (dataGridViewList.Columns["IdCustomer"] != null) dataGridViewList.Columns["IdCustomer"].Visible = false;

                if (dataGridViewList.Columns["SaleTotal"] != null)
                {
                    dataGridViewList.Columns["SaleTotal"].DefaultCellStyle.Format = "C2";
                    dataGridViewList.Columns["SaleTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar lista: " + ex.Message);
            }
        }

        protected override void GridToForm(DataGridViewRow? record)
        {
            if (record == null) return;

            int.TryParse(record.Cells["Id"].Value?.ToString(), out var id);
            txtId.Text = record.Cells["Id"].Value?.ToString();

            // Carrega os combos com segurança
            txtUser.SelectedValue = record.Cells["IdSalesman"].Value;
            txtCustomer.SelectedValue = record.Cells["IdCustomer"].Value;

            if (DateTime.TryParse(record.Cells["SaleDate"].Value?.ToString(), out var dataC))
                txtDateSale.Text = dataC.ToString("dd/MM/yyyy");

            // Carrega os itens da venda do banco
            var sale = _saleService.GetById<Sale>(id);
            if (sale != null)
            {
                _saleItems = new List<SaleItemViewModel>();
                if (sale.SaleItems != null)
                {
                    foreach (var item in sale.SaleItems)
                    {
                        var saleItem = new SaleItemViewModel
                        {
                            Id = item.Id,
                            IdProduct = item.Product != null ? item.Product.Id : 0,
                            Product = item.Product != null ? item.Product.Name : "Produto Removido",
                            TotalPrice = item.TotalPrice,
                            Quantity = item.Quantity,
                            UnitPrice = item.UnitPrice
                        };
                        _saleItems.Add(saleItem);
                    }
                }
            }

            PopulateGridItemsSale();
            CalcTotalSale(); // IMPORTANTE: Atualiza os labels de total ao carregar
        }

        private void PopulateGridItemsSale()
        {
            dataGridViewItems.DataSource = null; // Reset para forçar atualização
            dataGridViewItems.DataSource = _saleItems;

            // Configurações visuais da Grid de Itens
            if (dataGridViewItems.Columns["Id"] != null)
                dataGridViewItems.Columns["Id"].Visible = false;

            if (dataGridViewItems.Columns["IdProduct"] != null)
                dataGridViewItems.Columns["IdProduct"].HeaderText = @"Id.Product";

            if (dataGridViewItems.Columns["UnitPrice"] != null)
            {
                dataGridViewItems.Columns["UnitPrice"].DefaultCellStyle.Format = "C2";
                dataGridViewItems.Columns["UnitPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (dataGridViewItems.Columns["TotalPrice"] != null)
            {
                dataGridViewItems.Columns["TotalPrice"].DefaultCellStyle.Format = "C2";
                dataGridViewItems.Columns["TotalPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidaItem())
            {
                if (int.TryParse(txtProduct.SelectedValue?.ToString(), out var idProduct))
                {
                    var product = _productService.GetById<Product>(idProduct);
                    if (product == null) return;

                    // Lógica para DECIMAL (Dinheiro)
                    if (!decimal.TryParse(txtUnitValue.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out var unitValue)) return;
                    if (!decimal.TryParse(txtQuantity.Text, out var qtd)) return;

                    // Verifica se o produto JÁ ESTÁ na lista
                    var itemExistente = _saleItems.FirstOrDefault(x => x.IdProduct == idProduct);

                    if (itemExistente != null)
                    {
                        // Se já existe, só soma a quantidade e recalcula
                        itemExistente.Quantity += qtd;
                        itemExistente.TotalPrice = itemExistente.Quantity * itemExistente.UnitPrice;
                    }
                    else
                    {
                        // Se não existe, cria um novo
                        var saleItem = new SaleItemViewModel
                        {
                            IdProduct = product.Id,
                            Product = product.Name,
                            UnitPrice = unitValue,
                            Quantity = qtd,
                            TotalPrice = qtd * unitValue
                        };
                        _saleItems.Add(saleItem);
                    }

                    CalcTotalSale();
                    PopulateGridItemsSale();
                }
            }
        }

        private bool ValidaItem()
        {
            if (txtProduct.SelectedValue == null)
            {
                MessageBox.Show("Selecione um Produto!", "IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtQuantity.Text, out var qtd) || qtd <= 0)
            {
                MessageBox.Show("Informe uma quantidade válida!", "IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtUnitValue.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out var valor) || valor <= 0)
            {
                MessageBox.Show("Informe um valor unitário válido!", "IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void txtUnitValue_Leave(object sender, EventArgs e)
        {
            // Formata para moeda ao sair do campo
            if (decimal.TryParse(txtUnitValue.Text, out decimal value))
                txtUnitValue.Text = string.Format(CultureInfo.CurrentCulture, "{0:C2}", value);
            else
                txtUnitValue.Text = string.Format(CultureInfo.CurrentCulture, "{0:C2}", 0);

            CalcTotalItems();
        }

        private void txtQuantity_Leave(object sender, EventArgs e)
        {
            CalcTotalItems();
        }

        private void CalcTotalItems()
        {
            // Calcula o total parcial (Preço x Qtd) nos TextBoxes
            var convVlr = decimal.TryParse(txtUnitValue.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal unitValue);
            var convQtd = decimal.TryParse(txtQuantity.Text, out decimal quantidade);

            if (convVlr && convQtd)
            {
                var valorTotal = quantidade * unitValue;
                txtTotalValue.Text = string.Format(CultureInfo.CurrentCulture, "{0:C2}", valorTotal);
            }
        }

        private void CalcTotalSale()
        {
            // Atualiza os Labels com o resumo da venda
            if (_saleItems != null && _saleItems.Any())
            {
                decimal total = _saleItems.Sum(x => x.TotalPrice);
                decimal qtd = _saleItems.Sum(x => x.Quantity);

                lblValue.Text = $@"Total Value: {total.ToString("C2")}";
                lblQuantityItems.Text = $@"Products: {qtd}";
            }
            else
            {
                lblValue.Text = @"Total Value: R$ 0,00";
                lblQuantityItems.Text = @"Products: 0";
            }
        }

        private void SaleForm_Load(object sender, EventArgs e)
        {
            LoadCombo();
            New();
        }
    }
}
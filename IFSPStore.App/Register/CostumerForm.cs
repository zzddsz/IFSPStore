using IFSPStore.App.Base;
using IFSPStore.App.ViewModel;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validators;
using MySqlX.XDevAPI;
using System.Xml.Linq;

namespace IFSPStore.App.Register
{
    public partial class CostumerForm : BaseForm
    {
        private IBaseService<Costumer> _costumerService;
        private IBaseService<City> _cityService;
        private List<CostumerViewModel>? costumers;
        public CostumerForm(IBaseService<Costumer> costumerService, IBaseService<City> cityService)
        {
            _costumerService = costumerService;
            _cityService = cityService;
            InitializeComponent();
            LoadCities();
        }

        private void LoadCities()
        {
            txtCity.ValueMember = "Id";
            txtCity.DisplayMember = "NameState";
            txtCity.DataSource = _cityService.Get<CityViewModel>().ToList();
        }

        private void FormToObject(Costumer costumer)
        {
            costumer.Name = txtName.Text;
            costumer.Address = txtAddress.Text;
            costumer.Document = txtDocument.Text;
            costumer.District = txtDistrict.Text;

            if (int.TryParse(txtCity.SelectedValue!.ToString(), out var idGroup))
            {
                var city = _cityService.GetById<City>(idGroup);
                costumer.City = city;
            }
        }
        protected override void Save()
        {
            try
            {
                if (IsEditMode)
                {
                    int.TryParse(txtId.Text, out int id);
                    var costumer = _costumerService.GetById<Costumer>(id);
                    FormToObject(costumer);
                    costumer = _costumerService.Update<Costumer, Costumer, CostumerValidator>(costumer);
                }
                else
                {
                    var costumer = new Costumer();
                    FormToObject(costumer);
                    _costumerService.Add<Costumer, Costumer, CostumerValidator>(costumer);
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
                _costumerService.Delete(id);
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
            costumers = _costumerService.Get<CostumerViewModel>().ToList();
            dataGridViewList.DataSource = costumers;
            dataGridViewList.Columns["Name"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewList.Columns["IdCity"]!.Visible = false;
        }

        protected override void GridToForm(DataGridViewRow? record)
        {
            txtId.Text = record!.Cells["Id"].Value.ToString();
            txtName.Text = record.Cells["Name"].Value.ToString();
            txtAddress.Text = record.Cells["Address"].Value.ToString();
            txtDocument.Text = record.Cells["Document"].Value.ToString();
            txtDistrict.Text = record.Cells["District"].Value.ToString();
            txtCity.SelectedValue = record.Cells["IdCity"].Value.ToString();
        }

        private void CostumerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
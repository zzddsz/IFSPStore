using IFSPStore.App.Base;
using IFSPStore.App.ViewModel;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validators;

namespace IFSPStore.App.Register
{
    public partial class CityForm : BaseForm
    {
        private readonly IBaseService<City> _cityService;
        private List<CityViewModel>? cities;

        public CityForm(IBaseService<City> cityService)
        {
            _cityService = cityService;
            InitializeComponent();
        }

        private void FormToObject(City city)
        {
            city.Name = txtName.Text;
            city.State = txtState.Text;
        }

        protected override void Save()
        {
            try
            {
                if (IsEditMode)
                {
                    if (int.TryParse(txtId.Text, out int id))
                    {
                        var city = _cityService.GetById<City>(id);
                        if (city != null)
                        {
                            FormToObject(city);
                            _cityService.Update<City, City, CityValidator>(city);
                        }
                    }
                }
                else
                {
                    var city = new City();
                    FormToObject(city);
                    _cityService.Add<City, City, CityValidator>(city);
                }
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
                _cityService.Delete(id);
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
                cities = _cityService.Get<CityViewModel>().ToList();
                dataGridViewList.DataSource = cities;

                if (dataGridViewList.Columns["Name"] != null)
                {
                    dataGridViewList.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Erro ao carregar lista", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void GridToForm(DataGridViewRow? record)
        {
            if (record == null) return;

            txtId.Text = record.Cells["Id"].Value?.ToString();
            txtName.Text = record.Cells["Name"].Value?.ToString();
            txtState.Text = record.Cells["State"].Value?.ToString();
        }

        private void CityForm_Load(object sender, EventArgs e)
        {
        }
    }
}
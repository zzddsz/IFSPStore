using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace IFSPStore.App.Register
{
    public partial class CategoryForm : Base.BaseForm
    {
        private IBaseService<Category> _categoryService;
        private List<Category>? categories;
        public CategoryForm(IBaseService<Category> categoryService)
        {
            _categoryService = categoryService;
            InitializeComponent();
        }

        private void FormToObject(Category category)
        {
            category.Name = txtName.Text;
        }

        protected override void Save()
        {
            try
            {
                if (IsEditMode)
                {
                    int.TryParse(txtId.Text, out int id);
                    var category = _categoryService.GetById(id);
                    FormToObject(category);
                    category = _categoryService.Update<Category, Category, CategoryValidator>(category);
                }
                else
                {
                    var category = new Category();
                    FormToObject(category);
                    _categoryService.Add<Category, Category, CategoryValidator>(category);
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
                _categoryService.Delete(id);
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
            categories = _categoryService.Get().ToList();
            dataGridViewList.DataSource = categories;
            dataGridViewList.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void GridToForm(DataGridViewRow? record)
        {
            txtId.Text = record.Cells["Id"].Value.ToString();
            txtName.Text = record.Cells["Name"].Value.ToString();
        }
    }
}
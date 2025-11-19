using Microsoft.EntityFrameworkCore.Query.Internal;
using Mysqlx.Crud;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;

//DD

namespace IFSPStore.App.Base
{
    public partial class BaseForm : MaterialForm
    {
        #region Variables
        protected bool IsEditMode = false;
        #endregion

        #region Constructor Method
        public BaseForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Are you sure cancel?", @"IFSP Store", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ClearFields();
                tabControlRegister.SelectedIndex = 1;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
            tabControlRegister.SelectedIndex = 1;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            New();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Are you sure you want delete?", @"IFSP Store", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var id = (int)dataGridViewList.SelectedRows[0].Cells["Id"].Value;
                Delete(id);
                PopulateGrid();
            }
            else
            {
                MessageBox.Show("Please, select any row!", @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void tabPageList_Enter(object sender, EventArgs e)
        {
            PopulateGrid();
        }
        #endregion

        #region Methodes
        private void ClearFields()
        {
            IsEditMode = false;
            foreach (var control in tabPageRegister.Controls)
            {
                if (control is MaterialTextBoxEdit textBox)
                {
                    textBox.Clear();
                }
                else if (control is MaterialMaskedTextBox maskedTextBox)
                {
                    maskedTextBox.Clear();
                }
            }
        }

        protected virtual void New()
        {
            ClearFields();
            tabControlRegister.SelectedIndex = 0;
            tabPageRegister.Focus();
        }

        protected virtual void Save()
        {

        }
        protected virtual void Delete(int id)
        {

        }
        protected virtual void Edit()
        {
            if (dataGridViewList.SelectedRows.Count > 0)
            {
                IsEditMode = true;
                var record = dataGridViewList.SelectedRows[0];
                GridToForm(record);
                tabControlRegister.SelectedIndex = 0;
                tabPageRegister.Focus();
            }
            else
            {
                MessageBox.Show("Please, select any row!", @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        protected virtual void GridToForm(DataGridViewRow? record)
        {

        }
        protected virtual void PopulateGrid()
        {

        }

        #endregion
    }
}
using IFSPStore.App.Base;
using IFSPStore.App.ViewModel;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validators;

namespace IFSPStore.App.Register
{
    public partial class UserForm : BaseForm
    {
        private readonly IBaseService<User> _userService;
        private List<UserViewModel>? users;
        public static bool loginUser;

        public UserForm(IBaseService<User> userService)
        {
            _userService = userService;
            InitializeComponent();
        }

        private void FormToObject(User user)
        {
            user.Name = txtName.Text;
            user.Login = txtLogin.Text;
            user.Email = txtEmail.Text;
            user.Password = txtPassword.Text;

            // Só define a data e ativa se for um usuário NOVO (ID == 0)
            // Se for edição, mantém a data original
            if (user.Id == 0)
            {
                user.RegisterDate = DateTime.Now;
                user.IsActive = true;
            }
        }

        protected override void Save()
        {
            try
            {
                if (IsEditMode)
                {
                    // Tenta converter o ID. Se falhar, avisa.
                    if (int.TryParse(txtId.Text, out int id))
                    {
                        var user = _userService.GetById<User>(id);
                        if (user != null)
                        {
                            FormToObject(user);
                            _userService.Update<User, User, UserValidator>(user);
                        }
                    }
                }
                else
                {
                    var user = new User();
                    FormToObject(user);
                    _userService.Add<User, User, UserValidator>(user);

                    // Se for cadastro vindo da tela de Login
                    if (loginUser)
                    {
                        MainForm.user = user;
                        loginUser = false;
                        DialogResult = DialogResult.OK;
                        Close();
                    }
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
                _userService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void PopulateGrid()
        {
            users = _userService.Get<UserViewModel>().ToList();
            dataGridViewList.DataSource = users;

            // Verifica se a coluna existe antes de tentar acessar
            if (dataGridViewList.Columns["Name"] != null)
                dataGridViewList.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void GridToForm(DataGridViewRow? record)
        {
            if (record == null) return;

            // CORREÇÃO CRÍTICA: Preencher o ID
            txtId.Text = record.Cells["Id"].Value?.ToString();

            // Usamos '?.' para evitar erro se o valor vier nulo do banco
            txtName.Text = record.Cells["Name"].Value?.ToString();
            txtLogin.Text = record.Cells["Login"].Value?.ToString();
            txtEmail.Text = record.Cells["Email"].Value?.ToString();
            txtPassword.Text = record.Cells["Password"].Value?.ToString();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            // Pode deixar vazio ou carregar algo específico se precisar
        }
    }
}
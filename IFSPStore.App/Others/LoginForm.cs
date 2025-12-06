using IFSPStore.App.Infra;
using IFSPStore.App.Register;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validators;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;

namespace IFSPStore.App.Others
{
    public partial class LoginForm : MaterialForm
    {
        private readonly IBaseService<User> _userService;
        public LoginForm(IBaseService<User> userService)
        {
            _userService = userService;
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
           
            User? user = GetUser(txtLogin.Text, txtPassword.Text);

            if (user == null)
            {
                MessageBox.Show("Invalid username or password.", "IFSP Store",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!user.IsActive)
            {
                MessageBox.Show("User inactive!", "IFSP Store",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                user.LoginDate = DateTime.Now;
                user = _userService.Update<User, User, UserValidator>(user);
                MainForm.user = user;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private User? GetUser(string login, string password)
        {
            CheckUser();
            var user = _userService.Get<User>().Where(x => x.Login == login).FirstOrDefault();
            if (user == null)
                return null;
            return user.Password != password ? null : user;
        }
        private void CheckUser()
        {
            var users = _userService.Get<User>().ToList();
            if (!users.Any())
            {
                var user = new User
                {
                    Login = "admin",
                    Password = "admin",
                    Name = "Admnistrador do Sistema",
                    IsActive = true,
                    RegisterDate = DateTime.Now,
                    Email = "admin@gmail.com"
                };
                _userService.Add<User, User, UserValidator>(user);
            }
        }
        private void lblDontHave_Click(object sender, EventArgs e)
        {
            UserForm.loginUser = true;
            var userForm = ConfigureDI.serviceProvider!.GetService<UserForm>();
            userForm!.ShowDialog();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void txtLogin_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_Click(object sender, EventArgs e)
        {

        }
    }
}
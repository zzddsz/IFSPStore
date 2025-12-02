using IFSPStore.App.Infra;
using IFSPStore.App.Others;
using IFSPStore.App.Register;
using IFSPStore.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;

namespace IFSPStore.App
{
    public partial class MainForm : MaterialForm
    {
        public static User user;
        public MainForm()
        {
            InitializeComponent();
            LoadLogin();
            FormClosing += FormPrincipal_FormClosing;
        }

        private void LoadLogin()
        {
            var login = ConfigureDI.serviceProvider!.GetService<LoginForm>();
            if (login != null && !login.IsDisposed)
            {
                if (login.ShowDialog() != DialogResult.OK)
                {
                    Environment.Exit(0);
                }
                else
                {
                    lblUser.Text = $"Usuário: {user.Name}";
                }
            }
        }


        private void FormLoad<TForm>() where TForm : Form
        {
            var cad = ConfigureDI.serviceProvider!.GetService<TForm>();
            if (cad != null && !cad.IsDisposed)
            {
                cad.MdiParent = this;
                cad.Show();
            }
        }
        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLoad<UserForm>();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLoad<CategoryForm>();
        }

        private void cityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLoad<CityForm>();
        }

        private void custumerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLoad<CostumerForm>();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLoad<ProductForm>();
        }

        private void saleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLoad<SaleForm>();
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }
    }
}
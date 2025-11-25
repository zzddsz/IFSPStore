using IFSPStore.App.Infra;
using IFSPStore.App.Register;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;

namespace IFSPStore.App
{
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();
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

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLoad<CategoryForm>();
        }
    }
}
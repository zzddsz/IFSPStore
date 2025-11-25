using IFSPStore.App.Infra;
using IFSPStore.App.Base;

namespace IFSPStore.App
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConfigureDI.ConfigureServices();
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}
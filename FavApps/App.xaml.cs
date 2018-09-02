using System.Windows;

namespace FavApps
{
    public partial class App
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var favApps = new Main
            {
                DataContext = new FavAppsViewModel()
            };
            favApps.ShowDialog();
            Shutdown();
        }
    }
}
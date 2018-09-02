using System.Windows;
using FavAppsStarter.View;
using FavAppsStarter.ViewModel;

namespace FavAppsStarter
{
    public partial class App
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var favApps = new MainView
            {
                DataContext = new FavAppsViewModel()
            };
            favApps.ShowDialog();
            Shutdown();
        }
    }
}
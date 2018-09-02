using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Windows.Input;
using FavAppsStarter.Model;
using FavAppsStarter.View;

namespace FavAppsStarter.ViewModel
{
    public class FavAppsViewModel : ObservableObject
    {
        private ObservableCollection<AppGroupViewModel> _appGroups = new ObservableCollection<AppGroupViewModel>();

        private RelayCommand _openSettingsCommand;

        public FavAppsViewModel()
        {
            var groups = Database.GetAppGroups();

            AppGroups = new ObservableCollection<AppGroupViewModel>(
                groups.Select(group => new AppGroupViewModel(group)).ToList());
        }

        public ObservableCollection<AppGroupViewModel> AppGroups
        {
            get => _appGroups;
            set => SetProperty(ref _appGroups, value);
        }

        //private AppGroupViewModel _selectedAppGroup;
        //public AppGroupViewModel SelectedAppGroup
        //{
        //    get => _selectedAppGroup;
        //    set => SetProperty(ref _selectedAppGroup, value);
        //}

        [SuppressMessage("ReSharper", "UnusedMember.Global")]
        public ICommand OpenSettingsCommand
        {
            get
            {
                return _openSettingsCommand ?? (_openSettingsCommand =
                           new RelayCommand(param => OpenSettings()));
            }
        }

        private void OpenSettings()
        {
            var settings = new SettingsView
            {
                DataContext = this
            };
            settings.Show();
        }
    }
}
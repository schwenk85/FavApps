using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Input;
using FavAppsStarter.View;

namespace FavAppsStarter.ViewModel
{
    public class FavAppsViewModel : ObservableObject
    {
        private ObservableCollection<AppGroupViewModel> _appGroups = new ObservableCollection<AppGroupViewModel>();
        private AppGroupViewModel _selectedAppGroup;
        private RelayCommand _openSettingsCommand;

        public FavAppsViewModel()
        {
            AppGroups.Add(
                new AppGroupViewModel
                {
                    Title = "Media Centers",
                    AppElements = new ObservableCollection<AppElementViewModel>
                    {
                        new AppElementViewModel { Title = "Emby" },
                        new AppElementViewModel { Title = "Plex" }
                    }
                });
        }

        public ObservableCollection<AppGroupViewModel> AppGroups
        {
            get => _appGroups;
            set => SetProperty(ref _appGroups, value);
        }

        public AppGroupViewModel SelectedAppGroup
        {
            get => _selectedAppGroup;
            set => SetProperty(ref _selectedAppGroup, value);
        }

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
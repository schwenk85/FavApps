using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FavApps
{
    public class FavAppsViewModel : ObservableObject
    {
        private ObservableCollection<AppGroup> _appGroups = new ObservableCollection<AppGroup>();
        private AppGroup _selectedAppGroup;
        private RelayCommand _openSettingsCommand;

        public FavAppsViewModel()
        {

        }

        public ObservableCollection<AppGroup> AppGroups
        {
            get => _appGroups;
            set => SetProperty(ref _appGroups, value);
        }

        public AppGroup SelectedAppGroup
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
            var settings = new Settings
            {
                DataContext = this
            };
            settings.Show();
        }
    }
}
using System.Collections.ObjectModel;

namespace FavAppsStarter.ViewModel
{
    public class AppGroupViewModel : ObservableObject
    {
        private string _title;
        private ObservableCollection<AppElementViewModel> _appElements = new ObservableCollection<AppElementViewModel>();
        private AppElementViewModel _selectedAppElements;

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        public ObservableCollection<AppElementViewModel> AppElements
        {
            get => _appElements;
            set => SetProperty(ref _appElements, value);
        }

        public AppElementViewModel SelectedAppElements
        {
            get => _selectedAppElements;
            set => SetProperty(ref _selectedAppElements, value);
        }
    }
}

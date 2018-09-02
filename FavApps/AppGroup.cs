using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavApps
{
    public class AppGroup : ObservableObject
    {
        private string _title;
        private ObservableCollection<AppElement> _appElements = new ObservableCollection<AppElement>();
        private AppElement _selectedAppElements;

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        public ObservableCollection<AppElement> AppElements
        {
            get => _appElements;
            set => SetProperty(ref _appElements, value);
        }

        public AppElement SelectedAppElements
        {
            get => _selectedAppElements;
            set => SetProperty(ref _selectedAppElements, value);
        }
    }
}

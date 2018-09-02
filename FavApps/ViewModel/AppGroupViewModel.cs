using FavAppsStarter.Model;

namespace FavAppsStarter.ViewModel
{
    public class AppGroupViewModel : TreeViewItemViewModel
    {
        //private ObservableCollection<AppElementViewModel>
        //    _appElements = new ObservableCollection<AppElementViewModel>();
        //private AppElementViewModel _selectedAppElements;
        //public ObservableCollection<AppElementViewModel> AppElements
        //{
        //    get => _appElements;
        //    set => SetProperty(ref _appElements, value);
        //}
        //public AppElementViewModel SelectedAppElements
        //{
        //    get => _selectedAppElements;
        //    set => SetProperty(ref _selectedAppElements, value);
        //}

        private readonly AppGroup _group;

        public AppGroupViewModel(AppGroup group) : base(null, true)
        {
            _group = group;
        }

        public string Name
        {
            get => _group.Name;
            set
            {
                var groupName = _group.Name;
                if (SetProperty(ref groupName, value))
                {
                    _group.Name = groupName;
                }
            }
        }

        protected override void LoadChildren()
        {
            foreach (var element in Database.GetAppElements(_group))
            {
                Children.Add(new AppElementViewModel(element, this));
            }
        }
    }
}
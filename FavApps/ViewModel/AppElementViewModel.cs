using System.IO;
using System.Windows.Media.Imaging;
using FavAppsStarter.Model;

namespace FavAppsStarter.ViewModel
{
    public class AppElementViewModel : TreeViewItemViewModel
    {
        private readonly AppElement _element;

        public AppElementViewModel(AppElement element, TreeViewItemViewModel parent)
            : base(parent, true)
        {
            _element = element;
        }

        public string Name
        {
            get => _element.Name;
            set
            {
                var name = _element.Name;
                if (SetProperty(ref name, value))
                {
                    _element.Name = name;
                }
            }
        }

        public BitmapImage ImageSource
        {
            get => _element.ImageSource;
            set
            {
                var imageSource = _element.ImageSource;
                if (SetProperty(ref imageSource, value))
                {
                    _element.ImageSource = imageSource;
                }
            }
        }

        public FileInfo FullFilePath
        {
            get => _element.FullFilePath;
            set
            {
                var fullFilePath = _element.FullFilePath;
                if (SetProperty(ref fullFilePath, value))
                {
                    _element.FullFilePath = fullFilePath;
                }
            }
        }

        public string Arguments
        {
            get => _element.Arguments;
            set
            {
                var arguments = _element.Arguments;
                if (SetProperty(ref arguments, value))
                {
                    _element.Arguments = arguments;
                }
            }
        }
    }
}

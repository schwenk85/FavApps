using System.IO;
using System.Windows.Media.Imaging;

namespace FavAppsStarter.ViewModel
{
    public class AppElementViewModel : ObservableObject
    {
        private BitmapImage _imageSource;
        private string _title;
        private FileInfo _fullFilePath;
        private string _arguments;
        
        public BitmapImage ImageSource
        {
            get => _imageSource;
            set => SetProperty(ref _imageSource, value);
        }

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        public FileInfo FullFilePath
        {
            get => _fullFilePath;
            set => SetProperty(ref _fullFilePath, value);
        }

        public string Arguments
        {
            get => _arguments;
            set => SetProperty(ref _arguments, value);
        }
    }
}

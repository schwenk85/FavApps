using System.IO;
using System.Windows.Media.Imaging;

namespace FavAppsStarter.Model
{
    public class AppElement
    {
        public AppElement(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public BitmapImage ImageSource { get; set; }
        public FileInfo FullFilePath { get; set; }
        public string Arguments { get; set; }
    }
}
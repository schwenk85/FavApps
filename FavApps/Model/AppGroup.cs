using System.Collections.Generic;

namespace FavAppsStarter.Model
{
    public class AppGroup
    {
        public AppGroup(string name)
        {
            Name = name;
            AppElements = new List<AppElement>();
        }

        public string Name { get; set; }
        public List<AppElement> AppElements { get; set; }
    }
}
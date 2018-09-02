namespace FavAppsStarter.Model
{
    public static class Database
    {
        private const string GroupNameMediaCenters = "Media Centers";
        private const string GroupNameOnlineStreamingServices = "Online Streaming Services";
        private const string GroupNameGamingPortals = "Gaming Platforms";

        public static AppGroup[] GetAppGroups()
        {
            return new[]
            {
                new AppGroup(GroupNameMediaCenters),
                new AppGroup(GroupNameGamingPortals)
            };
        }

        public static AppElement[] GetAppElements(AppGroup group)
        {
            switch (group.Name)
            {
                case GroupNameMediaCenters:
                    return new[]
                    {
                        new AppElement("Emby"),
                        new AppElement("Kodi"),
                        new AppElement("Media Portal"),
                        new AppElement("Plex")
                    };
                case GroupNameOnlineStreamingServices:
                    return new[]
                    {
                        new AppElement("Netlfix"),
                        new AppElement("Amazon Prime"),
                        new AppElement("ARD Mediathek"),
                        new AppElement("ZDF Mediathek"),
                        new AppElement("RTL Now"),
                        new AppElement("Vox Now")
                    };
                case GroupNameGamingPortals:
                    return new[]
                    {
                        new AppElement("Steam"),
                        new AppElement("Origin"),
                        new AppElement("EmulationStation")
                    };
            }

            return null;
        }
    }
}
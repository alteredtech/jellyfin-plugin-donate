using MediaBrowser.Model.Plugins;

namespace Jellyfin.Plugin.Donate.Configuration
{
    public class PluginConfiguration : BasePluginConfiguration
    {
        // store configurable settings your plugin might need
        public string VenmoString { get; set; }

        public PluginConfiguration()
        {
            // set default options here
            VenmoString = "string";
        }
    }
}

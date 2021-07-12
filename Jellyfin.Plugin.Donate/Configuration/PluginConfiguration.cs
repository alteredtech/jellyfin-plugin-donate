using MediaBrowser.Model.Plugins;

namespace Jellyfin.Plugin.Donate.Configuration
{

    public class PluginConfiguration : BasePluginConfiguration
    {
        // store configurable settings your plugin might need
        public string VenmoAccount { get; set; }

        public PluginConfiguration()
        {
            // set default options here
            VenmoAccount = "string";
        }
    }
}

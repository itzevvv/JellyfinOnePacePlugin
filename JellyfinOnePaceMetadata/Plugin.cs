using MediaBrowser.Common.Configuration;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Model.Serialization;
using JellyfinOnePaceMetadata.Configuration;

class Plugin : BasePlugin<PluginConfiguration> {
    public override string Name => "One Pace Metadata Plugin";
    public override Guid Id => Guid.Parse("40ff4993-635c-4d5b-bc84-b7fb4a8ed00a");

    public static Plugin? Instance { get; private set; }

    public Plugin(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer) : base(applicationPaths, xmlSerializer) {
        Instance = this;
    }
}
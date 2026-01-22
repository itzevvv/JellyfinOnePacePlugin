using MediaBrowser.Controller;
using MediaBrowser.Controller.Plugins;
using Microsoft.Extensions.DependencyInjection;

namespace JellyfinOnePaceMetadata.Service;

class ServiceRegistrator : IPluginServiceRegistrator {
    public void RegisterServices(IServiceCollection serviceCollection, IServerApplicationHost applicationHost) {
        serviceCollection.AddSingleton<IOnePaceMetadataService, OnePaceMetadataService>();
    }
}
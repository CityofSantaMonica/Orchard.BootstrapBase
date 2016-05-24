using Orchard.UI.Resources;

namespace CSM.BootstrapBase
{
    public class ResourceManifest : IResourceManifestProvider
    {
        public void BuildManifests(ResourceManifestBuilder builder)
        {
            var manifest = builder.Add();

            manifest
                .DefineScript("CollapseContent")
                .SetUrl("CollapseContent/collapse-content.js")
                .SetDependencies("JQuery");
        }
    }
}
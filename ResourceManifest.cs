using Orchard.UI.Resources;

namespace CSM.BootstrapBase
{
    public class ResourceManifest : IResourceManifestProvider
    {
        public void BuildManifests(ResourceManifestBuilder builder)
        {
            var manifest = builder.Add();

            manifest
                .DefineScript("Bootstrap")
                .SetUrl("bootstrap/dist/bootstrap.min.js", "bootstrap/dist/bootstrap.js")
                .SetDependencies("jQuery");
        }
    }
}
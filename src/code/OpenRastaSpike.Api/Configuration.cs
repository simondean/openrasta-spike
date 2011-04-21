namespace OpenRastaSpike.Api
{
    using OpenRasta.Configuration;
    using OpenRastaSpike.Api.Handlers;
    using OpenRastaSpike.Api.Resources;

    public class Configuration : IConfigurationSource
    {
        public void Configure()
        {
            using (OpenRastaConfiguration.Manual)
            {
                ResourceSpace.Has.ResourcesOfType<product>()
                    .AtUri("/product/{productId}")
                    .HandledBy<ProductHandler>()
                    .AsXmlSerializer().ForMediaType("application/vnd.openrasta-spike.v1+xml")
                    .And.AsJsonDataContract().ForMediaType("application/vnd.openrasta-spike.v1+json")
                    .And.AsJsonDataContract().ForMediaType("text/plain");
            }
        }
    }
}
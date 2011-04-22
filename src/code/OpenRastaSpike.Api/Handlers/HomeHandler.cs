namespace OpenRastaSpike.Api.Handlers
{
    using OpenRasta.Web;
    using OpenRastaSpike.Api.Resources;

    public class HomeHandler
    {
        public object Get()
        {
            return new home
                       {
                           link = new[] {
                               new link
                                      {
                                          rel = RelationNames.ProductSearch, 
                                          href = typeof(product_search).CreateUri().AbsoluteUri
                                      }
                           }
                       };
        }
    }
}
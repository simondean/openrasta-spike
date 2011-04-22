namespace OpenRastaSpike.Api.Handlers
{
    using OpenRasta.Web;
    using OpenRastaSpike.Api.Resources;

    public class ProductSearchHandler
    {
        public object Get()
        {
            return new product_search
                       {
                           form = new form
                                      {
                                          rel = RelationNames.ProductSearch,
                                          action = typeof(product_search).CreateUri().AbsoluteUri,
                                          method = "get",
                                          input = new[]
                                                      {
                                                          new input
                                                              {
                                                                  name = "terms",
                                                                  type = "text"
                                                              }
                                                      }
                                      }
                       };
        }

        public object Post(product_search productSearch)
        {
            return new product_search
                       {
                           product = new[]
                                         {
                                             new product
                                                 {
                                                     id = 1,
                                                     name = "Wonder Soap"
                                                 },
                                             new product
                                                 {
                                                     id = 1,
                                                     name = "Regenerating Rest"
                                                 },

                                         }
                       };
        }
    }
}
using OpenRastaSpike.Api.Resources;

namespace OpenRastaSpike.Api.Handlers
{
    public class ProductHandler
    {
        public object Get(int productId)
        {
            return new product
                       {
                           id = productId, 
                           name = "Wonder Soap"
                       };
        }
    }
}
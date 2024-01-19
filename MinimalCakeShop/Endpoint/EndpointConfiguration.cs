using MinimalCakeShop.Endpoint.CakeShopEndpoint;

namespace MinimalCakeShop.Endpoint
{
    public class EndpointConfiguration 
    {
        private readonly ICakeShopEndPoint _endPoint;
        public EndpointConfiguration(ICakeShopEndPoint endPoint)
        {
            _endPoint = endPoint;
        }

        public void Register(WebApplication app)
        {
            app.MapGet("/getCakeShop",   _endPoint.GetAllCakeShop);
        }

        
    }
}

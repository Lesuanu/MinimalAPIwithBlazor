
using MinimalCakeShop_Models.CakeModels;

namespace MinimalCakeShopWeb.Services
{
    public interface ICakeShop
    {
        Task<IEnumerable<CakeShop>> GetAllCakeShop();
        Task<HttpResponseMessage> GetCakeShop();
    }
}

using MinimalCakeShop_Models.CakeModels;
using System.Net.Http.Json;

namespace MinimalCakeShopWeb.Services
{
    public class CakeShopService : ICakeShop
    {
        private readonly HttpClient _httpClient;
        public CakeShopService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<CakeShop> AddCakeShop()
        {
            // return  await _httpClient.GetAsync($"/getCakeShop");
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CakeShop>> GetAllCakeShop()
        {
            throw new NotImplementedException();
        }
    }
}

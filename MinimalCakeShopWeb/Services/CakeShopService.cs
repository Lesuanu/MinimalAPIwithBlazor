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

        public async Task<HttpResponseMessage> GetCakeShop()
        {
            var cakeShopAddition = await _httpClient.GetAsync($"/getCakeShop");
            if (cakeShopAddition == null)
            {
                throw new Exception("message was not received");
            }
            return cakeShopAddition;
        }

        public async Task<IEnumerable<CakeShop>> GetAllCakeShop()
        {
            // var result = await _httpClient.GetFromJsonAsync<CakeShop>($"/");
            // return result;
            throw new ArgumentNullException();
        }
    }
}

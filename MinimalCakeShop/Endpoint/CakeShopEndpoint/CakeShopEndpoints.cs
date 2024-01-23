using MinimalCakeShop.Abstraction;

namespace MinimalCakeShop.Endpoint.CakeShopEndpoint
{
    public class CakeShopEndpoints : ICakeShopEndPoint
    {
        private readonly ICakeShopRepository _repository;

        public CakeShopEndpoints(ICakeShopRepository repository)
        {
            _repository = repository;
        }
        public Task<IResult> AddCakeShop()
        {
            throw new NotImplementedException();
        }

        public Task<IResult> DeleteCakeShop(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult> GetAllCakeShop()
        {
            var result = await _repository.GetShop();
            return Results.Ok(result);
        }

        public Task<IResult> GetCakeShopById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> UpdateCakeShopById(string id)
        {
            throw new NotImplementedException();
        }
    }
}

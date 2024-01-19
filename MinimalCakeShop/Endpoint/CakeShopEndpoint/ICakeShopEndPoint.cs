namespace MinimalCakeShop.Endpoint.CakeShopEndpoint
{
    public interface ICakeShopEndPoint
    {
        Task<IResult> GetCakeShopById(int id);
        Task<IResult> GetAllCakeShop();
        Task<IResult> DeleteCakeShop(int id);
        Task<IResult> UpdateCakeShopById(string id);
        Task<IResult> AddCakeShop();

    }
}

using Microsoft.AspNetCore.Mvc;
using MinimalCakeShop_Models.CakeModels;
using System.Threading.Tasks;

namespace MinimalCakeShop.Abstraction
{
    public interface ICakeShopRepository
    {
        Task<CakeShop> CreateShop(CakeShop cakeShop);
        Task<CakeShop> UpdateShop(Guid id, CakeShop cakeShop);
        Task<CakeShop> DeleteShop(Guid id);
        Task<IEnumerable<CakeShop>> GetShop();
        Task<CakeShop> GetShopById(Guid id);

    }
}

using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MinimalCakeShop.Abstraction;
using MinimalCakeShop_Models.CakeModels;

namespace MinimalCakeShop.Repository
{
    public class CakeShopRepository : ICakeShopRepository
    {
        private readonly CakeShopContext _context;
        public CakeShopRepository(CakeShopContext context)
        {
            _context = context;
        }

        public async Task<CakeShop> CreateShop(CakeShop cakeShop)
        {
            var createdCakeShop = await _context.CakeShops.AddAsync(cakeShop);
            return createdCakeShop.Entity;
        }

        public async Task<CakeShop> DeleteShop(Guid id)
        {
            var shopsFound = await _context.CakeShops.FirstOrDefaultAsync(x => x.Id == id);
            if(shopsFound != null)
            {
                return shopsFound;
            }
            return new CakeShop { };
        }

        public Task<CakeShop> DeleteShop(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CakeShop>> GetShop()
        {
            var result = await _context.CakeShops.ToListAsync();
         
            return (IEnumerable<CakeShop>)result;
        }

        public async Task<CakeShop> GetShopById(Guid id)
        {
            var shopExist = await _context.CakeShops.FirstOrDefaultAsync(x => x.Id == id);
            return shopExist ??= shopExist;
        }

        public async Task<CakeShop> UpdateShop(Guid id, CakeShop cakeShop)
        {
            var shopExist = await  _context.CakeShops.FirstOrDefaultAsync(x => x.Id == id);
            if(shopExist == null)
            {
                return null;
            }
            _context.Entry<CakeShop>(cakeShop).CurrentValues.SetValues(cakeShop);
            return shopExist;                  
        }
    }
}

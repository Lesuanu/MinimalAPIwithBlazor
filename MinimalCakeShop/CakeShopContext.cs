using Microsoft.EntityFrameworkCore;
using MinimalCakeShop_Models.CakeModels;

namespace MinimalCakeShop
{
    public class CakeShopContext : DbContext
    {
        public CakeShopContext(DbContextOptions<CakeShopContext> options) : base(options)
        {
            
        }

        public DbSet<CakeShop> CakeShops { get; set; }
    }
}

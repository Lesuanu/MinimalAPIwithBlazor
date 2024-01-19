using MinimalCakeShop.Abstraction;

namespace MinimalCakeShop.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CakeShopContext _cakeShopContext;
        public ICakeShopRepository ICakeShopRepository { get => new CakeShopRepository(_cakeShopContext); }

        public UnitOfWork(CakeShopContext cakeShopContext)
        {
            _cakeShopContext = cakeShopContext;
        }
        public void SavingStuffAsync(CancellationToken cancellationToken = default)
        {
            _cakeShopContext.SaveChangesAsync(cancellationToken);
        }
    }
}

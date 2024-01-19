namespace MinimalCakeShop.Abstraction
{
    public interface IUnitOfWork
    {
        void SavingStuffAsync(CancellationToken cancellationToken = default);
    }
}

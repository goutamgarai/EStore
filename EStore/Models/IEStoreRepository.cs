namespace EStore.Models
{
    public interface IEStoreRepository
    {
        IQueryable<Product> Products { get; }
    }
}

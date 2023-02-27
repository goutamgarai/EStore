namespace EStore.Models
{
    public class EStoreRepository : IEStoreRepository
    {
        private EStoreDbContext context;
        public EStoreRepository(EStoreDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Product> Products => context.Products;
    }
}

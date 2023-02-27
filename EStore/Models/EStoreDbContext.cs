using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EStore.Models
{    
    public class EStoreDbContext : DbContext
    {
        public EStoreDbContext(DbContextOptions<EStoreDbContext> options)
            : base(options) { }
        public DbSet<Product> Products => Set<Product>();
    }
}

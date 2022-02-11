using System.Collections.Generic;
using System.Linq;
using API.Entities;

namespace API.Data
{
    public static class DBInitializer
    {
        public static void Initialize(StoreContext context)
        {
            if (context.Products.Any()) return;
            var products = new List<Product>() {
                new Product() {
                    Name = "Test 1",
                    price = 1000,
                    QuantityInStock = 100,

                },
                new Product() {
                    Name = "Test 2",
                    price = 400,
                    QuantityInStock = 300
                }
            };

            context.Products.AddRange(products);
            context.SaveChanges();
        }
    }
}
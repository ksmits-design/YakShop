using System.Collections.Generic;
using System.Linq;
using API.Entities;

namespace API.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            if (context.Products.Any()) return;

            var products = new List<Herd>
            {
                new Herd
                {
                    Name = "Yak-1",
                    Age = 4,
                    Sex ="Female",
                    Milk = 12.8,
                    Brand = "NetCore",
                    Shaveable = true,
                    DaysLastShaved = 7
                },

            };

            foreach (var product in products)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();
        }
    }
}
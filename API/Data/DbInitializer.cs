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
                    Name = "Angular Speedster Board 2000",
                    Gender =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Age = 20000,
                    PictureUrl = "/images/products/sb-ang1.png",
                    Brand = "Angular",
                    Type = "Boards",
                    DaysLastShaved = 100
                },
                new Herd
                {
                    Name = "Green Angular Board 3000",
                    Gender = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                    Age = 15000,
                    PictureUrl = "/images/products/sb-ang2.png",
                    Brand = "Angular",
                    Type = "Boards",
                    DaysLastShaved = 100
                },
                new Herd
                {
                    Name = "Yak-1",
                    Age = 4,
                    Gender ="Female",
                    PictureUrl = "/images/products/sb-core1.png",
                    Brand = "NetCore",
                    Type = "Boards",
                    DaysLastShaved = 100
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
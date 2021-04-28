using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace CampingStuff.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app
                    .ApplicationServices
                    .CreateScope()
                    .ServiceProvider
                    .GetRequiredService<StoreDbContext>();  
            
            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if(!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Kayak",
                        Description = "A boat for one person",
                        Category = "Watersports",
                        Price = 275
                    },
                    new Product
                    {
                        Name = "Lifejacket",
                        Description = "Protective and fashionable",
                        Category = "Watersports",
                        Price = 48.95m
                    },
                    new Product
                    {
                        Name = "Tent",
                        Description = "Big enough for 4 people",
                        Category = "Sleeping",
                        Price = 19.50m
                    },
                    new Product
                    {
                        Name = "Sleeping Bag",
                        Description = "Very warm, and is water proof",
                        Category = "Sleeping",
                        Price = 34.95m
                    },
                    new Product
                    {
                        Name = "Mat",
                        Description = "Put the mat under your sleeping bag for better comfort",
                        Category = "Sleeping",
                        Price = 79
                    },
                    new Product
                    {
                        Name = "Mountain Bike",
                        Description = "For better exploring",
                        Category = "Outdoor",
                        Price = 1600
                    },
                    new Product
                    {
                        Name = "Lamp",
                        Description = "To help see in the dark",
                        Category = "Outdoor",
                        Price = 29.95m
                    },
                    new Product
                    {
                        Name = "Baby Wipes",
                        Description = "Keep that butt clean",
                        Category = "Outdoor",
                        Price = 75
                    },
                    new Product
                    {
                        Name = "Grill",
                        Description = "For the master chef",
                        Category = "Outdoor",
                        Price = 1200
                    }
                );
                context.SaveChanges();
            }
        }
    }
}

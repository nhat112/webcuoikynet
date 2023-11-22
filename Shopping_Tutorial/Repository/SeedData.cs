using Microsoft.EntityFrameworkCore;
using Shopping_Tutorial.Models;

namespace Shopping_Tutorial.Repository
{
    public class SeedData
    {
        public static void SeedingData(DataContext _context)
        {
            _context.Database.Migrate();
            if (!_context.Products.Any())
            {
                CategoryModel bags = new CategoryModel { Name = "Bags", Slug = "bags", Description = "The Bags brand is well-known and influential in the world of high fashion", Status = 1 };
                CategoryModel handbags = new CategoryModel { Name = "HandBags", Slug = "HandBags", Description = "Discover HandBags latest fashion shows for both Women’s and Men’s Collections", Status = 1 };


                BrandModel gucci = new BrandModel { Name = "Gucci", Slug = "gucci", Description = "The Gucci brand is well-known and influential in the world of high fashion", Status = 1 };
                BrandModel louisvuitton = new BrandModel { Name = "LouisVuitton", Slug = "louisvuitton", Description = "Discover Louis Vuitton’s latest fashion shows for both Women’s and Men’s Collections", Status = 1 };

                _context.Products.AddRange(

                    new ProductModel { Name = "Bags", Slug = "bags", Description = "Bags is the Best", Image = "1.jpg", Category = bags, Brand = gucci, Price = 1000 },
                    new ProductModel { Name = "HandBags", Slug = "handbags", Description = "HandBags is the Best", Image = "1.jpg", Category = handbags, Brand = louisvuitton, Price = 1334 }
                );
                _context.SaveChanges();
            }
        }
    }
}

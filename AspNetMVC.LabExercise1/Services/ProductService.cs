using AspNetMVC.LabExercise1.Models;
using System.Collections.Generic;

namespace AspNetMVC.LabExercise1.Services
{
    public class ProductService
    {
        private List<Product> products;

        public ProductService()
        {
            products = new List<Product>();

            products.Add(new Product()
            {
                Id = 1,
                Name = "iPad Air 1",
                Description = "By Steve Jobs",
                Quantity = 1,
                Price = 21_000M
            });

            products.Add(new Product()
            {
                Id = 2,
                Name = "iPad Air 2",
                Description = "Better than iPad Air 1",
                Quantity = 2,
                Price = 22_000M
            });

            products.Add(new Product()
            {
                Id = 3,
                Name = "iPad Air 3",
                Description = "Better than iPad Air 2",
                Quantity = 3,
                Price = 23_000M
            });

            products.Add(new Product()
            {
                Id = 4,
                Name = "iPad Air 4",
                Description = "Better than iPad Air 3",
                Quantity = 4,
                Price = 24_000M
            });

            products.Add(new Product()
            {
                Id = 5,
                Name = "iPad Air 5",
                Description = "The Best",
                Quantity = 5,
                Price = 25_000M
            });
        }

        public List<Product> GetCatalog()
        {
            return products;
        }

        public decimal GrandTotal()
        {
            decimal grandTotal = 0M;
            foreach (Product product in products)
                grandTotal += product.TotalAmount;
            return grandTotal;
        }
    }
}

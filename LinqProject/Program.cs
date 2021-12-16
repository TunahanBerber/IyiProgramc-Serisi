using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    //linq özelliği en güçlü programlama dili c#tır
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>();
            {
                new Category { CategoryId = 1, CategoryName = "Bilgisayar" };
                new Category { CategoryId = 2, CategoryName = "Telefon" };
            }

            List<Product> products = new List<Product>
            {
                new Product { ProductId = 1, CategoryId = 1, ProductName = "Hp Pavillion", QuantityPerUnit = "32 GB Ram", UnitPrice = 20000, UnitsInStock = 5 },
                new Product{ProductId = 2, CategoryId = 1, ProductName = "Asus", QuantityPerUnit = "16 GB Ram", UnitPrice = 15000, UnitsInStock = 5 },
                new Product { ProductId = 3, CategoryId = 1, ProductName = "Monster ", QuantityPerUnit = "32 GB Ram", UnitPrice = 14000, UnitsInStock = 2 },
                new Product { ProductId = 4, CategoryId = 2, ProductName = "Xiomi", QuantityPerUnit = "128 GB ", UnitPrice = 2700, UnitsInStock = 2 },
                new Product { ProductId = 5, CategoryId = 2, ProductName = "Apple", QuantityPerUnit = "8 GB Ram", UnitPrice = 4000, UnitsInStock = 5 },
            };

            Console.WriteLine("Algoritmik----------");

            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitsInStock > 3)
                {
                    Console.WriteLine(product.ProductName); 
                }
                  
            }
            Console.WriteLine("Linq---------------- ");

            var result = products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3); //Where bir koşul anlamına geliyor

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }

        }

        static List<Product> GetProducts(List<Product>products)
        {
            List<Product> filteredProducts = new List<Product>();
            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitsInStock > 3)
                {
                    filteredProducts.Add(product);
                }

                GetProducts(products);

            }

            return filteredProducts;
        }


        static List<Product> GetProductsLinq(List<Product> products)
        {
            return products.Where(product => product.UnitPrice > 5000 && product.UnitsInStock > 3).ToList();
        }


    }

    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; } // misal evlenen kadın soyadını değiştirirken soyadını tek kurumda değiştirmesi yeterlidir
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
}

class Category
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }

}


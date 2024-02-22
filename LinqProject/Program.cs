using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categorylist = new List<Category>()
            {
                new Category{ CategoryId=1,CategoryName="Bilgisayar"},
                new Category{ CategoryId=2,CategoryName="Telefon"}
            };

            List<Product> productlist = new List<Product>()
            {
                new Product{ ProductId=1,CategoryId=1, ProductName="Acer Laptop", QuantityPerUnit="32 GB", UnitPrice=10000,UnitsInStock=5},
                new Product{ ProductId=2,CategoryId=1, ProductName="Asus Laptop", QuantityPerUnit="16 GB", UnitPrice=8000,UnitsInStock=3},
                new Product{ ProductId=3,CategoryId=1, ProductName="HP Laptop", QuantityPerUnit="8 GB", UnitPrice=6000,UnitsInStock=2},
                new Product{ ProductId=4,CategoryId=2, ProductName="Samsung Telefon", QuantityPerUnit="4 GB", UnitPrice=5000,UnitsInStock=15},
                new Product{ ProductId=5,CategoryId=2, ProductName="Apple Telefon", QuantityPerUnit="4 GB", UnitPrice=8000,UnitsInStock=0}
            };

            Console.WriteLine("Algoritmik------------------");
            foreach (var product in productlist)
            {
                if(product.UnitPrice>5000 && product.UnitsInStock > 3)
                {
                    Console.WriteLine(product.ProductName);
                }
            }

            Console.WriteLine("Linq------------------");

            var result=productlist.Where(x => x.UnitPrice>5000 && x.UnitsInStock>3);

            foreach(var item in result)
            {
                Console.WriteLine(item.ProductName);
            }

            Console.ReadLine();
        }
        //algoritmik metod
        static List<Product> getProductsAngoritmik(List<Product> productlist)
        {
            var filteredProducts = new List<Product>();
            foreach (var product in productlist)
            {
                if (product.UnitPrice > 5000 && product.UnitsInStock > 3)
                {
                    filteredProducts.Add(product);
                }
            }
            return filteredProducts;
        }
        //linq metod
        static List<Product> getProductsLinq(List<Product> productlist)
        {
            var products = productlist.Where(x => x.UnitPrice > 5000 && x.UnitsInStock > 3).ToList();
            return products;
        }
    }
    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}

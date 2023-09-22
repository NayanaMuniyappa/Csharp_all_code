using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codebaseTest_2
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
    }

    class Program
    {
        public static void Main()
         {
            List<Product> obj = new List<Product>();
            Product[] pp = new Product[15];

            // Accept 10 products (you can modify this as needed)
            for (int i = 1; i <= 10; i++)
            {
                pp[i] = new Product();
                pp[i].ProductId = i;
                Console.Write($"Enter the name of product {i}: ");
                pp[i].ProductName = Console.ReadLine();
                Console.Write($"Enter the price of product {i}: ");
                pp[i].Price = double.Parse(Console.ReadLine());
                obj.Add(pp[i]);
                
            }

            // Sort the products by price
            var sortedProducts = obj.OrderBy(p=>p.Price).ToList();

            // Display the sorted products
            Console.WriteLine("\nSorted Products by Price:");
            foreach (var product in sortedProducts)
            {
                Console.WriteLine($"Product ID: {product.ProductId}, Name: {product.ProductName}, Price: {product.Price:C}");
            }
            Read();
            
        }
    }
}
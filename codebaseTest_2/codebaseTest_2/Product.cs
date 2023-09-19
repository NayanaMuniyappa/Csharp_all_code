using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codebaseTest_2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
         
        public Product(int pid,string pname,double price)
        {
            this.ProductId = pid;
            this.ProductName = pname;
            this.Price = price;

        }
    }

    class Program
    {
       public  static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

        
            for (int i = 1; i <= 10; i++)
            {
                
              
                Console.Write($"Enter the name of product {i}: ");
                string Name = Console.ReadLine();
                Console.Write($"Enter the price of product {i}: ");
                 double Price = Convert.ToDouble(Console.ReadLine());
                Product product[i] = new Product();
                products.Add(product);
            }

 
            var sortedProducts = products.OrderBy(p => p.Price).ToList();

        
            Console.WriteLine("\nSorted Products by Price:");
            foreach (var product in sortedProducts)
            {
                Console.WriteLine($"Product ID: {product.ProductId}, Name: {product.ProductName}, Price: {product.Price}");
            }
            Console.ReadLine();
        }
    }
}
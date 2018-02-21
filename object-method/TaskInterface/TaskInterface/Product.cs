using System;
using System.Collections.Generic;
using System.Text;

namespace TaskInterface
{
    class Product : IProduct
    {
        public string ProductName;
        public double Price;
        public int NumberOfProducts;

        public Product()
        {
            ProductName = "unknown";
            Price = 0;
            NumberOfProducts = 0;
        }

        public Product(string productname, double price, int numberofproducts)
        {
            ProductName = productname;
            Price = price;
            NumberOfProducts = numberofproducts;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public string SearchProduct(Product pdt)
        {
            Console.Write("Search product; ");
            string userInput = Console.ReadLine();
            ProductName = userInput;

            if (ProductName == pdt.ProductName)
            {
               return $"Name: {pdt.ProductName}\nPrice: {pdt.Price}\nNumber of products: {pdt.NumberOfProducts}";
            }
            else
            {
                return null;
            }
        
        }

        public void TotalValue()
        {
            double total = Price * NumberOfProducts;

            Console.WriteLine($"Total value: {total}\n");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace TaskInterface
{
    class Store : Product, ICustomers, IProducts
    {
        public string StoreName;
        public int Sales;
        public Product[] Products;
        public Customer[] Customers;

        public Store()
        {
            StoreName = "unknown";
            Sales = 0;
        }

        public Store(string storename, int sales)
        {
            StoreName = storename;
            Sales = sales;
        }

        public override string ToString()
        {
            return string.Format($"Store Name: {StoreName}\n Store sales: {Sales}");
        }

        public void AddCustomer(Customer[] customers)
        {
            Customers = customers;
        }

        public void PrintCustomer()
        {
            for (int i = 0; i < Products.Length; i++)
            {
                Console.WriteLine($"Name: {Customers[i].CustomerName}" +
                              $"\nPrice: {Customers[i].Items}\n");
            }
            Console.WriteLine($"Total amount of customers: {Customers.Length}");
        }

        public void AddProduct(Product[] products)
        {
            Products = products;
        }

        public void PrintProducts()
        {
            int amount = 0;
            for (int i = 0; i < Products.Length; i++)
            {
                Console.WriteLine($"Product: {Products[i].ProductName}\n" +
                                  $"Price: {Products[i].Price}\n" +
                                  $"Number of products: {Products[i].NumberOfProducts}\n");

                amount += Products[i].NumberOfProducts;
            }
            Console.WriteLine($"\nAmount of all products: {amount}");
        }

        public void CountTotalValue()
        {
            Console.WriteLine($"\nTotal value: {Price}");
        }
    }
}

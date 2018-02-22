using System;

namespace TaskInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[3];
            products[0] = new Product("Computer", 1500, 5);
            products[1] = new Product("Phone", 600, 3);
            products[2] = new Product("Headphones", 100, 7);

            Console.WriteLine(products[0].SearchProduct(products[1]));

            products[0].TotalValue();
            products[1].TotalValue();
            products[2].TotalValue();

            Customer[] customers = new Customer[3];
            customers[0] = new Customer("Tia", 200);
            customers[1] = new Customer("Jani", 340);
            customers[2] = new Customer("Henna", 130);

            Console.WriteLine(customers[0].SearchCustomer(customers[1]));

            customers[0].CalculateBonus();
            customers[1].CalculateBonus();
            customers[2].CalculateBonus();

            Store shop = new Store("Gigantti", 13000);
            shop.AddProduct(products);
            shop.AddCustomer(customers);

            Console.WriteLine("----------------");
            shop.PrintProducts();
            shop.PrintCustomer();

            Console.ReadKey();
        }
    }
}

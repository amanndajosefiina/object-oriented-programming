using System;
using System.Collections.Generic;
using System.Text;

namespace TaskInterface
{
    class Customer : ICustomer
    {
        public string CustomerName;
        public int Items;

        public Customer()
        {
            CustomerName = "unknown";
            Items = 0;
        }

        public Customer(string customername, int items)
        {
            CustomerName = customername;
            Items = items;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public string SearchCustomer(Customer ctm)
        {
            Console.Write("Search customer: ");
            string userInput = Console.ReadLine();
            CustomerName = userInput;

            if (CustomerName == ctm.CustomerName)
            {
                return $"\nCustomer's name: {ctm.CustomerName}\nItems: {ctm.Items}\n";
            }
            else
            {
                return null;
            }

        }

            public void CalculateBonus()
            {
                double bonus;

                if (Items <= 1000)
                {
                    bonus = Items * 0.02;
                    Console.WriteLine($"Bonus: {bonus}\n");
                }
                else if (Items > 1000 && Items < 2000)
                {
                    bonus = Items * 0.03;
                    Console.WriteLine($"Bonus: {bonus}\n");
                }

                else
                {
                    bonus = Items * 0.05;
                    Console.WriteLine($"Bonus: {bonus}");
                }
                }
            }               
        }


using System;

namespace TaskTicketPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            Ticket customer = new Ticket();

            int age = -1;
            while (age < 0)
            {
                Console.Write("Enter age: ");
                if (!int.TryParse(Console.ReadLine(), out age))
                {
                    Console.WriteLine("Invalid age!");
                    age = -1;
                }
                else
                {
                    customer.Age = age;
                }

                customer.IsStudent = YesNo("\nAre you a student? Answer Y or N.");
                customer.IsMtk = YesNo("\nAre you a member of MTK? Answer Y or N.");
                customer.IsSoldier = YesNo("\nAre you a soldier? Answer Y or N.");

                customer.GetPrice();

                Console.ReadKey();
            }
        }

         public static bool YesNo(string message)
        {
            Console.WriteLine(message);
            string answer = Console.ReadLine().ToUpper();

            if (answer == "Y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

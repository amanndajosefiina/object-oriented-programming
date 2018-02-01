using System;

namespace TaskTicketPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            Ticket customer = new Ticket();

            Console.WriteLine("Enter age: ");
            string userInput = Console.ReadLine();
            int Age = int.Parse(userInput);

            customer.IsStudent = YesNo("Are you a student? Answer Yes or No.");
            customer.IsMtk = YesNo("Are you a member of MTK? Answer Yes or No.");
            customer.IsSoldier = YesNo("Are you a soldier? Answer Yes or No.");

            customer.GetPrice();

            Console.ReadKey();
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

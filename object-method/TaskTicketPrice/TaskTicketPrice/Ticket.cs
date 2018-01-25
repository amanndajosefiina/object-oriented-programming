using System;
using System.Collections.Generic;
using System.Text;

namespace TaskTicketPrice
{
    class Ticket
    {
        private int _age;
        private string _occupation;
        private int _price;

        public Ticket()
        {
            _age = 0;
            _occupation = "unknown";
        }

        public Ticket(int age, string occupation)
        {
            _age = age;
            _occupation = occupation;
        }

        int price = 16;

        public void AskData()
        {
            Console.Write("Input age: ");
            string userInput = Console.ReadLine();
            _age = int.Parse(userInput);

            Console.Write("Input occupation (MTK, student, army, none): ");
            string userInput1 = Console.ReadLine();
            _occupation = userInput1;


            if (_age >= 65 || _age >= 7 && < 15) ;
            {
                price = price / 2;
            }

            else if (_age > 7)
            {
                price = 0;
            }

            else
            {
                price = 16;
            }

        }
    }
}

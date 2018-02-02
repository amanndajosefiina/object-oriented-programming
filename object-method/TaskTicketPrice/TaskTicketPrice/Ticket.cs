using System;
using System.Collections.Generic;
using System.Text;

namespace TaskTicketPrice
{
    class Ticket
    {
        public int Age;
        public double Price;
        private bool _isStudent;
        private bool _isSoldier;
        private bool _isMtk;

        public bool IsStudent { get => _isStudent; set => _isStudent = value; }
        public bool IsSoldier { get => _isSoldier; set => _isSoldier = value; }
        public bool IsMtk { get => _isMtk; set => _isMtk = value; }

        public Ticket()
        {
            Age = 0;
            Price = 16;
        }

        public Ticket(int age, double price)
        {
            Age = age;
            Price = 16;
        }

        public void GetPrice()
        {
            if (Age < 7)
            {
                Price = 0;
            }
            else if (Age >= 7 && Age <= 15 || Age >= 65)
            {
                Price = 16 * 0.5;
            }

            else if (IsSoldier == true)
            {
                Price = 16 * 0.5;
            }

            else if (IsStudent == true)
            {
                Price = 16 * 0.55;
            }
            else if (IsMtk == true)
            {
                Price = 16 * 0.85;
            }

            else if (IsMtk == true && IsStudent == true)
            {
                Price = 16 * 0.5;
            }
            else
            {
                Price = 16;
            }

            Console.WriteLine($"\nPrice: {Price}");
        }   
    }
}

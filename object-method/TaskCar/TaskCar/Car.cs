using System;
using System.Collections.Generic;
using System.Text;

namespace TaskCar
{
    class Car
    {
        public string Brand;
        public int Speed;

        public Car()
        {
            Brand = "unknown";
            Speed = 0;
        }

        public Car(string brand, int speed)
        {
            Brand = brand;
            Speed = speed;
        }

        public void AskData()
        {
            Console.Write("Input car brand: ");
            string userInput = Console.ReadLine();
            Brand = userInput;

            Console.Write("Input car speed: ");
            string userInput1 = Console.ReadLine();
            Speed = int.Parse(userInput1);           
        }

        public void ShowCarInfo()
        {
            Console.WriteLine($"\nCar brand: {Brand}\nCar speed: {Speed}\n");
        }

        public void Accelerate(int number)
        {
            Speed = Speed + number;
        }

        public void Brake(int number)
        {
            Speed = (Speed * number) / 100;
        }
    }
}

﻿using System;

namespace TaskCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Car carAuto1 = new Car();
            carAuto1.AskData();
            carAuto1.ShowCarInfo();
            Console.WriteLine("Car speed after 30+:");
            carAuto1.Accelerate(30);
            carAuto1.ShowCarInfo();
            Console.WriteLine("Car speed after 10% slowdown:");
            carAuto1.Brake(90);
            carAuto1.ShowCarInfo();
                        
            Car carAuto2 = new Car();
            carAuto2.AskData();
            carAuto2.ShowCarInfo();
            Console.WriteLine("Car speed after 30+.");
            carAuto2.Accelerate(30);
            carAuto2.ShowCarInfo();
            Console.WriteLine("Car speed after 10% slowdown.");
            carAuto2.Brake(90);
            carAuto2.ShowCarInfo();

            Console.ReadKey();
        }
    }
}

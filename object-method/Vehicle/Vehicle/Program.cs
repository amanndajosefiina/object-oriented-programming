using System;

namespace Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Sedan", "BMW", 1992, 700, 1.6, "320", 5);
            car1.PrintInformation();

            Car car2 = new Car("Hatchback", "Mazda", 1996, 650, 1.4, "Neo", 3);
            car2.PrintInformation();

            Car car3 = new Car("Hatchback", "Volkswagen", 2011, 11000, 1.2, "Polo", 5);
            car3.PrintInformation();

            Console.WriteLine(car3.ToString());
            Console.WriteLine(car2.Equals(car2));
            Console.WriteLine(car2.Equals(car3));

            Truck truck1 = new Truck("Pickup", "Chevrolet", 2016, 21195, 3.6, "Colorado", 4, 2000, 15);

            truck1.PrintInformation();
            Console.WriteLine(truck1.CountConsumption());

            Console.ReadKey();
        }
    }
}

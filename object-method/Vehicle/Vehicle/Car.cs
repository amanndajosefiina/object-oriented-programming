using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    class Car : Vehicle1
    {
        protected double EngineSize;
        protected string Brand;
        protected int NumberOfDoors;

        public Car()
        {
            EngineSize = 0;
            Brand = "unknown";
            NumberOfDoors = 0;
        }

        public Car(string type, string model, int modelyear, double price, double enginesize, string brand, int numberofdoors) : base(type, model, modelyear, price)
        {
            EngineSize = enginesize;
            Brand = brand;
            NumberOfDoors = numberofdoors;
        }

        public override void PrintInformation()
        {
            Console.WriteLine($"\nType: {Type}\nModel: {Model}\nYear: {ModelYear}\nPrice: {Price}\nMotor: {EngineSize}\nBrand: {Brand}\nDoors: {NumberOfDoors}\n");
        }

        public override string ToString()
        {
            return ($"\n{EngineSize}\n{Brand}\n{NumberOfDoors}\n");
        }

        public override bool Equals(object obj)
        {
            Car carObj = obj as Car;
            if (carObj == null)
                return false;
            else
                return Model.Equals(carObj.Model);
        }
    }
}
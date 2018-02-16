using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    abstract class Vehicle1
    {
        protected string Type;
        protected string Model;
        protected int ModelYear;
        protected double Price;

        public Vehicle1()
        {
            Type = "unknown";
            Model = "unkwnown";
            ModelYear = 0;
            Price = 0;
        }

        public Vehicle1(string type, string model, int modelyear, double price)
        {
            Type = type;
            Model = model;
            ModelYear = modelyear;
            Price = price;
        }

        abstract public void PrintInformation();

    }
}

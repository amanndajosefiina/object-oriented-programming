using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    class Truck : Car
    {
        protected double LoadWeight;
        protected double ConsumptionPerKg;

        public Truck()
        {
            LoadWeight = 0;
            ConsumptionPerKg = 0;
        }

        public Truck(string type, string model, int modelyear, double price, double enginesize, string brand, int numberofdoors, double loadweight, double consumptionperkg) : base(type, model, modelyear, price, enginesize, brand, numberofdoors)
        {
            LoadWeight = loadweight;
            ConsumptionPerKg = consumptionperkg;
        }

        public string CountConsumption()
        {
            double consumption = LoadWeight / ConsumptionPerKg;
            return ($"Consumption is {consumption} liters.");
        }
    }
}

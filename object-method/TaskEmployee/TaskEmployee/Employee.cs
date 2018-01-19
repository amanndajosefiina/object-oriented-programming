using System;
using System.Collections.Generic;
using System.Text;

namespace TaskEmployee
{
    class Employee
    {
        public string Name;
        public int Id;
        public string Position;
        public decimal Salary;

        public Employee()
        {
            Name = "unknown";
            Id = 0;
            Position = "unknown";
            Salary = 0.0m;
        }

        public Employee(string name, int id, string position, decimal salary)
        {
            Name = name;
            Id = id;
            Position = position;
            Salary = salary;
        }

        public void PrintEmployeeInfo()
        {
            Console.WriteLine($"Name = {Name}\nId = {Id}\nPosition = {Position}\nSalary = {Salary:f2}");
        }

        public void CompareSalary(Employee worker)
        {
            if (Salary > worker.Salary)
            {
                Console.WriteLine($"{Name} has bigger salary than {worker.Name} - {Salary - worker.Salary}");
            }
            else
            {
                Console.WriteLine($"{worker.Name} has bigger salary than {Name} - {worker.Salary - Salary}");
            }
        }
    }
}

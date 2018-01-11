using System;
using System.Collections.Generic;
using System.Text;

namespace task_book
{
    class Person
    {
        //Muuttujat (fields) eli mitä olio tietää 
        public string Name;
        private int Age;

        //Constructor, täytyy nimetä aina samalla nimellä kuin class eli luokka
        public Person()
        {
            Name = "unknown";
            Age = 0;
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        //Methdos
        public void GrowOld()
        {
            Age++;
        }

        public void GrowOld(int number)
        {
            this.Age = this.Age + number;
        }

        public void PrintPersonInfo()
        {
            Console.WriteLine($"Nimi: {Name}\nIkä: {Age}\nAikuinen: {IsAdult()}");
        }

        public bool IsAdult()
        {
            if (Age >= 18)
                return true;
            else
                return false;
            // return this age >= 18;  korvaa ylläolevan
        }

        public int GetAge()
        {
            return Age;
        }
    }
}

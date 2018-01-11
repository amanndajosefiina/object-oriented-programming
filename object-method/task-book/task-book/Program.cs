using System;

namespace task_book
{
    class Program
    {
        static void Main(string[] args)
        {
            Person personAmanda = new Person();
            personAmanda.Name = "Amanda V";
            personAmanda.GrowOld();
            personAmanda.PrintPersonInfo();

            Person newPerson = new Person("John Doe", 25);
            newPerson.PrintPersonInfo();
            newPerson.GrowOld();
            newPerson.PrintPersonInfo();
            Console.ReadKey();

        }
    }
}

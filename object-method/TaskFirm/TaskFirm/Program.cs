using System;

namespace TaskFirm
{
    class Program
    {
        static void Main(string[] args)
        {
            Company firmCompany = new Company();
            firmCompany.Address = "Baker Street 29";
            firmCompany.Title = "The Company";
            firmCompany.Phone = 0449724367;
            firmCompany.Outcome = 400000;
            firmCompany.Expence = 20000;
            Company firmCompany2 = new Company(firmCompany);

            Company f3 = new Company("F3", "xxx 3", 044364836, 1000000, 96000);


            firmCompany.ShowInfo();
            firmCompany2.ShowInfo();
            firmCompany2.ShowProfit();
            f3.ShowProfit();

            Console.ReadKey();
        }
    }
}

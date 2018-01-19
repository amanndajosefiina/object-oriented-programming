using System;
using System.Collections.Generic;
using System.Text;

namespace TaskFirm
{
    class Company
    {
        public string Title;
        public string Address;
        public int Phone;
        public int Outcome;
        public int Expence;

        public Company()
        {
            Title = "unknown";
            Address = "unknown";
            Phone = 0;
            Outcome = 0;
            Expence = 0;
        }

        public Company(string title, string address, int phone, int outcome, int expence)
        {
            Title = title;
            Address = address;
            Phone = phone;
            Outcome = outcome;
            Expence = expence;
        }

        public Company(Company previousCompany)
        {
            Title = previousCompany.Title;
            Address = previousCompany.Address;
            Phone = previousCompany.Phone;
            Outcome = previousCompany.Outcome;
            Expence = previousCompany.Expence;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Title = {Title}\nAddress = {Address}\nPhone number = {Phone}\nOutcome = {Outcome}\nExpence = {Expence}\n");
        }

        public void ShowProfit()
        {
            int profit = (Outcome - Expence) / Expence * 100;

            if (profit < 2 * Expence)
            {
                Console.WriteLine($"\n{Title}: Company's profits are under 100 % bigger than expences. Company is not doing so great.");
            }

            else if (profit <= 3 * Expence)
            {
                Console.WriteLine($"\n{Title}: Company's profits are at least 200 % bigger than expences. Company is doing fine.");
            }

            else
            {
                Console.WriteLine($"\n{Title}: Company's profits are at least 300 % bigger than expences. Company is doing very well!");
            }
        }
    }
}

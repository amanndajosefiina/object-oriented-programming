using System;
using System.Collections.Generic;
using System.Text;

namespace TaskInterface
{
    interface ICustomer
    {
        string SearchCustomer(Customer ctm);

        void CalculateBonus();
    }
}

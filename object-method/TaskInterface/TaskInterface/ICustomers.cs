using System;
using System.Collections.Generic;
using System.Text;

namespace TaskInterface
{
    interface ICustomers
    {
        void AddCustomer(Customer[] customers);

        void PrintCustomer();
    }
}

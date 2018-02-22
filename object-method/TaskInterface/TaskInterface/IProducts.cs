using System;
using System.Collections.Generic;
using System.Text;

namespace TaskInterface
{
    interface IProducts
    {
        void AddProduct(Product[] product);

        void PrintProducts();
    }
}

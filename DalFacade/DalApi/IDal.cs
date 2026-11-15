using System;
using System.Collections.Generic;
using System.Text;

namespace DalApi
{
    internal interface IDal
    {
        ICustomer Customer { get; }
        IProduct Product { get; }
        ISale Sale { get; }
    }
}

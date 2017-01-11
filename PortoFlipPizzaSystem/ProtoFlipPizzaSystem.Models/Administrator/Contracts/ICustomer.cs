using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoFlipPizzaSystem.Models.Administrator.Contracts
{
    public interface ICustomer : IPerson
    {
        double Discount { get; }
        int NumberOfOrders { get; }
    }
}

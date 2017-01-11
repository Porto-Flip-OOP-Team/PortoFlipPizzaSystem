using ProtoFlipPizzaSystem.Models.Administrator.Contacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoFlipPizzaSystem.Models.Client.Contracts
{
    interface IOrder
    {
        IProduct Product { get; }
        int Quantity { get; set; }
        double TotalProductPrice { get; }

        double CalculateTotalOrderPrice(List<IOrder> order);
        
    }
}

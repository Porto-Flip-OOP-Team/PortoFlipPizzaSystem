using System.Collections.Generic;

using ProtoFlipPizzaSystem.Models.Administrator.Contracts;

namespace ProtoFlipPizzaSystem.Models.Client.Contracts
{
    public interface IOrder
    {
        IProduct Product { get; }

        int Quantity { get; set; }

        decimal TotalProductPrice { get; }

        decimal CalculateTotalOrderPrice(List<IOrder> order);

    }
}

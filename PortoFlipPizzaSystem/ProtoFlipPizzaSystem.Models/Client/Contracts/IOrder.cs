using System.Collections.Generic;

using ProtoFlipPizzaSystem.Models.Client.Structures;
using ProtoFlipPizzaSystem.Models.Contracts;

namespace ProtoFlipPizzaSystem.Models.Client.Contracts
{
    public interface IOrder : IDeletable
    {
        List<OrderItem> Products { get; }

        decimal CalculateTotalOrderPrice();
    }
}

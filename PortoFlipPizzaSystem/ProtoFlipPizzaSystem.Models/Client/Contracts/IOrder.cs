using System.Collections.Generic;

using ProtoFlipPizzaSystem.Models.Contracts;
using ProtoFlipPizzaSystem.Models.Client.Structures;

namespace ProtoFlipPizzaSystem.Models.Client.Contracts
{
    public interface IOrder : IDeletable
    {
        List<OrderItem> Products { get; }

        bool IsDeleted { get; }

        decimal CalculateTotalOrderPrice();

    }
}

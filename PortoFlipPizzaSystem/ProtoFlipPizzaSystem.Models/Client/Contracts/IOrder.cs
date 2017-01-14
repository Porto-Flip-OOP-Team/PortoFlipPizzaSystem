using System.Collections.Generic;

using ProtoFlipPizzaSystem.Models.Administrator.Contracts;

namespace ProtoFlipPizzaSystem.Models.Client.Contracts
{
    public interface IOrder
    {
        IProduct Product { get; }

        int Quantity { get; }

        decimal TotalProductPrice { get; }

        bool IsDeleted { get; }

        decimal CalculateTotalOrderPrice(List<IOrder> order);
        void Delete();

    }
}

using System.Collections.Generic;
using ProtoFlipPizzaSystem.Models.Client.Contracts;

namespace PortoFlipPizzaSystem.Data.Contracts
{
    public interface IGetAllOrders
    {
        ICollection<IOrder> GetAllOrders();
    }
}

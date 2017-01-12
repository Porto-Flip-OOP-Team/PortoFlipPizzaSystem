using ProtoFlipPizzaSystem.Models.Client.Contracts;

namespace PortoFlipPizzaSystem.Data.Contracts
{
    public interface IAddOrder
    {
        void AddOrder(int orderId, IOrder order);
    }
}

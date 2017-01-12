using ProtoFlipPizzaSystem.Models.Client.Contracts;

namespace ProtoFlipPizzaSystem.Models.Administrator.Contracts
{
    public interface IAddOrder
    {
        void AddOrder(int orderId, IOrder order);
    }
}

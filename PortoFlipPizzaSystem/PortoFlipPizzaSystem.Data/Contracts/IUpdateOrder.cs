using ProtoFlipPizzaSystem.Models.Administrator.Contracts;

namespace PortoFlipPizzaSystem.Data.Contracts
{
    public interface IUpdateOrder
    {
        void UpdateOrder(int orderId, IProduct product);
    }
}

using ProtoFlipPizzaSystem.Models.Client.Contracts;

namespace PortoFlipPizzaSystem.Data.Contracts
{
    public interface IGetOrder
    {
        IOrder GetOrder(int orderId);
    }
}

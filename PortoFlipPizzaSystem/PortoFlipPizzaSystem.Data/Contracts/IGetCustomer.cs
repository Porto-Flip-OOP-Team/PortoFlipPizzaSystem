using ProtoFlipPizzaSystem.Models.Administrator.Contracts;

namespace PortoFlipPizzaSystem.Data.Contracts
{
    public interface IGetCustomer
    {
        ICustomer GetCustomer(int customerId);
    }
}
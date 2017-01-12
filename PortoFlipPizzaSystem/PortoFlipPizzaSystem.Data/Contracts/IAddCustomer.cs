using ProtoFlipPizzaSystem.Models.Administrator.Contracts;

namespace PortoFlipPizzaSystem.Data.Contracts
{
    public interface IAddCustomer
    {
        void AddCustomer(int Customer, ICustomer customer);
    }
}
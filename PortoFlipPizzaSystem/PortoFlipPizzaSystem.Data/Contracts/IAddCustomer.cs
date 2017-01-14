using ProtoFlipPizzaSystem.Models.Administrator.Contracts;

namespace PortoFlipPizzaSystem.Data.Contracts
{
    public interface IAddCustomer
    {
        void AddCustomer(int customerID, ICustomer customer);
    }
}
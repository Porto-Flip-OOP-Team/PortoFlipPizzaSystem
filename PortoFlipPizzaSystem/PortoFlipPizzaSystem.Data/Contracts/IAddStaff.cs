using ProtoFlipPizzaSystem.Models.Administrator.Contracts;

namespace PortoFlipPizzaSystem.Data.Contracts
{
    public interface IAddStaff
    {
        void AddStaff(int staffId, IStaff staff);
    }
}
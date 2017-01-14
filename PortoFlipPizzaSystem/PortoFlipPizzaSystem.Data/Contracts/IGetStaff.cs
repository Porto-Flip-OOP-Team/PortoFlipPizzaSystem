using ProtoFlipPizzaSystem.Models.Administrator.Contracts;

namespace PortoFlipPizzaSystem.Data.Contracts
{
    public interface IGetStaff
    {
        IStaff GetStuff(int staffId);
    }
}
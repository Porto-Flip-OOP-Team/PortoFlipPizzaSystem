using ProtoFlipPizzaSystem.Models.Contracts;

namespace ProtoFlipPizzaSystem.Models.Administrator.Contracts
{
    public interface IProduct : ICanBeDeleted
    {
        decimal CalculatePrice();
    }
}

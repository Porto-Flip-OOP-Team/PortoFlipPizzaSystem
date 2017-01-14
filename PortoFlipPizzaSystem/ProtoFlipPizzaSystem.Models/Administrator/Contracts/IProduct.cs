using ProtoFlipPizzaSystem.Models.Contracts;

namespace ProtoFlipPizzaSystem.Models.Administrator.Contracts
{
    public interface IProduct : ICanBeDeleted
    {
        string Name { get; }
        bool IsDeleted { get; }

        decimal CalculatePrice();
    }
}

using ProtoFlipPizzaSystem.Models.Contracts;

namespace ProtoFlipPizzaSystem.Models.Administrator.Contracts
{
    public interface IProduct : IDeletable
    {
        string Name { get; }

        int IdProduct { get; }
        
        decimal CalculatePrice();
    }
}

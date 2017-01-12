using ProtoFlipPizzaSystem.Models.Enums;

namespace ProtoFlipPizzaSystem.Models.Administrator.Contracts
{
    public interface IIgredient
    {
        string Name { get; }

        MeasureUnitType UnitType { get; }

        decimal CalculateUnitPrice();

        decimal TotalPrice { get; }

        decimal Quantity { get; }

        bool IsDeleted { get; }
    }
}

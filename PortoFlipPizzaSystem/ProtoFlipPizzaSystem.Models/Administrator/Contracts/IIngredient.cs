using ProtoFlipPizzaSystem.Models.Enums;

namespace ProtoFlipPizzaSystem.Models.Administrator.Contracts
{
    public interface IIngredient
    {
        string Name { get; }

        MeasureUnitType UnitType { get; }

        decimal CalculateUnitPrice();

        decimal TotalPrice { get; }

        decimal Quantity { get; }

        void Delete();
    }
}

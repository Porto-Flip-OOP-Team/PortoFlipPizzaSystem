using ProtoFlipPizzaSystem.Models.Enums;

namespace ProtoFlipPizzaSystem.Models.Administrator.Contracts
{
    public interface IDrink : IProduct
    {
        MeasureUnitType Quantity { get; }
    }
}

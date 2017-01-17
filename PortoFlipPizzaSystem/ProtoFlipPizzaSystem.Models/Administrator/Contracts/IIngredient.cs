using ProtoFlipPizzaSystem.Models.Contracts;
using ProtoFlipPizzaSystem.Models.Enums;

namespace ProtoFlipPizzaSystem.Models.Administrator.Contracts
{
    public interface IIngredient : ICalculatable, IDeletable, IIdentifiable, INamable
    {
        MeasureUnitType UnitType { get; }

        decimal UnitPrice { get; }

        decimal Quantity { get; set; }
    }
}

using ProtoFlipPizzaSystem.Models.Contracts;
using ProtoFlipPizzaSystem.Models.Enums;

namespace ProtoFlipPizzaSystem.Models.Administrator.Contracts
{
    public interface IDrink : IProduct, ICalculatable, IDeletable, IIdentifiable, INamable
    {
        MeasureUnitType MeasureUnitType { get; }

        int UnitQuantity { get; }
    }
}
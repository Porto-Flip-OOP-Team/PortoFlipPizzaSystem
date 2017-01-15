using ProtoFlipPizzaSystem.Models.Enums;

namespace ProtoFlipPizzaSystem.Models.Administrator.Contracts
{
    public interface IIngredient
    {
        string Name { get; }

        MeasureUnitType UnitType { get; }

        decimal CalculatePrice();

        decimal UnitPrice { get; }

        decimal Quantity { get; set; }
        
        bool IsDeleted { get; }

        void Delete();
    }
}

using ProtoFlipPizzaSystem.Models.Administrator.Contracts;
using ProtoFlipPizzaSystem.Models.Common;
using ProtoFlipPizzaSystem.Models.Contracts;
using ProtoFlipPizzaSystem.Models.Enums;
using ProtoFlipPizzaSystem.Models.Validation;

namespace ProtoFlipPizzaSystem.Models.Administrator
{
    public class Ingredient : IdentifiableObject, IIngredient, IDeletable, IIdentifiable, INamable
    {
        private string name;

        public Ingredient(string name, decimal unitPrice, decimal quantity, MeasureUnitType unitType)
        {
            this.Name = name;
            this.UnitPrice = unitPrice;
            this.UnitType = unitType;
            this.Quantity = quantity;
            this.IsDeleted = false;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                Validator.ValidateSymbols("sOmething", "^[a-zA-Z]+$", "Invalid ingredient");
                this.name = value;
            }
        }

        public MeasureUnitType UnitType { get; private set; }

        public bool IsDeleted { get; set; } 

        public decimal Quantity { get; set; }

        public decimal UnitPrice { get; private set; }

        public decimal CalculatePrice()
        {
            return this.Quantity * this.UnitPrice;
        }
    }
}

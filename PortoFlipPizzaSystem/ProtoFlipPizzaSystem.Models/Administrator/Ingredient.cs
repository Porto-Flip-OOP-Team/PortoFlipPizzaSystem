using System;

using ProtoFlipPizzaSystem.Models.Administrator.Contracts;
using ProtoFlipPizzaSystem.Models.Enums;
using ProtoFlipPizzaSystem.Models.Validation;
using ProtoFlipPizzaSystem.Models.Common;

namespace ProtoFlipPizzaSystem.Models.Administrator
{
    public class Ingredient : IdentifiableObject, IIngredient
    {
        string name;

        public Ingredient(string name, decimal unitPrice, decimal quantity, MeasureUnitType unitType)
        {
            this.Name = name;
            this.UnitPrice = unitPrice;
            this.UnitType = unitType; 
            this.Quantity = quantity;
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

        public bool IsDeleted { get; private set; } = false;

        public decimal Quantity { get;  set; }

        public decimal UnitPrice { get; private set; }

        public void Delete()
        {
            this.IsDeleted = true;
        }

        public decimal CalculatePrice()
        {
            return this.Quantity * this.UnitPrice;
        }
    }
}

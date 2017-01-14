using ProtoFlipPizzaSystem.Models.Administrator.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoFlipPizzaSystem.Models.Enums;
using ProtoFlipPizzaSystem.Models.Validation;

namespace ProtoFlipPizzaSystem.Models.Administrator
{
    public class Ingredient : IIngredient
    {

        string name;

        public Ingredient(string name, MeasureUnitType unitType, decimal quantity, decimal unitPrice)
        {
            this.Name = name;
            this.UnitType = unitType; 
            this.Quantity = quantity;
            this.UnitPrice = unitPrice;
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

        public decimal Quantity { get; private set; }

        public decimal UnitPrice { get; private set; }


        public void Delete()
        {
            this.IsDeleted = true;
        }

        public decimal CalculateIngredientPrice()
        {
            return this.Quantity * this.UnitPrice;
        }
    }
}

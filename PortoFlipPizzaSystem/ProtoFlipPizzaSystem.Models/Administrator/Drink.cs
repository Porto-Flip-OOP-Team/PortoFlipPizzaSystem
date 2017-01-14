using System;
using ProtoFlipPizzaSystem.Models.Administrator.Contracts;
using ProtoFlipPizzaSystem.Models.Enums;
using ProtoFlipPizzaSystem.Models.Administrator.Abstract;
using System.Text;

namespace ProtoFlipPizzaSystem.Models.Administrator
{
    public class Drink : Product, IDrink
    {

        public Drink(string name, decimal price, MeasureUnitType quantity) : base(name)
        {
            this.Price = price;
            this.Quantity = quantity;
        }


        private decimal Price { get; set; }
        public MeasureUnitType Quantity { get; private set; }

        public override decimal CalculatePrice()
        {
            return this.Price;
        }

        public override string ToString()
        {
            StringBuilder visualization = new StringBuilder();
            visualization.Append($"{this.Name} {this.Quantity} {this.Price}");
            return visualization.ToString();
        }
    }
}

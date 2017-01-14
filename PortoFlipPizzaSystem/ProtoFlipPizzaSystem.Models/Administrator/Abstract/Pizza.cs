using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProtoFlipPizzaSystem.Models.Administrator.Contracts;
using ProtoFlipPizzaSystem.Models.Administrator.Structures;

namespace ProtoFlipPizzaSystem.Models.Administrator.Abstract
{
    public abstract class Pizza : Food, IPizza
    {
        public Pizza(string name, List<ProductItem> ingredients) : base(name, ingredients)
        {

        }
        public Pizza(int id, string name, List<ProductItem> ingredients) : base(id, name, ingredients)
        {

        }

        public decimal PizzaPremium { get; private set; } = 1.2M;
        public decimal Coeff { get; protected set; } = 0;

        public void SetPizzaPremium(decimal pizzaPremium)
        {
            this.PizzaPremium = pizzaPremium;
        }
        public void SetCoeff(decimal coeff)
        {
            this.Coeff = coeff;
        }

        public override decimal CalculatePrice()
        {
            decimal price = 0;

            foreach (var productItem in this.Ingredients)
            {
                price += (productItem.Igredient.TotalPrice * productItem.Quantity);
            }

            price += (price * (PizzaPremium + Coeff));

            return price;
        }
    }
}

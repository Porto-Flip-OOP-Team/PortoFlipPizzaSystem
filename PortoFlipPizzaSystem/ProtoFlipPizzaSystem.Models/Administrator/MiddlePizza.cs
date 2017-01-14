using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using ProtoFlipPizzaSystem.Models.Administrator.Contracts;
using ProtoFlipPizzaSystem.Models.Administrator.Abstract;


namespace ProtoFlipPizzaSystem.Models.Administrator
{
    public class MiddlePizza : Pizza, IPizza
    {
        private const decimal premium = 0.10M;
        private const decimal quantityOfProduct = 1.5M;
        public const int numberOfSlices = 8;

        public MiddlePizza(string name, List<IIngredient> ingredients) : base(name, ingredients)
        {

        }

        public override string Visualise()
        {
            string visualization = "Small " + Name
                                            + "\n" + numberOfSlices + "slices"
                                            + "\nPrice: " + CalculatePrice();

            return visualization;
        }

        public override decimal CalculatePrice()
        {
            decimal price = 0;

            foreach (var ingredient in Ingredients)
            {
                price += (ingredient.TotalPrice * quantityOfProduct);
            }

            price += (price * premium);

            return price;
        }
    }
}

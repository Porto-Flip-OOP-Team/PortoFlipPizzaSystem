using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using ProtoFlipPizzaSystem.Models.Administrator.Contracts;


namespace ProtoFlipPizzaSystem.Products
{
    public class SmallPizza : Pizza, IPizza
    {
        private const decimal premium = 0.15M;
        private const decimal quantityOfProduct = 1M;
        public const int numberOfSlices = 6;

        public SmallPizza(string name, List<IIngredient> ingredients) : base(name, ingredients)
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
                price += (ingredient.Price * quantityOfProduct);
            }

            price += (price * premium);

            return price;
        }
    }
}

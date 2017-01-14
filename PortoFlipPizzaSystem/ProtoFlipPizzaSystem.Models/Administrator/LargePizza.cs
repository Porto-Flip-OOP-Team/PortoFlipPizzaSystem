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

    public class LargePizza : Pizza, IPizza
    {
        private const decimal premium = 0.05M;
        private const decimal quantityOfProduct = 2M;
        public const int numberOfSlices = 12;

        public LargePizza(string name, List<IIngredient> ingredients) : base(name, ingredients)
        {

        }

        public override string Visualise()
        {
            string visualization = "Large " + Name
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

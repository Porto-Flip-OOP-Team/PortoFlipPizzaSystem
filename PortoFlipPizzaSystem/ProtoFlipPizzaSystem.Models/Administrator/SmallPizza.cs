using System.Collections.Generic;
using System.Text;

using ProtoFlipPizzaSystem.Models.Administrator.Contracts;
using ProtoFlipPizzaSystem.Models.Administrator.Abstract;
using ProtoFlipPizzaSystem.Models.Administrator.Structures;

namespace ProtoFlipPizzaSystem.Models.Administrator
{
    public class SmallPizza : Pizza, IPizza
    {

        public const int NUMBER_OF_SLICES = 6;

        public SmallPizza(string name, List<ProductItem> ingredients) 
            : base(name, ingredients)
        {
            this.Coeff = 0.3M;
        }

        public override string ToString()
        {
            StringBuilder visualization = new StringBuilder();
            visualization.AppendLine($"Small {this.Name}");
            visualization.AppendLine($"{NUMBER_OF_SLICES} slices");
            visualization.Append($"Price: {this.CalculatePrice()}");

            return visualization.ToString();
        }

    }
}

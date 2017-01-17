using System.Collections.Generic;
using System.Text;

using ProtoFlipPizzaSystem.Models.Administrator.Contracts;
using ProtoFlipPizzaSystem.Models.Administrator.Abstract;
using ProtoFlipPizzaSystem.Models.Administrator.Structures;

namespace ProtoFlipPizzaSystem.Models.Administrator
{
    public class MiddlePizza : Pizza, IPizza
    {
        public const int NUMBER_OF_SLICES = 8;

        public MiddlePizza(string name, List<ProductItem> ingredients) 
            : base(name, ingredients)
        {
            this.Coeff = 0.1M;
        }

        public override string ToString()
        {
            StringBuilder visualization = new StringBuilder();
            visualization.AppendLine($"Middle {this.Name}");
            visualization.AppendLine($"{NUMBER_OF_SLICES} slices");
            visualization.Append($"Price: {this.CalculatePrice()}");

            return visualization.ToString();
        }
    }
}

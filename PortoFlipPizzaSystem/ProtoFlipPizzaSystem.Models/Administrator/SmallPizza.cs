using System.Collections.Generic;
using System.Text;

using ProtoFlipPizzaSystem.Models.Administrator.Abstract;
using ProtoFlipPizzaSystem.Models.Administrator.Contracts;
using ProtoFlipPizzaSystem.Models.Administrator.Structures;

namespace ProtoFlipPizzaSystem.Models.Administrator
{
    public class SmallPizza : Pizza, IPizza
    {
        private const int SmallPizzaNumberOfSlices = 6;
        private const decimal SmallPizzaCoefficient = 0.3M;

        public SmallPizza(string name, List<ProductItem> ingredients)
            : base(name, ingredients)

        {
            this.Coeff = SmallPizzaCoefficient;
        }

        public static int NumberOfSlices
        {
            get
            {
                return NumberOfSlices;
            }
        }

        public override string ToString()
        {
            StringBuilder visualization = new StringBuilder();
            visualization.AppendLine($"Small {this.Name}");
            visualization.AppendLine($"{NumberOfSlices} slices");
            visualization.Append($"Price: {this.CalculatePrice()}");

            return visualization.ToString();
        }
    }
}

using System.Collections.Generic;
using System.Text;

using ProtoFlipPizzaSystem.Models.Administrator.Abstract;
using ProtoFlipPizzaSystem.Models.Administrator.Contracts;
using ProtoFlipPizzaSystem.Models.Administrator.Structures;

namespace ProtoFlipPizzaSystem.Models.Administrator
{
    public class Pasta : Food, IPasta
    {
        public Pasta(string name, List<ProductItem> ingredients)
            : base(name, ingredients)
        {
        }

        public decimal PastaPremium { get; private set; } = 0.2M;

        public void SetPastaPremium(decimal pastaPremium)
        {
            this.PastaPremium = pastaPremium;
        }

        public override decimal CalculatePrice()
        {
            decimal price = 0;

            foreach (var productItem in this.Ingredients)
            {
                price += productItem.Igredient.CalculatePrice() * productItem.Quantity;
            }

            price += price * this.PastaPremium;

            return price;
        }

        public override string ToString()
        {
            StringBuilder visualization = new StringBuilder();
            visualization.AppendLine($"Pasta {this.Name}");
            visualization.Append($"Price: {this.CalculatePrice()}");

            return visualization.ToString();
        }
    }
}

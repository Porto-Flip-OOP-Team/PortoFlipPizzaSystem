using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProtoFlipPizzaSystem.Models.Administrator.Abstract;
using ProtoFlipPizzaSystem.Models.Administrator.Structures;
using ProtoFlipPizzaSystem.Models.Administrator.Contracts;

namespace ProtoFlipPizzaSystem.Models.Administrator
{
    class Pasta : Food, IPasta
    {
        public Pasta(string name, List<ProductItem> ingredients) : base(name, ingredients)
        {
        }
        public Pasta(int id, string name, List<ProductItem> ingredients) : base(id, name, ingredients)
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
                price += (productItem.Igredient.CalculateIngredientPrice() * productItem.Quantity);
            }

            price += price * PastaPremium;

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

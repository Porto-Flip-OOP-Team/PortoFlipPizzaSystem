using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProtoFlipPizzaSystem.Models.Administrator.Contracts;


namespace ProtoFlipPizzaSystem.Products
{
    public abstract class Pizza : Food, IPizza
    {
        private string name;

        public Pizza(string name, List<IIngredient> ingredients) : base(ingredients)
        {
            this.Name = name;
        }

        public string Name { get; private set;  }

        public bool IsDeleted { get; private set; } = false;

        public abstract string Visualise();

        public abstract decimal CalculatePrice();
    }
}

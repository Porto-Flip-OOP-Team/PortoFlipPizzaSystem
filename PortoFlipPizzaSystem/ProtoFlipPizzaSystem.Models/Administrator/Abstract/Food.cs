using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProtoFlipPizzaSystem.Models.Administrator.Contracts;
using ProtoFlipPizzaSystem.Models.Administrator.Structures;

namespace ProtoFlipPizzaSystem.Models.Administrator.Abstract
{
    public abstract class Food : Product, IFood
    {
        public Food(string name, List<ProductItem> ingredients) : base(name)
        {
            this.Ingredients = ingredients;
        }
        public Food(int id, string name, List<ProductItem> ingredients) : base(id, name)
        {
            this.Ingredients = ingredients;
        }

        public List<ProductItem> Ingredients { get; private set; }

        public void AddIngredient(decimal quantity, IIngredient ingredient)
        {
            this.Ingredients.Add(new ProductItem(ingredient, quantity));
        }

        public void RemoveIngredient(IIngredient ingredient)
        {
            int index = this.Ingredients.FindIndex(item => item.Igredient.Name.Equals(ingredient.Name));
            this.Ingredients.RemoveAt(index);
        }
    }
}

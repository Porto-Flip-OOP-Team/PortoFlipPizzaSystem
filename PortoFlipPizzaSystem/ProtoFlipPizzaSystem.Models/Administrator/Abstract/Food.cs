using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProtoFlipPizzaSystem.Models.Administrator.Contracts;


namespace ProtoFlipPizzaSystem.Models.Administrator.Abstract
{
    public abstract class Food : Product, IFood
    {
        private List<IIngredient> ingredients;

        public Food(List<IIngredient> ingredients)
        {
            this.Ingredients = ingredients;
        }

        public List<IIngredient> Ingredients { get; private set; }

        public void AddIngredient(IIngredient ingredient)
        {
            this.ingredients.Add(ingredient);
        }

        public void RemoveIngredient(IIngredient ingredient)
        {
            this.ingredients.Remove(ingredient);
        }

        public abstract decimal CalculatePrice();
    }
}

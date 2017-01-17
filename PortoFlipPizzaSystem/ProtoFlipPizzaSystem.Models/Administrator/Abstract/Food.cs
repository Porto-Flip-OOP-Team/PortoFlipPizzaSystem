using System.Collections.Generic;

using ProtoFlipPizzaSystem.Models.Administrator.Contracts;
using ProtoFlipPizzaSystem.Models.Administrator.Structures;
using ProtoFlipPizzaSystem.Models.Contracts;
using ProtoFlipPizzaSystem.Models.Validation;

namespace ProtoFlipPizzaSystem.Models.Administrator.Abstract
{
    public abstract class Food : Product, IProduct, IFood, ICalculatable, IDeletable, IIdentifiable, INamable
    {
        private const decimal MinQuantity = 0;
        private const decimal MaxQuantity = 1500;

        private List<ProductItem> ingredients;

        public Food(string name, List<ProductItem> ingredients)
    : base(name)
        {
            this.Ingredients = ingredients;
        }

        public List<ProductItem> Ingredients
        {
            get
            {
                return this.ingredients;
            }

            private set
            {
                foreach (var ingredient in value)
                {
                    Validator.ValidateNull(ingredient, $"The ingredient is null!");
                }

                this.ingredients = value;
            }
        }

        public void AddIngredient(decimal quantity, IIngredient ingredient)
        {
            Validator.ValidateNull(ingredient, $"The ingredient is null!");
            Validator.ValidateDecimalRange(quantity, MinQuantity, MaxQuantity, "The quantity can not be negative");
            this.Ingredients.Add(new ProductItem(ingredient, quantity));
        }

        public void RemoveIngredient(IIngredient ingredient)
        {
            Validator.ValidateNull(ingredient, $"The ingredient is null!");
            int index = this.Ingredients.FindIndex(item => item.Igredient.Name.Equals(ingredient.Name));
            this.Ingredients.RemoveAt(index);
        }
    }
}

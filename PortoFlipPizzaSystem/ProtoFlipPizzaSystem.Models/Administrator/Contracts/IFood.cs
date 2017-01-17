using System.Collections.Generic;
using ProtoFlipPizzaSystem.Models.Administrator.Structures;

namespace ProtoFlipPizzaSystem.Models.Administrator.Contracts
{
    public interface IFood : IProduct
    {
        List<ProductItem> Ingredients { get; }

        void AddIngredient(decimal quantity, IIngredient ingredient);

        void RemoveIngredient(IIngredient ingredient);
    }
}

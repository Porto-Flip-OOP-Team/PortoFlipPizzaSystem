using ProtoFlipPizzaSystem.Models.Administrator.Contracts;

namespace PortoFlipPizzaSystem.Data.Contracts
{
    public interface IAddIngredient
    {
        void AddIngredient(int ingredientId, IIgredient ingredient);
    }
}

using ProtoFlipPizzaSystem.Models.Administrator.Contracts;

namespace PortoFlipPizzaSystem.Data.Contracts
{
    public interface IGetIngredient
    {
        IIgredient GetIngredient(int ingredientId);
    }
}
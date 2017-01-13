using ProtoFlipPizzaSystem.Models.Administrator.Contracts;

namespace PortoFlipPizzaSystem.Data.Contracts
{
    public interface IGetIngredient
    {
        IIngredient GetIngredient(int ingredientId);
    }
}
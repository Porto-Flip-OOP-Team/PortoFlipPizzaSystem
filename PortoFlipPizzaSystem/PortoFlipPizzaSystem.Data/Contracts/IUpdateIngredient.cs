namespace PortoFlipPizzaSystem.Data.Contracts
{
    public interface IUpdateIngredient
    {
        void UpdateQuantity(int ingredientID, decimal quantity);
    }
}
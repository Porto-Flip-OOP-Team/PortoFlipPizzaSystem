namespace ProtoFlipPizzaSystem.Models.Administrator.Contracts
{
    public interface IFood : IProduct
    {
        void AddIngredient(decimal quantity, IIngredient ingredient);

        void RemoveIngredient(IIngredient ingredient);
    }
}

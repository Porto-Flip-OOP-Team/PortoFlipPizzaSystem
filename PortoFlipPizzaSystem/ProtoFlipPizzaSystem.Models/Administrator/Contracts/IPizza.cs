using System.Collections.Generic;

namespace ProtoFlipPizzaSystem.Models.Administrator.Contracts
{
    interface IPizza : IFood
    {
        string Name { get; }

        List<IIngredient> Ingredients { get; }

        bool IsDeleted { get; }

        string Visualise();
        
        void AddIngredient(IIngredient ingredient);

        void RemoveIngredient(IIngredient ingredient);
    }
}

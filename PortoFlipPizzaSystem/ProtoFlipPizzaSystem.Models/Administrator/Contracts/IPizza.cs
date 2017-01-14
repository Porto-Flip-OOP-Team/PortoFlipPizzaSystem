using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProtoFlipPizzaSystem.Models.Administrator.Contracts
{
    interface IPizza : IFood
    {
        string Name { get; }
        List<IIngredient> Ingredients { get; }
        bool IsDeleted { get; }

        string Visualise();
        decimal CalculatePrice();
        void AddIngredient(IIngredient ingredient);
        void RemoveIngredient(IIngredient ingredient);
    }
}

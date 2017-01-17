using ProtoFlipPizzaSystem.Models.Contracts;

namespace ProtoFlipPizzaSystem.Models.Administrator.Contracts
{
    public interface IPizza : IProduct, IFood, ICalculatable, IDeletable, IIdentifiable, INamable
    {
        void SetPizzaPremium(decimal pizzaPremium);

        void SetCoeff(decimal coeff);
    }
}

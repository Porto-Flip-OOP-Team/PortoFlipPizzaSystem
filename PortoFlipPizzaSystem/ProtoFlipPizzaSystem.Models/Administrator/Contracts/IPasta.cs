using ProtoFlipPizzaSystem.Models.Contracts;

namespace ProtoFlipPizzaSystem.Models.Administrator.Contracts
{
    public interface IPasta : IFood, IProduct, ICalculatable, IDeletable, IIdentifiable, INamable
    {
        decimal PastaPremium { get; }

        void SetPastaPremium(decimal pastaPremium);
    }
}

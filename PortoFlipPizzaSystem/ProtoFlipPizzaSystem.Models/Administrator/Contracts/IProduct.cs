using ProtoFlipPizzaSystem.Models.Contracts;

namespace ProtoFlipPizzaSystem.Models.Administrator.Contracts
{
    public interface IProduct : ICalculatable, IDeletable, IIdentifiable, INamable
    {
        int TotalQuantity { get; set; }

        void UpdateTotalQuantity(int newQuantity);
    }
}

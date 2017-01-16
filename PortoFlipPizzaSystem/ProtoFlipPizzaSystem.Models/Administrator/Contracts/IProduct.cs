using ProtoFlipPizzaSystem.Models.Contracts;

namespace ProtoFlipPizzaSystem.Models.Administrator.Contracts
{
    public interface IProduct : ICalculatable, IDeletable, IIdentifiable, INamable
    {
        void UpdateTotalQuantity(int newQuantity);

        int TotalQuantity { get; set; }
    }
}

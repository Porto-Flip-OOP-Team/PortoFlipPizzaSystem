namespace ProtoFlipPizzaSystem.Models.Administrator.Contracts
{
    public interface ICustomer : IPerson
    {
        decimal Discount { get; }

        int NumberOfOrders { get; set; }
    }
}

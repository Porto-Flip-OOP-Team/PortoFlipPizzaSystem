using ProtoFlipPizzaSystem.Models.Contracts;

namespace ProtoFlipPizzaSystem.Models.Administrator.Contracts
{
    public interface IPerson : IDeletable, IIdentifiable
    {
        string FirstName { get; }

        string LastName { get; }

        string Address { get; set; }
    }
}

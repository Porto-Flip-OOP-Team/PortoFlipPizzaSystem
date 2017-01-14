using ProtoFlipPizzaSystem.Models.Contracts;

namespace ProtoFlipPizzaSystem.Models.Administrator.Contracts
{
    public interface IPerson : ICanBeDeleted
    {
        int IdPerson { get; }

        string FirstName { get; }

        string LastName { get; }

        string Address { get; }

        bool IsDeleted { get; }
    }
}

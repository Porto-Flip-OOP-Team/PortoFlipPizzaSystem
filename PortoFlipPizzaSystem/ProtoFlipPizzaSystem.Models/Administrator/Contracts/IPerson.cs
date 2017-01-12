namespace ProtoFlipPizzaSystem.Models.Administrator.Contracts
{
    public interface IPerson
    {
        string IdPerson { get; }
        string FirstName { get; }
        string LastName { get; }
        string Address { get; }
        bool IsDeleted { get; }

        void Delete();
    }
}

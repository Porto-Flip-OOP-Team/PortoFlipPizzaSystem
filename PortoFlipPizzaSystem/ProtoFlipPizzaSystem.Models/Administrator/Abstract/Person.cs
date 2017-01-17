using ProtoFlipPizzaSystem.Models.Administrator.Contracts;
using ProtoFlipPizzaSystem.Models.Common;
using ProtoFlipPizzaSystem.Models.Contracts;

namespace ProtoFlipPizzaSystem.Models.Administrator.Abstract
{
    public abstract class Person : IdentifiableObject, IPerson, IDeletable
    {
        public Person(string firstName, string lastName, string address)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.IsDeleted = false;
        }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public string Address { get; set; }

        public bool IsDeleted { get;  set; }
    }
}

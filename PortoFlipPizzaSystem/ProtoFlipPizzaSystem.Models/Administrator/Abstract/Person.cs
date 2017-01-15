using ProtoFlipPizzaSystem.Models.Administrator.Contracts;
using ProtoFlipPizzaSystem.Models.Contracts;

namespace ProtoFlipPizzaSystem.Models.Administrator.Abstract
{
    public abstract class Person : IPerson, IDeletable, IIdentifiable
    {
        protected static int idCounter = 1;
        private readonly int id;
        private bool isDeleted;

        public Person(string firstName, string lastName, string address)
        {
            this.id = this.GenerateId();
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.isDeleted = false;
        }

        public int Id { get; }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public string Address { get; set; }

        protected virtual int GenerateId()
        {
            return idCounter++;
        }

        public void Delete()
        {
            this.isDeleted = true;
        }
    }
}

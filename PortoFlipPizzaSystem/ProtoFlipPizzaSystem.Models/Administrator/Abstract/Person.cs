using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProtoFlipPizzaSystem.Models.Administrator.Contracts;

namespace ProtoFlipPizzaSystem.Models.Administrator.Abstract
{
    public abstract class Person : IPerson
    {
        protected static int idCounter = 1;
        protected string idPerson;

        public Person(string firstName,string lastName,string address)
        {
            this.IdPerson = this.GenerateId();
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
        }

        protected string IdPrefix
        {
            get
            {
                return this.GetPrefix();
            }

        }

        public string IdPerson
        {
            get
            {
                return this.idPerson;
            }
            private set
            {
                this.idPerson = value;
            }
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Address { get; private set; }

        protected abstract string GetPrefix();

        protected virtual string GenerateId()
        {
            return this.IdPrefix + (idCounter++).ToString().PadLeft(6, '0');
        }
    }
}

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

        public Person(string firstName, string lastName, string address)
        {
            this.IdPerson = this.GenerateId();
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
        }

        public Person(int idPerson, string firstName, string lastName, string address)
        {
            this.IdPerson = idPerson;
            this.IdPerson = this.GenerateId();
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
        }


        public int IdPerson { get; private set; }

        public bool IsDeleted { get; private set; } = false;

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Address { get; private set; }


        protected virtual int GenerateId()
        {
            return idCounter++;
        }

        public void Delete()
        {
            this.IsDeleted = true;
        }
    }
}

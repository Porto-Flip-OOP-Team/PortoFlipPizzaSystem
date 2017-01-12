using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoFlipPizzaSystem.Models.Enums;

namespace ProtoFlipPizzaSystem.Models.Administrator.Contracts
{
    public interface IStaff : IPerson
    {
        double Salary { get; }
        TypeWorkPosition WorkPosition { get; }

        void UpdateSalary(double newSalary);
    }
}

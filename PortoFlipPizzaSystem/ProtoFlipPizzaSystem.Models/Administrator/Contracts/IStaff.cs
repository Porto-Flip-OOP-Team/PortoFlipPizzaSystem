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
        decimal Salary { get; }
        WorkPositionType WorkPosition { get; }

        void UpdateSalary(decimal newSalary);
    }
}

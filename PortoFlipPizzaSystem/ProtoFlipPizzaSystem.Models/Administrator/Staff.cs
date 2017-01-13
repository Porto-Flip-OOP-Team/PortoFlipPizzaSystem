using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoFlipPizzaSystem.Models.Administrator.Contracts;
using ProtoFlipPizzaSystem.Models.Enums;
using ProtoFlipPizzaSystem.Models.Administrator.Abstract;

namespace ProtoFlipPizzaSystem.Models.Administrator
{
    public class Staff : Person, IStaff
    {
        public Staff(string firstName, string lastName, string address, decimal salary, WorkPositionType position)
                                        : base(firstName, lastName, address)
        {
            this.Salary = salary;
            this.WorkPosition = position;
        }
        public Staff(int idPerson, string firstName, string lastName, string address, decimal salary, WorkPositionType position)
                                        : base(idPerson, firstName, lastName, address)
        {
            this.Salary = salary;
            this.WorkPosition = position;
        }

        public decimal Salary { get; private set; }
        public WorkPositionType WorkPosition { get; private set; }

        public void UpdateSalary(decimal newSalary)
        {
            this.Salary = newSalary;
        }

    }
}

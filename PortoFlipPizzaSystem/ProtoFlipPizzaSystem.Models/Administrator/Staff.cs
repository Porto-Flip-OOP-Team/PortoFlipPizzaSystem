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
        public Staff(string firstName, string lastName, string address, double salary, WorkPositionType position)
                                        : base(firstName, lastName, address)
        {
            this.Salary = salary;
            this.WorkPosition = position;
        }

        public double Salary { get; private set; }
        public WorkPositionType WorkPosition { get; private set; }

        public void UpdateSalary(double newSalary)
        {
            this.Salary = newSalary;
        }
        protected override string GetPrefix()
        {
            return "EM";
        }
    }
}

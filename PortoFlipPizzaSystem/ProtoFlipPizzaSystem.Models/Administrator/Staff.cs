using ProtoFlipPizzaSystem.Models.Administrator.Contracts;
using ProtoFlipPizzaSystem.Models.Enums;
using ProtoFlipPizzaSystem.Models.Administrator.Abstract;
using ProtoFlipPizzaSystem.Models.Contracts;

namespace ProtoFlipPizzaSystem.Models.Administrator
{
    public class Staff : Person, IPerson, IDeletable, IIdentifiable, IStaff
    {
        public Staff(string firstName, string lastName, string address, decimal salary, WorkPositionType position)
                                        : base(firstName, lastName, address)
        {
            this.Salary = salary;
            this.WorkPosition = position;
        }

        public decimal Salary { get; private set; }

        public WorkPositionType WorkPosition { get; set; }

        public void UpdateSalary(decimal newSalary)
        {
            this.Salary = newSalary;
        }
    }
}

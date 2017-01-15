using ProtoFlipPizzaSystem.Models.Enums;

namespace ProtoFlipPizzaSystem.Models.Administrator.Contracts
{
    public interface IStaff : IPerson
    {
        decimal Salary { get; }

        WorkPositionType WorkPosition { get; set; }

        void UpdateSalary(decimal newSalary);
    }
}

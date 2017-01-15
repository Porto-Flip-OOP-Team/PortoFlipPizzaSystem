namespace PortoFlipPizzaSystem.Core.Contracts
{
    public interface ICommandHandler
    {
        string ExecuteCommand(string name, string[] parameters);
    }
}

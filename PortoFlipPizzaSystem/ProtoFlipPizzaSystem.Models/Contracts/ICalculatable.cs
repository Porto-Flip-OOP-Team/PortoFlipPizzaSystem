namespace ProtoFlipPizzaSystem.Models.Contracts
{
    public interface ICalculatable<T>
    {
        T CalculateTotal(T quantity, decimal price);
    }
}

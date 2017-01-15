namespace ProtoFlipPizzaSystem.Models.Contracts
{
    public interface IQuantable<T> where T : struct
    {
        T quantity { get; set; }
    }
}

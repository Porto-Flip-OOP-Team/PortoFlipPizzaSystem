using PortoFlipPizzaSystem.Data.Contracts;

namespace PortoFlipPizzaSystem.Core.Contracts
{
    public interface IController
    {
        IRestaurant Restaurant { get; }
    }
}

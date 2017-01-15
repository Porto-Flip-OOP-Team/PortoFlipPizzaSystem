using PortoFlipPizzaSystem.Core.Contracts;
using PortoFlipPizzaSystem.Data.Contracts;

namespace PortoFlipPizzaSystem.Core.Controllers
{
    public abstract class Controller : IController
    {
        private readonly IRestaurant restaurant;

        public Controller(IRestaurant restaurant)
        {
            this.restaurant = restaurant;
        }

        public IRestaurant Restaurant
        {
            get { return this.restaurant; }
        }
    }
}

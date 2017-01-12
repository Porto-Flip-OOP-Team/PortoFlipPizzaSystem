using ProtoFlipPizzaSystem.Models.Administrator.Contracts;

namespace PortoFlipPizzaSystem.Data.Contracts
{
    public interface IAddProduct
    {
        void AddProduct(int id, IProduct product);
    }
}